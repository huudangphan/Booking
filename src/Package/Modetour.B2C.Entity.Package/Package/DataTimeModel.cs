using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.Package
{
    public class DataTimeModel
    {
        public string FromTime { get; set; }
        public string ToTime { get; set; }       
        public DateTime DfromTime { get { return Convert.ToDateTime(FromTime); }set { } }
        public DateTime DtoTime { get { return Convert.ToDateTime(ToTime); } set { } }
    }
}
