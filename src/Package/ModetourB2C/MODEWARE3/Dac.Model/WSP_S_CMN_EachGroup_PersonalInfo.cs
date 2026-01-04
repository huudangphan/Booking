namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_단체별_개인정보
/// </summary>
public class WSP_S_CMN_EachGroup_PersonalInfo
{
	public const string SP_NAME = "WSP_S_CMN_단체별_개인정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
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
		/// <summary>
		/// IP
		/// </summary>
		[Description("IP")]
		public string IP { get; set; }
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
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
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
	}
}