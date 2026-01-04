namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_모두닷컴타겟푸시_여권인식
/// </summary>
public class WSP_T_MODEDotComTargetPush_PassportPerception
{
	public const string SP_NAME = "WSP_T_모두닷컴타겟푸시_여권인식";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 분류
		/// </summary>
		[Description("분류")]
		public string Classification { get; set; }
	}

}