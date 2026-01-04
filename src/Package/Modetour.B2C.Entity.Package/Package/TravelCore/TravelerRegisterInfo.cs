using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.TravelCore
{
    public class TravelerRegisterInfo
    {

        /// <summary>
        ///Booker phone number
        /// </summary>
        public string BookerPhoneNumber { get; set; }
        /// <summary>
        /// booker Korean Name
        /// </summary>
        public string BookerKoreanName { get; set; }
        /// <summary>
        /// booker family name
        /// </summary>
        public string BookerEngFamilyName { get; set; }
        /// <summary>
        /// English given name
        /// </summary>
        public string BookerEngGivenName { get; set; }
        /// Traveler citizen 
        public string BookerTravelerCitizenIDNumber { get; set; }
        /// <summary>
        /// Birthday
        /// </summary>
        public string BookerDateOfBirthDay { get; set; }
        /// <summary>
        ///Gender code [1,2: adult, 3,4: infant, 5: child] (first digit after social security number x) ([Reference] When creating data, FUNC_gender code (@traveller social security number, @departure date) Calculation)
        /// </summary>
        public string BookerGender { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string BookerEmail { get; set; }

        public string SalesTypeCode { get; set; }
        /// <summary>
        /// Inquiries, additional requests
        /// </summary>
        public string AdditionalInfo { get; set; }
        /// <summary>
        /// 조기예약할인여부 Get discount when booking early value : 'Y' or 'N'
        /// </summary>
        public string EarlyBookingFlag { get; set; }
        /// <summary>
        /// DI값
        /// </summary>
        public string BookerDuplicatedSignUpConfirmInfo { get; set; }

        public int? GroupNumber { get; set; }
        public string ProductCode { get; set; }
        public string BuyCode { get; set; }
        public int? AgentNo { get; set; }
        public string AgentEmpNo { get; set; }
        public string? CampaignId { get; set; }
        public DateTime CampaignDate { get; set; }
        public bool? EarlySaleFlag { get; set; }
        public int? NumberOfAdult { get; set; }
        public int? NumberOfChildNoBed { get; set; }
        public int? NumberOfChildExtraBed { get; set; }
        public int? NumberOfToddler { get; set; }
        public string SpecialClauseFlag { get; set; }
        public bool? IsCallBack { get; set; }
        public string PartnerMatchingFlag { get; set; }
        public string InnerPayFlag { get; set; }
        public List<PartnerTravel> PartnerTravelList { get; set; }
    }
    public class PartnerTravel 
    {
        /// <summary>
        ///phone number
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Korean name
        /// </summary>
        public string KoreanName { get; set; }
        /// <summary>
        /// /English name
        /// </summary>
        public string EngFamilyName { get; set; }
        /// <summary>
        /// English name
        /// </summary>
        public string EngGivenName { get; set; }

        /// <summary>
        /// Birthday
        /// </summary>
        public string DateOfBirthDay { get; set; }
        /// <summary>
        ///Gender code [1,2: adult, 3,4: infant, 5: child] (first digit after social security number x) ([Reference] When creating data, FUNC_gender code (@traveller social security number, @departure date) Calculation)
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// TravelerCitizenIDNumber
        /// </summary>
        public string TravelerCitizenIDNumber { get; set; }
        /// <summary>
        /// Price
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        ///Sales Household Classification [Adult (P1), Child N (P2), Child E (P3), Infant (P4)] ([Reference] Recalculated as gender code within USP_T_Sales Procedure when creating data)
        /// </summary>
        public string PriceType { get; set; }
        /// <summary>
        /// Tour mileage number(MT number)
        /// </summary>
        public string MileageNo { get; set; }
        /// <summary>
        /// Classification of tour mileage members
        /// </summary>
        public string MileageLevel { get; set; }
        /// <summary>
        /// Whether to send [0: Not set, 1: Employee sending, 2: E sending]
        /// </summary>
        public int Sending { get; set; }
    }
}
