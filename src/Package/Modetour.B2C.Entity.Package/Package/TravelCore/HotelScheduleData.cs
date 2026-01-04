using Modetour.B2C.Entity.Package.TravelCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package
{
    public class HotelSchedule
    {
        public List<HotelScheduleDataItem> ListHotelScheduleDataItem { get; set; }
    }
    public class HotelScheduleDataItem
    {
        public DateTime Date { get; set; }
        public int First { get; set; }
        public List<string> PlaceHeader { get; set; }
        public IEnumerable<PlaceModel.Result> ListHotelPlaceData { get; set; }
    }

}
