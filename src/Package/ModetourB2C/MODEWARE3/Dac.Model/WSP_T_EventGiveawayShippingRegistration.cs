namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_이벤트경품배송등록
/// </summary>
public class WSP_T_EventGiveawayShippingRegistration
{
	public const string SP_NAME = "WSP_T_이벤트경품배송등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Description("이벤트번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 경품품목번호
		/// </summary>
		[Description("경품품목번호")]
		public int GiveawayItemNumber { get; set; }
		/// <summary>
		/// 배송번호
		/// </summary>
		[Description("배송번호")]
		public string ShippingNumber { get; set; }
		/// <summary>
		/// 배송일
		/// </summary>
		[Description("배송일")]
		public string ShippingDate { get; set; }
	}

}