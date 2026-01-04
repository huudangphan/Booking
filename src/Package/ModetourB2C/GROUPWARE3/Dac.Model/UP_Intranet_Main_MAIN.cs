namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// UP_인트라넷_메인_MAIN
/// </summary>
public class UP_Intranet_Main_MAIN
{
	public const string SP_NAME = "UP_인트라넷_메인_MAIN";

	public class Parameters : BaseDbParameters
	{
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
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 양식번호
		/// </summary>
		[Column("양식번호")]
		public short FormNumber { get; set; }
		/// <summary>
		/// 중요도
		/// </summary>
		[Column("중요도")]
		public string ImportanceLevel { get; set; }
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public int Column1 { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 양식번호
		/// </summary>
		[Column("양식번호")]
		public short FormNumber { get; set; }
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public int Column1 { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 문서코드
		/// </summary>
		[Column("문서코드")]
		public int DocumentCode { get; set; }
		/// <summary>
		/// 문서유형
		/// </summary>
		[Column("문서유형")]
		public string DocumentType { get; set; }
		/// <summary>
		/// 문서구분
		/// </summary>
		[Column("문서구분")]
		public string DocumentClassification { get; set; }
		/// <summary>
		/// 양식번호
		/// </summary>
		[Column("양식번호")]
		public short FormNumber { get; set; }
		/// <summary>
		/// 기안일
		/// </summary>
		[Column("기안일")]
		public DateTime DraftDate { get; set; }
		/// <summary>
		/// 기안자정보
		/// </summary>
		[Column("기안자정보")]
		public string DrafterInfo { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 결재진행
		/// </summary>
		[Column("결재진행")]
		public string ApprovalProgress { get; set; }
		/// <summary>
		/// 항목
		/// </summary>
		[Column("항목")]
		public string Item { get; set; }
		/// <summary>
		/// 지출금액
		/// </summary>
		[Column("지출금액")]
		public long SpendingAmount { get; set; }
		/// <summary>
		/// 지출계정
		/// </summary>
		[Column("지출계정")]
		public string SpendingAccount { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 휴가번호
		/// </summary>
		[Column("휴가번호")]
		public int VacationNumber { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public DateTime WrittingDate { get; set; }
		/// <summary>
		/// 휴가일1
		/// </summary>
		[Column("휴가일1")]
		public DateTime VacationDate1 { get; set; }
		/// <summary>
		/// 휴가일2
		/// </summary>
		[Column("휴가일2")]
		public DateTime VacationDate2 { get; set; }
		/// <summary>
		/// 기간
		/// </summary>
		[Column("기간")]
		public decimal Period { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Column("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 부서
		/// </summary>
		[Column("부서")]
		public string Department { get; set; }
		/// <summary>
		/// 현황
		/// </summary>
		[Column("현황")]
		public string CurrentState { get; set; }
		/// <summary>
		/// 항목
		/// </summary>
		[Column("항목")]
		public string Item { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public int Column1 { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
		/// <summary>
		/// 결재함명
		/// </summary>
		[Column("결재함명")]
		public string ApprovalName { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// 부서코드
		/// </summary>
		[Column("부서코드")]
		public int DepartmentCode { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 본부명
		/// </summary>
		[Column("본부명")]
		public string HeadofficeName { get; set; }
	}

	public class Result8 : IDbResult
	{
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public int DepartmentName { get; set; }
		/// <summary>
		/// 메뉴명
		/// </summary>
		[Column("메뉴명")]
		public string MenuName { get; set; }
	}
}