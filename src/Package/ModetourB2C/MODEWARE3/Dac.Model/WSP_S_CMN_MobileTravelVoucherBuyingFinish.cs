namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_모바일여행상품권구매완료
/// </summary>
public class WSP_S_CMN_MobileTravelVoucherBuyingFinish
{
	public const string SP_NAME = "WSP_S_CMN_모바일여행상품권구매완료";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 구매주문번호
		/// </summary>
		[Column("구매주문번호")]
		public int BuyOrderNumber { get; set; }
		/// <summary>
		/// 구매자이름
		/// </summary>
		[Column("구매자이름")]
		public string BuyerName { get; set; }
		/// <summary>
		/// 수령자이름
		/// </summary>
		[Column("수령자이름")]
		public string ReceiverName { get; set; }
		/// <summary>
		/// 구매일시
		/// </summary>
		[Column("구매일시")]
		public DateTime BuyDateAndTime { get; set; }
		/// <summary>
		/// 유효기간일자
		/// </summary>
		[Column("유효기간일자")]
		public DateTime ValidPeriodDate { get; set; }
		/// <summary>
		/// 총금액
		/// </summary>
		[Column("총금액")]
		public int TotalAmount { get; set; }
		/// <summary>
		/// 수량
		/// </summary>
		[Column("수량")]
		public int Quantity { get; set; }
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 취소일시
		/// </summary>
		[Column("취소일시")]
		public DateTime CancelDateAndTime { get; set; }
	}
}