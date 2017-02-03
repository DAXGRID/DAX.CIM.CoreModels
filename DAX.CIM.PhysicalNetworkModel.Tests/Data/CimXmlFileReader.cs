using System;
using System.Collections.Generic;
using System.IO;

namespace DAX.CIM.PhysicalNetworkModel.Tests.Data
{
    /// <summary>
    /// CIM XML file reader that can be used to stream a file based on the <see cref="CimXmlReader.XmlSchemaNs"/> schema.
    /// Internally, <see cref="CimXmlReader"/> is used to actually parse the file stream
    /// </summary>
    public class CimXmlFileReader
    {
        readonly CimXmlReader _reader = new CimXmlReader();
        readonly string _xmlFilePath;

        /// <summary>
        /// Creates the reader for the given XML file path
        /// </summary>
        public CimXmlFileReader(string xmlFilePath)
        {
            if (string.IsNullOrWhiteSpace(xmlFilePath))
            {
                throw new ArgumentException("Please specify the path to a CIM XML file", nameof(xmlFilePath));
            }

            _xmlFilePath = GetXmlFilePath(xmlFilePath);

            if (!File.Exists(_xmlFilePath))
            {
                throw new FileNotFoundException($"Could not find the file '{xmlFilePath}'");
            }
        }

        /// <summary>
        /// Opens the file for reading and starts traversing it, returning a sequence of <see cref="IdentifiedObject"/> along the way
        /// </summary>
        public IEnumerable<IdentifiedObject> Read()
        {
            using (var source = File.OpenRead(_xmlFilePath))
            {
                foreach (var identifiedObject in _reader.Read(source))
                {
                    yield return identifiedObject;
                }
            }
        }

        static string GetXmlFilePath(string xmlFilePath)
        {
            return Path.IsPathRooted(xmlFilePath)
                ? xmlFilePath
                : Path.Combine(AppDomain.CurrentDomain.BaseDirectory, xmlFilePath);
        }
    }
}