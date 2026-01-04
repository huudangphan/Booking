namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_여권자동등록서비스_로그인
/// </summary>
public class WSP_S_PassportAutoRegistrationService_Login
{
	public const string SP_NAME = "WSP_S_여권자동등록서비스_로그인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Description("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Description("생년월일")]
		public string BirthYearMonthDay { get; set; }
		/// <summary>
		/// IP
		/// </summary>
		[Description("IP")]
		public string IP { get; set; }
		/// <summary>
		/// 닷컴모바일유입여부
		/// </summary>
		[Description("닷컴모바일유입여부")]
		public string DotComMobileInflowOrNot { get; set; }
		/// <summary>
		/// 유입판매명세번호
		/// </summary>
		[Description("유입판매명세번호")]
		public int InflowSalesSpecificationNumber { get; set; }
		/// <summary>
		/// 유입예약대행자PTID
		/// </summary>
		[Description("유입예약대행자PTID")]
		public int InflowBookingProcurator_PTID { get; set; }
		/// <summary>
		/// 회원PTID
		/// </summary>
		[Description("회원PTID")]
		public int Member_PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 상태
		/// </summary>
		[Column("상태")]
		public string State { get; set; }
		/// <summary>
		/// 대표자
		/// </summary>
		[Column("대표자")]
		public string Representative { get; set; }
		/// <summary>
		/// 지난단체
		/// </summary>
		[Column("지난단체")]
		public string LastGroup { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
	}
}