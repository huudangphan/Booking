namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_단체예약_주문_여권
/// </summary>
public class WSP_T_CMN_GroupReservation_Order_Passport
{
	public const string SP_NAME = "WSP_T_CMN_단체예약_주문_여권";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Description("파일명")]
		public string FileName { get; set; }
	}

}