namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_센딩_무인센딩_발송예약
/// </summary>
public class WSP_T_Sending_UnmannedSending_SendingReservation
{
	public const string SP_NAME = "WSP_T_센딩_무인센딩_발송예약";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 예약번호
		/// </summary>
		[Description("예약번호")]
		public int BookingNumber { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 핸드폰번호
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("핸드폰번호")]
		public List<TYPE_UnmannedSending_Number> PhoneNumber { get; set; }
		/// <summary>
		/// 여행계약서URL
		/// </summary>
		[Description("여행계약서URL")]
		public string TravelContract_URL { get; set; }
	}

}