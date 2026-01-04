namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_해외항공_보험_에이스
/// </summary>
public class WSP_S_OverseaFlight_Insurance_Ace
{
	public const string SP_NAME = "WSP_S_해외항공_보험_에이스";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 보험사
		/// </summary>
		[Description("보험사")]
		public string InsuranceCompany { get; set; }
		/// <summary>
		/// 여행기간
		/// </summary>
		[Description("여행기간")]
		public int TravelPeriod { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 보험나이
		/// </summary>
		[Column("보험나이")]
		public int InsuranceAge { get; set; }
		/// <summary>
		/// 만나이
		/// </summary>
		[Column("만나이")]
		public int InternationalAge { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 플랜
		/// </summary>
		[Column("플랜")]
		public string Plan { get; set; }
		/// <summary>
		/// 여행기간
		/// </summary>
		[Column("여행기간")]
		public string TravelPeriod { get; set; }
		/// <summary>
		/// 금액
		/// </summary>
		[Column("금액")]
		public int Amount { get; set; }
	}
}