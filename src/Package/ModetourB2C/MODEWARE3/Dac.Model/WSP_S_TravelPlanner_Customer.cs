namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_여행플래너_거래처
/// </summary>
public class WSP_S_TravelPlanner_Customer
{
	public const string SP_NAME = "WSP_S_여행플래너_거래처";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Description("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Column("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 회사명
		/// </summary>
		[Column("회사명")]
		public string CompanyName { get; set; }
		/// <summary>
		/// 대표자
		/// </summary>
		[Column("대표자")]
		public string Representative { get; set; }
		/// <summary>
		/// 거래처분류
		/// </summary>
		[Column("거래처분류")]
		public string CustomerClassification { get; set; }
	}
}