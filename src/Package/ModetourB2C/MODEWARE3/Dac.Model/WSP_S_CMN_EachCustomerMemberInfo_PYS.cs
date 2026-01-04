namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_거래처별회원정보_PYS
/// </summary>
public class WSP_S_CMN_EachCustomerMemberInfo_PYS
{
	public const string SP_NAME = "WSP_S_CMN_거래처별회원정보_PYS";

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
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// MT_NO
		/// </summary>
		[Description("MT_NO")]
		public string MT_NO { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public int Column1 { get; set; }
	}

	public class Result2 : IDbResult
	{
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
		/// 비밀번호
		/// </summary>
		[Column("비밀번호")]
		public string Password { get; set; }
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
		/// <summary>
		/// 전화
		/// </summary>
		[Column("전화")]
		public string Phone { get; set; }
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
		/// 메일수신
		/// </summary>
		[Column("메일수신")]
		public string MailReception { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 여권번호
		/// </summary>
		[Column("여권번호")]
		public string PassportNumber { get; set; }
		/// <summary>
		/// 여권만료일
		/// </summary>
		[Column("여권만료일")]
		public string PassportExpirationDate { get; set; }
		/// <summary>
		/// 미국비자번호
		/// </summary>
		[Column("미국비자번호")]
		public string AmericaVisaNumber { get; set; }
		/// <summary>
		/// 미국비자만료일
		/// </summary>
		[Column("미국비자만료일")]
		public string AmericaVisaExpirationDate { get; set; }
		/// <summary>
		/// 일본비자번호
		/// </summary>
		[Column("일본비자번호")]
		public string JapanVisaNumber { get; set; }
		/// <summary>
		/// 일본비자만료일
		/// </summary>
		[Column("일본비자만료일")]
		public string JapanVisaExpirationDate { get; set; }
		/// <summary>
		/// 생일
		/// </summary>
		[Column("생일")]
		public string Birthday { get; set; }
		/// <summary>
		/// 양음력
		/// </summary>
		[Column("양음력")]
		public string SolarLunarCalendar { get; set; }
		/// <summary>
		/// 결혼기념일
		/// </summary>
		[Column("결혼기념일")]
		public string WeddingAnniversaryDate { get; set; }
		/// <summary>
		/// 회사명
		/// </summary>
		[Column("회사명")]
		public string CompanyName { get; set; }
		/// <summary>
		/// 관계종류
		/// </summary>
		[Column("관계종류")]
		public string RelationshipType { get; set; }
		/// <summary>
		/// 직업구분
		/// </summary>
		[Column("직업구분")]
		public string JobClassification { get; set; }
		/// <summary>
		/// 상태15
		/// </summary>
		[Column("상태15")]
		public string State15 { get; set; }
		/// <summary>
		/// 파트너여행사동의날짜
		/// </summary>
		[Column("파트너여행사동의날짜")]
		public string PartnerTravelCompanyAgreeDate { get; set; }
		/// <summary>
		/// 우편물
		/// </summary>
		[Column("우편물")]
		public string PostalMail { get; set; }
		/// <summary>
		/// SMS
		/// </summary>
		[Column("SMS")]
		public string SMS { get; set; }
		/// <summary>
		/// 거주지역
		/// </summary>
		[Column("거주지역")]
		public string LivingRegion { get; set; }
		/// <summary>
		/// 여행경험지역
		/// </summary>
		[Column("여행경험지역")]
		public string TravelExperienceRegion { get; set; }
		/// <summary>
		/// 여행출발지
		/// </summary>
		[Column("여행출발지")]
		public string TravelDepartures { get; set; }
		/// <summary>
		/// 파트너여행사
		/// </summary>
		[Column("파트너여행사")]
		public int PartnerTravelCompany { get; set; }
		/// <summary>
		/// 파트너여행사명
		/// </summary>
		[Column("파트너여행사명")]
		public string PartnerTravelCompanyName { get; set; }
		/// <summary>
		/// 주소선택
		/// </summary>
		[Column("주소선택")]
		public string AddressSelect { get; set; }
		/// <summary>
		/// DI
		/// </summary>
		[Column("DI")]
		public string DI { get; set; }
		/// <summary>
		/// 아이핀인증여부
		/// </summary>
		[Column("아이핀인증여부")]
		public string IPINVerificationOrNot { get; set; }
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
		/// 통신사
		/// </summary>
		[Column("통신사")]
		public string TelecomCompany { get; set; }
		/// <summary>
		/// 실제생일
		/// </summary>
		[Column("실제생일")]
		public DateTime RealBirthday { get; set; }
		/// <summary>
		/// 실제생일_양음력
		/// </summary>
		[Column("실제생일_양음력")]
		public string RealBirthday_SolarLunarCalendar { get; set; }
		/// <summary>
		/// 출국횟수코드
		/// </summary>
		[Column("출국횟수코드")]
		public string LeaveCountryTimesCode { get; set; }
		/// <summary>
		/// SMS수신여부
		/// </summary>
		[Column("SMS수신여부")]
		public string SMS_ReceptionOrNot { get; set; }
		/// <summary>
		/// DM수신여부
		/// </summary>
		[Column("DM수신여부")]
		public string DM_ReceptionOrNot { get; set; }
		/// <summary>
		/// 우편물수신지
		/// </summary>
		[Column("우편물수신지")]
		public string PostalMailReceptionPlace { get; set; }
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
		/// <summary>
		/// 회원유지기간
		/// </summary>
		[Column("회원유지기간")]
		public string MemberMaintainPeriod { get; set; }
		/// <summary>
		/// 파트너여행사동의날짜1
		/// </summary>
		[Column("파트너여행사동의날짜1")]
		public string PartnerTravelCompanyAgreeDate1 { get; set; }
		/// <summary>
		/// MT_NO
		/// </summary>
		[Column("MT_NO")]
		public string MT_NO { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// ptid
		/// </summary>
		[Column("ptid")]
		public int ptid { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 대륙
		/// </summary>
		[Column("대륙")]
		public int Continent { get; set; }
		/// <summary>
		/// 나라
		/// </summary>
		[Column("나라")]
		public int Country { get; set; }
		/// <summary>
		/// 도시
		/// </summary>
		[Column("도시")]
		public int City { get; set; }
		/// <summary>
		/// 참조번호
		/// </summary>
		[Column("참조번호")]
		public int ReferenceNumber { get; set; }
		/// <summary>
		/// 대륙명
		/// </summary>
		[Column("대륙명")]
		public string ContinentName { get; set; }
		/// <summary>
		/// 나라명
		/// </summary>
		[Column("나라명")]
		public string CountryName { get; set; }
		/// <summary>
		/// 도시명
		/// </summary>
		[Column("도시명")]
		public string CityName { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// ptid
		/// </summary>
		[Column("ptid")]
		public int ptid { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 참조번호
		/// </summary>
		[Column("참조번호")]
		public int ReferenceNumber { get; set; }
	}

	public class Result5 : IDbResult
	{
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
		/// 비밀번호
		/// </summary>
		[Column("비밀번호")]
		public string Password { get; set; }
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

	public class Result6 : IDbResult
	{
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
		/// 비밀번호
		/// </summary>
		[Column("비밀번호")]
		public string Password { get; set; }
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
		/// <summary>
		/// 전화
		/// </summary>
		[Column("전화")]
		public string Phone { get; set; }
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
		/// 메일수신
		/// </summary>
		[Column("메일수신")]
		public string MailReception { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 회사구분
		/// </summary>
		[Column("회사구분")]
		public string CompanyClassification { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Column("거래처코드")]
		public string CustomerCode { get; set; }
		/// <summary>
		/// 회사명
		/// </summary>
		[Column("회사명")]
		public string CompanyName { get; set; }
		/// <summary>
		/// 사업자번호
		/// </summary>
		[Column("사업자번호")]
		public string LicenseeNumber { get; set; }
		/// <summary>
		/// 대표자
		/// </summary>
		[Column("대표자")]
		public string Representative { get; set; }
		/// <summary>
		/// 회사우편번호
		/// </summary>
		[Column("회사우편번호")]
		public string CompanyZipCode { get; set; }
		/// <summary>
		/// 회사주소1
		/// </summary>
		[Column("회사주소1")]
		public string CompanyAddress1 { get; set; }
		/// <summary>
		/// 회사주소2
		/// </summary>
		[Column("회사주소2")]
		public string CompanyAddress2 { get; set; }
		/// <summary>
		/// 회사전화번호
		/// </summary>
		[Column("회사전화번호")]
		public string CompanyPhoneNumber { get; set; }
		/// <summary>
		/// 회사팩스번호
		/// </summary>
		[Column("회사팩스번호")]
		public string CompanyFaxNumber { get; set; }
		/// <summary>
		/// 회사상담메일
		/// </summary>
		[Column("회사상담메일")]
		public string CompanyConsultantMail { get; set; }
		/// <summary>
		/// 여권번호
		/// </summary>
		[Column("여권번호")]
		public string PassportNumber { get; set; }
		/// <summary>
		/// 여권만료일
		/// </summary>
		[Column("여권만료일")]
		public string PassportExpirationDate { get; set; }
		/// <summary>
		/// 미국비자번호
		/// </summary>
		[Column("미국비자번호")]
		public string AmericaVisaNumber { get; set; }
		/// <summary>
		/// 미국비자만료일
		/// </summary>
		[Column("미국비자만료일")]
		public string AmericaVisaExpirationDate { get; set; }
		/// <summary>
		/// 일본비자번호
		/// </summary>
		[Column("일본비자번호")]
		public string JapanVisaNumber { get; set; }
		/// <summary>
		/// 일본비자만료일
		/// </summary>
		[Column("일본비자만료일")]
		public string JapanVisaExpirationDate { get; set; }
		/// <summary>
		/// 생일
		/// </summary>
		[Column("생일")]
		public string Birthday { get; set; }
		/// <summary>
		/// 양음력
		/// </summary>
		[Column("양음력")]
		public string SolarLunarCalendar { get; set; }
		/// <summary>
		/// 결혼기념일
		/// </summary>
		[Column("결혼기념일")]
		public string WeddingAnniversaryDate { get; set; }
		/// <summary>
		/// 사이트코드
		/// </summary>
		[Column("사이트코드")]
		public int SiteCode { get; set; }
		/// <summary>
		/// 관계종류
		/// </summary>
		[Column("관계종류")]
		public string RelationshipType { get; set; }
		/// <summary>
		/// 직업구분
		/// </summary>
		[Column("직업구분")]
		public string JobClassification { get; set; }
		/// <summary>
		/// 상태15
		/// </summary>
		[Column("상태15")]
		public string State15 { get; set; }
		/// <summary>
		/// 우편물
		/// </summary>
		[Column("우편물")]
		public string PostalMail { get; set; }
		/// <summary>
		/// SMS
		/// </summary>
		[Column("SMS")]
		public string SMS { get; set; }
		/// <summary>
		/// 거주지역
		/// </summary>
		[Column("거주지역")]
		public string LivingRegion { get; set; }
		/// <summary>
		/// 여행경험지역
		/// </summary>
		[Column("여행경험지역")]
		public string TravelExperienceRegion { get; set; }
		/// <summary>
		/// 여행출발지
		/// </summary>
		[Column("여행출발지")]
		public string TravelDepartures { get; set; }
		/// <summary>
		/// 파트너여행사
		/// </summary>
		[Column("파트너여행사")]
		public int PartnerTravelCompany { get; set; }
		/// <summary>
		/// 파트너여행사명
		/// </summary>
		[Column("파트너여행사명")]
		public string PartnerTravelCompanyName { get; set; }
		/// <summary>
		/// 주소선택
		/// </summary>
		[Column("주소선택")]
		public string AddressSelect { get; set; }
		/// <summary>
		/// DI
		/// </summary>
		[Column("DI")]
		public string DI { get; set; }
		/// <summary>
		/// 아이핀인증여부
		/// </summary>
		[Column("아이핀인증여부")]
		public string IPINVerificationOrNot { get; set; }
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
		/// 통신사
		/// </summary>
		[Column("통신사")]
		public string TelecomCompany { get; set; }
		/// <summary>
		/// 실제생일
		/// </summary>
		[Column("실제생일")]
		public DateTime RealBirthday { get; set; }
		/// <summary>
		/// 실제생일_양음력
		/// </summary>
		[Column("실제생일_양음력")]
		public string RealBirthday_SolarLunarCalendar { get; set; }
		/// <summary>
		/// 출국횟수코드
		/// </summary>
		[Column("출국횟수코드")]
		public string LeaveCountryTimesCode { get; set; }
		/// <summary>
		/// SMS수신여부
		/// </summary>
		[Column("SMS수신여부")]
		public string SMS_ReceptionOrNot { get; set; }
		/// <summary>
		/// DM수신여부
		/// </summary>
		[Column("DM수신여부")]
		public string DM_ReceptionOrNot { get; set; }
		/// <summary>
		/// 우편물수신지
		/// </summary>
		[Column("우편물수신지")]
		public string PostalMailReceptionPlace { get; set; }
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
		/// <summary>
		/// 회원유지기간
		/// </summary>
		[Column("회원유지기간")]
		public string MemberMaintainPeriod { get; set; }
		/// <summary>
		/// 파트너여행사동의날짜
		/// </summary>
		[Column("파트너여행사동의날짜")]
		public string PartnerTravelCompanyAgreeDate { get; set; }
		/// <summary>
		/// MT_NO
		/// </summary>
		[Column("MT_NO")]
		public string MT_NO { get; set; }
	}
}