namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_TM_STORYM_TOURIST_INSERT
/// </summary>
public class WSP_T_CMN_TM_STORYM_TOURIST_INSERT
{
	public const string SP_NAME = "WSP_T_CMN_TM_STORYM_TOURIST_INSERT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// AreaCode
		/// </summary>
		[Description("AreaCode")]
		public string AreaCode { get; set; }
		/// <summary>
		/// TouristCode
		/// </summary>
		[Description("TouristCode")]
		public string TouristCode { get; set; }
		/// <summary>
		/// UseFlag
		/// </summary>
		[Description("UseFlag")]
		public string UseFlag { get; set; }
		/// <summary>
		/// Summary
		/// </summary>
		[Description("Summary")]
		public string Summary { get; set; }
		/// <summary>
		/// Order
		/// </summary>
		[Description("Order")]
		public int Order { get; set; }
		/// <summary>
		/// Name
		/// </summary>
		[Description("Name")]
		public string Name { get; set; }
		/// <summary>
		/// Img1
		/// </summary>
		[Description("Img1")]
		public string Img1 { get; set; }
		/// <summary>
		/// Img2
		/// </summary>
		[Description("Img2")]
		public string Img2 { get; set; }
		/// <summary>
		/// Location
		/// </summary>
		[Description("Location")]
		public string Location { get; set; }
		/// <summary>
		/// Addr
		/// </summary>
		[Description("Addr")]
		public string Addr { get; set; }
		/// <summary>
		/// Tel
		/// </summary>
		[Description("Tel")]
		public string Tel { get; set; }
		/// <summary>
		/// HomePage
		/// </summary>
		[Description("HomePage")]
		public string HomePage { get; set; }
		/// <summary>
		/// MinBookingCnt
		/// </summary>
		[Description("MinBookingCnt")]
		public string MinBookingCnt { get; set; }
		/// <summary>
		/// Price
		/// </summary>
		[Description("Price")]
		public string Price { get; set; }
		/// <summary>
		/// CheckInOut
		/// </summary>
		[Description("CheckInOut")]
		public string CheckInOut { get; set; }
		/// <summary>
		/// RoomCnt
		/// </summary>
		[Description("RoomCnt")]
		public string RoomCnt { get; set; }
		/// <summary>
		/// RoomType
		/// </summary>
		[Description("RoomType")]
		public string RoomType { get; set; }
		/// <summary>
		/// SpecialMenu
		/// </summary>
		[Description("SpecialMenu")]
		public string SpecialMenu { get; set; }
		/// <summary>
		/// SetMenu
		/// </summary>
		[Description("SetMenu")]
		public string SetMenu { get; set; }
		/// <summary>
		/// WayToGo
		/// </summary>
		[Description("WayToGo")]
		public string WayToGo { get; set; }
		/// <summary>
		/// OfficeHours
		/// </summary>
		[Description("OfficeHours")]
		public string OfficeHours { get; set; }
		/// <summary>
		/// Holidays
		/// </summary>
		[Description("Holidays")]
		public string Holidays { get; set; }
		/// <summary>
		/// WayToRide
		/// </summary>
		[Description("WayToRide")]
		public string WayToRide { get; set; }
		/// <summary>
		/// Fare
		/// </summary>
		[Description("Fare")]
		public string Fare { get; set; }
		/// <summary>
		/// Time
		/// </summary>
		[Description("Time")]
		public string Time { get; set; }
		/// <summary>
		/// AddFacility
		/// </summary>
		[Description("AddFacility")]
		public string AddFacility { get; set; }
	}

}