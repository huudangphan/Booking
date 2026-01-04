namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_모두마일리지카드신청
/// </summary>
public class USP_T_MODEMileageCardRequest
{
	public const string SP_NAME = "USP_T_모두마일리지카드신청";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Description("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Description("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Description("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 핸드폰
		/// </summary>
		[Description("핸드폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 권유자코드
		/// </summary>
		[Description("권유자코드")]
		public string RecommenderCode { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 부서번호
		/// </summary>
		[Description("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 카드구분
		/// </summary>
		[Description("카드구분")]
		public string CardClassification { get; set; }
		/// <summary>
		/// 교통카드여부
		/// </summary>
		[Description("교통카드여부")]
		public string TransportationCardOrNot { get; set; }
		/// <summary>
		/// 분류1
		/// </summary>
		[Description("분류1")]
		public string Classification1 { get; set; }
		/// <summary>
		/// 분류2
		/// </summary>
		[Description("분류2")]
		public string Classification2 { get; set; }
		/// <summary>
		/// TM직원
		/// </summary>
		[Description("TM직원")]
		public int TM_Employee { get; set; }
		/// <summary>
		/// 발급일
		/// </summary>
		[Description("발급일")]
		public DateTime IssuanceDate { get; set; }
		/// <summary>
		/// 비고사항
		/// </summary>
		[Description("비고사항")]
		public string NoteItem { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 유치경로
		/// </summary>
		[Description("유치경로")]
		public string AttractionRoute { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Description("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
	}

}