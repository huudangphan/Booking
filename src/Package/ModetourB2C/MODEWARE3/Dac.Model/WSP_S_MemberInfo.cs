namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_회원정보
/// </summary>
public class WSP_S_MemberInfo
{
	public const string SP_NAME = "WSP_S_회원정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Column("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 집전화
		/// </summary>
		[Column("집전화")]
		public string HomePhone { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// DI
		/// </summary>
		[Column("DI")]
		public string DI { get; set; }
		/// <summary>
		/// CI
		/// </summary>
		[Column("CI")]
		public string CI { get; set; }
		/// <summary>
		/// 상태15
		/// </summary>
		[Column("상태15")]
		public string State15 { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 아이핀인증여부
		/// </summary>
		[Column("아이핀인증여부")]
		public string IPINVerificationOrNot { get; set; }
		/// <summary>
		/// 멤버쉽약관동의여부
		/// </summary>
		[Column("멤버쉽약관동의여부")]
		public string MembershipTermsAgreeOrNot { get; set; }
		/// <summary>
		/// 메일수신여부
		/// </summary>
		[Column("메일수신여부")]
		public string MailReceptionOrNot { get; set; }
		/// <summary>
		/// SMS수신여부
		/// </summary>
		[Column("SMS수신여부")]
		public string SMS_ReceptionOrNot { get; set; }
		/// <summary>
		/// MT_NO
		/// </summary>
		[Column("MT_NO")]
		public string MT_NO { get; set; }
		/// <summary>
		/// 멤버쉽_이용약관동의여부
		/// </summary>
		[Column("멤버쉽_이용약관동의여부")]
		public string Membership_TermsAndConditionsAgreeOrNot { get; set; }
		/// <summary>
		/// 멤버쉽약관동의일
		/// </summary>
		[Column("멤버쉽약관동의일")]
		public DateTime MembershipTermsAgreeDate { get; set; }
		/// <summary>
		/// 모두투어이용약관
		/// </summary>
		[Column("모두투어이용약관")]
		public string MODETOURTermsAndConditions { get; set; }
		/// <summary>
		/// 멤버쉽_개인정보수집동의여부
		/// </summary>
		[Column("멤버쉽_개인정보수집동의여부")]
		public string Membership_PersonalInfoCollectionAgreeOrNot { get; set; }
		/// <summary>
		/// 멤버쉽_개인정보위탁동의여부
		/// </summary>
		[Column("멤버쉽_개인정보위탁동의여부")]
		public string Membership_PersonalInfoConsignmentAgreeOrNot { get; set; }
		/// <summary>
		/// 멤버쉽_제3자제공동의여부
		/// </summary>
		[Column("멤버쉽_제3자제공동의여부")]
		public string Membership_3rdPartyProvisionAgreeOrNot { get; set; }
		/// <summary>
		/// 멤버쉽_고유식별정보수집동의여부
		/// </summary>
		[Column("멤버쉽_고유식별정보수집동의여부")]
		public string Membership_UniqueInfoCollectionAgreeOrNot { get; set; }
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
		/// 상태23
		/// </summary>
		[Column("상태23")]
		public string State23 { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Column("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 가라인증여부
		/// </summary>
		[Column("가라인증여부")]
		public string FakeCertificationOrNot { get; set; }
		/// <summary>
		/// 우편번호
		/// </summary>
		[Column("우편번호")]
		public string ZipCode { get; set; }
		/// <summary>
		/// 주소1
		/// </summary>
		[Column("주소1")]
		public string Address1 { get; set; }
		/// <summary>
		/// 주소2
		/// </summary>
		[Column("주소2")]
		public string Address2 { get; set; }
	}
}