namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_TP_SPECIAL_PRODUCT
/// </summary>
public class ACP_TP_SPECIAL_PRODUCT
{
	public const string SP_NAME = "ACP_TP_SPECIAL_PRODUCT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// SPR_IDX
		/// </summary>
		[Description("SPR_IDX")]
		public int SPR_IDX { get; set; }
		/// <summary>
		/// MENU
		/// </summary>
		[Description("MENU")]
		public string MENU { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 특선상품번호
		/// </summary>
		[Column("특선상품번호")]
		public int SpecialSelectionProductNumber { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 특가명
		/// </summary>
		[Column("특가명")]
		public string SpecialPriceName { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// GL_목표모객
		/// </summary>
		[Column("GL_목표모객")]
		public long GL_GoalAudience { get; set; }
		/// <summary>
		/// GL_VI
		/// </summary>
		[Column("GL_VI")]
		public double GL_VI { get; set; }
		/// <summary>
		/// GL_여행설명1
		/// </summary>
		[Column("GL_여행설명1")]
		public string GL_TravelExplaination1 { get; set; }
		/// <summary>
		/// GL_여행설명2
		/// </summary>
		[Column("GL_여행설명2")]
		public string GL_TravelExplaination2 { get; set; }
		/// <summary>
		/// GL_여행설명3
		/// </summary>
		[Column("GL_여행설명3")]
		public string GL_TravelExplaination3 { get; set; }
		/// <summary>
		/// TOTAL
		/// </summary>
		[Column("TOTAL")]
		public long TOTAL { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// SPR_IDX
		/// </summary>
		[Column("SPR_IDX")]
		public int SPR_IDX { get; set; }
		/// <summary>
		/// PRO_CODE
		/// </summary>
		[Column("PRO_CODE")]
		public string PRO_CODE { get; set; }
		/// <summary>
		/// SPRS_MIN_PRICE
		/// </summary>
		[Column("SPRS_MIN_PRICE")]
		public long SPRS_MIN_PRICE { get; set; }
		/// <summary>
		/// SPR_TITLE
		/// </summary>
		[Column("SPR_TITLE")]
		public string SPR_TITLE { get; set; }
		/// <summary>
		/// SPR_IMG
		/// </summary>
		[Column("SPR_IMG")]
		public string SPR_IMG { get; set; }
	}
}