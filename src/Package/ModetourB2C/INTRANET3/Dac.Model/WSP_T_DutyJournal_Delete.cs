namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_T_업무일지_삭제
/// </summary>
public class WSP_T_DutyJournal_Delete
{
	public const string SP_NAME = "WSP_T_업무일지_삭제";

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
		/// 첨부
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 200)]
		[Description("첨부")]
		public string Attach { get; set; }
	}

}