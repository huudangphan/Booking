namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// ASP_ITINERARY_EVENT_LIST_SELECT
/// </summary>
public class ASP_ITINERARY_EVENT_LIST_SELECT
{
	public const string SP_NAME = "ASP_ITINERARY_EVENT_LIST_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// GRO_IDX
		/// </summary>
		[Description("GRO_IDX")]
		public int GRO_IDX { get; set; }
		/// <summary>
		/// TRADE_PTID
		/// </summary>
		[Description("TRADE_PTID")]
		public int TRADE_PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// EVT_IDX
		/// </summary>
		[Column("EVT_IDX")]
		public int EVT_IDX { get; set; }
		/// <summary>
		/// EVT_NAME
		/// </summary>
		[Column("EVT_NAME")]
		public string EVT_NAME { get; set; }
		/// <summary>
		/// EVT_TYPE_CODE
		/// </summary>
		[Column("EVT_TYPE_CODE")]
		public string EVT_TYPE_CODE { get; set; }
		/// <summary>
		/// BANNER_TAG
		/// </summary>
		[Column("BANNER_TAG")]
		public string BANNER_TAG { get; set; }
		/// <summary>
		/// START_DATE
		/// </summary>
		[Column("START_DATE")]
		public DateTime START_DATE { get; set; }
		/// <summary>
		/// END_DATE
		/// </summary>
		[Column("END_DATE")]
		public DateTime END_DATE { get; set; }
		/// <summary>
		/// DISPLAY_YN
		/// </summary>
		[Column("DISPLAY_YN")]
		public string DISPLAY_YN { get; set; }
		/// <summary>
		/// DISPLAY_PLACE
		/// </summary>
		[Column("DISPLAY_PLACE")]
		public string DISPLAY_PLACE { get; set; }
		/// <summary>
		/// MOBILE_DISPLAY_YN
		/// </summary>
		[Column("MOBILE_DISPLAY_YN")]
		public string MOBILE_DISPLAY_YN { get; set; }
		/// <summary>
		/// MOBILE_TAG
		/// </summary>
		[Column("MOBILE_TAG")]
		public string MOBILE_TAG { get; set; }
		/// <summary>
		/// DISPLAY_LOCATION
		/// </summary>
		[Column("DISPLAY_LOCATION")]
		public string DISPLAY_LOCATION { get; set; }
	}
}