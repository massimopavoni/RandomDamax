using System.IO;
using System.Xml.Serialization;

/// <summary>
/// Contains simplified methods to serialize and deserialize into and from XML strings. 
/// </summary>
public static class XMLSerializer
{

    /// <summary>
    /// Serializes a generic type object into a XML string.
    /// </summary>
    /// <typeparam name="T">Object type.</typeparam>
    /// <param name="objectToSerialize">Input object.</param>
    /// <returns>The serialized string.</returns>
    public static string Serialize<T>(T objectToSerialize)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(objectToSerialize.GetType());

        using (StringWriter textWriter = new StringWriter())
        {
            xmlSerializer.Serialize(textWriter, objectToSerialize);
            return textWriter.ToString();
        }
    }

    /// <summary>
    /// Deserializes an XML string into a generic type object.
    /// </summary>
    /// <typeparam name="T">Object type.</typeparam>
    /// <param name="input">Input XML string.</param>
    /// <returns>The deserialized object.</returns>
    public static T Deserialize<T>(string input)
    {

        XmlSerializer ser = new XmlSerializer(typeof(T));

        using (StringReader sr = new StringReader(input))
        {
            return (T)ser.Deserialize(sr);
        }
    }
}
