namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_항공호텔예약문의_코멘트저장
/// </summary>
public class WSP_T_CMN_FlightHotelReservationInquiry_CommentSaving
{
	public const string SP_NAME = "WSP_T_CMN_항공호텔예약문의_코멘트저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상위일련번호
		/// </summary>
		[Description("상위일련번호")]
		public int HighRankSerialNumber { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 코멘트
		/// </summary>
		[Description("코멘트")]
		public string Comment { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 10)]
		[Description("결과")]
		public string Result { get; set; }
	}

}