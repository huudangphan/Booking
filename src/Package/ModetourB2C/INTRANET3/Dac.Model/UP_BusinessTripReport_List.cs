namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// UP_출장보고_리스트
/// </summary>
public class UP_BusinessTripReport_List
{
	public const string SP_NAME = "UP_출장보고_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분번호
		/// </summary>
		[Description("구분번호")]
		public string ClassificationNumber { get; set; }
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
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 단체명
		/// </summary>
		[Column("단체명")]
		public string GroupName { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public string GroupNumber { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public DateTime WrittingDate { get; set; }
		/// <summary>
		/// 파일
		/// </summary>
		[Column("파일")]
		public string File { get; set; }
		/// <summary>
		/// 수배담당
		/// </summary>
		[Column("수배담당")]
		public string WantedResponsibility { get; set; }
		/// <summary>
		/// 담당결재일
		/// </summary>
		[Column("담당결재일")]
		public string ResponsibilityApprovalDate { get; set; }
		/// <summary>
		/// 파트장
		/// </summary>
		[Column("파트장")]
		public string PartLeader { get; set; }
		/// <summary>
		/// 파트장결재일
		/// </summary>
		[Column("파트장결재일")]
		public string PartLeaderApprovalDate { get; set; }
		/// <summary>
		/// 팀장
		/// </summary>
		[Column("팀장")]
		public string TeamLeader { get; set; }
		/// <summary>
		/// 팀장결재일
		/// </summary>
		[Column("팀장결재일")]
		public string TeamLeaderApprovalDate { get; set; }
		/// <summary>
		/// 부본부장
		/// </summary>
		[Column("부본부장")]
		public string HeadofficeDeputyDirector { get; set; }
		/// <summary>
		/// 부본부장결재일
		/// </summary>
		[Column("부본부장결재일")]
		public string HeadofficeDeputyDirectorApprovalDate { get; set; }
		/// <summary>
		/// 본부장
		/// </summary>
		[Column("본부장")]
		public string HeadofficeDirector { get; set; }
		/// <summary>
		/// 본부장결재일
		/// </summary>
		[Column("본부장결재일")]
		public string HeadofficeDirectorApprovalDate { get; set; }
		/// <summary>
		/// 답글
		/// </summary>
		[Column("답글")]
		public int Reply { get; set; }
		/// <summary>
		/// 수배담당자
		/// </summary>
		[Column("수배담당자")]
		public string WantedManager { get; set; }
		/// <summary>
		/// 직위
		/// </summary>
		[Column("직위")]
		public string Position { get; set; }
	}
}