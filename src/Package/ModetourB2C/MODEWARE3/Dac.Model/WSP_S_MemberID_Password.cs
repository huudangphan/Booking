namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_회원아이디_비밀번호
/// </summary>
public class WSP_S_MemberID_Password
{
	public const string SP_NAME = "WSP_S_회원아이디_비밀번호";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 업체번호
		/// </summary>
		[Description("업체번호")]
		public int CompanyNumber { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 회원명
		/// </summary>
		[Description("회원명")]
		public string MemberName { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Description("주민번호")]
		public string CitizenIDNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Column("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 회원번호
		/// </summary>
		[Column("회원번호")]
		public int MemberNumber { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 휴면회원YN
		/// </summary>
		[Column("휴면회원YN")]
		public string UnactiveMember_YN { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 회원구분
		/// </summary>
		[Column("회원구분")]
		public string MemberClassification { get; set; }
		/// <summary>
		/// 회사명
		/// </summary>
		[Column("회사명")]
		public string CompanyName { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Column("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 사원직위코드
		/// </summary>
		[Column("사원직위코드")]
		public string StaffPositionCode { get; set; }
		/// <summary>
		/// 임원
		/// </summary>
		[Column("임원")]
		public string Executive { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Column("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Column("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 결혼기념일
		/// </summary>
		[Column("결혼기념일")]
		public DateTime WeddingAnniversaryDate { get; set; }
		/// <summary>
		/// 이용약관
		/// </summary>
		[Column("이용약관")]
		public string TermsAndConditions { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Column("생년월일")]
		public string BirthYearMonthDay { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 외국인
		/// </summary>
		[Column("외국인")]
		public string Foreigner { get; set; }
		/// <summary>
		/// 멤버쉽약관동의여부
		/// </summary>
		[Column("멤버쉽약관동의여부")]
		public string MembershipTermsAgreeOrNot { get; set; }
		/// <summary>
		/// 멤버쉽_이용약관동의여부
		/// </summary>
		[Column("멤버쉽_이용약관동의여부")]
		public string Membership_TermsAndConditionsAgreeOrNot { get; set; }
		/// <summary>
		/// 멤버쉽_개인정보수집동의여부
		/// </summary>
		[Column("멤버쉽_개인정보수집동의여부")]
		public string Membership_PersonalInfoCollectionAgreeOrNot { get; set; }
		/// <summary>
		/// 멤버쉽_고유식별정보수집동의여부
		/// </summary>
		[Column("멤버쉽_고유식별정보수집동의여부")]
		public string Membership_UniqueInfoCollectionAgreeOrNot { get; set; }
		/// <summary>
		/// 멤버쉽_제3자제공동의여부
		/// </summary>
		[Column("멤버쉽_제3자제공동의여부")]
		public string Membership_3rdPartyProvisionAgreeOrNot { get; set; }
		/// <summary>
		/// 멤버쉽_개인정보위탁동의여부
		/// </summary>
		[Column("멤버쉽_개인정보위탁동의여부")]
		public string Membership_PersonalInfoConsignmentAgreeOrNot { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public int Column1 { get; set; }
	}
}