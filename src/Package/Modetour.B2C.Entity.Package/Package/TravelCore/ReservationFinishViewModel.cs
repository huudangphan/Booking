using Modetour.B2C.Entity.Package.TravelCore;
using ModetourB2C.Dac.Model.MODEWARE3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.Package.TravelCore
{
    public class ReservationFinishViewModel
    {
        public SangPumData SangPum { get; set; }
        public ProductReservationData Product { get; set; }
        public OrderReservationData Order { get; set; }
        public ForeignKeyData ForeignKey { get; set; }
        public InChargeData InCharge { get; set; }
        public SubscriberData Subscriber { get; set; }
        public List<PartnerTravelItem> PartnerTravelList { get; set; }
    }
    public class ProductReservationData : WSP_S_CMN_GroupReservationFinish.Result4
    {
        public string GroupBriefKeyword { get; set; }
    }
    public class OrderReservationData : WSP_S_CMN_GroupReservationFinish.Result1
    {
        public int? NumberOfAdult { get; set; } = 0;
        public int? NumberOfChildNobed { get; set; } = 0;
        public int? NumberOfChildExtraBed { get; set; } = 0;
        public int? NumberOfTolder { get; set; } = 0;
    }
    public class InChargeData : WSP_S_CMN_GroupReservationFinish.Result6
    {
    }
    public class SubscriberData : WSP_S_CMN_GroupReservationFinish.Result2
    {
    }
    public class SangPumData : WSP_S_CMN_GroupReservationFinish.Result5
    {
    }
    public class ForeignKeyData : WSP_S_CMN_GroupReservationFinish.Result7
    {
    }
    public class PartnerTravelItem : PartnerTravel
    {
        public string? CustomerRequest { get; set; }
        public string ? EmailCheck { get; set; }
        public string? PassportExpirationDate { get; set; }
        public string? PassportCode { get; set; }
        public string? PassportExpirationDate1 { get; set; }
    }
}
