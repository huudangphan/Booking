namespace Modetour.B2C.Entity.Package.Package
{
    public class ProductFilter
    {
        public string? typeFilter { get; set; }
        public decimal? minPrice { get; set; }
        public decimal? maxPrice { get; set; }
        public string[]? startingPoint { get; set; }
        public string[]? travelConcept { get; set; }
        public string[]? transport { get; set; }
        public string? promotion { get; set; }
        public TourConditionCommand? tourCondition { get; set; }
        public string[]? travelPeriod { get; set; }
        public string[]? depatureTime { get; set; }
        public string[]? depatureDay { get; set; }
        public string[]? lodgment { get; set; }
        //public string[]? productBrand { get; set; }  
        public bool? isViewAllAvaiableSeat { get; set; }
        public string? Sort { get; set; }
        public string[]? hotelGrade { get; set; }
        public string[]? TravelType { get; set; }
        //public int PageNo { get; set; }
        //public int TotalRecord { get; set; }
    }
    public class TourCondition
    {
        public List<Grade> AirSeatClass { get; set; }
        public List<Grade> AirPortTax { get; set; }
        public List<Grade> LocalTraffic { get; set; }
        public List<Grade> MealFee { get; set; }
        public List<Grade> RoomCharge { get; set; }
        //public List<Grade> Dolomites { get; set; }
        public List<Grade> EntranceFee { get; set; }
        public List<Grade> NeccessaryLocalExpenses { get; set; }
        public List<Grade> LocalGuide { get; set; }
        public List<Grade> GuideYn { get; set; }
        public List<Grade> AccompaniedByAChaperone { get; set; }

        public List<Grade> Shopping { get; set; }
        public List<Grade> FreeSchedule { get; set; }
        public List<Grade> OptionalTour { get; set; }

    }
    public class TourConditionCommand
    {
        public List<string>? AirSeatClass { get; set; }
        public List<string>? AirPortTax { get; set; }
        public List<string>? LocalTraffic { get; set; }
        public List<string>? MealFee { get; set; }
        public List<string>? RoomCharge { get; set; }
        public List<string>? Dolomites { get; set; }
        public List<string>? EntranceFee { get; set; }
        public List<string>? NeccessaryLocalExpenses { get; set; }
        public List<string>? LocalGuide { get; set; }
        public List<string>? GuideYn { get; set; }
        //public List<string> AccompaniedByAChaperone { get; set; }

        public List<string>? Shopping { get; set; }
        public List<string>? FreeSchedule { get; set; }
        public List<string>? OptionalTour { get; set; }
    }
    public class FilterTourCondition
    {
        public TourCondition tourContion { get; set; }
        public string filterStatus { get; set; }
    }
    public class TourConditionC
    {
        public IEnumerable<GradeC> AirSeatClass { get; set; }
        public IEnumerable<GradeC> AirPortTax { get; set; }
        public IEnumerable<GradeC> LocalTraffic { get; set; }
        public IEnumerable<GradeC> MealFee { get; set; }
        public IEnumerable<GradeC> RoomCharge { get; set; }
        //public IEnumerable<GradeC> Dolomites { get; set; }
        public List<GradeC> EntranceFee { get; set; }
        public List<GradeC> NeccessaryLocalExpenses { get; set; }
        public IEnumerable<GradeC> LocalGuide { get; set; }
        public IEnumerable<GradeC> GuideYn { get; set; }
        public List<GradeC> AccompaniedByAChaperone { get; set; }

        public List<GradeC> Shopping { get; set; }
        public IEnumerable<GradeC> FreeSchedule { get; set; }
        public List<GradeC> OptionalTour { get; set; }
        public List<GradeC> TravelType { get; set; }
    }
}