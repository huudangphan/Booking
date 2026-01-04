namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_BATCH_THEME_AREA_MENU
/// </summary>
public class ACP_BATCH_THEME_AREA_MENU
{
	public const string SP_NAME = "ACP_BATCH_THEME_AREA_MENU";

	public class Result1 : IDbResult
	{
		/// <summary>
		/// RCODE
		/// </summary>
		[Column("RCODE")]
		public string RCODE { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// RLE_IDX
		/// </summary>
		[Column("RLE_IDX")]
		public int RLE_IDX { get; set; }
		/// <summary>
		/// RLE_IDX_UP
		/// </summary>
		[Column("RLE_IDX_UP")]
		public int RLE_IDX_UP { get; set; }
		/// <summary>
		/// MW_MENU_NAME
		/// </summary>
		[Column("MW_MENU_NAME")]
		public string MW_MENU_NAME { get; set; }
		/// <summary>
		/// RLE_MENU_CODE
		/// </summary>
		[Column("RLE_MENU_CODE")]
		public string RLE_MENU_CODE { get; set; }
		/// <summary>
		/// RLE_MENU_CODE_UP
		/// </summary>
		[Column("RLE_MENU_CODE_UP")]
		public string RLE_MENU_CODE_UP { get; set; }
		/// <summary>
		/// MW_START
		/// </summary>
		[Column("MW_START")]
		public string MW_START { get; set; }
		/// <summary>
		/// MW_TCODE
		/// </summary>
		[Column("MW_TCODE")]
		public int MW_TCODE { get; set; }
		/// <summary>
		/// MW_ACODE
		/// </summary>
		[Column("MW_ACODE")]
		public int MW_ACODE { get; set; }
		/// <summary>
		/// MW_DEPTH
		/// </summary>
		[Column("MW_DEPTH")]
		public string MW_DEPTH { get; set; }
	}
}