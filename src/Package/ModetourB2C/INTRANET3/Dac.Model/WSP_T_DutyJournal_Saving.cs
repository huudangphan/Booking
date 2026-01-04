namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_T_업무일지_저장
/// </summary>
public class WSP_T_DutyJournal_Saving
{
	public const string SP_NAME = "WSP_T_업무일지_저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일지번호
		/// </summary>
		[Description("일지번호")]
		public int JournalNumber { get; set; }
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
		/// 종류
		/// </summary>
		[Description("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 내용1
		/// </summary>
		[Description("내용1")]
		public string Content1 { get; set; }
		/// <summary>
		/// 내용2
		/// </summary>
		[Description("내용2")]
		public string Content2 { get; set; }
		/// <summary>
		/// 내용3
		/// </summary>
		[Description("내용3")]
		public string Content3 { get; set; }
		/// <summary>
		/// 내용4
		/// </summary>
		[Description("내용4")]
		public string Content4 { get; set; }
		/// <summary>
		/// 내용5_제목
		/// </summary>
		[Description("내용5_제목")]
		public string Content5_Title { get; set; }
		/// <summary>
		/// 내용5
		/// </summary>
		[Description("내용5")]
		public string Content5 { get; set; }
		/// <summary>
		/// 내용6
		/// </summary>
		[Description("내용6")]
		public string Content6 { get; set; }
		/// <summary>
		/// 내용7
		/// </summary>
		[Description("내용7")]
		public string Content7 { get; set; }
		/// <summary>
		/// 첨부
		/// </summary>
		[Description("첨부")]
		public string Attach { get; set; }
		/// <summary>
		/// 아이피
		/// </summary>
		[Description("아이피")]
		public string IP { get; set; }
		/// <summary>
		/// 결재구분
		/// </summary>
		[Description("결재구분")]
		public string ApprovalClassification { get; set; }
		/// <summary>
		/// 선택부서번호
		/// </summary>
		[Description("선택부서번호")]
		public int SelectDepartmentNumber { get; set; }
		/// <summary>
		/// 추가내용
		/// </summary>
		[Description("추가내용")]
		public string AddContent { get; set; }
	}

}