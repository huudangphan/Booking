namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_주문정보갱신
/// </summary>
public class WSP_T_CMN_OrderInfoRenew
{
	public const string SP_NAME = "WSP_T_CMN_주문정보갱신";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
	}

}