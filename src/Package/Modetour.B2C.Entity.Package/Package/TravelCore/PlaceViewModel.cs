using ModetourB2C.Dac.Model.MODEWARE3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.TravelCore
{
    public class PlaceViewModel : WSP_S_ScheduleTable.Result4
    {
        public Ext_PlaceExternalLinkModel PlaceExternalLinkModel { get; set; }
        public Ext_PlaceReviewModel PlaceReviewModel { get; set; }
        public ExtG_GoogleExternalLinkModel GoogleExternalLinkModel { get; set; }
        public string HotelNameE { get; set; }
        public string HotelNameK { get; set; }
        public string LocalK { get; set; }
        public string LocalE { get; set; }
        public string InterNetAmenities { get; set; }
        public string DefaultAmenities { get; set; }
        public string RoomAmenities { get; set; }
        public string RestrantAmenities { get; set; }
        public string BathRoomAmenities { get; set; }
        public string ParkingAmenities { get; set; }
        public string PoolAmenities { get; set; }
        public string FacilityAmenities { get; set; }
        public string SuttleAmenities { get; set; }
        public string CreditAmenities { get; set; }
        public string HotelHeedDesc { get; set; }
        public string HotelClass { get; set; }
        public string HotelChoiceServiceDesc { get; set; }
        public bool? DisplayLabel { get; set; }
        
        public List<string> HotelImage { get; set; }
        public List<string> ArrdefaultAmenities { get; set; }
        public List<string> ArrroomAmenities { get; set; }
        public List<string> ArrrestrantAmenities { get; set; }
        public List<string> ArrbathRoomAmenities { get; set; }
        public List<string> ArrparkingAmenities { get; set; }
        public List<string> ArrpoolAmenities { get; set; }
        public List<string> ArrfacilityAmenities { get; set; }
        public List<string> ArrsuttleAmenities { get; set; }
        public List<string> ArrcreditAmenities { get; set; }



    }
}
