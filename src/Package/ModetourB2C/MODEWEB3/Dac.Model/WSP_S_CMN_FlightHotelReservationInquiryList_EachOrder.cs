namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_항공호텔예약문의리스트_주문별
/// </summary>
public class WSP_S_CMN_FlightHotelReservationInquiryList_EachOrder
{
	public const string SP_NAME = "WSP_S_CMN_항공호텔예약문의리스트_주문별";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public string PTID { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 예약구분
		/// </summary>
		[Column("예약구분")]
		public string BookingClassification { get; set; }
		/// <summary>
		/// 문의구분
		/// </summary>
		[Column("문의구분")]
		public string InquiryClassification { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public DateTime WrittingDate { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 답변상태
		/// </summary>
		[Column("답변상태")]
		public string AnswerState { get; set; }
		/// <summary>
		/// 예약담당자
		/// </summary>
		[Column("예약담당자")]
		public string BookingManager { get; set; }
		/// <summary>
		/// 답변내용
		/// </summary>
		[Column("답변내용")]
		public string AnswerContent { get; set; }
		/// <summary>
		/// 재발행
		/// </summary>
		[Column("재발행")]
		public string RePublish { get; set; }
		/// <summary>
		/// 재발행주문번호
		/// </summary>
		[Column("재발행주문번호")]
		public int RePublishOrderNumber { get; set; }
	}
}