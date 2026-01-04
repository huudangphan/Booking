using System.Xml.Serialization;

namespace Modetour.B2C.Entity.Package.PackageXml
{
    [XmlRoot(ElementName = "ModeTouretail")]
    public class MenuModel
    {
        [XmlElement(ElementName = "item")]
        public List<SubItem1> Item1 { get; set; }
        [XmlElement(ElementName = "StartArea")]
        public StartArea StartArea { get; set; }
    }
    public class StartArea
    {
        [XmlAttribute(AttributeName = "dlc")]
        public string Dlc { get; set; }
        [XmlAttribute(AttributeName = "gubun")]
        public string Gubun { get; set; }
        [XmlAttribute(AttributeName = "domestic")]
        public string Domestic { get; set; }
        [XmlAttribute(AttributeName = "selFirst")]
        public string DelFirst { get; set; }
        [XmlAttribute(AttributeName = "selSecond")]
        public string SelSecond { get; set; }
        [XmlAttribute(AttributeName = "theme")]
        public string Theme { get; set; }
        [XmlAttribute(AttributeName = "themeName")]
        public string ThemeName { get; set; }
    }
    public class SubItem1
    {

        [XmlAttribute(AttributeName = "label")]
        public string Label { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "SubMain")]
        public int SubMain { get; set; }
        [XmlAttribute(AttributeName = "Depth")]
        public int Depth { get; set; }
        [XmlAttribute(AttributeName = "Path")]
        public string Path { get; set; }
        [XmlAttribute(AttributeName = "Col")]
        public int Col { get; set; }
        [XmlAttribute(AttributeName = "Merge")]
        public string Merge { get; set; }
        [XmlElement(ElementName = "item")]
        public List<SubItem2> Item { get; set; }
    }
    public class SubItem2
    {
        [XmlAttribute(AttributeName = "label")]
        public string Label2 { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id2 { get; set; }
        [XmlAttribute(AttributeName = "SubMain")]
        public int SubMain2 { get; set; }
        [XmlAttribute(AttributeName = "Depth")]
        public int Depth2 { get; set; }
        [XmlAttribute(AttributeName = "Path")]
        public string Path2 { get; set; }
        [XmlAttribute(AttributeName = "Col")]
        public int Col2 { get; set; }
        [XmlAttribute(AttributeName = "Theme")]
        public string Theme2 { get; set; }
        [XmlAttribute(AttributeName = "ThemeLabel")]
        public string ThemeLabel2 { get; set; }
        [XmlAttribute(AttributeName = "Merge")]
        public string Merge2 { get; set; }
        [XmlElement(ElementName = "item")]
        public List<SubItem3> Item2 { get; set; }
    }
    public class SubItem3
    {
        [XmlAttribute(AttributeName = "label")]
        public string Label3 { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id3 { get; set; }
        [XmlAttribute(AttributeName = "SubMain")]
        public int SubMain3 { get; set; }
        [XmlAttribute(AttributeName = "Depth")]
        public int Depth3 { get; set; }
        [XmlAttribute(AttributeName = "Theme")]
        public string Theme3 { get; set; }
        [XmlAttribute(AttributeName = "ThemeLabel")]
        public string ThemeLabel3 { get; set; }
    }

}
