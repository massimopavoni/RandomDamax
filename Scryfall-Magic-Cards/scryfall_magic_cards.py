import json
import os
from progress.bar import ChargingBar
from progress_patch import get_patched_progress
import sqlite3
import time
import urllib.request

CARDS_PER_PAGE = 175
PAGES_NUMBER = 1355
CARDS_TABLE_NAME = "ScryfallCards"
CARD_NAME_COLUMN_NAME = "CardName"
CARD_ID_COLUMN_NAME = "CardId"


class JsonObject(object):
    def __init__(self, contents):
        self.__dict__ = json.loads(contents)


def create_cards_text_file(file_path, pages_number, cards_per_page):
    try:
        print(f"Now sending {pages_number} http requests to get all card pages and write the text file.\n" +
              "Please be patient.\n\n")
        file = open(file_path, 'w')
        progress_bar = ChargingBar("Progress", max=pages_number,
                                   suffix="%(percent)d%%\t [%(index)d/%(max)d]\t%(elapsed)ds")
        for i in range(1, pages_number + 1):
            page = urllib.request.urlopen(
                f"https://api.scryfall.com/cards?page={i}"
            ).read()
            page_json = JsonObject(page)
            for card_json in page_json.data:
                file.write(f"{card_json['name']}#{card_json['id']}\n")
            if i % 250 == 0:
                time.sleep(10)
            progress_bar.next()
        progress_bar.finish()
        file.close()
        print("Text file successfully created.")
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
        query = f"""INSERT INTO {cards_table_name}({card_name_column_name}, {card_id_column_name}) """ + \
                f"""VALUES('{card_args[0].replace("'", "''")}', '{card_args[1].replace("'", "''")}')"""
        cursor = connection.cursor()
        cursor.execute(query)
        return True
    except Exception as e:
        print(e)
    return None


def main():
    print("\n\n\nScryfall Magic Cards\n\n" +
          "Producing a SQLite database with name and id of all magic cards present in Scryfall.\n\n")
    text_file_path = input("Please insert the destination txt file path: ")

    print("\n\n")
    create_cards_text_file(text_file_path, PAGES_NUMBER, CARDS_PER_PAGE)

    sorted_text_file_path = text_file_path.replace(".txt", "_sorted.txt")
    print("\n\n")
    text_file_alphabetical_sort(text_file_path, sorted_text_file_path)

    print("\n\n")
    database_file_path = input("Please insert the destination SQLite database file path: ")
    sqlite_connection = create_sqlite_connection(database_file_path)

    print("\n\n\n")
    create_table(sqlite_connection, CARDS_TABLE_NAME, CARD_ID_COLUMN_NAME, CARD_NAME_COLUMN_NAME)

    print("\n\n\n" +
          f"Now inserting {PAGES_NUMBER * CARDS_PER_PAGE} cards into the SQLite database at {database_file_path}.\n" +
          "Please be patient.\n\n")
    progress_bar = ChargingBar("Progress", max=PAGES_NUMBER * CARDS_PER_PAGE,
                               suffix="%(percent)d%%\tInserting cards into database")
    with sqlite_connection:
        f = open(sorted_text_file_path, "r")
        for card_line in f.readlines():
            create_card(sqlite_connection, CARDS_TABLE_NAME, CARD_ID_COLUMN_NAME, CARD_NAME_COLUMN_NAME, card_line)
            progress_bar.next()
        progress_bar.finish()
        f.close()

    print("Done!")


if __name__ == '__main__':
    progress = get_patched_progress()
    os.system("cls")
    main()
