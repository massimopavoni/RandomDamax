import asyncio
import json
import os
from progress.bar import ChargingBar
from progress_patch import get_patched_progress
import sqlite3
import time
import urllib.request

BASE_API_URL = "https://api.scryfall.com/cards?page="
CARDS_PER_PAGE = 175
PAGES_NUMBER = 1355
CARDS_TABLE_NAME = "Cards"
CARD_NAME_COLUMN_NAME = "CardName"
CARD_ID_COLUMN_NAME = "CardId"


class JsonObject(object):
    def __init__(self, contents):
        self.__dict__ = json.loads(contents)


async def make_api_request(base_api_url, page_number, pages_number, base_pages_folder, base_file_name, progress_bar):
    page = urllib.request.urlopen(base_api_url + str(page_number)).read()

    page_json = JsonObject(page)

    page_text_file = open(base_pages_folder + '\\' + base_file_name.replace(".txt", f"_{page_number}.txt"), 'w')
    for card_json in page_json.data:
        page_text_file.write(f"{card_json['name']}#{card_json['id']}\n")
    page_text_file.close()

    progress_bar.next()
    if page_number == pages_number:
        progress_bar.finish()


def merge_text_files(pages_number, base_pages_folder, base_file_path, base_file_name):
    print(f"Now merging {pages_number} text file into {base_file_path}.\n")
    progress_bar = ChargingBar("Progress", max=pages_number,
                               suffix="%(percent)d%%   [%(index)d/%(max)d]   [%(elapsed_td)s]")

    base_file = open(base_file_path, 'w')

    for i in pages_number:
        page_file_path = base_pages_folder + '\\' + base_file_name.replace(".txt", f"_{i}.txt")
        page_file = open(page_file_path, 'w')

        base_file.writelines(page_file.readlines())
        page_file.close()

        os.remove(page_file_path)

        progress_bar.next()

    os.rmdir(base_pages_folder)


async def create_cards_text_file(base_file_path, base_api_url, pages_number):
    try:
        print(f"Now sending {pages_number} http requests to get all card pages and write the text file.\n" +
              "Please be patient.\n")
        progress_bar = ChargingBar("Progress", max=pages_number,
                                   suffix="%(percent)d%%   [%(index)d/%(max)d]   [%(elapsed_td)s]")

        base_file = open(base_file_path, 'w')
        base_file.close()

        base_file_folder = os.path.dirname(base_file_path)
        base_file_name = os.path.basename(base_file_path)
        os.mkdir(base_file_folder + "\\pages")
        base_pages_folder = base_file_folder + "\\pages"

        for i in range(1, pages_number + 1):
            await make_api_request(base_api_url, i, pages_number, base_pages_folder, base_file_name, progress_bar)
            if i % 250 == 0:
                time.sleep(10)

        print('\n')
        merge_text_files(pages_number, base_pages_folder, base_file_path, base_file_name)

        print("\nText file successfully created.")
        return True
    except Exception as e:
        print(e)
    return None


def text_file_alphabetical_sort(input_file_path, output_file_path):
    try:
        input_file = open(input_file_path, 'r')
        lines_list = input_file.readlines()
        input_file.close()

        lines_list.sort()
        output_file = open(output_file_path, 'w')
        output_file.writelines(lines_list)
        output_file.close()

        print(f"Text file successfully sorted into {output_file_path}")
        return True
    except Exception as e:
        print(e)
    return None


def create_sqlite_connection(db_file_path):
    try:
        connection = sqlite3.connect(db_file_path)
        print(f"Successfully created SQLite database (version {sqlite3.version}) at {db_file_path}.")
        return connection
    except Exception as e:
        print(e)
    return None


def create_table(connection, cards_table_name, card_id_column_name, card_name_column_name):
    try:
        query = f"""CREATE TABLE {cards_table_name} (""" + \
                f"""{card_id_column_name} TEXT NOT NULL UNIQUE,""" + \
                f"""{card_name_column_name}	TEXT NOT NULL,""" + \
                f"""PRIMARY KEY({card_id_column_name}))"""

        cursor = connection.cursor()
        cursor.execute(query)

        print(f"Successfully created {cards_table_name} table in database.")
        return True
    except Exception as e:
        print(e)
    return None


def create_card(connection, cards_table_name, card_id_column_name, card_name_column_name, card_info):
    try:
        card_args = card_info.split('#')

        query = f"""INSERT IGNORE INTO {cards_table_name}({card_name_column_name}, {card_id_column_name}) """ + \
                f"""VALUES('{card_args[0].replace("'", "''")}', '{card_args[1].replace("'", "''")}')"""

        cursor = connection.cursor()
        cursor.execute(query)

        return True
    except Exception as e:
        print(e)
    return None


async def main():
    print("\nScryfall Magic Cards\n\n" +
          "Producing a SQLite database with name and id of all magic cards present in Scryfall.\n\n")

    text_file_path = input("Please insert the destination .txt file path: ")

    print('\n')
    await create_cards_text_file(text_file_path, BASE_API_URL, PAGES_NUMBER)

    sorted_text_file_path = text_file_path.replace(".txt", "_sorted.txt")
    print('\n')
    text_file_alphabetical_sort(text_file_path, sorted_text_file_path)

    print('\n')
    database_file_path = input("Please insert the destination SQLite database file path: ")

    print('\n')
    sqlite_connection = create_sqlite_connection(database_file_path)

    print('\n')
    create_table(sqlite_connection, CARDS_TABLE_NAME, CARD_ID_COLUMN_NAME, CARD_NAME_COLUMN_NAME)

    sorted_text_file = open(sorted_text_file_path, "r")
    sorted_text_file_lines = sorted_text_file.readlines()

    print('\n\n' +
          f"Now inserting about {sorted_text_file_lines - 1} cards " +
          f"into the SQLite database at {database_file_path}.\n" +
          "Please be patient.\n")

    progress_bar = ChargingBar("Progress", max=len(sorted_text_file_lines),
                               suffix="%(percent)d%%   [%(index)d/%(max)d]   [%(elapsed_td)s]")

    for card_line in sorted_text_file_lines:
        create_card(sqlite_connection, CARDS_TABLE_NAME, CARD_ID_COLUMN_NAME, CARD_NAME_COLUMN_NAME, card_line)
        progress_bar.next()
    progress_bar.finish()

    sorted_text_file.close()
    sqlite_connection.close()

    os.remove(text_file_path)
    os.remove(sorted_text_file_path)

    print("\nCards data successfully inserted.")


if __name__ == '__main__':
    progress = get_patched_progress()
    os.system("cls")
    asyncio.run(main())
