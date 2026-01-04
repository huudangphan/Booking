namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_여권자동등록서비스_여행자입력정보
/// </summary>
public class WSP_S_PassportAutoRegistrationService_TravelerInputInfo
{
	public const string SP_NAME = "WSP_S_여권자동등록서비스_여행자입력정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// IP
		/// </summary>
		[Description("IP")]
		public string IP { get; set; }
		/// <summary>
		/// APP
		/// </summary>
		[Description("APP")]
		public string APP { get; set; }
		/// <summary>
		/// 진행상태코드
		/// </summary>
		[Description("진행상태코드")]
		public string ProgressStateCode { get; set; }
		/// <summary>
		/// 신청번호2
		/// </summary>
		[Description("신청번호2")]
		public int RequestNumber2 { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 한글성명
		/// </summary>
		[Column("한글성명")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문성
		/// </summary>
		[Column("영문성")]
		public string EnglishLastName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 여권번호
		/// </summary>
		[Column("여권번호")]
		public string PassportNumber { get; set; }
		/// <summary>
		/// 여권만료일
		/// </summary>
		[Column("여권만료일")]
		public string PassportExpirationDate { get; set; }
		/// <summary>
		/// 국적코드
		/// </summary>
		[Column("국적코드")]
		public string NationalityCode { get; set; }
		/// <summary>
		/// 국적명
		/// </summary>
		[Column("국적명")]
		public string NationalityName { get; set; }
		/// <summary>
		/// 발행국코드
		/// </summary>
		[Column("발행국코드")]
		public string PublishCountryCode { get; set; }
		/// <summary>
		/// 발행국명
		/// </summary>
		[Column("발행국명")]
		public string PublishCountryName { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Column("생년월일")]
		public string BirthYearMonthDay { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 기본값수정불가여부
		/// </summary>
		[Column("기본값수정불가여부")]
		public string DefaultValueEditionImpossibleOrNot { get; set; }
		/// <summary>
		/// 상태코드
		/// </summary>
		[Column("상태코드")]
		public string StateCode { get; set; }
		/// <summary>
		/// 여권사본등록유무
		/// </summary>
		[Column("여권사본등록유무")]
		public string PassportCopyRegisterOrNot { get; set; }
	}
}