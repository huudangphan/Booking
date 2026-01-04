using ModetourB2C.Dac.Model.MODEWARE3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package
{
    public class ProductInfoViewModel : WSP_S_ScheduleTable.Result1
    {
        public string TransportationMethodEngName { get; set; }
        public string FlightCode { get; set; }
        public string FlightCodeLogoImage { get; set; }
        public string? ReserveStatus { get; set; }

        public string? MeetSrc { get; set; }

        public string? CountryUnique { get; set; }
        public List<String> VisitCities { get; set; }
        public List<ImageItem> ListAreaImages { get; set; }
        public List<SafetyInfoModel> ListSafetyInfoEachCountry { get; set; }
    }

    public enum BookingStatus
    {
        Available,
        PhoneConfirm,
        End,
        Waiting
    }

    public class ImageItem 
    {
        public string Type { get; set; }
        public string Image { get; set; }
    }
}
