namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_BTMS_견적세부_취소
/// </summary>
public class WSP_T_CMN_BTMS_EstimateDetail_Cancel
{
	public const string SP_NAME = "WSP_T_CMN_BTMS_견적세부_취소";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 세부번호
		/// </summary>
		[Description("세부번호")]
		public int DetailNumber { get; set; }
		/// <summary>
		/// RESULT
		/// </summary>
		[Description("RESULT")]
		public string RESULT { get; set; }
	}

}