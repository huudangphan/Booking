using ModetourB2C.Dac.Model.MODEWARE3.Package;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.Package.Json
{
    public class GroupItem : WSP_S_CMN_GroupList.Result1
    {
        public int MoreInclusionsNumber { get; set; }
        public int TouristSpotsNumber { get; set; }
        public int MealNumber { get; set; }
        public int HotelStyleNumber { get; set; }

        public int FreeSchduleNumber { get; set; }
        
        public string RepresentativeImage { get; set; }
    }
}
