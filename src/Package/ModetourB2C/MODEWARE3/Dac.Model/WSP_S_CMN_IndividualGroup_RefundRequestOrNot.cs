namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_개별단체_환불신청여부
/// </summary>
public class WSP_S_CMN_IndividualGroup_RefundRequestOrNot
{
	public const string SP_NAME = "WSP_S_CMN_개별단체_환불신청여부";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 환불구분
		/// </summary>
		[Description("환불구분")]
		public string RefundClassification { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
	}

}