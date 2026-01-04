namespace Modetour.B2C.Entity.Package
{
    public class AirRouteViewModel{
        public string FlightTypeName { get; set; }
        public bool isDirectFlight { get; set; }
        public List<AirRouteItemViewModel> Item { get; set; }
     }
    public class AirRouteItemViewModel
    {
        public string Name { get; set; }
        public string AirlineLogo { get; set; }
        public string AirlineName { get; set; }
        public string DepartureCityName { get; set; }
        public string DepartureCity { get; set; }
        public DateTime? DepartureDate { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalCity { get; set; }
        public string ArrivalCityName { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public string DepartureFlightDuration { get; set; }
        public string DepartureFlight { get; set; }
        public DateTime? D_T_DepartureDate { get; set; }
        public string D_T_DepartureTime { get; set; }
        public string D_ThroughCityName { get; set; }
        public string D_ThroughCity { get; set; }
        public DateTime? D_T_ArrivalDate { get; set; }
        public string D_T_DepartureFlightDuration { get; set; }
        public string D_T_ArrivalTime { get; set; }
        public string DepartureDateDiff { get; set; }
        public string A_ThroughCityName { get; set; }
        public string A_DepartureCity { get; set; }

        public DateTime? ThroughDate1 { get; set; }
        public DateTime? ThroughDate2 { get; set; }
        public string? WaitingTime { get; set; }
        public string Description { get; set; }
        public string D_T_AirFlight { get; set; }
        public string DepartureFlightTime { get; set; }
        public string ArrivalTime { get; set; }
        public string ArrivalDateDiff { get; set; }
        public string ThroughDateDiff { get; set; }
    }
}