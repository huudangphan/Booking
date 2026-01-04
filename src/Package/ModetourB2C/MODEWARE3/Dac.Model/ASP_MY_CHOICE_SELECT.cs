namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// ASP_MY_CHOICE_SELECT
/// </summary>
public class ASP_MY_CHOICE_SELECT
{
	public const string SP_NAME = "ASP_MY_CHOICE_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// SUS_USERKEY
		/// </summary>
		[Description("SUS_USERKEY")]
		public string SUS_USERKEY { get; set; }
		/// <summary>
		/// SUS_TYPE
		/// </summary>
		[Description("SUS_TYPE")]
		public string SUS_TYPE { get; set; }
		/// <summary>
		/// LAST_IDX
		/// </summary>
		[Description("LAST_IDX")]
		public int LAST_IDX { get; set; }
		/// <summary>
		/// SEL_CNT
		/// </summary>
		[Description("SEL_CNT")]
		public int SEL_CNT { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// TOTAL_CNT
		/// </summary>
		[Column("TOTAL_CNT")]
		public int TOTAL_CNT { get; set; }
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
		public DateTime GRO_DEPARTURE_DATE { get; set; }
		/// <summary>
		/// GRO_DEPARTURE_TIME
		/// </summary>
		[Column("GRO_DEPARTURE_TIME")]
		public string GRO_DEPARTURE_TIME { get; set; }
		/// <summary>
		/// GRO_ARRIVE_DATE
		/// </summary>
		[Column("GRO_ARRIVE_DATE")]
		public DateTime GRO_ARRIVE_DATE { get; set; }
		/// <summary>
		/// GRO_ARRIVE_TIME
		/// </summary>
		[Column("GRO_ARRIVE_TIME")]
		public string GRO_ARRIVE_TIME { get; set; }
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
		public string GRO_SEAT { get; set; }
		/// <summary>
		/// GRO_AD_STATUS
		/// </summary>
		[Column("GRO_AD_STATUS")]
		public string GRO_AD_STATUS { get; set; }
		/// <summary>
		/// GRO_STATUS
		/// </summary>
		[Column("GRO_STATUS")]
		public string GRO_STATUS { get; set; }
		/// <summary>
		/// GRO_START_ACCEPT
		/// </summary>
		[Column("GRO_START_ACCEPT")]
		public string GRO_START_ACCEPT { get; set; }
		/// <summary>
		/// GRO_CHOICE
		/// </summary>
		[Column("GRO_CHOICE")]
		public int GRO_CHOICE { get; set; }
		/// <summary>
		/// SUS_REGDATE
		/// </summary>
		[Column("SUS_REGDATE")]
		public DateTime SUS_REGDATE { get; set; }
		/// <summary>
		/// IMG_URL
		/// </summary>
		[Column("IMG_URL")]
		public string IMG_URL { get; set; }
		/// <summary>
		/// CANCEL_YN
		/// </summary>
		[Column("CANCEL_YN")]
		public string CANCEL_YN { get; set; }
	}
}