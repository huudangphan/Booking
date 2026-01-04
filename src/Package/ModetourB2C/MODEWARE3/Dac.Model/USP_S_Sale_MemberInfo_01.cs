namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_판매_회원정보_01
/// </summary>
public class USP_S_Sale_MemberInfo_01
{
	public const string SP_NAME = "USP_S_판매_회원정보_01";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 한글이름
		/// </summary>
		[Description("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Description("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Description("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// CHECK
		/// </summary>
		[Description("CHECK")]
		public string CHECK { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// MT_NO
		/// </summary>
		[Column("MT_NO")]
		public string MT_NO { get; set; }
		/// <summary>
		/// 회원구분
		/// </summary>
		[Column("회원구분")]
		public string MemberClassification { get; set; }
		/// <summary>
		/// 회원구분코드
		/// </summary>
		[Column("회원구분코드")]
		public string MemberClassificationCode { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 파트너여행사
		/// </summary>
		[Column("파트너여행사")]
		public int PartnerTravelCompany { get; set; }
		/// <summary>
		/// 파트너여행사동의날짜
		/// </summary>
		[Column("파트너여행사동의날짜")]
		public string PartnerTravelCompanyAgreeDate { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// MT_NO
		/// </summary>
		[Column("MT_NO")]
		public string MT_NO { get; set; }
		/// <summary>
		/// 회원구분
		/// </summary>
		[Column("회원구분")]
		public string MemberClassification { get; set; }
		/// <summary>
		/// 회원구분코드
		/// </summary>
		[Column("회원구분코드")]
		public string MemberClassificationCode { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 멤버쉽동의일
		/// </summary>
		[Column("멤버쉽동의일")]
		public string MembershipAgreementDate { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 파트너여행사
		/// </summary>
		[Column("파트너여행사")]
		public int PartnerTravelCompany { get; set; }
		/// <summary>
		/// 파트너여행사동의날짜
		/// </summary>
		[Column("파트너여행사동의날짜")]
		public string PartnerTravelCompanyAgreeDate { get; set; }
	}
}