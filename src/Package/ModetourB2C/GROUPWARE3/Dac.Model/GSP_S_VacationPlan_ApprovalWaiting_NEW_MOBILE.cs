namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// GSP_S_휴가계_결재대기_NEW_MOBILE
/// </summary>
public class GSP_S_VacationPlan_ApprovalWaiting_NEW_MOBILE
{
	public const string SP_NAME = "GSP_S_휴가계_결재대기_NEW_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 부서번호
		/// </summary>
		[Description("부서번호")]
		public int DepartmentNumber { get; set; }
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

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 휴가번호
		/// </summary>
		[Column("휴가번호")]
		public int VacationNumber { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Column("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 부서번호
		/// </summary>
		[Column("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Column("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 휴가일1
		/// </summary>
		[Column("휴가일1")]
		public string VacationDate1 { get; set; }
		/// <summary>
		/// 휴가일2
		/// </summary>
		[Column("휴가일2")]
		public string VacationDate2 { get; set; }
		/// <summary>
		/// 기간
		/// </summary>
		[Column("기간")]
		public decimal Period { get; set; }
		/// <summary>
		/// 사유
		/// </summary>
		[Column("사유")]
		public string Reason { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public DateTime WrittingDate { get; set; }
		/// <summary>
		/// 결재자
		/// </summary>
		[Column("결재자")]
		public int Approver { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 종류명
		/// </summary>
		[Column("종류명")]
		public string TypeName { get; set; }
		/// <summary>
		/// 월차사용여부
		/// </summary>
		[Column("월차사용여부")]
		public string MonthlyUseOrNot { get; set; }
		/// <summary>
		/// 첨부파일
		/// </summary>
		[Column("첨부파일")]
		public string AttachFile { get; set; }
		/// <summary>
		/// 직위명
		/// </summary>
		[Column("직위명")]
		public string PositionName { get; set; }
		/// <summary>
		/// Profile_image
		/// </summary>
		[Column("Profile_image")]
		public string Profile_image { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 부서번호
		/// </summary>
		[Column("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 결재대기수
		/// </summary>
		[Column("결재대기수")]
		public int NumberOfWaitingPayments { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// CNT
		/// </summary>
		[Column("CNT")]
		public int CNT { get; set; }
	}
}