namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_여행플래너_XML_저장
/// </summary>
public class WSP_T_TravelPlanner_XML_Saving
{
	public const string SP_NAME = "WSP_T_여행플래너_XML_저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Description("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 서버아이피
		/// </summary>
		[Description("서버아이피")]
		public string ServerIP { get; set; }
	}

}