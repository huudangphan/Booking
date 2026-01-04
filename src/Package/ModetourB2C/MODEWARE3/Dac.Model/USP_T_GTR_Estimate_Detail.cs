namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_GTR_견적_상세
/// </summary>
public class USP_T_GTR_Estimate_Detail
{
	public const string SP_NAME = "USP_T_GTR_견적_상세";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 견적번호
		/// </summary>
		[Description("견적번호")]
		public int EstimateNumber { get; set; }
		/// <summary>
		/// 신청자명
		/// </summary>
		[Description("신청자명")]
		public string RequesterName { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 견적번호
		/// </summary>
		[Column("견적번호")]
		public int EstimateNumber { get; set; }
		/// <summary>
		/// 신청기관
		/// </summary>
		[Column("신청기관")]
		public string RequestOffice { get; set; }
		/// <summary>
		/// 신청자명
		/// </summary>
		[Column("신청자명")]
		public string RequesterName { get; set; }
		/// <summary>
		/// 소속
		/// </summary>
		[Column("소속")]
		public string Affiliation { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 부서
		/// </summary>
		[Column("부서")]
		public string Department { get; set; }
		/// <summary>
		/// 휴대폰번호
		/// </summary>
		[Column("휴대폰번호")]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// 출장자정보
		/// </summary>
		[Column("출장자정보")]
		public string BusinessTripPersonInfo { get; set; }
		/// <summary>
		/// 항공출발편
		/// </summary>
		[Column("항공출발편")]
		public string FlightDepartureFlight { get; set; }
		/// <summary>
		/// 항공경유편
		/// </summary>
		[Column("항공경유편")]
		public string FlightTransitFlight { get; set; }
		/// <summary>
		/// 항공귀국편
		/// </summary>
		[Column("항공귀국편")]
		public string FlightReturnToHomelandFlight { get; set; }
		/// <summary>
		/// 세부요청사항
		/// </summary>
		[Column("세부요청사항")]
		public string DetailRequest { get; set; }
		/// <summary>
		/// 첨부파일명
		/// </summary>
		[Column("첨부파일명")]
		public string AttachFileName { get; set; }
		/// <summary>
		/// 호텔요청사항
		/// </summary>
		[Column("호텔요청사항")]
		public string HotelRequest { get; set; }
		/// <summary>
		/// 보험가입요청사항
		/// </summary>
		[Column("보험가입요청사항")]
		public string InsuranceSignUpRequest { get; set; }
		/// <summary>
		/// 비자요청사항
		/// </summary>
		[Column("비자요청사항")]
		public string VisaRequest { get; set; }
		/// <summary>
		/// 기타요청사항
		/// </summary>
		[Column("기타요청사항")]
		public string OtherRequest { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Column("비밀번호")]
		public byte[] Password { get; set; }
		/// <summary>
		/// 항공담당자
		/// </summary>
		[Column("항공담당자")]
		public string FlightManager { get; set; }
		/// <summary>
		/// 항공수정일
		/// </summary>
		[Column("항공수정일")]
		public DateTime FlightEditionDate { get; set; }
		/// <summary>
		/// 항공상태
		/// </summary>
		[Column("항공상태")]
		public string FlightState { get; set; }
		/// <summary>
		/// 호텔담당자
		/// </summary>
		[Column("호텔담당자")]
		public string HotelManager { get; set; }
		/// <summary>
		/// 호텔수정일
		/// </summary>
		[Column("호텔수정일")]
		public DateTime HotelEditionDate { get; set; }
		/// <summary>
		/// 호텔상태
		/// </summary>
		[Column("호텔상태")]
		public string HotelState { get; set; }
		/// <summary>
		/// 진행여부
		/// </summary>
		[Column("진행여부")]
		public string ProgressOrNot { get; set; }
		/// <summary>
		/// 신청일
		/// </summary>
		[Column("신청일")]
		public DateTime RequestDate { get; set; }
	}
}