using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

#region Models

/// <summary>
/// Represents a person with basic information and exam scores.
/// </summary>
public class Person
{
    /// <summary>
    /// Gets or sets the name of the person.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the age of the person.
    /// </summary>
    public int Age { get; set; }

    /// <summary>
    /// Gets or sets the list of scores for the person.
    /// </summary>
    public List<int>? Score { get; set; }
}

#endregion

#region XML Serialization Demo

/// <summary>
/// Demonstrates XML serialization of a list of Person objects.
/// </summary>
class XMLSerialization
{
    /// <summary>
    /// Application entry point.
    /// Creates sample data and serializes it to XML.
    /// </summary>
    static void Main()
    {
        #region Sample Data

        // Create a list of people with their scores
        List<Person> people =
        [
            new()
            {
                Name = "John",
                Age = 12,
                Score = [122, 13, 12]
            },
            new()
            {
                Name = "Cena",
                Age = 13,
                Score = [98, 99, 88]
            }
        ];

        #endregion

        #region Serialization

        // Create an XML serializer for a list of Person objects
        XmlSerializer serializer = new(typeof(List<Person>));

        string xml;

        // Serialize the object graph into XML
        using (StringWriter writer = new())
        {
            serializer.Serialize(writer, people);
            xml = writer.ToString();
        }

        #endregion

        #region Output

        // Display the generated XML in the console
        Console.WriteLine(xml);

        #endregion
    }
}

#endregion


// Object to XML Serialization in C#

// XML Serialization converts a C# object into XML format
// XML is used for data storage and data transfer
// C# uses XmlSerializer for XML serialization

// Why Do We Use XML Serialization?
// To save object data in a readable format
// To send data between applications
// To store configuration or backup data

// Where Is XML Used?
// Web services (SOAP)
// Configuration files
// Data sharing between systems

// Class and properties must be public - XmlSerializer works outside your class, It uses reflection to read data

// Class must have a parameterless constructor - During deserialization, XML is converted back into an object, XmlSerializer first creates an empty object

// Steps:
// Create a class
// Create an object
// Use XmlSerializer
// Call Serialize()
// Store XML in a string or file

// We use StringWriter because XmlSerializer requires a TextWriter, and StringBuilder is not a writer.

// Simple analogy
// XmlSerializer → needs a pen
// StringWriter → acts like a pen
// StringBuilder → is just the paper

// Propertioes are converted to XMl
// Functions are not considered in Serialization
// Does not work on Dictionary & Map

// XS —> XML Schema
// is a contract between publisher and subscriber