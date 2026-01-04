namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_거래처별회원_마케팅수신정보
/// </summary>
public class WSP_T_CMN_EachCustomerMember_MarketingReceiptInfo
{
	public const string SP_NAME = "WSP_T_CMN_거래처별회원_마케팅수신정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// SMS수신여부
		/// </summary>
		[Description("SMS수신여부")]
		public string SMS_ReceptionOrNot { get; set; }
		/// <summary>
		/// 메일수신여부
		/// </summary>
		[Description("메일수신여부")]
		public string MailReceptionOrNot { get; set; }
		/// <summary>
		/// DM수신여부
		/// </summary>
		[Description("DM수신여부")]
		public string DM_ReceptionOrNot { get; set; }
		/// <summary>
		/// 전화수신여부
		/// </summary>
		[Description("전화수신여부")]
		public string PhoneReceptionOrNot { get; set; }
		/// <summary>
		/// 마케팅활용
		/// </summary>
		[Description("마케팅활용")]
		public string MarketingUse { get; set; }
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

}