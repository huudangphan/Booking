namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// ASP_RELATION_PRODUCT_LIST_SELECT
/// </summary>
public class ASP_RELATION_PRODUCT_LIST_SELECT
{
	public const string SP_NAME = "ASP_RELATION_PRODUCT_LIST_SELECT";

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
		/// GRO_IDX
		/// </summary>
		[Column("GRO_IDX")]
		public int GRO_IDX { get; set; }
		/// <summary>
		/// GRO_DEPARTURE_DATE
		/// </summary>
		[Column("GRO_DEPARTURE_DATE")]
		public DateTime GRO_DEPARTURE_DATE { get; set; }
		/// <summary>
		/// PRO_CODE
		/// </summary>
		[Column("PRO_CODE")]
		public string PRO_CODE { get; set; }
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
		/// MW_ANAME
		/// </summary>
		[Column("MW_ANAME")]
		public string MW_ANAME { get; set; }
		/// <summary>
		/// GRO_TYPE
		/// </summary>
		[Column("GRO_TYPE")]
		public string GRO_TYPE { get; set; }
		/// <summary>
		/// MW_START
		/// </summary>
		[Column("MW_START")]
		public string MW_START { get; set; }
		/// <summary>
		/// IMGURL
		/// </summary>
		[Column("IMGURL")]
		public string IMGURL { get; set; }
	}
}