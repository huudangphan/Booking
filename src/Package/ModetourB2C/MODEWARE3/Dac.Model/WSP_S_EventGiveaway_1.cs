namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_이벤트경품_1
/// </summary>
public class WSP_S_EventGiveaway_1
{
	public const string SP_NAME = "WSP_S_이벤트경품_1";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Description("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Description("이벤트번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// 이벤트시작일
		/// </summary>
		[Description("이벤트시작일")]
		public DateTime EventStartDate { get; set; }
		/// <summary>
		/// 경품품목번호
		/// </summary>
		[Description("경품품목번호")]
		public int GiveawayItemNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// IP
		/// </summary>
		[Description("IP")]
		public string IP { get; set; }
		/// <summary>
		/// APP
		/// </summary>
		[Description("APP")]
		public string APP { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 신청수량
		/// </summary>
		[Column("신청수량")]
		public int RequestQuantity { get; set; }
		/// <summary>
		/// 신청자수
		/// </summary>
		[Column("신청자수")]
		public int RequesterNumber { get; set; }
		/// <summary>
		/// 총수량
		/// </summary>
		[Column("총수량")]
		public int TotalQuantity { get; set; }
		/// <summary>
		/// 경품품목번호
		/// </summary>
		[Column("경품품목번호")]
		public int GiveawayItemNumber { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 판매일
		/// </summary>
		[Column("판매일")]
		public string SalesDate { get; set; }
		/// <summary>
		/// 총여행경비
		/// </summary>
		[Column("총여행경비")]
		public long TotalTravelExpense { get; set; }
		/// <summary>
		/// 수납액
		/// </summary>
		[Column("수납액")]
		public long ReceiptAmount { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 성별코드
		/// </summary>
		[Column("성별코드")]
		public string GenderCode { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 예약자수
		/// </summary>
		[Column("예약자수")]
		public int NumberOfBooker { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 배송번호
		/// </summary>
		[Column("배송번호")]
		public string ShippingNumber { get; set; }
		/// <summary>
		/// 배송예정일
		/// </summary>
		[Column("배송예정일")]
		public DateTime ShippingExpectationDate { get; set; }
		/// <summary>
		/// 배송일
		/// </summary>
		[Column("배송일")]
		public DateTime ShippingDate { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 주소1
		/// </summary>
		[Column("주소1")]
		public string Address1 { get; set; }
		/// <summary>
		/// 주소2
		/// </summary>
		[Column("주소2")]
		public string Address2 { get; set; }
		/// <summary>
		/// 우편번호
		/// </summary>
		[Column("우편번호")]
		public string ZipCode { get; set; }
		/// <summary>
		/// 신청일
		/// </summary>
		[Column("신청일")]
		public DateTime RequestDate { get; set; }
		/// <summary>
		/// 수량
		/// </summary>
		[Column("수량")]
		public byte Quantity { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Column("주민번호")]
		public string CitizenIDNumber { get; set; }
	}
}