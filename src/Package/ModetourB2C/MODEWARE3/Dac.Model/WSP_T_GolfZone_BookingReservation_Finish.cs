namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_골프존_부킹예약_완료
/// </summary>
public class WSP_T_GolfZone_BookingReservation_Finish
{
	public const string SP_NAME = "WSP_T_골프존_부킹예약_완료";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 골프장예약번호
		/// </summary>
		[Description("골프장예약번호")]
		public string GolfCourseBookingNumber { get; set; }
		/// <summary>
		/// 핸드폰번호
		/// </summary>
		[Description("핸드폰번호")]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 1000)]
		[Description("결과")]
		public string Result { get; set; }
	}

}