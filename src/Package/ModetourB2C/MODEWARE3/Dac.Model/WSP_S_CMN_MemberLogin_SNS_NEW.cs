namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_회원로그인_SNS_NEW
/// </summary>
public class WSP_S_CMN_MemberLogin_SNS_NEW
{
	public const string SP_NAME = "WSP_S_CMN_회원로그인_SNS_NEW";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 업체번호
		/// </summary>
		[Description("업체번호")]
		public int CompanyNumber { get; set; }
		/// <summary>
		/// CHANNEL
		/// </summary>
		[Description("CHANNEL")]
		public string CHANNEL { get; set; }
		/// <summary>
		/// CHANNELID
		/// </summary>
		[Description("CHANNELID")]
		public string CHANNELID { get; set; }
		/// <summary>
		/// 최근접속IP
		/// </summary>
		[Description("최근접속IP")]
		public string RecentAccess_IP { get; set; }
		/// <summary>
		/// 휴면해지
		/// </summary>
		[Description("휴면해지")]
		public string UnactiveCancel { get; set; }
		/// <summary>
		/// 로그인TYPE
		/// </summary>
		[Description("로그인TYPE")]
		public string Login_TYPE { get; set; }
	}

	public class Result : IDbResult
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
		/// <summary>
		/// 쿠폰이벤트
		/// </summary>
		[Column("쿠폰이벤트")]
		public string CouponEvent { get; set; }
	}
}