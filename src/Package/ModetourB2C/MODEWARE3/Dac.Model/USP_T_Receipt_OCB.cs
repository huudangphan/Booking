namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_수납_OCB
/// </summary>
public class USP_T_Receipt_OCB
{
	public const string SP_NAME = "USP_T_수납_OCB";

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
		/// 수납번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("수납번호")]
		public int ReceiptNumber { get; set; }
		/// <summary>
		/// 수납일
		/// </summary>
		[Description("수납일")]
		public DateTime ReceiptDate { get; set; }
		/// <summary>
		/// ReplyCode
		/// </summary>
		[Description("ReplyCode")]
		public string ReplyCode { get; set; }
		/// <summary>
		/// ReplyMessage
		/// </summary>
		[Description("ReplyMessage")]
		public string ReplyMessage { get; set; }
		/// <summary>
		/// DetailMessage
		/// </summary>
		[Description("DetailMessage")]
		public string DetailMessage { get; set; }
		/// <summary>
		/// NxMctNo
		/// </summary>
		[Description("NxMctNo")]
		public string NxMctNo { get; set; }
		/// <summary>
		/// SubMallId
		/// </summary>
		[Description("SubMallId")]
		public string SubMallId { get; set; }
		/// <summary>
		/// SubMallName
		/// </summary>
		[Description("SubMallName")]
		public string SubMallName { get; set; }
		/// <summary>
		/// SubMallCorpNo
		/// </summary>
		[Description("SubMallCorpNo")]
		public string SubMallCorpNo { get; set; }
		/// <summary>
		/// MctId
		/// </summary>
		[Description("MctId")]
		public string MctId { get; set; }
		/// <summary>
		/// MctTrNo
		/// </summary>
		[Description("MctTrNo")]
		public string MctTrNo { get; set; }
		/// <summary>
		/// MctTrDate
		/// </summary>
		[Description("MctTrDate")]
		public string MctTrDate { get; set; }
		/// <summary>
		/// TxNo
		/// </summary>
		[Description("TxNo")]
		public string TxNo { get; set; }
		/// <summary>
		/// AppTime
		/// </summary>
		[Description("AppTime")]
		public string AppTime { get; set; }
		/// <summary>
		/// Amount
		/// </summary>
		[Description("Amount")]
		public long Amount { get; set; }
		/// <summary>
		/// Point
		/// </summary>
		[Description("Point")]
		public long Point { get; set; }
		/// <summary>
		/// EventPoint
		/// </summary>
		[Description("EventPoint")]
		public long EventPoint { get; set; }
		/// <summary>
		/// ChargePoint
		/// </summary>
		[Description("ChargePoint")]
		public long ChargePoint { get; set; }
		/// <summary>
		/// AvPoint
		/// </summary>
		[Description("AvPoint")]
		public long AvPoint { get; set; }
		/// <summary>
		/// AccPoint
		/// </summary>
		[Description("AccPoint")]
		public long AccPoint { get; set; }
		/// <summary>
		/// DstPoint
		/// </summary>
		[Description("DstPoint")]
		public long DstPoint { get; set; }
		/// <summary>
		/// DstSavePoint
		/// </summary>
		[Description("DstSavePoint")]
		public long DstSavePoint { get; set; }
		/// <summary>
		/// Enc
		/// </summary>
		[Description("Enc")]
		public string Enc { get; set; }
		/// <summary>
		/// SubMallUserId
		/// </summary>
		[Description("SubMallUserId")]
		public string SubMallUserId { get; set; }
		/// <summary>
		/// AuthId
		/// </summary>
		[Description("AuthId")]
		public string AuthId { get; set; }
		/// <summary>
		/// 취소구분
		/// </summary>
		[Description("취소구분")]
		public string CancelClassification { get; set; }
		/// <summary>
		/// 취소금액
		/// </summary>
		[Description("취소금액")]
		public long CancelAmount { get; set; }
		/// <summary>
		/// 취소사유
		/// </summary>
		[Description("취소사유")]
		public string CancelReason { get; set; }
		/// <summary>
		/// 취소결과
		/// </summary>
		[Description("취소결과")]
		public string CancelResult { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Description("등록자")]
		public int Registerer { get; set; }
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
	}

}