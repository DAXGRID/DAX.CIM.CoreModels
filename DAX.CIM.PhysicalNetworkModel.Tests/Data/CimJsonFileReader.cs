using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAX.CIM.PhysicalNetworkModel.Tests.Data
{
    public class CimJsonFileReader
    {
        readonly string _jsonFilePath;

        /// <summary>
        /// Creates the reader for the given Json file path
        /// </summary>
        public CimJsonFileReader(string jsonFilePath)
        {
            if (string.IsNullOrWhiteSpace(jsonFilePath))
            {
                throw new ArgumentException("Please specify the path to a CIM Json file", nameof(jsonFilePath));
            }

            _jsonFilePath = GetXmlFilePath(jsonFilePath);

            if (!File.Exists(_jsonFilePath))
            {
                throw new FileNotFoundException($"Could not find the file '{jsonFilePath}'");
            }
        }

        /// <summary>
        /// Opens the file for reading and starts traversing it, returning a sequence of <see cref="IdentifiedObject"/> along the way
        /// </summary>
        public IEnumerable<IdentifiedObject> Read()
        {
            using (var source = File.OpenRead(_jsonFilePath))
            {
                var cson = new DAX.Cson.CsonSerializer();

                foreach (var identifiedObject in cson.DeserializeObjects(source))
                {
                    yield return identifiedObject;
                }
            }
        }

        static string GetXmlFilePath(string jsonFilePath)
        {
            return Path.IsPathRooted(jsonFilePath)
                ? jsonFilePath
                : Path.Combine(AppDomain.CurrentDomain.BaseDirectory, jsonFilePath);
        }
    }
}
