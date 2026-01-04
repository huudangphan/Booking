namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// 상품문의_추가예약저장
/// </summary>
public class ProductInquiry_AddReservationSaving
{
	public const string SP_NAME = "상품문의_추가예약저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 구분2
		/// </summary>
		[Description("구분2")]
		public string Classification2 { get; set; }
		/// <summary>
		/// 추가예약번호1
		/// </summary>
		[Description("추가예약번호1")]
		public int AddBookingNumber1 { get; set; }
		/// <summary>
		/// 추가예약번호2
		/// </summary>
		[Description("추가예약번호2")]
		public int AddBookingNumber2 { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 추가예약1담당자
		/// </summary>
		[Description("추가예약1담당자")]
		public int AddBooking1Manager { get; set; }
		/// <summary>
		/// 추가예약1담당자정보
		/// </summary>
		[Description("추가예약1담당자정보")]
		public string AddBooking1ManagerInfo { get; set; }
		/// <summary>
		/// 추가예약1담당자지정일
		/// </summary>
		[Description("추가예약1담당자지정일")]
		public DateTime AddBooking1ManagerAssignmentDate { get; set; }
		/// <summary>
		/// 추가예약1담당자지정자
		/// </summary>
		[Description("추가예약1담당자지정자")]
		public string AddBooking1ManagerAssigner { get; set; }
		/// <summary>
		/// 추가예약2담당자
		/// </summary>
		[Description("추가예약2담당자")]
		public int AddBooking2Manager { get; set; }
		/// <summary>
		/// 추가예약2담당자정보
		/// </summary>
		[Description("추가예약2담당자정보")]
		public string AddBooking2ManagerInfo { get; set; }
		/// <summary>
		/// 추가예약2담당자지정일
		/// </summary>
		[Description("추가예약2담당자지정일")]
		public DateTime AddBooking2ManagerAssignmentDate { get; set; }
		/// <summary>
		/// 추가예약2담당자지정자
		/// </summary>
		[Description("추가예약2담당자지정자")]
		public string AddBooking2ManagerAssigner { get; set; }
	}

}