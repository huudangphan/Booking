namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_수납_아시아나마일리지
/// </summary>
public class USP_T_Receipt_AsianaMileage
{
	public const string SP_NAME = "USP_T_수납_아시아나마일리지";

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
		/// InputDate
		/// </summary>
		[Description("InputDate")]
		public string InputDate { get; set; }
		/// <summary>
		/// InputID
		/// </summary>
		[Description("InputID")]
		public string InputID { get; set; }
		/// <summary>
		/// ACNO
		/// </summary>
		[Description("ACNO")]
		public string ACNO { get; set; }
		/// <summary>
		/// IclubID
		/// </summary>
		[Description("IclubID")]
		public string IclubID { get; set; }
		/// <summary>
		/// partnerCode
		/// </summary>
		[Description("partnerCode")]
		public string partnerCode { get; set; }
		/// <summary>
		/// DeductMile
		/// </summary>
		[Description("DeductMile")]
		public long DeductMile { get; set; }
		/// <summary>
		/// CertificateNo
		/// </summary>
		[Description("CertificateNo")]
		public string CertificateNo { get; set; }
		/// <summary>
		/// AgreementType
		/// </summary>
		[Description("AgreementType")]
		public string AgreementType { get; set; }
		/// <summary>
		/// AgreementCNT
		/// </summary>
		[Description("AgreementCNT")]
		public string AgreementCNT { get; set; }
		/// <summary>
		/// ChkInDate
		/// </summary>
		[Description("ChkInDate")]
		public string ChkInDate { get; set; }
		/// <summary>
		/// ChkOutDate
		/// </summary>
		[Description("ChkOutDate")]
		public string ChkOutDate { get; set; }
		/// <summary>
		/// PaymentSUM
		/// </summary>
		[Description("PaymentSUM")]
		public long PaymentSUM { get; set; }
		/// <summary>
		/// SocialNo
		/// </summary>
		[Description("SocialNo")]
		public string SocialNo { get; set; }
		/// <summary>
		/// ItemInfo1
		/// </summary>
		[Description("ItemInfo1")]
		public string ItemInfo1 { get; set; }
		/// <summary>
		/// ItemInfo2
		/// </summary>
		[Description("ItemInfo2")]
		public string ItemInfo2 { get; set; }
		/// <summary>
		/// RequestDomain
		/// </summary>
		[Description("RequestDomain")]
		public string RequestDomain { get; set; }
		/// <summary>
		/// RequestUserIp
		/// </summary>
		[Description("RequestUserIp")]
		public string RequestUserIp { get; set; }
		/// <summary>
		/// ReturnUrl
		/// </summary>
		[Description("ReturnUrl")]
		public string ReturnUrl { get; set; }
		/// <summary>
		/// ReturnCode
		/// </summary>
		[Description("ReturnCode")]
		public string ReturnCode { get; set; }
		/// <summary>
		/// AvailMileage
		/// </summary>
		[Description("AvailMileage")]
		public long AvailMileage { get; set; }
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