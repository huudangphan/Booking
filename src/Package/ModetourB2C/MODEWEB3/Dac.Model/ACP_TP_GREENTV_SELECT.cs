namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_TP_GREENTV_SELECT
/// </summary>
public class ACP_TP_GREENTV_SELECT
{
	public const string SP_NAME = "ACP_TP_GREENTV_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// GT_IDX
		/// </summary>
		[Description("GT_IDX")]
		public int GT_IDX { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// GT_IDX
		/// </summary>
		[Column("GT_IDX")]
		public int GT_IDX { get; set; }
		/// <summary>
		/// TITLE
		/// </summary>
		[Column("TITLE")]
		public string TITLE { get; set; }
		/// <summary>
		/// URL
		/// </summary>
		[Column("URL")]
		public string URL { get; set; }
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
		/// CONTENTS
		/// </summary>
		[Column("CONTENTS")]
		public string CONTENTS { get; set; }
		/// <summary>
		/// PRODUCT_NO
		/// </summary>
		[Column("PRODUCT_NO")]
		public int PRODUCT_NO { get; set; }
		/// <summary>
		/// SP_TITLE
		/// </summary>
		[Column("SP_TITLE")]
		public string SP_TITLE { get; set; }
		/// <summary>
		/// SP_URL
		/// </summary>
		[Column("SP_URL")]
		public string SP_URL { get; set; }
		/// <summary>
		/// DATE_CHK
		/// </summary>
		[Column("DATE_CHK")]
		public bool DATE_CHK { get; set; }
		/// <summary>
		/// MIN_PRICE
		/// </summary>
		[Column("MIN_PRICE")]
		public int MIN_PRICE { get; set; }
		/// <summary>
		/// DIRECT_CHK
		/// </summary>
		[Column("DIRECT_CHK")]
		public bool DIRECT_CHK { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// GT_IDX
		/// </summary>
		[Column("GT_IDX")]
		public int GT_IDX { get; set; }
		/// <summary>
		/// TAB_TITLE
		/// </summary>
		[Column("TAB_TITLE")]
		public string TAB_TITLE { get; set; }
		/// <summary>
		/// TAB_PRODUCT_NO
		/// </summary>
		[Column("TAB_PRODUCT_NO")]
		public int TAB_PRODUCT_NO { get; set; }
		/// <summary>
		/// TAB_CONTENTS
		/// </summary>
		[Column("TAB_CONTENTS")]
		public string TAB_CONTENTS { get; set; }
		/// <summary>
		/// ITEMCODE
		/// </summary>
		[Column("ITEMCODE")]
		public string ITEMCODE { get; set; }
		/// <summary>
		/// SP_TITLE
		/// </summary>
		[Column("SP_TITLE")]
		public string SP_TITLE { get; set; }
		/// <summary>
		/// ITM_SORT
		/// </summary>
		[Column("ITM_SORT")]
		public int ITM_SORT { get; set; }
		/// <summary>
		/// MIN_PRICE
		/// </summary>
		[Column("MIN_PRICE")]
		public long MIN_PRICE { get; set; }
		/// <summary>
		/// TAB_AIR_CODE
		/// </summary>
		[Column("TAB_AIR_CODE")]
		public string TAB_AIR_CODE { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// GT_IDX
		/// </summary>
		[Column("GT_IDX")]
		public int GT_IDX { get; set; }
		/// <summary>
		/// TITLE
		/// </summary>
		[Column("TITLE")]
		public string TITLE { get; set; }
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
		/// DATE_CHK
		/// </summary>
		[Column("DATE_CHK")]
		public bool DATE_CHK { get; set; }
	}
}