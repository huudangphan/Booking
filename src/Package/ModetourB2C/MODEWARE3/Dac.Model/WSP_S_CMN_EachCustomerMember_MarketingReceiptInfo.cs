namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_거래처별회원_마케팅수신정보
/// </summary>
public class WSP_S_CMN_EachCustomerMember_MarketingReceiptInfo
{
	public const string SP_NAME = "WSP_S_CMN_거래처별회원_마케팅수신정보";

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
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// PTKNAME
		/// </summary>
		[Column("PTKNAME")]
		public string PTKNAME { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Column("상태1")]
		public string State1 { get; set; }
		/// <summary>
		/// SMS수신여부
		/// </summary>
		[Column("SMS수신여부")]
		public string SMS_ReceptionOrNot { get; set; }
		/// <summary>
		/// 메일수신여부
		/// </summary>
		[Column("메일수신여부")]
		public string MailReceptionOrNot { get; set; }
		/// <summary>
		/// DM수신여부
		/// </summary>
		[Column("DM수신여부")]
		public string DM_ReceptionOrNot { get; set; }
		/// <summary>
		/// 전화수신여부
		/// </summary>
		[Column("전화수신여부")]
		public string PhoneReceptionOrNot { get; set; }
		/// <summary>
		/// 마케팅활용
		/// </summary>
		[Column("마케팅활용")]
		public string MarketingUse { get; set; }
	}
}