namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_여권자동등록서비스_로그
/// </summary>
public class WSP_T_PassportAutoRegistrationService_Log
{
	public const string SP_NAME = "WSP_T_여권자동등록서비스_로그";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 인식속도
		/// </summary>
		[Description("인식속도")]
		public int RecognitionSpeed { get; set; }
		/// <summary>
		/// 오류내용
		/// </summary>
		[Description("오류내용")]
		public string ErrorContent { get; set; }
		/// <summary>
		/// 여권유무
		/// </summary>
		[Description("여권유무")]
		public string PassportOrNot { get; set; }
		/// <summary>
		/// 한글성명_인식유무
		/// </summary>
		[Description("한글성명_인식유무")]
		public string KoreanName_RecognitionOrNot { get; set; }
		/// <summary>
		/// 생년월일_인식유무
		/// </summary>
		[Description("생년월일_인식유무")]
		public string BirthYearMonthDay_RecognitionOrNot { get; set; }
		/// <summary>
		/// 성별_인식유무
		/// </summary>
		[Description("성별_인식유무")]
		public string Gender_RecognitionOrNot { get; set; }
		/// <summary>
		/// 영문성_인식유무
		/// </summary>
		[Description("영문성_인식유무")]
		public string EnglishLastName_RecognitionOrNot { get; set; }
		/// <summary>
		/// 영문이름_인식유무
		/// </summary>
		[Description("영문이름_인식유무")]
		public string EnglishName_RecognitionOrNot { get; set; }
		/// <summary>
		/// 여권번호_인식유무
		/// </summary>
		[Description("여권번호_인식유무")]
		public string PassportNumber_RecognitionOrNot { get; set; }
		/// <summary>
		/// 여권만료일_인식유무
		/// </summary>
		[Description("여권만료일_인식유무")]
		public string PassportExpirationDate_RecognitionOrNot { get; set; }
		/// <summary>
		/// 국적코드_인식유무
		/// </summary>
		[Description("국적코드_인식유무")]
		public string NationalityCode_RecognitionOrNot { get; set; }
		/// <summary>
		/// 발행국가코드_인식유무
		/// </summary>
		[Description("발행국가코드_인식유무")]
		public string PublishCountryCode_RecognitionOrNot { get; set; }
		/// <summary>
		/// 인식번호
		/// </summary>
		[Description("인식번호")]
		public int RecognitionNumber { get; set; }
	}

}