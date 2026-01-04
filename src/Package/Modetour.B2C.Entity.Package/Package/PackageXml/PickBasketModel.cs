using System.Xml.Serialization;

namespace Modetour.B2C.Entity.Package.PackageXml
{
    [XmlRoot(ElementName = "ModeTouretail")]
    public class PickBasketModel
    {
        [XmlElement(ElementName = "Product")]
        public List<Product> product { get; set; }
    }

    public class Product
    {
        [XmlAttribute(AttributeName = "Pcode")]
        public string PCode { get; set; }
        [XmlAttribute(AttributeName = "Pnum")]
        public string PNum { get; set; }
        [XmlAttribute(AttributeName = "Grade")]
        public string Grade { get; set; }
        [XmlElement(ElementName = "Image")]
        public string Image { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Nation")]
        public string Nation { get; set; }
        [XmlElement(ElementName = "City")]
        public string City { get; set; }
        [XmlElement(ElementName = "Price")]
        public Price Price { get; set; }
        [XmlElement(ElementName = "Date")]
        public Date Date { get; set; }
        [XmlElement(ElementName = "Air")]
        public Air Air { get; set; }

    }
    public class Price
    {
        [XmlAttribute(AttributeName = "PreAdult")]
        public double PreAdult { get; set; }
        [XmlAttribute(AttributeName = "Adult")]
        public double Adult { get; set; }

    }
    public class Date
    {
        [XmlAttribute(AttributeName = "Night")]
        public int Night { get; set; }
        [XmlAttribute(AttributeName = "Days")]
        public int Day { get; set; }
        [XmlAttribute(AttributeName = "Sdate")]
        public string SDate { get; set; }
        [XmlAttribute(AttributeName = "Stime")]
        public string STime { get; set; }
    }
    public class Air
    {
        [XmlAttribute(AttributeName = "Stime")]
        public string AirName { get; set; }
    }
}
