namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_T_할인쿠폰_수동발급_패키지용
/// </summary>
public class WSV_T_DiscountCoupon_ManualIssuance_PackageUsage
{
	public const string SP_NAME = "WSV_T_할인쿠폰_수동발급_패키지용";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 쿠폰번호
		/// </summary>
		[Description("쿠폰번호")]
		public string CouponNumber { get; set; }
		/// <summary>
		/// 소유자
		/// </summary>
		[Description("소유자")]
		public int Owner { get; set; }
		/// <summary>
		/// 발급번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("발급번호")]
		public int IssuanceNumber { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 에러메시지
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 1000)]
		[Description("에러메시지")]
		public string ErrorMessage { get; set; }
	}

}