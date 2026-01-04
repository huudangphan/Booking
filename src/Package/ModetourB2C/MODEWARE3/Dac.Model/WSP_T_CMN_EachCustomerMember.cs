namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_거래처별회원
/// </summary>
public class WSP_T_CMN_EachCustomerMember
{
	public const string SP_NAME = "WSP_T_CMN_거래처별회원";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 사이트거래처코드
		/// </summary>
		[Description("사이트거래처코드")]
		public int SiteCustomerCode { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Description("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Description("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Description("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 직책
		/// </summary>
		[Description("직책")]
		public string Duty { get; set; }
		/// <summary>
		/// 생일
		/// </summary>
		[Description("생일")]
		public DateTime Birthday { get; set; }
		/// <summary>
		/// 양음력
		/// </summary>
		[Description("양음력")]
		public string SolarLunarCalendar { get; set; }
		/// <summary>
		/// 결혼기념일
		/// </summary>
		[Description("결혼기념일")]
		public DateTime WeddingAnniversaryDate { get; set; }
		/// <summary>
		/// 자녀수
		/// </summary>
		[Description("자녀수")]
		public int ChildrenNumber { get; set; }
		/// <summary>
		/// 직업대분류코드
		/// </summary>
		[Description("직업대분류코드")]
		public string JobMajorClassificationCode { get; set; }
		/// <summary>
		/// 직업소분류코드
		/// </summary>
		[Description("직업소분류코드")]
		public string JobSubClassificationCode { get; set; }
		/// <summary>
		/// 집전화
		/// </summary>
		[Description("집전화")]
		public string HomePhone { get; set; }
		/// <summary>
		/// 부서번호
		/// </summary>
		[Description("부서번호")]
		public string DepartmentNumber { get; set; }
		/// <summary>
		/// 상태3
		/// </summary>
		[Description("상태3")]
		public string State3 { get; set; }
		/// <summary>
		/// 회사전화
		/// </summary>
		[Description("회사전화")]
		public string CompanyPhone { get; set; }
		/// <summary>
		/// 내선
		/// </summary>
		[Description("내선")]
		public string Interphone { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Description("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 팩스
		/// </summary>
		[Description("팩스")]
		public string Fax { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 메신저
		/// </summary>
		[Description("메신저")]
		public string Messager { get; set; }
		/// <summary>
		/// 주소1
		/// </summary>
		[Description("주소1")]
		public string Address1 { get; set; }
		/// <summary>
		/// 주소2
		/// </summary>
		[Description("주소2")]
		public string Address2 { get; set; }
		/// <summary>
		/// 우편번호
		/// </summary>
		[Description("우편번호")]
		public string ZipCode { get; set; }
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
		/// 메일수신여부
		/// </summary>
		[Description("메일수신여부")]
		public string MailReceptionOrNot { get; set; }
		/// <summary>
		/// 신청일
		/// </summary>
		[Description("신청일")]
		public DateTime RequestDate { get; set; }
		/// <summary>
		/// 회사명
		/// </summary>
		[Description("회사명")]
		public string CompanyName { get; set; }
		/// <summary>
		/// 회사주소1
		/// </summary>
		[Description("회사주소1")]
		public string CompanyAddress1 { get; set; }
		/// <summary>
		/// 회사주소2
		/// </summary>
		[Description("회사주소2")]
		public string CompanyAddress2 { get; set; }
		/// <summary>
		/// 회사대표메일
		/// </summary>
		[Description("회사대표메일")]
		public string CompanyRepresentativeMail { get; set; }
		/// <summary>
		/// 회사우편번호
		/// </summary>
		[Description("회사우편번호")]
		public string CompanyZipCode { get; set; }
		/// <summary>
		/// 여권번호
		/// </summary>
		[Description("여권번호")]
		public string PassportNumber { get; set; }
		/// <summary>
		/// 여권만료일
		/// </summary>
		[Description("여권만료일")]
		public DateTime PassportExpirationDate { get; set; }
		/// <summary>
		/// 미국비자번호
		/// </summary>
		[Description("미국비자번호")]
		public string AmericaVisaNumber { get; set; }
		/// <summary>
		/// 미국비자만료일
		/// </summary>
		[Description("미국비자만료일")]
		public DateTime AmericaVisaExpirationDate { get; set; }
		/// <summary>
		/// 일본비자번호
		/// </summary>
		[Description("일본비자번호")]
		public string JapanVisaNumber { get; set; }
		/// <summary>
		/// 일본비자만료일
		/// </summary>
		[Description("일본비자만료일")]
		public DateTime JapanVisaExpirationDate { get; set; }
		/// <summary>
		/// 대표자
		/// </summary>
		[Description("대표자")]
		public string Representative { get; set; }
		/// <summary>
		/// 사업자번호
		/// </summary>
		[Description("사업자번호")]
		public string LicenseeNumber { get; set; }
		/// <summary>
		/// 여권종류
		/// </summary>
		[Description("여권종류")]
		public string PassportType { get; set; }
		/// <summary>
		/// 미국비자종류
		/// </summary>
		[Description("미국비자종류")]
		public string AmericaVisaType { get; set; }
		/// <summary>
		/// 일본비자종류
		/// </summary>
		[Description("일본비자종류")]
		public string JapanVisaType { get; set; }
		/// <summary>
		/// 이전사업자번호
		/// </summary>
		[Description("이전사업자번호")]
		public string PreviousLicenseeNumber { get; set; }
		/// <summary>
		/// 회사팩스
		/// </summary>
		[Description("회사팩스")]
		public string CompanyFax { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 별칭
		/// </summary>
		[Description("별칭")]
		public string Nickname { get; set; }
		/// <summary>
		/// 관계임시일련번호
		/// </summary>
		[Description("관계임시일련번호")]
		public int RelationshipTemporarySerialNumber { get; set; }
		/// <summary>
		/// 지점명
		/// </summary>
		[Description("지점명")]
		public string BranchName { get; set; }
		/// <summary>
		/// 거주지역
		/// </summary>
		[Description("거주지역")]
		public string LivingRegion { get; set; }
		/// <summary>
		/// 여행경험지역
		/// </summary>
		[Description("여행경험지역")]
		public string TravelExperienceRegion { get; set; }
		/// <summary>
		/// 여행출발지
		/// </summary>
		[Description("여행출발지")]
		public string TravelDepartures { get; set; }
		/// <summary>
		/// 파트너여행사
		/// </summary>
		[Description("파트너여행사")]
		public int PartnerTravelCompany { get; set; }
		/// <summary>
		/// 주소선택
		/// </summary>
		[Description("주소선택")]
		public string AddressSelect { get; set; }
		/// <summary>
		/// 관심여행지
		/// </summary>
		[Description("관심여행지")]
		public string InterestingTravelSpot { get; set; }
		/// <summary>
		/// 관심테마
		/// </summary>
		[Description("관심테마")]
		public string InterestingTheme { get; set; }
		/// <summary>
		/// 아이핀인증여부
		/// </summary>
		[Description("아이핀인증여부")]
		public string IPINVerificationOrNot { get; set; }
		/// <summary>
		/// DI중복가입정보
		/// </summary>
		[Description("DI중복가입정보")]
		public string DI_DuplicatedSignUpInfo { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Description("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 내외국인구분
		/// </summary>
		[Description("내외국인구분")]
		public string CitizenAndForeignerClassification { get; set; }
		/// <summary>
		/// RETURN
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 200)]
		[Description("RETURN")]
		public string RETURN { get; set; }
		/// <summary>
		/// 상태10
		/// </summary>
		[Description("상태10")]
		public string State10 { get; set; }
		/// <summary>
		/// 상태11
		/// </summary>
		[Description("상태11")]
		public string State11 { get; set; }
		/// <summary>
		/// 상태12
		/// </summary>
		[Description("상태12")]
		public string State12 { get; set; }
		/// <summary>
		/// 회사구분
		/// </summary>
		[Description("회사구분")]
		public string CompanyClassification { get; set; }
		/// <summary>
		/// 정보수정구분
		/// </summary>
		[Description("정보수정구분")]
		public string InfoEditionClassification { get; set; }
		/// <summary>
		/// 권유자코드
		/// </summary>
		[Description("권유자코드")]
		public string RecommenderCode { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 보호자성명
		/// </summary>
		[Description("보호자성명")]
		public string ProtecterName { get; set; }
		/// <summary>
		/// IPIN생년월일
		/// </summary>
		[Description("IPIN생년월일")]
		public string IPIN_BirthYearMonthDay { get; set; }
		/// <summary>
		/// 개인정보취급방침동의여부
		/// </summary>
		[Description("개인정보취급방침동의여부")]
		public string PersonalInfoPrivacyPolicyAgreeOrNot { get; set; }
		/// <summary>
		/// CI
		/// </summary>
		[Description("CI")]
		public string CI { get; set; }
		/// <summary>
		/// 통신사코드
		/// </summary>
		[Description("통신사코드")]
		public string TelecomCompanyCode { get; set; }
		/// <summary>
		/// SMS수신여부
		/// </summary>
		[Description("SMS수신여부")]
		public string SMS_ReceptionOrNot { get; set; }
		/// <summary>
		/// DM수신여부
		/// </summary>
		[Description("DM수신여부")]
		public string DM_ReceptionOrNot { get; set; }
		/// <summary>
		/// 우편물수신지
		/// </summary>
		[Description("우편물수신지")]
		public string PostalMailReceptionPlace { get; set; }
		/// <summary>
		/// 전화수신여부
		/// </summary>
		[Description("전화수신여부")]
		public string PhoneReceptionOrNot { get; set; }
		/// <summary>
		/// 실제생일
		/// </summary>
		[Description("실제생일")]
		public DateTime RealBirthday { get; set; }
		/// <summary>
		/// 실제생일양음력
		/// </summary>
		[Description("실제생일양음력")]
		public string RealBirthdaySolarLunarCalendar { get; set; }
		/// <summary>
		/// 멤버쉽약관동의여부
		/// </summary>
		[Description("멤버쉽약관동의여부")]
		public string MembershipTermsAgreeOrNot { get; set; }
		/// <summary>
		/// 멤_출국횟수코드
		/// </summary>
		[Description("멤_출국횟수코드")]
		public string Member_LeaveCountryTimesCode { get; set; }
		/// <summary>
		/// 멤_출국목적
		/// </summary>
		[Description("멤_출국목적")]
		public string Member_LeaveCountryPurpose { get; set; }
		/// <summary>
		/// 멤_출발지
		/// </summary>
		[Description("멤_출발지")]
		public string Member_Departures { get; set; }
		/// <summary>
		/// 멤_여행경험지
		/// </summary>
		[Description("멤_여행경험지")]
		public string Member_TravelExperiencePoint { get; set; }
		/// <summary>
		/// 멤_관심지역
		/// </summary>
		[Description("멤_관심지역")]
		public string Member_InterestingRegion { get; set; }
		/// <summary>
		/// 멤_관심테마
		/// </summary>
		[Description("멤_관심테마")]
		public string Member_InterestingTheme { get; set; }
		/// <summary>
		/// 멤_관심여행시기
		/// </summary>
		[Description("멤_관심여행시기")]
		public string Member_InterestingTravelTime { get; set; }
		/// <summary>
		/// 멤_관심혜택
		/// </summary>
		[Description("멤_관심혜택")]
		public string Member_InterestingBenefit { get; set; }
		/// <summary>
		/// 멤버쉽_이용약관동의여부
		/// </summary>
		[Description("멤버쉽_이용약관동의여부")]
		public string Membership_TermsAndConditionsAgreeOrNot { get; set; }
		/// <summary>
		/// 멤버쉽_개인정보수집동의여부
		/// </summary>
		[Description("멤버쉽_개인정보수집동의여부")]
		public string Membership_PersonalInfoCollectionAgreeOrNot { get; set; }
		/// <summary>
		/// 멤버쉽_고유식별정보수집동의여부
		/// </summary>
		[Description("멤버쉽_고유식별정보수집동의여부")]
		public string Membership_UniqueInfoCollectionAgreeOrNot { get; set; }
		/// <summary>
		/// 멤버쉽_제3자제공동의여부
		/// </summary>
		[Description("멤버쉽_제3자제공동의여부")]
		public string Membership_3rdPartyProvisionAgreeOrNot { get; set; }
		/// <summary>
		/// 멤버쉽_개인정보위탁동의여부
		/// </summary>
		[Description("멤버쉽_개인정보위탁동의여부")]
		public string Membership_PersonalInfoConsignmentAgreeOrNot { get; set; }
		/// <summary>
		/// 회원가입수단코드
		/// </summary>
		[Description("회원가입수단코드")]
		public string MemberSignUpMethodCode { get; set; }
		/// <summary>
		/// 모두투어이용약관
		/// </summary>
		[Description("모두투어이용약관")]
		public string MODETOURTermsAndConditions { get; set; }
		/// <summary>
		/// 멤버쉽이용약관
		/// </summary>
		[Description("멤버쉽이용약관")]
		public string MembershipTermsAndConditions { get; set; }
		/// <summary>
		/// 개인정보수집
		/// </summary>
		[Description("개인정보수집")]
		public string PersonalInfoCollection { get; set; }
		/// <summary>
		/// 고유식별정보수집
		/// </summary>
		[Description("고유식별정보수집")]
		public string UniqueInfoCollection { get; set; }
		/// <summary>
		/// 개인정보3자제공
		/// </summary>
		[Description("개인정보3자제공")]
		public string PersonalInfo3rdPartyProvision { get; set; }
		/// <summary>
		/// 개인정보위탁
		/// </summary>
		[Description("개인정보위탁")]
		public string PersonalInfoConsign { get; set; }
		/// <summary>
		/// 마케팅활용
		/// </summary>
		[Description("마케팅활용")]
		public string MarketingUse { get; set; }
		/// <summary>
		/// 가라인증여부
		/// </summary>
		[Description("가라인증여부")]
		public string FakeCertificationOrNot { get; set; }
		/// <summary>
		/// 추천인ID
		/// </summary>
		[Description("추천인ID")]
		public string Recommender_ID { get; set; }
		/// <summary>
		/// 추천인PTID
		/// </summary>
		[Description("추천인PTID")]
		public int Recommender_PTID { get; set; }
		/// <summary>
		/// MT_NO
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 15)]
		[Description("MT_NO")]
		public string MT_NO { get; set; }
		/// <summary>
		/// PID
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("PID")]
		public int PID { get; set; }
	}

}