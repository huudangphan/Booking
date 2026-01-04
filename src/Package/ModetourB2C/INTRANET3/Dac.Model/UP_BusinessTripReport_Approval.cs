namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// UP_출장보고_결재
/// </summary>
public class UP_BusinessTripReport_Approval
{
	public const string SP_NAME = "UP_출장보고_결재";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 결재구분
		/// </summary>
		[Description("결재구분")]
		public string ApprovalClassification { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Description("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 구분번호
		/// </summary>
		[Description("구분번호")]
		public string ClassificationNumber { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 결재권한
		/// </summary>
		[Column("결재권한")]
		public string ApprovalAuthority { get; set; }
	}

	public class Result2 : IDbResult
	{
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
		/// 수배담당자
		/// </summary>
		[Column("수배담당자")]
		public string WantedManager { get; set; }
		/// <summary>
		/// 수배담당PTID
		/// </summary>
		[Column("수배담당PTID")]
		public int WantedResponsibility_PTID { get; set; }
		/// <summary>
		/// 직위
		/// </summary>
		[Column("직위")]
		public string Position { get; set; }
	}
}