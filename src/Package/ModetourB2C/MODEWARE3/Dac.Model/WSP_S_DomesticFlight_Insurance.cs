namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_국내항공_보험
/// </summary>
public class WSP_S_DomesticFlight_Insurance
{
	public const string SP_NAME = "WSP_S_국내항공_보험";

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
		/// 주민번호
		/// </summary>
		[Description("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Description("성별")]
		public string Gender { get; set; }
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
		/// 플랜코드
		/// </summary>
		[Column("플랜코드")]
		public string PlanCode { get; set; }
		/// <summary>
		/// 플랜명
		/// </summary>
		[Column("플랜명")]
		public string PlanName { get; set; }
		/// <summary>
		/// 보험기간
		/// </summary>
		[Column("보험기간")]
		public int InsurancePeriod { get; set; }
		/// <summary>
		/// 보험료
		/// </summary>
		[Column("보험료")]
		public double InsuranceFee { get; set; }
		/// <summary>
		/// 회차
		/// </summary>
		[Column("회차")]
		public int Episode { get; set; }
	}
}