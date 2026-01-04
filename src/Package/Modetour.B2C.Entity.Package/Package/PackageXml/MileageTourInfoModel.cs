using ModetourB2C.Dac.Model.MODEWARE3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.Package.PackageXml
{
    public class MileageTourInfoModel
    {
        public MileageTourInfoWithNoPTId Data1 { get; set; }
        public MileageTourInfoWithPTId Data2 { get; set; }

    }
    public class MileageTourInfoWithNoPTId : USP_S_Sale_MemberInfo_01.Result1 {
    
    }
    public class MileageTourInfoWithPTId : USP_S_Sale_MemberInfo_01.Result2 {

    }
}
