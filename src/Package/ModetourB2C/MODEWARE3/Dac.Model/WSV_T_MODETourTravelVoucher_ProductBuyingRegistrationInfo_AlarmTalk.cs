namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_T_모두투어여행상품권_상품구매등록안내_알림톡
/// </summary>
public class WSV_T_MODETourTravelVoucher_ProductBuyingRegistrationInfo_AlarmTalk
{
	public const string SP_NAME = "WSV_T_모두투어여행상품권_상품구매등록안내_알림톡";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
	}

}