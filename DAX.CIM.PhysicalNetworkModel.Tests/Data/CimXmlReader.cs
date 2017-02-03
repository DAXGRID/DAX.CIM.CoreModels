using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace DAX.CIM.PhysicalNetworkModel.Tests.Data
{
    /// <summary>
    /// Streaming XML reader that can be used to traverse an XML stream based on the <see cref="CimXmlReader.XmlSchemaNs"/> schema
    /// </summary>
    public class CimXmlReader
    {
        /// <summary>
        /// Schema upon which the XML is based
        /// </summary>
        public const string XmlSchemaNs = "http://daxgrid.net/PhysicalNetworkModel_0_1";

        static readonly Dictionary<string, Type> TypeDictionary = InitializeTypeDictionary();

        static Dictionary<string, Type> InitializeTypeDictionary()
        {
            return typeof(PhysicalNetworkModelEnvelope).Assembly.GetTypes()
                .Where(t => t.Namespace == typeof(IdentifiedObject).Namespace)
                .ToDictionary(t => t.Name);
        }

        /// <summary>
        /// Reads XML from the given <paramref name="source"/> stream, returning objects as they are parsed
        /// </summary>
        public IEnumerable<IdentifiedObject> Read(Stream source)
        {
            var settings = new XmlReaderSettings
            {
                IgnoreComments = true,
                IgnoreWhitespace = true,
            };

            var serializers = new ConcurrentDictionary<string, XmlSerializer>();

            using (var reader = XmlReader.Create(source, settings))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement(typeof(PhysicalNetworkModelEnvelope).Name))
                    {
                        while (reader.Read())
                        {
                            if (reader.IsStartElement())
                            {
                                var xmlSerializer = serializers.GetOrAdd(reader.Name, GetNewSerializer);
                                var subtreeReader = reader.ReadSubtree();
                                var obj = xmlSerializer.Deserialize(subtreeReader);

                                if (obj is IdentifiedObject)
                                {
                                    yield return (IdentifiedObject)obj;
                                }
                            }
                        }
                    }
                }
            }
        }

        static XmlSerializer GetNewSerializer(string name)
        {
            var type = ResolveType(name);

            return new XmlSerializer(type, XmlSchemaNs);
        }

        static Type ResolveType(string name)
        {
            try
            {
                return TypeDictionary[name];
            }
            catch (KeyNotFoundException exception)
            {
                var availableTypes = string.Join(Environment.NewLine, TypeDictionary.Select(kvp => $"    {kvp.Key}: {kvp.Value}"));

                throw new KeyNotFoundException($@"Could not find type for element named '{name}' - have the following types:

{availableTypes}", exception);
            }
        }
    }
}