namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_BTMS_거래처직원
/// </summary>
public class WSP_S_CMN_BTMS_CustomerEmployee
{
	public const string SP_NAME = "WSP_S_CMN_BTMS_거래처직원";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Cnt
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("Cnt")]
		public int Cnt { get; set; }
		/// <summary>
		/// Type
		/// </summary>
		[Description("Type")]
		public string Type { get; set; }
		/// <summary>
		/// Name
		/// </summary>
		[Description("Name")]
		public string Name { get; set; }
		/// <summary>
		/// Phone
		/// </summary>
		[Description("Phone")]
		public string Phone { get; set; }
		/// <summary>
		/// USERID
		/// </summary>
		[Description("USERID")]
		public string USERID { get; set; }
		/// <summary>
		/// USERPWD
		/// </summary>
		[Description("USERPWD")]
		public string USERPWD { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 부서
		/// </summary>
		[Column("부서")]
		public string Department { get; set; }
		/// <summary>
		/// 핸드폰
		/// </summary>
		[Column("핸드폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 전화
		/// </summary>
		[Column("전화")]
		public string Phone { get; set; }
		/// <summary>
		/// 팩스
		/// </summary>
		[Column("팩스")]
		public string Fax { get; set; }
		/// <summary>
		/// 회사주소
		/// </summary>
		[Column("회사주소")]
		public string CompanyAddress { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Column("비고")]
		public string Note { get; set; }
		/// <summary>
		/// 직원성향
		/// </summary>
		[Column("직원성향")]
		public string EmployeeTendency { get; set; }
		/// <summary>
		/// 최근미팅일자
		/// </summary>
		[Column("최근미팅일자")]
		public DateTime RecentMeetingDate { get; set; }
		/// <summary>
		/// 최근미팅내용
		/// </summary>
		[Column("최근미팅내용")]
		public string RecentMeetingContent { get; set; }
		/// <summary>
		/// 거래처동향
		/// </summary>
		[Column("거래처동향")]
		public string CustomerTrends { get; set; }
		/// <summary>
		/// 직급
		/// </summary>
		[Column("직급")]
		public string JobPosition { get; set; }
		/// <summary>
		/// 관리자여부
		/// </summary>
		[Column("관리자여부")]
		public string AdminOrNot { get; set; }
		/// <summary>
		/// 승인상태
		/// </summary>
		[Column("승인상태")]
		public string ApprovalState { get; set; }
		/// <summary>
		/// 승인자
		/// </summary>
		[Column("승인자")]
		public int Approver { get; set; }
		/// <summary>
		/// 승인일자
		/// </summary>
		[Column("승인일자")]
		public DateTime ApprovalDate { get; set; }
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
		/// 비자유무
		/// </summary>
		[Column("비자유무")]
		public string VisaOrNot { get; set; }
		/// <summary>
		/// 개인정보동의여부
		/// </summary>
		[Column("개인정보동의여부")]
		public string PersonalInfoAgreeOrNot { get; set; }
		/// <summary>
		/// IDXKEY_여권번호
		/// </summary>
		[Column("IDXKEY_여권번호")]
		public string IDXKEY_PassportNumber { get; set; }
		/// <summary>
		/// ENC_여권번호
		/// </summary>
		[Column("ENC_여권번호")]
		public byte[] ENC_PassportNumber { get; set; }
		/// <summary>
		/// USERID
		/// </summary>
		[Column("USERID")]
		public string USERID { get; set; }
		/// <summary>
		/// USERPWD
		/// </summary>
		[Column("USERPWD")]
		public string USERPWD { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Column("생년월일")]
		public string BirthYearMonthDay { get; set; }
		/// <summary>
		/// 여권파일번호
		/// </summary>
		[Column("여권파일번호")]
		public int PassportFileNumber { get; set; }
		/// <summary>
		/// 신청일
		/// </summary>
		[Column("신청일")]
		public DateTime RequestDate { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
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
	}

	public class Result3 : IDbResult
	{
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
	}

	public class Result4 : IDbResult
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
		/// 핸드폰
		/// </summary>
		[Column("핸드폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// USERID
		/// </summary>
		[Column("USERID")]
		public string USERID { get; set; }
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
		public string PassportIssuanceDate { get; set; }
		/// <summary>
		/// 여권만료일
		/// </summary>
		[Column("여권만료일")]
		public string PassportExpirationDate { get; set; }
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
		/// 부서
		/// </summary>
		[Column("부서")]
		public string Department { get; set; }
		/// <summary>
		/// 직급
		/// </summary>
		[Column("직급")]
		public string JobPosition { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 일반비자번호
		/// </summary>
		[Column("일반비자번호")]
		public int NormalVisaNumber { get; set; }
		/// <summary>
		/// 발급국가
		/// </summary>
		[Column("발급국가")]
		public string IssuanceCountry { get; set; }
		/// <summary>
		/// 유효기간
		/// </summary>
		[Column("유효기간")]
		public DateTime ValidPeriod { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Column("등록자")]
		public int Registerer { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 비자번호
		/// </summary>
		[Column("비자번호")]
		public string VisaNumber { get; set; }
		/// <summary>
		/// 파일번호
		/// </summary>
		[Column("파일번호")]
		public int FileNumber { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
	}
}