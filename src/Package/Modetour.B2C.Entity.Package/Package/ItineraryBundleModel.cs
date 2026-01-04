namespace Modetour.B2C.Entity.Package
{
    /// <summary>
    /// 일정표 Bundle
    /// </summary>
    public class ItineraryBundleModel
    {
        /// <summary>
        /// 단체정보
        ///   group information
        /// </summary>
        public TourProductModel TourProduct { get; set; }
        /// <summary>
        /// arr_항공비고
        /// arr_flight remarks
        /// </summary>
        public List<AirRemarksModel> arrAirRemark { get; set; }
        /// <summary>
        /// arr_다른날짜
        /// arr_other date
        /// </summary>
        public List<OtherDayModel> arrOtherDay { get; set; }
        /// <summary>
        /// arr_장소정보
        ///  arr_place information
        /// </summary>
        public List<PlaceModel.Result> arrPlace { get; set; }
    }
}
