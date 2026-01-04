namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_개별단체_환불신청
/// </summary>
public class WSP_T_CMN_IndividualGroup_RefundRequest
{
	public const string SP_NAME = "WSP_T_CMN_개별단체_환불신청";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 환불구분
		/// </summary>
		[Description("환불구분")]
		public string RefundClassification { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 환불상태
		/// </summary>
		[Description("환불상태")]
		public string RefundState { get; set; }
		/// <summary>
		/// 환불자
		/// </summary>
		[Description("환불자")]
		public string Refunder { get; set; }
		/// <summary>
		/// 휴대전화
		/// </summary>
		[Description("휴대전화")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 반송방법
		/// </summary>
		[Description("반송방법")]
		public string SendBackWay { get; set; }
		/// <summary>
		/// 환불계좌은행
		/// </summary>
		[Description("환불계좌은행")]
		public string RefundAccountBank { get; set; }
		/// <summary>
		/// 환불계좌번호
		/// </summary>
		[Description("환불계좌번호")]
		public string RefundAccountNumber { get; set; }
		/// <summary>
		/// 환불계좌예금주
		/// </summary>
		[Description("환불계좌예금주")]
		public string RefundAccountBankAccountOwner { get; set; }
		/// <summary>
		/// 메시지제목
		/// </summary>
		[Description("메시지제목")]
		public string MessageTitle { get; set; }
		/// <summary>
		/// 메시지내용
		/// </summary>
		[Description("메시지내용")]
		public string MessageContent { get; set; }
		/// <summary>
		/// 환불요청사항
		/// </summary>
		[Description("환불요청사항")]
		public string RefundRequest { get; set; }
		/// <summary>
		/// 환불비용
		/// </summary>
		[Description("환불비용")]
		public int RefundExpense { get; set; }
		/// <summary>
		/// 구매총액
		/// </summary>
		[Description("구매총액")]
		public int BuyTotalAmount { get; set; }
		/// <summary>
		/// 수령택배비
		/// </summary>
		[Description("수령택배비")]
		public int ReceiptDeliveryFee { get; set; }
		/// <summary>
		/// 반송택배비
		/// </summary>
		[Description("반송택배비")]
		public int SendBackDeliveryFee { get; set; }
		/// <summary>
		/// 환불등록자
		/// </summary>
		[Description("환불등록자")]
		public int RefundRegisterer { get; set; }
	}

}