namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_거래처_좌표
/// </summary>
public class WSP_T_CMN_Customer_Coordinate
{
	public const string SP_NAME = "WSP_T_CMN_거래처_좌표";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// LAT
		/// </summary>
		[Description("LAT")]
		public string LAT { get; set; }
		/// <summary>
		/// LNG
		/// </summary>
		[Description("LNG")]
		public string LNG { get; set; }
	}

}