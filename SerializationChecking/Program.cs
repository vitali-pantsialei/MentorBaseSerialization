using BooksCatalogXmlSerializable;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationChecking
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputXml = "..//..//books.xml";
            string outputXml = "..//..//serialize.xml";
            Catalog catalog;
            XmlSerializer serializer = new XmlSerializer(typeof(Catalog));
            using (FileStream stream = new FileStream(inputXml, FileMode.Open))
            {
                catalog = serializer.Deserialize(stream) as Catalog;
            }
            using (FileStream stream = new FileStream(outputXml, FileMode.Create))
            {
                serializer.Serialize(stream, catalog);
            }
        }
    }
}
