namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_이벤트경품
/// </summary>
public class WSP_S_EventGiveaway
{
	public const string SP_NAME = "WSP_S_이벤트경품";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public long OrderNumber { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Description("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// EVENTNUM
		/// </summary>
		[Description("EVENTNUM")]
		public short EVENTNUM { get; set; }
		/// <summary>
		/// MSG
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 200)]
		[Description("MSG")]
		public string MSG { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Column("이벤트번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// 이벤트명
		/// </summary>
		[Column("이벤트명")]
		public string EventName { get; set; }
	}

	public class Result2 : IDbResult
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
		/// 주민번호
		/// </summary>
		[Column("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public string Column1 { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 배송일
		/// </summary>
		[Column("배송일")]
		public DateTime ShippingDate { get; set; }
		/// <summary>
		/// 배송번호
		/// </summary>
		[Column("배송번호")]
		public string ShippingNumber { get; set; }
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Column("이벤트번호")]
		public int EventNumber { get; set; }
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
		/// 이벤트명
		/// </summary>
		[Column("이벤트명")]
		public string EventName { get; set; }
		/// <summary>
		/// 경품품목명
		/// </summary>
		[Column("경품품목명")]
		public string GiveawayItemName { get; set; }
		/// <summary>
		/// 경품품목번호
		/// </summary>
		[Column("경품품목번호")]
		public int GiveawayItemNumber { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Column("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 수납액
		/// </summary>
		[Column("수납액")]
		public long ReceiptAmount { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 경품품목번호
		/// </summary>
		[Column("경품품목번호")]
		public int GiveawayItemNumber { get; set; }
		/// <summary>
		/// 경품품목명
		/// </summary>
		[Column("경품품목명")]
		public string GiveawayItemName { get; set; }
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Column("이벤트번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Column("비고")]
		public string Note { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 신청자수
		/// </summary>
		[Column("신청자수")]
		public int RequesterNumber { get; set; }
	}
}