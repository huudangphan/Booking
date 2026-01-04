using System.Xml.Serialization;

namespace Modetour.B2C.Entity.Package.PackageXml
{
    [XmlRoot(ElementName = "Root")]
    public class MainVideoUpModel
    {
        [XmlElement(ElementName = "VideoUpload")]
        public VideoUpload VideoUpload { get; set; }
    }
    public class VideoUpload
    {
        [XmlElement(ElementName = "Item")]
        public List<VideoUpItem> Item { get; set; }
    }
    public class VideoUpItem
    {
        [XmlAttribute(AttributeName = "VideoUpload")]
        public string Type { get; set; }
        [XmlElement(ElementName = "imageURL1")]
        public string ImageUrl1 { get; set; }
        [XmlElement(ElementName = "imageURL2")]
        public string ImageUrl2 { get; set; }
        [XmlElement(ElementName = "imageURL3")]
        public string ImageUrl3 { get; set; }
        [XmlElement(ElementName = "MainDescription")]
        public string MainDescription { get; set; }
        [XmlElement(ElementName = "SubDescription")]
        public string SubDescription { get; set; }
        [XmlElement(ElementName = "URL")]
        public string Url { get; set; }
        [XmlElement(ElementName = "NewOpen>")]
        public string NewOpen { get; set; }


    }


}
