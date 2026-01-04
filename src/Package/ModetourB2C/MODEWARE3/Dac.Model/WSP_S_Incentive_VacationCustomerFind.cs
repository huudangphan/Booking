namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_인센티브_휴가거래처조회
/// </summary>
public class WSP_S_Incentive_VacationCustomerFind
{
	public const string SP_NAME = "WSP_S_인센티브_휴가거래처조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public string CustomerNumber { get; set; }
	}

}