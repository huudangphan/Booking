namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_T_아이템_항공_SMS발송
/// </summary>
public class WSV_T_Item_Flight_SMS_Sending
{
	public const string SP_NAME = "WSV_T_아이템_항공_SMS발송";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 예약상태
		/// </summary>
		[Description("예약상태")]
		public string BookingState { get; set; }
		/// <summary>
		/// TL
		/// </summary>
		[Description("TL")]
		public DateTime TL { get; set; }
		/// <summary>
		/// 계좌정보
		/// </summary>
		[Description("계좌정보")]
		public string AccountInfo { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public string Column1 { get; set; }
	}
}