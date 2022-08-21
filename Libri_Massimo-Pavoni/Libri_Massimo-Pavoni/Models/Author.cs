using System.Collections.Generic;

namespace Libri_Massimo_Pavoni.Models
{
    /// <summary>
    /// Contains the properties of a book author and the required constructors.
    /// </summary>
    public class Author
    {
        #region Properties

        public string FirstName { get; set; }
        public List<string> MiddleNames { get; set; }
        public string LastName { get; set; }

        #endregion

        /// <summary>
        /// Required parameterless construtor for object serialization and deserialization.
        /// </summary>
        public Author() { }

        /// <summary>
        /// Author default constructor.
        /// </summary>
        /// <param name="firstName">Author's first name.</param>
        /// <param name="lastName">Author's last name.</param>
        /// <param name="middleNames">Author's middle names list.</param>
        public Author(string firstName, string lastName, List<string> middleNames = null)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleNames = middleNames;
        }
    }
}
