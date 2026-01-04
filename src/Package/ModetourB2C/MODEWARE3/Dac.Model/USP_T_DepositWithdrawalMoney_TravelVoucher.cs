namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_입출금_여행상품권
/// </summary>
public class USP_T_DepositWithdrawalMoney_TravelVoucher
{
	public const string SP_NAME = "USP_T_입출금_여행상품권";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Description("등록자")]
		public int Registerer { get; set; }
		/// <summary>
		/// 사용금액
		/// </summary>
		[Description("사용금액")]
		public int UseAmount { get; set; }
		/// <summary>
		/// 취소수납번호
		/// </summary>
		[Description("취소수납번호")]
		public int CancelReceiptNumber { get; set; }
		/// <summary>
		/// 여행상품권일련번호
		/// </summary>
		[Description("여행상품권일련번호")]
		public int TravelVoucherSerialNumber { get; set; }
		/// <summary>
		/// 취소사유
		/// </summary>
		[Description("취소사유")]
		public string CancelReason { get; set; }
		/// <summary>
		/// 취소사유코드
		/// </summary>
		[Description("취소사유코드")]
		public string CancelReasonCode { get; set; }
		/// <summary>
		/// 결제경로
		/// </summary>
		[Description("결제경로")]
		public string PaymentRoute { get; set; }
		/// <summary>
		/// USERIP
		/// </summary>
		[Description("USERIP")]
		public string USERIP { get; set; }
		/// <summary>
		/// APPNAME
		/// </summary>
		[Description("APPNAME")]
		public string APPNAME { get; set; }
		/// <summary>
		/// 수납번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("수납번호")]
		public int ReceiptNumber { get; set; }
		/// <summary>
		/// 메시지발송여부
		/// </summary>
		[Description("메시지발송여부")]
		public bool MessageSendingOrNot { get; set; }
	}

}