namespace Modetour.B2C.Entity.Package
{
    public class ScheduleTabViewModel
    {
        //public DateTime LastDate { get; set; }
        //public int LastDay { get; set; }

        //public string DepartureCityName { get; set; }
        //public string ArrivalCityName { get; set; }
        public List<ScheduleTabItem> ScheduleItemList { get; set; }
    }

    public class ScheduleTabItem
    {
        public DateTime Date { get; set; }
        public int First { get; set; }
        public IEnumerable<string>? AllPlaceTravelToday { get; set; }
        public List<string> PlaceHeader { get; set; }
        //public string AirRouteInfo { get; set; }
        public List<TourScheduleItemModel> OrtherActions { get; set; }

        //public IEnumerable<PlaceModel.Result> OrtherActions { get; set; }
        public IEnumerable<PlaceModel.Result> ListLocalPlace { get; set; }

        public IEnumerable<PlaceModel.Result> ListGuidePlace { get; set; }
        public IEnumerable<PlaceModel.Result> ListHotelPlace { get; set; }
        public IEnumerable<PlaceModel.Result> ListTransportPlace { get; set; }
        public IEnumerable<PlaceModel.Result> ListMealPlace { get; set; }
        public AirRouteViewModel ListAirRouteInfo { get; set; }
    }
}