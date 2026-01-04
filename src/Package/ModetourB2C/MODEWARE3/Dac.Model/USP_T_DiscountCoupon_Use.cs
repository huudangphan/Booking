namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_할인쿠폰_사용
/// </summary>
public class USP_T_DiscountCoupon_Use
{
	public const string SP_NAME = "USP_T_할인쿠폰_사용";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// TBL
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("TBL")]
		public List<TYPE_DiscountCoupon> TBL { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Description("등록자")]
		public int Registerer { get; set; }
		/// <summary>
		/// 권한체크여부
		/// </summary>
		[Description("권한체크여부")]
		public string AuthorityCheckOrNot { get; set; }
		/// <summary>
		/// NO_ERROR
		/// </summary>
		[Description("NO_ERROR")]
		public string NO_ERROR { get; set; }
	}

}