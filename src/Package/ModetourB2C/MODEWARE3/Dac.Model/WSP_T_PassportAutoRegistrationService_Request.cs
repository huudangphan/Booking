namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_여권자동등록서비스_신청
/// </summary>
public class WSP_T_PassportAutoRegistrationService_Request
{
	public const string SP_NAME = "WSP_T_여권자동등록서비스_신청";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 한글성명
		/// </summary>
		[Description("한글성명")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Description("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 영문성
		/// </summary>
		[Description("영문성")]
		public string EnglishLastName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Description("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 여권번호
		/// </summary>
		[Description("여권번호")]
		public string PassportNumber { get; set; }
		/// <summary>
		/// 여권만료일
		/// </summary>
		[Description("여권만료일")]
		public DateTime PassportExpirationDate { get; set; }
		/// <summary>
		/// 국적코드
		/// </summary>
		[Description("국적코드")]
		public string NationalityCode { get; set; }
		/// <summary>
		/// 발행국가코드
		/// </summary>
		[Description("발행국가코드")]
		public string PublishCountryCode { get; set; }
		/// <summary>
		/// 신청자명
		/// </summary>
		[Description("신청자명")]
		public string RequesterName { get; set; }
		/// <summary>
		/// 신청자_PTID
		/// </summary>
		[Description("신청자_PTID")]
		public int Requester_PTID { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Description("생년월일")]
		public DateTime BirthYearMonthDay { get; set; }
		/// <summary>
		/// 여권파일명
		/// </summary>
		[Description("여권파일명")]
		public string PassportFileName { get; set; }
		/// <summary>
		/// 여권사본등록유무
		/// </summary>
		[Description("여권사본등록유무")]
		public string PassportCopyRegisterOrNot { get; set; }
		/// <summary>
		/// 여권인식유무
		/// </summary>
		[Description("여권인식유무")]
		public string PassportRecognitionOrNot { get; set; }
		/// <summary>
		/// 대표여부
		/// </summary>
		[Description("대표여부")]
		public string RepresentativeOrNot { get; set; }
		/// <summary>
		/// 여권구분
		/// </summary>
		[Description("여권구분")]
		public string PassportClassification { get; set; }
		/// <summary>
		/// 인식분류
		/// </summary>
		[Description("인식분류")]
		public string RecognitionClassification { get; set; }
	}

}