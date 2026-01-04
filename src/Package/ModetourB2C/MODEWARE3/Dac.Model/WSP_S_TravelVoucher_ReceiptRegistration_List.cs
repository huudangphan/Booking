namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_여행상품권_수령등록_리스트
/// </summary>
public class WSP_S_TravelVoucher_ReceiptRegistration_List
{
	public const string SP_NAME = "WSP_S_여행상품권_수령등록_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 여행상품권구매일련번호
		/// </summary>
		[Column("여행상품권구매일련번호")]
		public int TravelVoucherBuySerialNumber { get; set; }
		/// <summary>
		/// 권종
		/// </summary>
		[Column("권종")]
		public string MoneyType { get; set; }
		/// <summary>
		/// 상품권명
		/// </summary>
		[Column("상품권명")]
		public string VoucherName { get; set; }
		/// <summary>
		/// 금액
		/// </summary>
		[Column("금액")]
		public int Amount { get; set; }
		/// <summary>
		/// 유효기간일자
		/// </summary>
		[Column("유효기간일자")]
		public DateTime ValidPeriodDate { get; set; }
		/// <summary>
		/// 여행상품권번호
		/// </summary>
		[Column("여행상품권번호")]
		public string TravelVoucherNumber { get; set; }
		/// <summary>
		/// 여행상품권일련번호
		/// </summary>
		[Column("여행상품권일련번호")]
		public int TravelVoucherSerialNumber { get; set; }
		/// <summary>
		/// 구매회원번호
		/// </summary>
		[Column("구매회원번호")]
		public string BuyMemberNumber { get; set; }
		/// <summary>
		/// 수령자이름
		/// </summary>
		[Column("수령자이름")]
		public string ReceiverName { get; set; }
		/// <summary>
		/// 수령자핸드폰
		/// </summary>
		[Column("수령자핸드폰")]
		public string ReceiverPhone { get; set; }
		/// <summary>
		/// 수령일시
		/// </summary>
		[Column("수령일시")]
		public DateTime ReceiptDateAndTime { get; set; }
		/// <summary>
		/// 수납번호
		/// </summary>
		[Column("수납번호")]
		public int ReceiptNumber { get; set; }
		/// <summary>
		/// 사용구분
		/// </summary>
		[Column("사용구분")]
		public string UseClassification { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 총금액
		/// </summary>
		[Column("총금액")]
		public int TotalAmount { get; set; }
		/// <summary>
		/// 총사용가능수
		/// </summary>
		[Column("총사용가능수")]
		public int TotalUsePossibleNumber { get; set; }
	}
}