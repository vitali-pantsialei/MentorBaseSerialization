using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BooksCatalogXmlSerializable
{
    [XmlRoot("catalog", Namespace=@"http://library.by/catalog")]
    public class Catalog
    {
        private DateTime creationTime;

        [XmlAttribute("date")]
        public string CreationTime
        {
            get { return this.creationTime.ToString("yyyy-MM-dd"); }
            set { this.creationTime = DateTime.Parse(value); }
        }

        [XmlElement("book")]
        public List<Book> CatalogList { get; set; }
    }
}
