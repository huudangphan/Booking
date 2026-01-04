namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_GTR_견적
/// </summary>
public class USP_T_GTR_Estimate
{
	public const string SP_NAME = "USP_T_GTR_견적";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 견적번호
		/// </summary>
		[Description("견적번호")]
		public int EstimateNumber { get; set; }
		/// <summary>
		/// 신청기관
		/// </summary>
		[Description("신청기관")]
		public string RequestOffice { get; set; }
		/// <summary>
		/// 신청자명
		/// </summary>
		[Description("신청자명")]
		public string RequesterName { get; set; }
		/// <summary>
		/// 소속
		/// </summary>
		[Description("소속")]
		public string Affiliation { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 부서
		/// </summary>
		[Description("부서")]
		public string Department { get; set; }
		/// <summary>
		/// 휴대폰번호
		/// </summary>
		[Description("휴대폰번호")]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// 출장자정보
		/// </summary>
		[Description("출장자정보")]
		public string BusinessTripPersonInfo { get; set; }
		/// <summary>
		/// 항공출발편
		/// </summary>
		[Description("항공출발편")]
		public string FlightDepartureFlight { get; set; }
		/// <summary>
		/// 항공경유편
		/// </summary>
		[Description("항공경유편")]
		public string FlightTransitFlight { get; set; }
		/// <summary>
		/// 항공귀국편
		/// </summary>
		[Description("항공귀국편")]
		public string FlightReturnToHomelandFlight { get; set; }
		/// <summary>
		/// 세부요청사항
		/// </summary>
		[Description("세부요청사항")]
		public string DetailRequest { get; set; }
		/// <summary>
		/// 첨부파일명
		/// </summary>
		[Description("첨부파일명")]
		public string AttachFileName { get; set; }
		/// <summary>
		/// 호텔요청사항
		/// </summary>
		[Description("호텔요청사항")]
		public string HotelRequest { get; set; }
		/// <summary>
		/// 보험가입요청사항
		/// </summary>
		[Description("보험가입요청사항")]
		public string InsuranceSignUpRequest { get; set; }
		/// <summary>
		/// 비자요청사항
		/// </summary>
		[Description("비자요청사항")]
		public string VisaRequest { get; set; }
		/// <summary>
		/// 기타요청사항
		/// </summary>
		[Description("기타요청사항")]
		public string OtherRequest { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
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