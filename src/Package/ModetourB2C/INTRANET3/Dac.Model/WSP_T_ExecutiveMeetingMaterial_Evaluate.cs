namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_T_임원회의자료_평가
/// </summary>
public class WSP_T_ExecutiveMeetingMaterial_Evaluate
{
	public const string SP_NAME = "WSP_T_임원회의자료_평가";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 게시판번호
		/// </summary>
		[Description("게시판번호")]
		public int NoticeboardNumber { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 평가
		/// </summary>
		[Description("평가")]
		public byte Evaluation { get; set; }
	}

}