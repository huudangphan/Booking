namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_BTMS_거래처직원리스트
/// </summary>
public class WSP_S_CMN_BTMS_CustomerEmployeeList
{
	public const string SP_NAME = "WSP_S_CMN_BTMS_거래처직원리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 승인
		/// </summary>
		[Description("승인")]
		public string Approval { get; set; }
		/// <summary>
		/// 검색필드
		/// </summary>
		[Description("검색필드")]
		public string SearchingField { get; set; }
		/// <summary>
		/// 검색어
		/// </summary>
		[Description("검색어")]
		public string SearchingKeyword { get; set; }
		/// <summary>
		/// 현재페이지
		/// </summary>
		[Description("현재페이지")]
		public int CurrentPage { get; set; }
		/// <summary>
		/// 페이지당글개수
		/// </summary>
		[Description("페이지당글개수")]
		public int EachPageCharactersNumber { get; set; }
		/// <summary>
		/// 전체게시글수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체게시글수")]
		public int EntirePostCharactersNumber { get; set; }
		/// <summary>
		/// 전체페이지수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체페이지수")]
		public int EntirePageNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// UserID
		/// </summary>
		[Column("UserID")]
		public string UserID { get; set; }
		/// <summary>
		/// 핸드폰
		/// </summary>
		[Column("핸드폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Column("생년월일")]
		public string BirthYearMonthDay { get; set; }
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
		/// 관리자여부
		/// </summary>
		[Column("관리자여부")]
		public string AdminOrNot { get; set; }
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 승인일자
		/// </summary>
		[Column("승인일자")]
		public DateTime ApprovalDate { get; set; }
		/// <summary>
		/// 신청일
		/// </summary>
		[Column("신청일")]
		public DateTime RequestDate { get; set; }
		/// <summary>
		/// ENC_여권번호
		/// </summary>
		[Column("ENC_여권번호")]
		public byte[] ENC_PassportNumber { get; set; }
		/// <summary>
		/// 여권발급일
		/// </summary>
		[Column("여권발급일")]
		public DateTime PassportIssuanceDate { get; set; }
		/// <summary>
		/// 여권만료일
		/// </summary>
		[Column("여권만료일")]
		public DateTime PassportExpirationDate { get; set; }
		/// <summary>
		/// 여권파일번호
		/// </summary>
		[Column("여권파일번호")]
		public int PassportFileNumber { get; set; }
		/// <summary>
		/// 비자여부
		/// </summary>
		[Column("비자여부")]
		public string VisaOrNot { get; set; }
		/// <summary>
		/// 대표비자정보
		/// </summary>
		[Column("대표비자정보")]
		public string RepresentativeVisaInfo { get; set; }
		/// <summary>
		/// 부서
		/// </summary>
		[Column("부서")]
		public string Department { get; set; }
		/// <summary>
		/// 직급
		/// </summary>
		[Column("직급")]
		public string JobPosition { get; set; }
	}
}