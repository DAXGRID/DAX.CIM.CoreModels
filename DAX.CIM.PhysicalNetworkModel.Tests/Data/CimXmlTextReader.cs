using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DAX.CIM.PhysicalNetworkModel.Tests.Data
{
    /// <summary>
    /// CIM XML string reader that can be used to read an XML string based on the <see cref="CimXmlReader.XmlSchemaNs"/> schema.
    /// Internally, <see cref="CimXmlReader"/> is used to actually parse string stream
    /// </summary>
    public class CimXmlTextReader
    {
        readonly CimXmlReader _reader = new CimXmlReader();
        readonly string _text;

        /// <summary>
        /// Creates the reader
        /// </summary>
        public CimXmlTextReader(string text)
        {
            if (text == null) throw new ArgumentNullException(nameof(text));
            _text = text;
        }

        /// <summary>
        /// Parses the XML from the string, returning the parsed objects as a sequence
        /// </summary>
        public IEnumerable<IdentifiedObject> Read()
        {
            using (var source = new MemoryStream(Encoding.UTF8.GetBytes(_text)))
            {
                foreach (var identifiedObject in _reader.Read(source))
                {
                    yield return identifiedObject;
                }
            }
        }
    }
}