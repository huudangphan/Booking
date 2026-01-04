using ModetourB2C.Dac.Model.MODEWARE3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package
{
    public class ScheduleTableViewModel : WSP_S_ScheduleTable.Result1
    {
        public string TransportSchedule { get; set; }
        public string AddPerson { get; set; }
        public string NumberOfBooking { get; set; }
        public string VisitCity { get; set; }
    }
}
