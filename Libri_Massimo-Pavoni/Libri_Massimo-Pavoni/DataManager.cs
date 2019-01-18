using Libri_Massimo_Pavoni.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Libri_Massimo_Pavoni
{
    /// <summary>
    /// Contains the properties of the elements to be stored and methods to write and read them to and from JSON and XML files. 
    /// </summary>
    public static class DataManager
    {
        /// <summary>
        /// In-memory list of books.
        /// </summary>
        public static List<Book> Books { get; set; }

        /// <summary>
        /// Checks if the JSON and XML files exist at the specified paths and creates them if they do not.
        /// </summary>
        /// <param name="jsonPath">Path string of the JSON file.</param>
        /// <param name="xmlPath">Path string of the XML file.</param>
        internal static void CheckFiles(string jsonPath, string xmlPath)
        {
            if (!File.Exists(jsonPath)) File.Create(jsonPath);
            if (!File.Exists(xmlPath)) File.Create(xmlPath);
        }

        #region JSON and XML methods

        /// <summary>
        /// Reads the contents of an object and serializes them to a specified JSON file.
        /// </summary>
        /// <typeparam name="T">Object type.</typeparam>
        /// <param name="objectSource">Input object.</param>
        /// <param name="path">Output JSON file path.</param>
        /// <param name="output">Outcome message.</param>
        /// <returns>True if the contents of the object were successfully saved to the file, otherwise false.</returns>
        internal static bool WriteJSON<T>(T objectSource, string path, out string output)
        {
            try
            {
                File.WriteAllText(path, JsonConvert.SerializeObject(objectSource));
                output = "OK";
                return true;
            }
            catch (Exception ex)
            {
                output = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Reads the contents of an object and serializes them to a specified XML file.
        /// </summary>
        /// <typeparam name="T">Object type.</typeparam>
        /// <param name="objectSource">Input object.</param>
        /// <param name="path">Output XML file path.</param>
        /// <param name="output">Outcome message.</param>
        /// <returns>True if the contents of the object were successfully saved to the file, otherwise false.</returns>
        internal static bool WriteXML<T>(T objectSource, string path, out string output)
        {
            try
            {
                File.WriteAllText(path, XMLSerializer.Serialize(objectSource));
                output = "OK";
                return true;
            }
            catch (Exception ex)
            {
                output = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Reads the contents of a JSON file and deserilizes them to a specified object.
        /// </summary>
        /// <typeparam name="T">Object type.</typeparam>
        /// <param name="path">Input JSON file path.</param>
        /// <param name="objectDestination">Output object.</param>
        /// <param name="output">Outcome message.</param>
        /// <returns>True if the contents of the file were successfully saved to the object, otherwise false.</returns>
        internal static bool ReadJSON<T>(string path, out T objectDestination, out string output)
        {
            try
            {
                objectDestination = JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
                output = "OK";
                return true;
            }
            catch (Exception ex)
            {
                objectDestination = default(T);
                output = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Reads the contents of a XML file and deserilizes them to a specified object.
        /// </summary>
        /// <typeparam name="T">Object type.</typeparam>
        /// <param name="path">Input XML file path.</param>
        /// <param name="objectDestination">Output object.</param>
        /// <param name="output">Outcome message.</param>
        /// <returns>True if the contents of the file were successfully saved to the object, otherwise false.</returns>
        internal static bool ReadXML<T>(string path, out T objectDestination, out string output)
        {
            try
            {
                objectDestination = XMLSerializer.Deserialize<T>(File.ReadAllText(path));
                output = "OK";
                return true;
            }
            catch (Exception ex)
            {
                objectDestination = default(T);
                output = ex.Message;
                return false;
            }
        }

        #endregion
    }
}