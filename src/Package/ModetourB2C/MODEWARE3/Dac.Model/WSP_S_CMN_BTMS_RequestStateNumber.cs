namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_BTMS_요청상태건수
/// </summary>
public class WSP_S_CMN_BTMS_RequestStateNumber
{
	public const string SP_NAME = "WSP_S_CMN_BTMS_요청상태건수";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 요청분류
		/// </summary>
		[Column("요청분류")]
		public string RequestClassification { get; set; }
		/// <summary>
		/// 요청분류명
		/// </summary>
		[Column("요청분류명")]
		public string RequestClassificationName { get; set; }
		/// <summary>
		/// 견적상태
		/// </summary>
		[Column("견적상태")]
		public string EstimateState { get; set; }
		/// <summary>
		/// 견적상태명
		/// </summary>
		[Column("견적상태명")]
		public string EstimateStateName { get; set; }
		/// <summary>
		/// 건수
		/// </summary>
		[Column("건수")]
		public int Numberofcases { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 승인상태
		/// </summary>
		[Column("승인상태")]
		public string ApprovalState { get; set; }
		/// <summary>
		/// 승인상태명
		/// </summary>
		[Column("승인상태명")]
		public string ApprovalStateName { get; set; }
		/// <summary>
		/// 건수
		/// </summary>
		[Column("건수")]
		public int Numberofcases { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 결제상태
		/// </summary>
		[Column("결제상태")]
		public string PaymentState { get; set; }
	}
}