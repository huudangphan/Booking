namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_센딩보고_내용
/// </summary>
public class WSP_S_SendingReport_Content
{
	public const string SP_NAME = "WSP_S_센딩보고_내용";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 작성자번호
		/// </summary>
		[Column("작성자번호")]
		public int WritterNumber { get; set; }
		/// <summary>
		/// 작성자명
		/// </summary>
		[Column("작성자명")]
		public string WritterName { get; set; }
		/// <summary>
		/// 센딩일
		/// </summary>
		[Column("센딩일")]
		public string SendingDate { get; set; }
		/// <summary>
		/// 출발지
		/// </summary>
		[Column("출발지")]
		public string Departures { get; set; }
		/// <summary>
		/// 목적지
		/// </summary>
		[Column("목적지")]
		public string Destination { get; set; }
		/// <summary>
		/// 항공
		/// </summary>
		[Column("항공")]
		public string Flight { get; set; }
		/// <summary>
		/// 발생내용
		/// </summary>
		[Column("발생내용")]
		public string OccurContent { get; set; }
		/// <summary>
		/// 고객명
		/// </summary>
		[Column("고객명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 첨부파일
		/// </summary>
		[Column("첨부파일")]
		public string AttachFile { get; set; }
		/// <summary>
		/// 상세내용
		/// </summary>
		[Column("상세내용")]
		public string DetailContent { get; set; }
		/// <summary>
		/// 보상내용
		/// </summary>
		[Column("보상내용")]
		public string CompensationContent { get; set; }
		/// <summary>
		/// 수신자번호
		/// </summary>
		[Column("수신자번호")]
		public string ReceiverNumber { get; set; }
		/// <summary>
		/// 수신자정보
		/// </summary>
		[Column("수신자정보")]
		public string ReceiverInfo { get; set; }
		/// <summary>
		/// 수신부서
		/// </summary>
		[Column("수신부서")]
		public string ReceptionDepartment { get; set; }
		/// <summary>
		/// 공지
		/// </summary>
		[Column("공지")]
		public bool Notification { get; set; }
		/// <summary>
		/// 예약번호
		/// </summary>
		[Column("예약번호")]
		public int BookingNumber { get; set; }
		/// <summary>
		/// 간략보고_시간1
		/// </summary>
		[Column("간략보고_시간1")]
		public string BriefReport_Time1 { get; set; }
		/// <summary>
		/// 간략보고_시간2
		/// </summary>
		[Column("간략보고_시간2")]
		public string BriefReport_Time2 { get; set; }
		/// <summary>
		/// 간략보고_시간3
		/// </summary>
		[Column("간략보고_시간3")]
		public string BriefReport_Time3 { get; set; }
		/// <summary>
		/// 간략보고_시간4
		/// </summary>
		[Column("간략보고_시간4")]
		public string BriefReport_Time4 { get; set; }
		/// <summary>
		/// 간략보고_시간5
		/// </summary>
		[Column("간략보고_시간5")]
		public string BriefReport_Time5 { get; set; }
		/// <summary>
		/// 간략보고_시간6
		/// </summary>
		[Column("간략보고_시간6")]
		public string BriefReport_Time6 { get; set; }
		/// <summary>
		/// 간략보고_시간7
		/// </summary>
		[Column("간략보고_시간7")]
		public string BriefReport_Time7 { get; set; }
		/// <summary>
		/// 간략보고_내용1
		/// </summary>
		[Column("간략보고_내용1")]
		public string BriefReport_Content1 { get; set; }
		/// <summary>
		/// 간략보고_내용2
		/// </summary>
		[Column("간략보고_내용2")]
		public string BriefReport_Content2 { get; set; }
		/// <summary>
		/// 간략보고_내용3
		/// </summary>
		[Column("간략보고_내용3")]
		public string BriefReport_Content3 { get; set; }
		/// <summary>
		/// 간략보고_내용4
		/// </summary>
		[Column("간략보고_내용4")]
		public string BriefReport_Content4 { get; set; }
		/// <summary>
		/// 간략보고_내용5
		/// </summary>
		[Column("간략보고_내용5")]
		public string BriefReport_Content5 { get; set; }
		/// <summary>
		/// 간략보고_내용6
		/// </summary>
		[Column("간략보고_내용6")]
		public string BriefReport_Content6 { get; set; }
		/// <summary>
		/// 간략보고_내용7
		/// </summary>
		[Column("간략보고_내용7")]
		public string BriefReport_Content7 { get; set; }
	}
}