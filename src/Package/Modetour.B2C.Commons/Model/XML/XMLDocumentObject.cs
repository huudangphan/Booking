using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Modetour.B2C.Commons.Model
{
    public class XMLDocumentObject : XmlDocument
    {
        private XmlDocument _XmlDoc;
        public XmlDocument XMLDocObject
        {
            get { return _XmlDoc; }
            set { _XmlDoc = value; }
        }
        public XMLDocumentObject() { _XmlDoc = new XmlDocument(); }
    }
}
