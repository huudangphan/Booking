namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_항공호텔예약문의저장
/// </summary>
public class WSP_T_CMN_FlightHotelReservationInquirySaving
{
	public const string SP_NAME = "WSP_T_CMN_항공호텔예약문의저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public string PTID { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public string OrderNumber { get; set; }
		/// <summary>
		/// 예약구분
		/// </summary>
		[Description("예약구분")]
		public string BookingClassification { get; set; }
		/// <summary>
		/// 문의구분
		/// </summary>
		[Description("문의구분")]
		public string InquiryClassification { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Description("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Description("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 사이트번호
		/// </summary>
		[Description("사이트번호")]
		public int SiteNumber { get; set; }
		/// <summary>
		/// 답변상태
		/// </summary>
		[Description("답변상태")]
		public string AnswerState { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 10)]
		[Description("결과")]
		public string Result { get; set; }
	}

}