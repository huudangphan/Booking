namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_T_여행상품권
/// </summary>
public class WSV_T_TravelVoucher
{
	public const string SP_NAME = "WSV_T_여행상품권";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 사이트번호
		/// </summary>
		[Description("사이트번호")]
		public int SiteNumber { get; set; }
		/// <summary>
		/// 수령자이름
		/// </summary>
		[Description("수령자이름")]
		public string ReceiverName { get; set; }
		/// <summary>
		/// 수령자핸드폰
		/// </summary>
		[Description("수령자핸드폰")]
		public string ReceiverPhone { get; set; }
		/// <summary>
		/// 수령회원번호
		/// </summary>
		[Description("수령회원번호")]
		public string ReceiptMemberNumber { get; set; }
		/// <summary>
		/// 선물메시지
		/// </summary>
		[Description("선물메시지")]
		public string GiftMessage { get; set; }
		/// <summary>
		/// 권종
		/// </summary>
		[Description("권종")]
		public string MoneyType { get; set; }
		/// <summary>
		/// 수량
		/// </summary>
		[Description("수량")]
		public int Quantity { get; set; }
		/// <summary>
		/// 예약자번호
		/// </summary>
		[Description("예약자번호")]
		public int BookerNumber { get; set; }
		/// <summary>
		/// 전체요금
		/// </summary>
		[Description("전체요금")]
		public long EntireFare { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 에러메시지
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 1000)]
		[Description("에러메시지")]
		public string ErrorMessage { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public int Column1 { get; set; }
		/// <summary>
		/// Column2
		/// </summary>
		[Column("Column2")]
		public string Column2 { get; set; }
		/// <summary>
		/// Column3
		/// </summary>
		[Column("Column3")]
		public string Column3 { get; set; }
	}
}