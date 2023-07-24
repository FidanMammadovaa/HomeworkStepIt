using System.Xml.Serialization;

namespace MyConverter.Models
{
    [XmlRoot("ValCurs")]
    public class ValCurs
    {
        [XmlAttribute("Date")]
        public string Date { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Description")]
        public string Description { get; set; }

        [XmlElement("ValType")]
        public List<ValType> ValTypes { get; set; }
    }

    public class ValType
    {
        [XmlAttribute("Type")]
        public string Type { get; set; }

        [XmlElement("Valute")]
        public List<Valute> Valutes { get; set; }
    }

    public class Valute
    {
        [XmlAttribute("Code")]
        public string Code { get; set; }

        [XmlElement("Nominal")]
        public string Nominal { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Value")]
        public string Value { get; set; }
    }
}
