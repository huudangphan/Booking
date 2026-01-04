namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_인센티브마스터_WEMODE_견적상세_상담자정보
/// </summary>
public class WSP_S_CMN_IncentiveMaster_WEMODE_EstimateDetail_ConsultantPersonInfo
{
	public const string SP_NAME = "WSP_S_CMN_인센티브마스터_WEMODE_견적상세_상담자정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 메인번호
		/// </summary>
		[Description("메인번호")]
		public int MainNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 노출거래처명
		/// </summary>
		[Column("노출거래처명")]
		public string DisplayCustomerName { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 거래처직원
		/// </summary>
		[Column("거래처직원")]
		public string CustomerEmployee { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Column("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 거래처직원회사전화번호
		/// </summary>
		[Column("거래처직원회사전화번호")]
		public string CustomerEmployeeCompanyPhoneNumber { get; set; }
		/// <summary>
		/// 거래처직원휴대폰번호
		/// </summary>
		[Column("거래처직원휴대폰번호")]
		public string CustomerEmployeePhoneNumber { get; set; }
		/// <summary>
		/// 거래처직원이메일
		/// </summary>
		[Column("거래처직원이메일")]
		public string CustomerEmployeeEmail { get; set; }
	}
}