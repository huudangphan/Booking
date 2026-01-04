using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Modetour.B2C.Entity.Package.Package
{
    public class ProductMasterDetailResponse
    {
        [JsonProperty("ModeTour")]
        public ModeTouretail[] ProductMasterDetail { get; set; }
    }
    #region old model
    public class ProductMasterDetailParse
    {
        public ModeTouretail[] ProductMasterDetail { get; set; }
        public Filter Filter { get; set; }
    }
    public partial class ProductList
    {
        [JsonProperty("MasterNumber")]
        public string MasterNumber { get; set; }

        [JsonProperty("pnum")]
        public long Pnum { get; set; }

        [JsonProperty("sDate")]
        public DateTimeOffset SDate { get; set; }

        [JsonProperty("eDate")]
        public DateTimeOffset EDate { get; set; }

        [JsonProperty("sday")]
        public string Sday { get; set; }

        [JsonProperty("eDay")]
        public string EDay { get; set; }

        [JsonProperty("period")]
        public long Period { get; set; }

        [JsonProperty("sTime")]
        public string STime { get; set; }

        [JsonProperty("eTime")]
        public string ETime { get; set; }

        [JsonProperty("night")]
        public long Night { get; set; }

        [JsonProperty("day")]
        public long Day { get; set; }

        [JsonProperty("airCode")]
        public string AirCode { get; set; }

        [JsonProperty("airName")]
        public string AirName { get; set; }

        [JsonProperty("ke")]
        public string Ke { get; set; }

        [JsonProperty("oz")]
        public string Oz { get; set; }

        [JsonProperty("fa")]
        public string Fa { get; set; }

        [JsonProperty("lca")]
        public string Lca { get; set; }

        [JsonProperty("ship")]
        public string Ship { get; set; }

        [JsonProperty("df")]
        public string Df { get; set; }

        [JsonProperty("sAdult")]
        public long SAdult { get; set; }

        [JsonProperty("hotel")]
        public long Hotel { get; set; }

        [JsonProperty("hotelGrade")]
        public string HotelGrade { get; set; }

        [JsonProperty("golfCourse")]
        public long GolfCourse { get; set; }

        [JsonProperty("golfHall")]
        public object GolfHall { get; set; }

        [JsonProperty("golfHallCode")]

        public long GolfHallCode { get; set; }

        [JsonProperty("golfCaddie")]
        public string GolfCaddie { get; set; }

        [JsonProperty("golfCart")]
        public string GolfCart { get; set; }

        [JsonProperty("shoppingCount")]
        public long ShoppingCount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("adultExpense")]
        public long AdultExpense { get; set; }

        [JsonProperty("guideInwon")]
        public long GuideInwon { get; set; }

        [JsonProperty("guideWithFlag")]
        public string GuideWithFlag { get; set; }

        [JsonProperty("guideWith")]
        public string GuideWith { get; set; }

        [JsonProperty("guideDecide")]
        public string GuideDecide { get; set; }

        [JsonProperty("freeTime")]
        public string FreeTime { get; set; }

        [JsonProperty("prefix")]

        public long Prefix { get; set; }

        [JsonProperty("prefixName")]
        public string PrefixName { get; set; }

        [JsonProperty("pName")]
        public string PName { get; set; }

        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        [JsonProperty("availableSeatNumber")]

        public long AvailableSeatNumber { get; set; }

        [JsonProperty("disCount")]
        public long DisCount { get; set; }

        [JsonProperty("bookingState")]

        public long BookingState { get; set; }
        [JsonProperty("depatureFrom")]
        public string DepatureFrom { get; set; }

        [JsonProperty("depatureTo")]
        public string DepatureTo { get; set; }

        [JsonProperty("freeSeat")]
        public long FreeSeat { get; set; }

        [JsonProperty("mimimumDepature")]
        public long MimimumDepature { get; set; }
        [JsonProperty("OrderNumberPlaced")]
        public long OrderNumberPlaced { get; set; }
    }
    #endregion
    public partial class ModeTouretail
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("LastModifiDate")]
        public string LastModifiDate { get; set; }
        [JsonProperty("Month")]
        public int month { get; set; }
        [JsonProperty("Pcode")]
        [BsonElement("Pcode")]
        public string Pcode { get; set; }

        [JsonProperty("YYYYMM")]
        [BsonElement("Yyyymm")]
        public long Yyyymm { get; set; }

        [JsonProperty("Theme")]
        [BsonElement("Theme")]
        public string Theme { get; set; }

        //[JsonProperty("CreateDate")]
        //public DateTimeOffset CreateDate { get; set; }

        //[JsonProperty("MonthWeekDay")]
        //public MonthWeekDay MonthWeekDay { get; set; }

        [JsonProperty("ProductDate")]
        [BsonElement("ProductDate")]
        public ProductDate[] ProductDate { get; set; }

        [JsonProperty("MinMax")]
        [BsonElement("MinMax")]
        public MinMax MinMax { get; set; }

        [JsonProperty("ProductTitle")]
        [BsonElement("ProductTitle")]
        public string ProductTitle { get; set; }

        [JsonProperty("ProductImg")]
        [BsonElement("ProductImg")]
        public string ProductImg { get; set; }

        [JsonProperty("ProductCont")]
        [BsonElement("ProductCont")]
        public string ProductCont { get; set; }

        [JsonProperty("ProductKey")]
        [BsonElement("ProductKey")]
        public string[] ProductKey { get; set; }

        //[JsonProperty("Place")]
        //public Place[] Place { get; set; }
    }

    public partial class MinMax
    {
        [JsonProperty("minPrice")]
        [BsonElement("MinPrice")]
        public long MinPrice { get; set; }

        [JsonProperty("maxPrice")]
        [BsonElement("MaxPrice")]
        public long MaxPrice { get; set; }

        [JsonProperty("minDays")]
        [BsonElement("MinDays")]
        public long MinDays { get; set; }

        [JsonProperty("maxDays")]
        [BsonElement("MaxDays")]
        public long MaxDays { get; set; }
    }

    public partial class MonthWeekDay
    {
        [JsonProperty("StartWeekDay")]
        public long StartWeekDay { get; set; }

        [JsonProperty("WeekDay")]
        public WeekDay WeekDay { get; set; }
    }

    public partial class WeekDay
    {
        [JsonProperty("Sat")]
        public DateTimeOffset[] Sat { get; set; }

        [JsonProperty("Sun")]
        public DateTimeOffset[] Sun { get; set; }
    }

    public partial class Place
    {
        [JsonProperty("Nation")]
        public Nation Nation { get; set; }
    }

    public partial class Nation
    {
        [JsonProperty("pId")]
        public long PId { get; set; }

        [JsonProperty("pCode")]
        public string PCode { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("City", NullValueHandling = NullValueHandling.Ignore)]
        public Nation City { get; set; }
    }

    public partial class ProductDate
    {
        [JsonProperty("Pnum")]
        public long Pnum { get; set; }

        //[JsonProperty("Assort")]
        //public object Assort { get; set; }

        //[JsonProperty("Grade")]
        //public string Grade { get; set; }

        //[JsonProperty("Meet")]
        //public string Meet { get; set; }

        //[JsonProperty("State")]
        //public string State { get; set; }

        //[JsonProperty("StateSort")]
        //public long StateSort { get; set; }

        //[JsonProperty("Com")]
        //public long Com { get; set; }

        [JsonProperty("shoppingCount")]
        public long ShoppingCount { get; set; }

        [JsonProperty("leaderYN")]
        public string LeaderYn { get; set; }

        [JsonProperty("guideYN")]
        public string GuideYn { get; set; }

        [JsonProperty("PName")]
        public string PName { get; set; }

        [JsonProperty("Price")]
        public Price Price { get; set; }

        [JsonProperty("beforeDicount")]
        [BsonElement("BeforeDicount")]
        public BeforeDicount BeforeDicount { get; set; }

        [JsonProperty("Date")]
        [BsonElement("Date")]
        public ProductDateDate Date { get; set; }

        [JsonProperty("Air")]
        public Air Air { get; set; }

        //[JsonProperty("Hidden")]
        //public Hidden Hidden { get; set; }

        [JsonProperty("Booking")]
        public Booking Booking { get; set; }

        [JsonProperty("PrefixPName")]
        public string PrefixPName { get; set; }

        //[JsonProperty("Price2")]
        //public Dictionary<string, long> Price2 { get; set; }

        [JsonProperty("Filters")]
        public Filters Filters { get; set; }
    }

    public partial class Air
    {
        [JsonProperty("AirCode")]
        public string AirCode { get; set; }

        [JsonProperty("StartAir")]
        public string StartAir { get; set; }

        [JsonProperty("AirLineName")]
        public string AirLineName { get; set; }
    }

    public partial class BeforeDicount
    {
        //[JsonProperty("Icon")]
        //public string Icon { get; set; }

        //[JsonProperty("Rate_Price")]
        //public string RatePrice { get; set; }

        //[JsonProperty("PromotionText")]
        //public string PromotionText { get; set; }

        [JsonProperty("Adult")]
        public long Adult { get; set; }

        //[JsonProperty("ChildNoBed")]
        //public long ChildNoBed { get; set; }

        //[JsonProperty("ChildExBed")]
        //public long ChildExBed { get; set; }

        //[JsonProperty("Infant")]
        //public long Infant { get; set; }

        //[JsonProperty("Join")]
        //public long Join { get; set; }
    }

    public partial class Booking
    {
        [JsonProperty("State")]

        public long State { get; set; }

        [JsonProperty("RestSeat")]

        public long RestSeat { get; set; }

        [JsonProperty("MinSeat")]
        public long MinSeat { get; set; }
    }

    public partial class ProductDateDate
    {
        [JsonProperty("Sdate")]
        public DateTimeOffset Sdate { get; set; }

        [JsonProperty("Edate")]
        public DateTimeOffset Edate { get; set; }

        [JsonProperty("Night")]
        public long Night { get; set; }

        [JsonProperty("Days")]
        public long Days { get; set; }

        [JsonProperty("StartTime")]
        public string StartTime { get; set; }

        [JsonProperty("Startweekday")]
        public long Startweekday { get; set; }

        [JsonProperty("ArrivalTime")]
        public string ArrivalTime { get; set; }

        [JsonProperty("Arrivalweekday")]
        public long Arrivalweekday { get; set; }
        [BsonElement("Period")]
        public string Period { get { return Night.ToString() + "|" + Days.ToString(); } }
    }

    public partial class Filters
    {
        [JsonProperty("Theme")]
        public string Theme { get; set; }

        [JsonProperty("departure")]
        public string Departure { get; set; }
        public string DepatureName { get; set; }

        [JsonProperty("concept")]
        public Grade[] Concept { get; set; }

        [JsonProperty("transportation")]
        public Grade Transportation { get; set; }

        [JsonProperty("airLineName")]
        public string AirLineName { get; set; }

        [JsonProperty("promotion")]
        public object Promotion { get; set; }

        [JsonProperty("condition")]
        public Condition Condition { get; set; }

        [JsonProperty("Date")]
        public FiltersDate Date { get; set; }

        [JsonProperty("hotelGrade")]
        public Grade HotelGrade { get; set; }

        [JsonProperty("Grade")]
        public Grade Grade { get; set; }
    }

    public partial class Grade
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
    public partial class GradeC
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cnt")]
        public int Cnt { get; set; }
    }
    public partial class Condition
    {
        [JsonProperty("flightClass")]
        public Grade FlightClass { get; set; }

        [JsonProperty("localAirportTaxYn")]
        public Grade LocalAirportTaxYn { get; set; }

        [JsonProperty("localTransportation")]
        public Grade[] LocalTransportation { get; set; }

        [JsonProperty("mealFee")]
        public Grade MealFee { get; set; }

        [JsonProperty("roomCharge")]
        public Grade RoomCharge { get; set; }

        [JsonProperty("admission")]
        public Grade Admission { get; set; }

        [JsonProperty("localExpensesYN")]

        public bool LocalExpensesYn { get; set; }

        [JsonProperty("leader")]
        public Grade Leader { get; set; }

        [JsonProperty("guideYN")]
        public Grade GuideYn { get; set; }

        [JsonProperty("shppingCount")]
        public long ShppingCount { get; set; }

        [JsonProperty("freeschedule")]
        public Grade Freeschedule { get; set; }

        [JsonProperty("optionalTour")]

        public bool OptionalTour { get; set; }
        [JsonProperty("localTraffic")]
        public Grade LocalTraffic { get; set; }
    }

    public partial class FiltersDate
    {
        [JsonProperty("Night")]
        public long Night { get; set; }

        [JsonProperty("Days")]
        public long Days { get; set; }

        [JsonProperty("StartTime")]
        public string StartTime { get; set; }

        [JsonProperty("Startweekday")]
        public long Startweekday { get; set; }
        public string Period { get { return Night.ToString() + " night /" + Days.ToString() + " day"; } set { } }
    }

    public partial class Hidden
    {
        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("HiddenSite")]
        public HiddenSite[] HiddenSite { get; set; }
    }

    public partial class HiddenSite
    {
        [JsonProperty("OrdSeq")]
        public long OrdSeq { get; set; }

        [JsonProperty("AgentName")]
        public string AgentName { get; set; }

        [JsonProperty("HiddenYn")]
        public string HiddenYn { get; set; }
    }

    public partial class Price
    {
        [JsonProperty("Adult")]
        public long Adult { get; set; }

        //[JsonProperty("ChildNoBed")]
        //public long ChildNoBed { get; set; }

        //[JsonProperty("ChildExBed")]
        //public long ChildExBed { get; set; }

        //[JsonProperty("Infant")]
        //public long Infant { get; set; }

        //[JsonProperty("Join")]
        //public long Join { get; set; }

        //[JsonProperty("noTipYN")]
        //public string NoTipYn { get; set; }

        //[JsonProperty("localExpensesYN")]
        //public string LocalExpensesYn { get; set; }

        //[JsonProperty("localExpensesCurrency")]
        //public string LocalExpensesCurrency { get; set; }

        //[JsonProperty("localExpenses")]
        //public long LocalExpenses { get; set; }
    }
}
