using Libri_Massimo_Pavoni.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Libri_Massimo_Pavoni
{
    /// <summary>
    /// Contains the MainForm's properties, events and methods.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Global dialog result to catch user's choices.
        /// </summary>
        private DialogResult _userChoice;

        /// <summary>
        /// Temporary book object.
        /// </summary>
        private Book _tempBook;

        /// <summary>
        /// MainForm default constructor.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            DataManager.Books = new List<Book>();
            // check the storing files existence
            DataManager.CheckFiles(Properties.Settings.Default.JSONFilePath, Properties.Settings.Default.XMLFilePath);
        }

        #region Events

        /// <summary>
        /// MainForm Load event.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // choose initial storing file
            _userChoice = MessageBox.Show(
                "Would you like to begin with JSON file type?",
                "Modify books lists", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            switch (_userChoice)
            {
                case DialogResult.Yes:
                    ReadBooksInfo(FileType.JSON);
                    break;
                case DialogResult.No:
                    ReadBooksInfo(FileType.XML);
                    break;
                case DialogResult.Cancel:
                    Close();
                    break;
            }
        }

        /// <summary>
        /// btnWriteJSON Click event.
        /// </summary>
        private void btnWriteJSON_Click(object sender, EventArgs e) => WriteBooksInfo(FileType.JSON);

        /// <summary>
        /// btnWriteXML Click event.
        /// </summary>
        private void btnWriteXML_Click(object sender, EventArgs e) => WriteBooksInfo(FileType.XML);

        /// <summary>
        /// btnReadJSON Click event.
        /// </summary>
        private void btnReadJSON_Click(object sender, EventArgs e) => ReadBooksInfo(FileType.JSON);

        /// <summary>
        /// btnReadXML Click event.
        /// </summary>
        private void btnReadXML_Click(object sender, EventArgs e) => ReadBooksInfo(FileType.XML);

        /// <summary>
        /// lsvBooks SelectedIndexChanged event.
        /// </summary>
        private void lsvBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // only if one item was selected
            if (lsvBooks.SelectedItems.Count == 1)
            {
                // find the selected item inside in-memory books list with ISBN
                _tempBook = DataManager.Books.Single(b => b.ISBN == lsvBooks.SelectedItems[0].Text);
                
                // visualize book info
                txbISBNValue.Text = _tempBook.ISBN;
                txbTitleValue.Text = _tempBook.Title;
                txbAuthorsValue.Text = "";
                // compose authors string for the textbox
                foreach (Author author in _tempBook.Authors)
                {
                    txbAuthorsValue.Text += author.FirstName;
                    if (author.MiddleNames == null ? author.MiddleNames != null : author.MiddleNames.Count != 0)
                        txbAuthorsValue.Text += ' ' + author.MiddleNames.Aggregate((a, b) => a + ' ' + b);
                    if (!String.IsNullOrWhiteSpace(author.LastName))
                        txbAuthorsValue.Text += ' ' + author.LastName;
                    txbAuthorsValue.Text += "\r\n";
                }
                txbPublisherValue.Text = _tempBook.Publisher;
                nudPagesNumberValue.Value = _tempBook.PagesNumber;
                txbDescriptionValue.Text = _tempBook.Description;
            }
        }

        /// <summary>
        /// btnCreateBook and btnUpdateBook Click event.
        /// </summary>
        private void btnCreateOrUpdateBook_Click(object sender, EventArgs e)
        {
            // check inserted data consistency
            Book checkBook = DataManager.Books.FirstOrDefault(b => b.ISBN == txbISBNValue.Text);
            if (String.IsNullOrWhiteSpace(txbISBNValue.Text) ||
                (checkBook != null && checkBook != _tempBook) ||
                String.IsNullOrWhiteSpace(txbTitleValue.Text) ||
                String.IsNullOrWhiteSpace(txbAuthorsValue.Text) || String.IsNullOrWhiteSpace(txbPublisherValue.Text))
                MessageBox.Show(
                    "Be sure to insert all required information: ISBN (must be unique), title, authors and publisher.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            else if(!ParseAuthors(out List<Author> authors, out string output))
                MessageBox.Show(
                    "Could not parse authors string.\n\n" + output,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            else
            {
                // detect sender button
                switch (((Button)sender).Tag)
                {
                    case "create":
                        // add new book and refresh visualization
                        DataManager.Books.Add(new Book(txbISBNValue.Text, txbTitleValue.Text, authors,
                            txbPublisherValue.Text, (short)nudPagesNumberValue.Value, txbDescriptionValue.Text));
                        MessageBox.Show(
                            "Book successfully created, remember to save to a file (JSON or XML) before closing.",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        RefreshBooksList();
                        break;
                    case "update":
                        // confirm book update
                        _userChoice = MessageBox.Show(
                            "Are you sure you want to update this item?",
                            "Update book", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if(_userChoice == DialogResult.Yes)
                        {
                            // update existing book data and refresh visualization
                            DataManager.Books[DataManager.Books.IndexOf(_tempBook)] = new Book(txbISBNValue.Text, txbTitleValue.Text, authors,
                                txbPublisherValue.Text, (short)nudPagesNumberValue.Value, txbDescriptionValue.Text);
                            MessageBox.Show(
                                "Book successfully updated, remember to save to a file (JSON or XML) before closing.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            RefreshBooksList();
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// btnDeleteBook Click event.
        /// </summary>
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            // confirm book deletion
            _userChoice = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Delete book", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (_userChoice == DialogResult.Yes)
            {
                // delete book and refresh visualization
                DataManager.Books.RemoveAt(DataManager.Books.IndexOf(_tempBook));
                MessageBox.Show(
                    "Book successfully deleted, remember to save to a file (JSON or XML) before closing.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                RefreshBooksList();
            }
        }

        /// <summary>
        /// lsv ColumnWidthChanging event.
        /// </summary>
        private void lsv_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            // block column resize
            e.NewWidth = ((ListView)sender).Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Reads the contents of the books list and serilizes them to a file.
        /// </summary>
        /// <param name="fileType">Storing file type.</param>
        private void WriteBooksInfo(FileType fileType)
        {
            // detect file type
            switch (fileType)
            {
                case FileType.JSON:
                    if (!DataManager.WriteJSON(Properties.Settings.Default.JSONFilePath, DataManager.Books, out string jsonOutput))
                        MessageBox.Show(
                            "Could not save books' information to JSON file.\n\n" + jsonOutput,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    else
                        MessageBox.Show("Books' information saved to JSON file.", "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    break;
                case FileType.XML:
                    if (!DataManager.WriteXML(Properties.Settings.Default.XMLFilePath, DataManager.Books, out string xmlOutput))
                        MessageBox.Show(
                            "Could not save books' information to XML file.\n\n" + xmlOutput,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    else
                        MessageBox.Show("Books' information saved to XML file.", "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    break;
            }
            RefreshBooksList();
        }

        /// <summary>
        /// Reads the contents of a file and deserilizes them to the books list.
        /// </summary>
        /// <param name="fileType">Storing file type.</param>
        private void ReadBooksInfo(FileType fileType)
        {
            List<Book> tempBooksList = new List<Book>();

            // detect file type
            switch (fileType)
            {
                case FileType.JSON:
                    if (!DataManager.ReadJSON(Properties.Settings.Default.JSONFilePath, out tempBooksList, out string jsonOutput))
                        MessageBox.Show(
                            "Could not load books' information from JSON file.\n\n" + jsonOutput,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    else
                    {
                        MessageBox.Show(
                            "Books' information loaded from JSON file.", "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        lblFileTypeValue.Text = "JSON";
                    }
                    break;
                case FileType.XML:
                    if (!DataManager.ReadXML(Properties.Settings.Default.XMLFilePath, out tempBooksList, out string xmlOutput))
                        MessageBox.Show(
                            "Could not load books' information from XML file.\n\n" + xmlOutput,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    else
                    {
                        MessageBox.Show(
                            "Books' information loaded from XML file.", "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        lblFileTypeValue.Text = "XML";
                    }
                    break;
            }
            DataManager.Books = tempBooksList;
            RefreshBooksList();
        }

        /// <summary>
        /// Refreshes the books visulization.
        /// </summary>
        private void RefreshBooksList()
        {
            // erase temporary book object
            _tempBook = new Book();

            // reset single book visualization
            txbISBNValue.Text = "";
            txbTitleValue.Text = "";
            txbAuthorsValue.Text = "";
            txbPublisherValue.Text = "";
            nudPagesNumberValue.Value = 1;
            txbDescriptionValue.Text = "";

            // order books list by ascending title
            DataManager.Books = DataManager.Books.OrderBy(b => b.Title).ToList();

            // show books count
            lblBooksCountValue.Text = DataManager.Books.Count.ToString();

            // show books
            lsvBooks.Items.Clear();
            foreach (Book book in DataManager.Books)
                lsvBooks.Items.Add(new ListViewItem(new string[] { book.ISBN, book.Title,
                    book.Authors.First().FirstName + ' ' + book.Authors.First().LastName, book.Publisher }));
        }

        /// <summary>
        /// Parses an input string into a list of authors.
        /// </summary>
        /// <param name="authors">Output object.</param>
        /// <param name="output">Outcome message.</param>
        /// <returns>True if the contents of the string were successfully saved to the object, otherwise false.</returns>
        private bool ParseAuthors(out List<Author> authors, out string output)
        {
            try
            {
                authors = new List<Author>();
                // skip last element (it is a newline character)
                foreach (string author in txbAuthorsValue.Lines.Take(txbAuthorsValue.Lines.Length - 1))
                {
                    // extrapolate author properties
                    string[] authorArgs = author.Split(' ').Where(s => !String.IsNullOrWhiteSpace(s)).ToArray();
                    authors.Add(new Author(authorArgs.First(), authorArgs.Length > 1 ? authorArgs.Last() : String.Empty,
                        authorArgs.Length > 2 ? authorArgs.Skip(1).Take(authorArgs.Length - 2).ToList() : null));
                }
                output = "OK";
                return true;
            }
            catch (Exception ex)
            {
                authors = null;
                output = ex.Message;
                return false;
            }
        }

        #endregion
    }
}
