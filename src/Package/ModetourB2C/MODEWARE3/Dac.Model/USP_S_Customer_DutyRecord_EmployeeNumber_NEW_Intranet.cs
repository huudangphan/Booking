namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_거래처_업무기록_직원번호_NEW_인트라넷
/// </summary>
public class USP_S_Customer_DutyRecord_EmployeeNumber_NEW_Intranet
{
	public const string SP_NAME = "USP_S_거래처_업무기록_직원번호_NEW_인트라넷";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 년
		/// </summary>
		[Description("년")]
		public string Year { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 거래처명
		/// </summary>
		[Description("거래처명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
	}

}