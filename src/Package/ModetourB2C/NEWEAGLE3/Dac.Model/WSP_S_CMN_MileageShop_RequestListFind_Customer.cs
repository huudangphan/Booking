namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_마일리지샵_신청목록조회_고객
/// </summary>
public class WSP_S_CMN_MileageShop_RequestListFind_Customer
{
	public const string SP_NAME = "WSP_S_CMN_마일리지샵_신청목록조회_고객";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 신청일
		/// </summary>
		[Description("신청일")]
		public DateTime RequestDate { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 신청목록no
		/// </summary>
		[Column("신청목록no")]
		public int RequestList_NO { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 신청일
		/// </summary>
		[Column("신청일")]
		public DateTime RequestDate { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 섬네일
		/// </summary>
		[Column("섬네일")]
		public string Thumbnail { get; set; }
		/// <summary>
		/// 수량
		/// </summary>
		[Column("수량")]
		public long Quantity { get; set; }
		/// <summary>
		/// 마일리지
		/// </summary>
		[Column("마일리지")]
		public int Mileage { get; set; }
		/// <summary>
		/// 옵션유무
		/// </summary>
		[Column("옵션유무")]
		public string OptionOrNot { get; set; }
		/// <summary>
		/// 수령자
		/// </summary>
		[Column("수령자")]
		public string Receiver { get; set; }
		/// <summary>
		/// 수령우편번호
		/// </summary>
		[Column("수령우편번호")]
		public string ReceiptZipCode { get; set; }
		/// <summary>
		/// 수령주소1
		/// </summary>
		[Column("수령주소1")]
		public string ReceiptAddress1 { get; set; }
		/// <summary>
		/// 수령주소2
		/// </summary>
		[Column("수령주소2")]
		public string ReceiptAddress2 { get; set; }
		/// <summary>
		/// 고객요청사항
		/// </summary>
		[Column("고객요청사항")]
		public string CustomerRequest { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 운송번호
		/// </summary>
		[Column("운송번호")]
		public string TransportationNumber { get; set; }
		/// <summary>
		/// 전화번호
		/// </summary>
		[Column("전화번호")]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// 수납액
		/// </summary>
		[Column("수납액")]
		public long ReceiptAmount { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 신청목록no
		/// </summary>
		[Column("신청목록no")]
		public int RequestList_NO { get; set; }
		/// <summary>
		/// 옵션명
		/// </summary>
		[Column("옵션명")]
		public string OptionName { get; set; }
		/// <summary>
		/// 수량
		/// </summary>
		[Column("수량")]
		public int Quantity { get; set; }
	}
}