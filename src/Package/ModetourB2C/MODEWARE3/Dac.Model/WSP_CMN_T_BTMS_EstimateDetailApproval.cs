namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_CMN_T_BTMS_견적세부승인
/// </summary>
public class WSP_CMN_T_BTMS_EstimateDetailApproval
{
	public const string SP_NAME = "WSP_CMN_T_BTMS_견적세부승인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 견적번호
		/// </summary>
		[Description("견적번호")]
		public int EstimateNumber { get; set; }
		/// <summary>
		/// 세부번호
		/// </summary>
		[Description("세부번호")]
		public string DetailNumber { get; set; }
		/// <summary>
		/// 승인
		/// </summary>
		[Description("승인")]
		public string Approval { get; set; }
	}

}