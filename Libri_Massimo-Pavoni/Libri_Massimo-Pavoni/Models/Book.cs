using System.Collections.Generic;

namespace Libri_Massimo_Pavoni.Models
{
    /// <summary>
    /// Contains the properties of a book and the required constructors.
    /// </summary>
    public class Book
    {
        #region Properties

        public string ISBN { get; set; }
        public string Title { get; set; }
        public List<Author> Authors { get; set; }
        public string Publisher { get; set; }
        public short PagesNumber { get; set; }
        public string Description { get; set; }

        #endregion

        /// <summary>
        /// Required parameterless construtor for object serialization and deserialization.
        /// </summary>
        public Book() { }

        /// <summary>
        /// Book default constructor.
        /// </summary>
        /// <param name="isbn">Book's ISBN.</param>
        /// <param name="title">Book's title.</param>
        /// <param name="authors">Book's authors list.</param>
        /// <param name="publisher">Book's publisher.</param>
        /// <param name="pagesNumber">Book's number of pages.</param>
        /// <param name="description">Book's description.</param>
        public Book(string isbn, string title, List<Author> authors, string publisher, short pagesNumber, string description = null)
        {
            ISBN = isbn;
            Title = title;
            Authors = authors;
            Publisher = publisher;
            PagesNumber = pagesNumber;
            Description = description;
        }
    }
}
