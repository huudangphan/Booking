namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_복호화_개인정보3_주문번호
/// </summary>
public class USP_S_Decryption_PersonalInfo3_OrderNumber
{
	public const string SP_NAME = "USP_S_복호화_개인정보3_주문번호";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// IP
		/// </summary>
		[Description("IP")]
		public string IP { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// APP
		/// </summary>
		[Description("APP")]
		public string APP { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// DEC_주민번호
		/// </summary>
		[Column("DEC_주민번호")]
		public string DEC_CitizenIDNumber { get; set; }
		/// <summary>
		/// DEC_연락처
		/// </summary>
		[Column("DEC_연락처")]
		public string DEC_Contact { get; set; }
		/// <summary>
		/// DEC_전화
		/// </summary>
		[Column("DEC_전화")]
		public string DEC_Phone { get; set; }
		/// <summary>
		/// DEC_HP
		/// </summary>
		[Column("DEC_HP")]
		public string DEC_HP { get; set; }
		/// <summary>
		/// DEC_이메일
		/// </summary>
		[Column("DEC_이메일")]
		public string DEC_Email { get; set; }
		/// <summary>
		/// DEC_메신저
		/// </summary>
		[Column("DEC_메신저")]
		public string DEC_Messager { get; set; }
		/// <summary>
		/// DEC_ETICKET요청메일
		/// </summary>
		[Column("DEC_ETICKET요청메일")]
		public string DEC_ETICKE_TRequestMail { get; set; }
		/// <summary>
		/// DEC_보호자연락처
		/// </summary>
		[Column("DEC_보호자연락처")]
		public string DEC_ProtectPersonContact { get; set; }
		/// <summary>
		/// DEC_여권번호
		/// </summary>
		[Column("DEC_여권번호")]
		public string DEC_PassportNumber { get; set; }
	}
}