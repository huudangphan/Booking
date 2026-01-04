namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_T_업무일지_지시사항메모
/// </summary>
public class WSP_T_DutyJournal_CommandsMemo
{
	public const string SP_NAME = "WSP_T_업무일지_지시사항메모";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일지번호
		/// </summary>
		[Description("일지번호")]
		public int JournalNumber { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Description("순서")]
		public byte Order { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 지시사항
		/// </summary>
		[Description("지시사항")]
		public string Commands { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
	}

}