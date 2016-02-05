using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BooksCatalogXmlSerializable
{
    public enum Genre 
    {
        [XmlEnum]
        Computer,
        [XmlEnum]
        Fantasy,
        [XmlEnum]
        Romance,
        [XmlEnum]
        Horror,
        [XmlEnum("Science Fiction")]
        ScienceFiction
    }
    [XmlType("book")]
    public class Book
    {
        private DateTime publishDate;
        private DateTime registrationDate;

        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlElement("isbn")]
        public string Isbn { get; set; }

        [XmlElement("author")]
        public string Author { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("genre")]
        public Genre Genre { get; set; }

        [XmlElement("publisher")]
        public string Publisher { get; set; }

        [XmlElement("publish_date")]
        public string PublishDate
        {
            get { return this.publishDate.ToString("yyyy-MM-dd"); }
            set { this.publishDate = DateTime.Parse(value); }
        }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("registration_date")]
        public string RegistrationDate
        {
            get { return this.registrationDate.ToString("yyyy-MM-dd"); }
            set { this.registrationDate = DateTime.Parse(value); }
        }
    }
}
