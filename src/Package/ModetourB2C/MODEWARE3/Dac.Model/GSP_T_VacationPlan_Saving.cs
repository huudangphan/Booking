namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_T_휴가계_저장
/// </summary>
public class GSP_T_VacationPlan_Saving
{
	public const string SP_NAME = "GSP_T_휴가계_저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 휴가번호
		/// </summary>
		[Description("휴가번호")]
		public int VacationNumber { get; set; }
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
		/// 휴가일1
		/// </summary>
		[Description("휴가일1")]
		public string VacationDate1 { get; set; }
		/// <summary>
		/// 휴가일2
		/// </summary>
		[Description("휴가일2")]
		public string VacationDate2 { get; set; }
		/// <summary>
		/// 첨부파일폴더
		/// </summary>
		[Description("첨부파일폴더")]
		public string AttachFileFolder { get; set; }
		/// <summary>
		/// 첨부파일
		/// </summary>
		[Description("첨부파일")]
		public string AttachFile { get; set; }
		/// <summary>
		/// 기간
		/// </summary>
		[Description("기간")]
		public decimal Period { get; set; }
		/// <summary>
		/// 사유
		/// </summary>
		[Description("사유")]
		public string Reason { get; set; }
		/// <summary>
		/// 배정신청서번호
		/// </summary>
		[Description("배정신청서번호")]
		public string AssignmentRequestFormNumber { get; set; }
		/// <summary>
		/// 답사기안번호
		/// </summary>
		[Description("답사기안번호")]
		public string AnswerLetterDraftNumber { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 결과2
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("결과2")]
		public int Result2 { get; set; }
	}

}