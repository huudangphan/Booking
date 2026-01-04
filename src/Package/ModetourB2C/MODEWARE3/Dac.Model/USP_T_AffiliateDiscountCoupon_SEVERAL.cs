namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_제휴할인쿠폰_SEVERAL
/// </summary>
public class USP_T_AffiliateDiscountCoupon_SEVERAL
{
	public const string SP_NAME = "USP_T_제휴할인쿠폰_SEVERAL";

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
		public List<TYPE_AffiliateDiscountCoupon> TBL { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Description("등록자")]
		public int Registerer { get; set; }
		/// <summary>
		/// NO_RAISERROR
		/// </summary>
		[Description("NO_RAISERROR")]
		public string NO_RAISERROR { get; set; }
		/// <summary>
		/// TEST여부
		/// </summary>
		[Description("TEST여부")]
		public string TEST_OrNot { get; set; }
	}

}