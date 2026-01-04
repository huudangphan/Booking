namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_TP_GREENLIGHT_RESULT_PREVIEW
/// </summary>
public class ACP_TP_GREENLIGHT_RESULT_PREVIEW
{
	public const string SP_NAME = "ACP_TP_GREENLIGHT_RESULT_PREVIEW";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// BI_IDX
		/// </summary>
		[Description("BI_IDX")]
		public int BI_IDX { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 특선상품번호
		/// </summary>
		[Column("특선상품번호")]
		public int SpecialSelectionProductNumber { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// GL_목표모객
		/// </summary>
		[Column("GL_목표모객")]
		public long GL_GoalAudience { get; set; }
		/// <summary>
		/// 최종모객
		/// </summary>
		[Column("최종모객")]
		public int FinalAudience { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[Column("결과")]
		public string RESULT { get; set; }
		/// <summary>
		/// BI_IDX
		/// </summary>
		[Column("BI_IDX")]
		public int BI_IDX { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
	}
}