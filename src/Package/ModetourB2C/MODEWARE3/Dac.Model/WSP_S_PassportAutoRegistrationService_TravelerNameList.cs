namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_여권자동등록서비스_여행자명단
/// </summary>
public class WSP_S_PassportAutoRegistrationService_TravelerNameList
{
	public const string SP_NAME = "WSP_S_여권자동등록서비스_여행자명단";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
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
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 대표
		/// </summary>
		[Column("대표")]
		public string Representative { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 성별1
		/// </summary>
		[Column("성별1")]
		public string Gender1 { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 성별2
		/// </summary>
		[Column("성별2")]
		public string Gender2 { get; set; }
		/// <summary>
		/// 등록유무
		/// </summary>
		[Column("등록유무")]
		public string RegisterOrNot { get; set; }
		/// <summary>
		/// 성별3
		/// </summary>
		[Column("성별3")]
		public string Gender3 { get; set; }
		/// <summary>
		/// 상태정보
		/// </summary>
		[Column("상태정보")]
		public string StateInfo { get; set; }
		/// <summary>
		/// 상태정보코드
		/// </summary>
		[Column("상태정보코드")]
		public string StateInfoCode { get; set; }
		/// <summary>
		/// 상태정보날짜
		/// </summary>
		[Column("상태정보날짜")]
		public string StateInfoDate { get; set; }
		/// <summary>
		/// 한글이름1
		/// </summary>
		[Column("한글이름1")]
		public string KoreanName1 { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 영문성
		/// </summary>
		[Column("영문성")]
		public string EnglishLastName { get; set; }
		/// <summary>
		/// DEC_여권번호
		/// </summary>
		[Column("DEC_여권번호")]
		public string DEC_PassportNumber { get; set; }
		/// <summary>
		/// 여권만료일
		/// </summary>
		[Column("여권만료일")]
		public DateTime PassportExpirationDate { get; set; }
		/// <summary>
		/// CHK_주민번호
		/// </summary>
		[Column("CHK_주민번호")]
		public string CHK_CitizenIDNumber { get; set; }
		/// <summary>
		/// 국적코드
		/// </summary>
		[Column("국적코드")]
		public string NationalityCode { get; set; }
		/// <summary>
		/// 발행국코드
		/// </summary>
		[Column("발행국코드")]
		public string PublishCountryCode { get; set; }
		/// <summary>
		/// 본인여부
		/// </summary>
		[Column("본인여부")]
		public string SelfOrNot { get; set; }
		/// <summary>
		/// DEC_HP
		/// </summary>
		[Column("DEC_HP")]
		public string DEC_HP { get; set; }
		/// <summary>
		/// 진행상태코드
		/// </summary>
		[Column("진행상태코드")]
		public string ProgressStateCode { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public DateTime ArrivalDate { get; set; }
		/// <summary>
		/// 주문일
		/// </summary>
		[Column("주문일")]
		public DateTime OrderDate { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 신청중인건수
		/// </summary>
		[Column("신청중인건수")]
		public int RequestingStateNumber { get; set; }
	}
}