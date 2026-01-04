using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package
{
    public class ShareMailViewModel
    {
        public int GroupId { get; set; }
        /// <summary>MailFromName</summary>
        public string MailFromName { get; set; }
        public string MailFromAddr { get; set; }
        public string MailToAddrList { get; set; }
        public string MailTitle { get; set; }
        public string MailContent { get; set; }
    }
}
