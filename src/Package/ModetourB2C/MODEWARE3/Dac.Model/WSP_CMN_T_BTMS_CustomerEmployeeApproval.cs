namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_CMN_T_BTMS_거래처직원승인
/// </summary>
public class WSP_CMN_T_BTMS_CustomerEmployeeApproval
{
	public const string SP_NAME = "WSP_CMN_T_BTMS_거래처직원승인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// USERID
		/// </summary>
		[Description("USERID")]
		public string USERID { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 승인
		/// </summary>
		[Description("승인")]
		public string Approval { get; set; }
	}

}