namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_투어마일리지_기사용액
/// </summary>
public class USP_S_TourMileage_ArticleUsageAmount
{
	public const string SP_NAME = "USP_S_투어마일리지_기사용액";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 회원번호
		/// </summary>
		[Column("회원번호")]
		public string MemberNumber { get; set; }
		/// <summary>
		/// 기사용액
		/// </summary>
		[Column("기사용액")]
		public long ArticleUsageAmount { get; set; }
	}
}