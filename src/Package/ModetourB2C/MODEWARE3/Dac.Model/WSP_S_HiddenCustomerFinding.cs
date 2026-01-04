namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_숨은고객찾기
/// </summary>
public class WSP_S_HiddenCustomerFinding
{
	public const string SP_NAME = "WSP_S_숨은고객찾기";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// AREA_STR
		/// </summary>
		[Description("AREA_STR")]
		public string AREA_STR { get; set; }
		/// <summary>
		/// TRADE_PTID
		/// </summary>
		[Description("TRADE_PTID")]
		public int TRADE_PTID { get; set; }
		/// <summary>
		/// SDATE
		/// </summary>
		[Description("SDATE")]
		public string SDATE { get; set; }
		/// <summary>
		/// EDATE
		/// </summary>
		[Description("EDATE")]
		public string EDATE { get; set; }
		/// <summary>
		/// SEL_CNT
		/// </summary>
		[Description("SEL_CNT")]
		public int SEL_CNT { get; set; }
		/// <summary>
		/// LAST_IDX
		/// </summary>
		[Description("LAST_IDX")]
		public int LAST_IDX { get; set; }
		/// <summary>
		/// SUS_USERKEY
		/// </summary>
		[Description("SUS_USERKEY")]
		public string SUS_USERKEY { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// INFO_AREA_NAME
		/// </summary>
		[Column("INFO_AREA_NAME")]
		public string INFO_AREA_NAME { get; set; }
		/// <summary>
		/// INFO_START_DATE
		/// </summary>
		[Column("INFO_START_DATE")]
		public int INFO_START_DATE { get; set; }
		/// <summary>
		/// INFO_START_NAME
		/// </summary>
		[Column("INFO_START_NAME")]
		public string INFO_START_NAME { get; set; }
		/// <summary>
		/// INFO_PRO_CODE
		/// </summary>
		[Column("INFO_PRO_CODE")]
		public int INFO_PRO_CODE { get; set; }
		/// <summary>
		/// INFO_BG_IMG
		/// </summary>
		[Column("INFO_BG_IMG")]
		public string INFO_BG_IMG { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// LAST_ROWNUM
		/// </summary>
		[Column("LAST_ROWNUM")]
		public int LAST_ROWNUM { get; set; }
		/// <summary>
		/// ROWNUM
		/// </summary>
		[Column("ROWNUM")]
		public int ROWNUM { get; set; }
		/// <summary>
		/// GRO_IDX
		/// </summary>
		[Column("GRO_IDX")]
		public int GRO_IDX { get; set; }
		/// <summary>
		/// PRO_CODE
		/// </summary>
		[Column("PRO_CODE")]
		public string PRO_CODE { get; set; }
		/// <summary>
		/// GRO_DEPARTURE_DATE
		/// </summary>
		[Column("GRO_DEPARTURE_DATE")]
		public string GRO_DEPARTURE_DATE { get; set; }
		/// <summary>
		/// GRO_DEPARTURE_TIME
		/// </summary>
		[Column("GRO_DEPARTURE_TIME")]
		public string GRO_DEPARTURE_TIME { get; set; }
		/// <summary>
		/// GRO_ARRIVE_DATE
		/// </summary>
		[Column("GRO_ARRIVE_DATE")]
		public string GRO_ARRIVE_DATE { get; set; }
		/// <summary>
		/// GRO_ARRIVE_TIME
		/// </summary>
		[Column("GRO_ARRIVE_TIME")]
		public string GRO_ARRIVE_TIME { get; set; }
		/// <summary>
		/// GRO_AIR_CODE_FULL
		/// </summary>
		[Column("GRO_AIR_CODE_FULL")]
		public string GRO_AIR_CODE_FULL { get; set; }
		/// <summary>
		/// GRO_AIR_CODE
		/// </summary>
		[Column("GRO_AIR_CODE")]
		public string GRO_AIR_CODE { get; set; }
		/// <summary>
		/// GRO_AIR_NAME
		/// </summary>
		[Column("GRO_AIR_NAME")]
		public string GRO_AIR_NAME { get; set; }
		/// <summary>
		/// GRO_AIR_TYPE
		/// </summary>
		[Column("GRO_AIR_TYPE")]
		public string GRO_AIR_TYPE { get; set; }
		/// <summary>
		/// GRO_NIGHTS
		/// </summary>
		[Column("GRO_NIGHTS")]
		public byte GRO_NIGHTS { get; set; }
		/// <summary>
		/// GRO_DAYS
		/// </summary>
		[Column("GRO_DAYS")]
		public byte GRO_DAYS { get; set; }
		/// <summary>
		/// GRO_PNAME
		/// </summary>
		[Column("GRO_PNAME")]
		public string GRO_PNAME { get; set; }
		/// <summary>
		/// GRO_DISCOUNT_BEFORE_PRICE
		/// </summary>
		[Column("GRO_DISCOUNT_BEFORE_PRICE")]
		public long GRO_DISCOUNT_BEFORE_PRICE { get; set; }
		/// <summary>
		/// GRO_PRICE
		/// </summary>
		[Column("GRO_PRICE")]
		public long GRO_PRICE { get; set; }
		/// <summary>
		/// GRO_AVAIL_DATE
		/// </summary>
		[Column("GRO_AVAIL_DATE")]
		public string GRO_AVAIL_DATE { get; set; }
		/// <summary>
		/// GRO_NAMETL
		/// </summary>
		[Column("GRO_NAMETL")]
		public string GRO_NAMETL { get; set; }
		/// <summary>
		/// GRO_SEAT
		/// </summary>
		[Column("GRO_SEAT")]
		public int GRO_SEAT { get; set; }
		/// <summary>
		/// GRO_RESERVED_SEAT
		/// </summary>
		[Column("GRO_RESERVED_SEAT")]
		public int GRO_RESERVED_SEAT { get; set; }
		/// <summary>
		/// GRO_BOOKING_SEAT
		/// </summary>
		[Column("GRO_BOOKING_SEAT")]
		public int GRO_BOOKING_SEAT { get; set; }
		/// <summary>
		/// GRO_MIN_SEAT
		/// </summary>
		[Column("GRO_MIN_SEAT")]
		public int GRO_MIN_SEAT { get; set; }
		/// <summary>
		/// GRO_AD_STATUS
		/// </summary>
		[Column("GRO_AD_STATUS")]
		public string GRO_AD_STATUS { get; set; }
		/// <summary>
		/// GRO_START_ACCEPT
		/// </summary>
		[Column("GRO_START_ACCEPT")]
		public string GRO_START_ACCEPT { get; set; }
		/// <summary>
		/// GRO_STATUS
		/// </summary>
		[Column("GRO_STATUS")]
		public string GRO_STATUS { get; set; }
		/// <summary>
		/// GRO_CHOICE
		/// </summary>
		[Column("GRO_CHOICE")]
		public int GRO_CHOICE { get; set; }
		/// <summary>
		/// GRO_TYPE
		/// </summary>
		[Column("GRO_TYPE")]
		public string GRO_TYPE { get; set; }
		/// <summary>
		/// GRO_LOCALCOST_YN
		/// </summary>
		[Column("GRO_LOCALCOST_YN")]
		public string GRO_LOCALCOST_YN { get; set; }
		/// <summary>
		/// GRO_LOCALCOST
		/// </summary>
		[Column("GRO_LOCALCOST")]
		public int GRO_LOCALCOST { get; set; }
		/// <summary>
		/// GRO_LOCALCOST_NAME
		/// </summary>
		[Column("GRO_LOCALCOST_NAME")]
		public string GRO_LOCALCOST_NAME { get; set; }
		/// <summary>
		/// GRO_SHOPPING
		/// </summary>
		[Column("GRO_SHOPPING")]
		public int GRO_SHOPPING { get; set; }
		/// <summary>
		/// GRO_GUIDE_YN
		/// </summary>
		[Column("GRO_GUIDE_YN")]
		public string GRO_GUIDE_YN { get; set; }
		/// <summary>
		/// GRO_GUIDE
		/// </summary>
		[Column("GRO_GUIDE")]
		public string GRO_GUIDE { get; set; }
		/// <summary>
		/// GRO_FREE
		/// </summary>
		[Column("GRO_FREE")]
		public string GRO_FREE { get; set; }
		/// <summary>
		/// GRO_HOTEL_CLASS
		/// </summary>
		[Column("GRO_HOTEL_CLASS")]
		public string GRO_HOTEL_CLASS { get; set; }
		/// <summary>
		/// GRO_SHIP_YN
		/// </summary>
		[Column("GRO_SHIP_YN")]
		public string GRO_SHIP_YN { get; set; }
		/// <summary>
		/// GRO_GOLF_HOLE
		/// </summary>
		[Column("GRO_GOLF_HOLE")]
		public string GRO_GOLF_HOLE { get; set; }
		/// <summary>
		/// GRO_GOLFCADDIE_YN
		/// </summary>
		[Column("GRO_GOLFCADDIE_YN")]
		public string GRO_GOLFCADDIE_YN { get; set; }
		/// <summary>
		/// GRO_GOLFCART_YN
		/// </summary>
		[Column("GRO_GOLFCART_YN")]
		public string GRO_GOLFCART_YN { get; set; }
		/// <summary>
		/// GRO_DEPARTURE_CITY_CODE
		/// </summary>
		[Column("GRO_DEPARTURE_CITY_CODE")]
		public string GRO_DEPARTURE_CITY_CODE { get; set; }
		/// <summary>
		/// GRO_THEME
		/// </summary>
		[Column("GRO_THEME")]
		public string GRO_THEME { get; set; }
		/// <summary>
		/// GRO_DISCOUNT_ICON_YN
		/// </summary>
		[Column("GRO_DISCOUNT_ICON_YN")]
		public string GRO_DISCOUNT_ICON_YN { get; set; }
		/// <summary>
		/// GRO_DISCOUNT
		/// </summary>
		[Column("GRO_DISCOUNT")]
		public string GRO_DISCOUNT { get; set; }
		/// <summary>
		/// GRO_DISCOUNT_LOGOPATH
		/// </summary>
		[Column("GRO_DISCOUNT_LOGOPATH")]
		public string GRO_DISCOUNT_LOGOPATH { get; set; }
		/// <summary>
		/// GRO_DISCOUNT_MASTER_NUMBER
		/// </summary>
		[Column("GRO_DISCOUNT_MASTER_NUMBER")]
		public int GRO_DISCOUNT_MASTER_NUMBER { get; set; }
	}
}