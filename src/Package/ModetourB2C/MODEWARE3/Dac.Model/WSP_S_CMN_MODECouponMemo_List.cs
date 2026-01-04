namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_모두쿠폰메모_리스트
/// </summary>
public class WSP_S_CMN_MODECouponMemo_List
{
	public const string SP_NAME = "WSP_S_CMN_모두쿠폰메모_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 모두쿠폰구분번호
		/// </summary>
		[Description("모두쿠폰구분번호")]
		public int MODECouponClassificationNumber { get; set; }
		/// <summary>
		/// 모두쿠폰구분번호리스트
		/// </summary>
		[Description("모두쿠폰구분번호리스트")]
		public string MODECouponClassificationNumberList { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 쿠폰번호
		/// </summary>
		[Column("쿠폰번호")]
		public string CouponNumber { get; set; }
		/// <summary>
		/// 발행일
		/// </summary>
		[Column("발행일")]
		public DateTime PublishDate { get; set; }
		/// <summary>
		/// 모두쿠폰구분번호
		/// </summary>
		[Column("모두쿠폰구분번호")]
		public int MODECouponClassificationNumber { get; set; }
		/// <summary>
		/// 쿠폰발행한예약번호
		/// </summary>
		[Column("쿠폰발행한예약번호")]
		public int CouponPublishedBookingNumber { get; set; }
		/// <summary>
		/// 쿠폰신청자아이디
		/// </summary>
		[Column("쿠폰신청자아이디")]
		public string CouponRequesterID { get; set; }
		/// <summary>
		/// 쿠폰신청자이름
		/// </summary>
		[Column("쿠폰신청자이름")]
		public string CouponRequesterName { get; set; }
		/// <summary>
		/// 등록IP
		/// </summary>
		[Column("등록IP")]
		public string RegisterIP { get; set; }
		/// <summary>
		/// 사용가능금액
		/// </summary>
		[Column("사용가능금액")]
		public string UsePossibleAmount { get; set; }
		/// <summary>
		/// 쿠폰금액
		/// </summary>
		[Column("쿠폰금액")]
		public long CouponAmount { get; set; }
		/// <summary>
		/// 사용가능여부
		/// </summary>
		[Column("사용가능여부")]
		public string UsePossibleOrNot { get; set; }
		/// <summary>
		/// 사용개시일
		/// </summary>
		[Column("사용개시일")]
		public DateTime UseReleaseDate { get; set; }
		/// <summary>
		/// 사용마감일
		/// </summary>
		[Column("사용마감일")]
		public DateTime UseEndDate { get; set; }
		/// <summary>
		/// 사용제한일
		/// </summary>
		[Column("사용제한일")]
		public string UseLimitDate { get; set; }
		/// <summary>
		/// 쿠폰사용가능한PTID
		/// </summary>
		[Column("쿠폰사용가능한PTID")]
		public int CouponUsable_PTID { get; set; }
		/// <summary>
		/// 쿠폰사용일
		/// </summary>
		[Column("쿠폰사용일")]
		public string CouponUseDate { get; set; }
		/// <summary>
		/// 쿠폰사용한예약번호
		/// </summary>
		[Column("쿠폰사용한예약번호")]
		public int CouponUsedReservationNumber { get; set; }
		/// <summary>
		/// 주의사항이미지경로
		/// </summary>
		[Column("주의사항이미지경로")]
		public string NoticesImageRoute { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Column("비고")]
		public string Note { get; set; }
		/// <summary>
		/// 분개번호
		/// </summary>
		[Column("분개번호")]
		public int DivertedNumber { get; set; }
		/// <summary>
		/// 모두쿠폰구분번호1
		/// </summary>
		[Column("모두쿠폰구분번호1")]
		public int ModetourCouponClassificationNumber1 { get; set; }
		/// <summary>
		/// 이벤트명
		/// </summary>
		[Column("이벤트명")]
		public string EventName { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Column("사용여부")]
		public string UseOrNot { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 시작일
		/// </summary>
		[Column("시작일")]
		public DateTime StartDate { get; set; }
		/// <summary>
		/// 종료일
		/// </summary>
		[Column("종료일")]
		public DateTime EndDate { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 직책
		/// </summary>
		[Column("직책")]
		public string Duty { get; set; }
		/// <summary>
		/// 회사명
		/// </summary>
		[Column("회사명")]
		public string CompanyName { get; set; }
		/// <summary>
		/// 생일
		/// </summary>
		[Column("생일")]
		public DateTime Birthday { get; set; }
		/// <summary>
		/// 양음력
		/// </summary>
		[Column("양음력")]
		public string SolarLunarCalendar { get; set; }
		/// <summary>
		/// 결혼기념일
		/// </summary>
		[Column("결혼기념일")]
		public DateTime WeddingAnniversaryDate { get; set; }
		/// <summary>
		/// 자녀수
		/// </summary>
		[Column("자녀수")]
		public byte ChildrenNumber { get; set; }
		/// <summary>
		/// 직업대분류코드
		/// </summary>
		[Column("직업대분류코드")]
		public string JobMajorClassificationCode { get; set; }
		/// <summary>
		/// 직업소분류코드
		/// </summary>
		[Column("직업소분류코드")]
		public string JobSubClassificationCode { get; set; }
		/// <summary>
		/// 집전화
		/// </summary>
		[Column("집전화")]
		public string HomePhone { get; set; }
		/// <summary>
		/// 회사전화
		/// </summary>
		[Column("회사전화")]
		public string CompanyPhone { get; set; }
		/// <summary>
		/// 내선
		/// </summary>
		[Column("내선")]
		public string Interphone { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 팩스
		/// </summary>
		[Column("팩스")]
		public string Fax { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 메신저
		/// </summary>
		[Column("메신저")]
		public string Messager { get; set; }
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
		/// 우편번호
		/// </summary>
		[Column("우편번호")]
		public string ZipCode { get; set; }
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
		/// 메일수신여부
		/// </summary>
		[Column("메일수신여부")]
		public string MailReceptionOrNot { get; set; }
		/// <summary>
		/// 신청일
		/// </summary>
		[Column("신청일")]
		public DateTime RequestDate { get; set; }
		/// <summary>
		/// 최근접속일
		/// </summary>
		[Column("최근접속일")]
		public DateTime RecentAccessDate { get; set; }
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
		/// 회사우편번호
		/// </summary>
		[Column("회사우편번호")]
		public string CompanyZipCode { get; set; }
		/// <summary>
		/// 회사대표자메일
		/// </summary>
		[Column("회사대표자메일")]
		public string CompanyRepresentativeMail { get; set; }
		/// <summary>
		/// 여권번호
		/// </summary>
		[Column("여권번호")]
		public string PassportNumber { get; set; }
		/// <summary>
		/// 여권만료일
		/// </summary>
		[Column("여권만료일")]
		public DateTime PassportExpirationDate { get; set; }
		/// <summary>
		/// 미국비자
		/// </summary>
		[Column("미국비자")]
		public string AmericaVisa { get; set; }
		/// <summary>
		/// 미국비자만료일
		/// </summary>
		[Column("미국비자만료일")]
		public DateTime AmericaVisaExpirationDate { get; set; }
		/// <summary>
		/// 일본비자
		/// </summary>
		[Column("일본비자")]
		public string JapanVisa { get; set; }
		/// <summary>
		/// 일본비자만료일
		/// </summary>
		[Column("일본비자만료일")]
		public DateTime JapanVisaExpirationDate { get; set; }
		/// <summary>
		/// 대표자
		/// </summary>
		[Column("대표자")]
		public string Representative { get; set; }
		/// <summary>
		/// 사업자번호
		/// </summary>
		[Column("사업자번호")]
		public string LicenseeNumber { get; set; }
		/// <summary>
		/// 여권종류
		/// </summary>
		[Column("여권종류")]
		public string PassportType { get; set; }
		/// <summary>
		/// 미국비자종류
		/// </summary>
		[Column("미국비자종류")]
		public string AmericaVisaType { get; set; }
		/// <summary>
		/// 일본비자종류
		/// </summary>
		[Column("일본비자종류")]
		public string JapanVisaType { get; set; }
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
		/// 여행경험지역
		/// </summary>
		[Column("여행경험지역")]
		public string TravelExperienceRegion { get; set; }
		/// <summary>
		/// 거주지역
		/// </summary>
		[Column("거주지역")]
		public string LivingRegion { get; set; }
		/// <summary>
		/// 주소선택
		/// </summary>
		[Column("주소선택")]
		public string AddressSelect { get; set; }
		/// <summary>
		/// 회사주소3
		/// </summary>
		[Column("회사주소3")]
		public string CompanyAddress3 { get; set; }
		/// <summary>
		/// 센드빌ID
		/// </summary>
		[Column("센드빌ID")]
		public string Sendbill_ID { get; set; }
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
		/// 탈퇴사유
		/// </summary>
		[Column("탈퇴사유")]
		public string CancelReason { get; set; }
		/// <summary>
		/// 탈퇴일
		/// </summary>
		[Column("탈퇴일")]
		public DateTime CancelDate { get; set; }
		/// <summary>
		/// 최근접속IP
		/// </summary>
		[Column("최근접속IP")]
		public string RecentAccess_IP { get; set; }
		/// <summary>
		/// 유입웹사이트
		/// </summary>
		[Column("유입웹사이트")]
		public int InflowWebsite { get; set; }
		/// <summary>
		/// 여권발급일
		/// </summary>
		[Column("여권발급일")]
		public DateTime PassportIssuanceDate { get; set; }
		/// <summary>
		/// 마일리지_KE
		/// </summary>
		[Column("마일리지_KE")]
		public string Mileage_KE { get; set; }
		/// <summary>
		/// 마일리지_OZ
		/// </summary>
		[Column("마일리지_OZ")]
		public string Mileage_OZ { get; set; }
		/// <summary>
		/// 비자
		/// </summary>
		[Column("비자")]
		public string Visa { get; set; }
		/// <summary>
		/// 멤버쉽약관동의여부
		/// </summary>
		[Column("멤버쉽약관동의여부")]
		public string MembershipTermsAgreeOrNot { get; set; }
		/// <summary>
		/// MT_NO
		/// </summary>
		[Column("MT_NO")]
		public string MT_NO { get; set; }
		/// <summary>
		/// 출국횟수코드
		/// </summary>
		[Column("출국횟수코드")]
		public string LeaveCountryTimesCode { get; set; }
		/// <summary>
		/// 전화수신여부
		/// </summary>
		[Column("전화수신여부")]
		public string PhoneReceptionOrNot { get; set; }
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
		/// 임시회원여부
		/// </summary>
		[Column("임시회원여부")]
		public string TemporaryMemberOrNot { get; set; }
		/// <summary>
		/// 통신사
		/// </summary>
		[Column("통신사")]
		public string TelecomCompany { get; set; }
		/// <summary>
		/// 외국인여부
		/// </summary>
		[Column("외국인여부")]
		public string ForeignerOrNot { get; set; }
		/// <summary>
		/// 회원인증일
		/// </summary>
		[Column("회원인증일")]
		public DateTime MemberVerificationDate { get; set; }
		/// <summary>
		/// 직판관계자
		/// </summary>
		[Column("직판관계자")]
		public int DirectSalesRelationshipPerson { get; set; }
		/// <summary>
		/// 직판유형
		/// </summary>
		[Column("직판유형")]
		public string DirectSalesType { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 직위
		/// </summary>
		[Column("직위")]
		public string Position { get; set; }
		/// <summary>
		/// 우편물수신지
		/// </summary>
		[Column("우편물수신지")]
		public string PostalMailReceptionPlace { get; set; }
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
		/// 법정대리인_성명
		/// </summary>
		[Column("법정대리인_성명")]
		public string LegalRepresentative_Name { get; set; }
		/// <summary>
		/// 법정대리인_관계
		/// </summary>
		[Column("법정대리인_관계")]
		public string LegalRepresentative_Relationship { get; set; }
		/// <summary>
		/// 법정대리인_생년월일
		/// </summary>
		[Column("법정대리인_생년월일")]
		public DateTime LegalRepresentative_BirthYearMonthDate { get; set; }
		/// <summary>
		/// 법정대리인_EMAIL
		/// </summary>
		[Column("법정대리인_EMAIL")]
		public string LegalRepresentative_EMAIL { get; set; }
		/// <summary>
		/// 법정대리인_휴대폰
		/// </summary>
		[Column("법정대리인_휴대폰")]
		public string LegalRepresentative_PhoneNumber { get; set; }
		/// <summary>
		/// 법정대리인_휴대폰_통신사
		/// </summary>
		[Column("법정대리인_휴대폰_통신사")]
		public string LegalRepresentative_PhoneNumber_Telecompany { get; set; }
		/// <summary>
		/// 본인인증_인증자구분
		/// </summary>
		[Column("본인인증_인증자구분")]
		public string SelfVerification_VerificationPersonClassification { get; set; }
		/// <summary>
		/// 본인인증_인증수단
		/// </summary>
		[Column("본인인증_인증수단")]
		public string SelfVerification_VerificationMethod { get; set; }
		/// <summary>
		/// 본인인증_인증정보
		/// </summary>
		[Column("본인인증_인증정보")]
		public string SelfVerification_VerificationInfo { get; set; }
		/// <summary>
		/// 본인인증_발행기관
		/// </summary>
		[Column("본인인증_발행기관")]
		public string SelfVerification_PublicationOffice { get; set; }
		/// <summary>
		/// 회원인증구분
		/// </summary>
		[Column("회원인증구분")]
		public string MemberVerificationClassification { get; set; }
		/// <summary>
		/// 주소X
		/// </summary>
		[Column("주소X")]
		public string Address_X { get; set; }
		/// <summary>
		/// 도로명주소여부
		/// </summary>
		[Column("도로명주소여부")]
		public string StreetNameAddressOrNot { get; set; }
		/// <summary>
		/// 직판부서
		/// </summary>
		[Column("직판부서")]
		public int DirectSalesDepartment { get; set; }
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
		/// 멤버쉽약관동의일
		/// </summary>
		[Column("멤버쉽약관동의일")]
		public DateTime MembershipTermsAgreeDate { get; set; }
		/// <summary>
		/// 멤버쉽_온라인약관동의
		/// </summary>
		[Column("멤버쉽_온라인약관동의")]
		public string Membership_OnlineTermsAndConditionsAgreement { get; set; }
		/// <summary>
		/// 멤버쉽_온라인_개인정보수집동의여부
		/// </summary>
		[Column("멤버쉽_온라인_개인정보수집동의여부")]
		public string Membership_Online_PersonalInfoCollectionAgreementOrNot { get; set; }
		/// <summary>
		/// 멤버쉽_온라인_제3자제공동의여부
		/// </summary>
		[Column("멤버쉽_온라인_제3자제공동의여부")]
		public string Membership_Online_ThirdPartyProvisionAgreementOrNot { get; set; }
		/// <summary>
		/// 멤버쉽_온라인_개인정보위탁동의여부
		/// </summary>
		[Column("멤버쉽_온라인_개인정보위탁동의여부")]
		public string Membership_Online_PersonalInfoConsignmentAgreementOrNot { get; set; }
		/// <summary>
		/// 멤버쉽동의구분
		/// </summary>
		[Column("멤버쉽동의구분")]
		public string MembershipAgreementClassification { get; set; }
		/// <summary>
		/// 휴면고지여부
		/// </summary>
		[Column("휴면고지여부")]
		public string InactiveNoticeOrNot { get; set; }
		/// <summary>
		/// 휴면고지일
		/// </summary>
		[Column("휴면고지일")]
		public DateTime InactiveNoticeDate { get; set; }
		/// <summary>
		/// 마케팅활용
		/// </summary>
		[Column("마케팅활용")]
		public string MarketingUse { get; set; }
		/// <summary>
		/// ENC_여권번호
		/// </summary>
		[Column("ENC_여권번호")]
		public byte[] ENC_PassportNumber { get; set; }
		/// <summary>
		/// 법인회원
		/// </summary>
		[Column("법인회원")]
		public string CorporationMember { get; set; }
		/// <summary>
		/// 휴대폰비교
		/// </summary>
		[Column("휴대폰비교")]
		public string PhoneNumberComparison { get; set; }
		/// <summary>
		/// SMS수신여부_변경일자
		/// </summary>
		[Column("SMS수신여부_변경일자")]
		public DateTime SMSReceiveMessageOrNot_ChangeDate { get; set; }
		/// <summary>
		/// 메일수신여부_변경일자
		/// </summary>
		[Column("메일수신여부_변경일자")]
		public DateTime MailReceiveMessageOrNot_ChangeDate { get; set; }
		/// <summary>
		/// 전화수신여부_변경일자
		/// </summary>
		[Column("전화수신여부_변경일자")]
		public DateTime PhoneCallReceiveMessageOrNot_ChangeDate { get; set; }
		/// <summary>
		/// DM수신여부_변경일자
		/// </summary>
		[Column("DM수신여부_변경일자")]
		public DateTime DM_ReceiveMessageOrNot_ChangeDate { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 주문구분코드
		/// </summary>
		[Column("주문구분코드")]
		public string OrderClassificationCode { get; set; }
		/// <summary>
		/// 주문일
		/// </summary>
		[Column("주문일")]
		public DateTime OrderDate { get; set; }
		/// <summary>
		/// GROSS
		/// </summary>
		[Column("GROSS")]
		public long GROSS { get; set; }
		/// <summary>
		/// COMM
		/// </summary>
		[Column("COMM")]
		public long COMM { get; set; }
		/// <summary>
		/// VAT
		/// </summary>
		[Column("VAT")]
		public long VAT { get; set; }
		/// <summary>
		/// CHARGE
		/// </summary>
		[Column("CHARGE")]
		public long CHARGE { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// DISPLAY차액
		/// </summary>
		[Column("DISPLAY차액")]
		public long DISPLAY_Difference { get; set; }
		/// <summary>
		/// 커미션선출금
		/// </summary>
		[Column("커미션선출금")]
		public string CommissionPreWithdrawal { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 취소일
		/// </summary>
		[Column("취소일")]
		public DateTime CancelDate2 { get; set; }
		/// <summary>
		/// 취소자
		/// </summary>
		[Column("취소자")]
		public int CancelPerson { get; set; }
		/// <summary>
		/// 미수기준일
		/// </summary>
		[Column("미수기준일")]
		public DateTime OutstandingStandardDate { get; set; }
		/// <summary>
		/// 신청금입금일
		/// </summary>
		[Column("신청금입금일")]
		public DateTime RequestMoneyDepositDate { get; set; }
		/// <summary>
		/// 계산서발행일
		/// </summary>
		[Column("계산서발행일")]
		public DateTime BillPublicationDate { get; set; }
		/// <summary>
		/// BP예약
		/// </summary>
		[Column("BP예약")]
		public string BP_Booking { get; set; }
		/// <summary>
		/// 티켓원천징수액
		/// </summary>
		[Column("티켓원천징수액")]
		public long TicketWithholdingTaxAmount { get; set; }
		/// <summary>
		/// 입금가
		/// </summary>
		[Column("입금가")]
		public long DepositPrice { get; set; }
		/// <summary>
		/// 부가세미수기준일
		/// </summary>
		[Column("부가세미수기준일")]
		public DateTime AdditionalTaxOutstandingStandardDate { get; set; }
		/// <summary>
		/// 출발후입금가능
		/// </summary>
		[Column("출발후입금가능")]
		public string AfterDepartureDepositPossible { get; set; }
		/// <summary>
		/// 콜센터예약
		/// </summary>
		[Column("콜센터예약")]
		public string CallCenterBooking { get; set; }
		/// <summary>
		/// 발권수수료
		/// </summary>
		[Column("발권수수료")]
		public long TicketIssuanceFee { get; set; }
		/// <summary>
		/// 미팅간소화
		/// </summary>
		[Column("미팅간소화")]
		public string MeetingSimplify { get; set; }
		/// <summary>
		/// 빌링미반영CASH
		/// </summary>
		[Column("빌링미반영CASH")]
		public long BillingUnreflect_CASH { get; set; }
		/// <summary>
		/// 상품권환불대상
		/// </summary>
		[Column("상품권환불대상")]
		public string VoucherRefundObject { get; set; }
		/// <summary>
		/// 가상계좌번호
		/// </summary>
		[Column("가상계좌번호")]
		public string VirtualAccountNumber { get; set; }
		/// <summary>
		/// 가상계좌구분
		/// </summary>
		[Column("가상계좌구분")]
		public string VirtualAccountClassification { get; set; }
		/// <summary>
		/// 현금영수증_발행금액
		/// </summary>
		[Column("현금영수증_발행금액")]
		public long CashReceipt_PublicationAmount { get; set; }
		/// <summary>
		/// 현금영수증_자진발급액
		/// </summary>
		[Column("현금영수증_자진발급액")]
		public long CashReceipt_VoluntaryIssuanceAmount { get; set; }
		/// <summary>
		/// 현금영수증_잔액
		/// </summary>
		[Column("현금영수증_잔액")]
		public long CashReceipt_RemainingAmount { get; set; }
		/// <summary>
		/// 할인금액
		/// </summary>
		[Column("할인금액")]
		public long DiscountAmount { get; set; }
		/// <summary>
		/// 수수료
		/// </summary>
		[Column("수수료")]
		public long Fee { get; set; }
		/// <summary>
		/// 티켓지원금여부
		/// </summary>
		[Column("티켓지원금여부")]
		public string TicketSupportAmountOrNot { get; set; }
		/// <summary>
		/// 통합VI
		/// </summary>
		[Column("통합VI")]
		public int Integration_VI { get; set; }
		/// <summary>
		/// 총액대비커미션여부
		/// </summary>
		[Column("총액대비커미션여부")]
		public string TotalAmountPrepareCommissionOrNot { get; set; }
		/// <summary>
		/// 커미션_VAT포함여부
		/// </summary>
		[Column("커미션_VAT포함여부")]
		public string Commission_VAT_IncludedOrNot { get; set; }
		/// <summary>
		/// 완납입금일
		/// </summary>
		[Column("완납입금일")]
		public DateTime FullPaymentDepositDate { get; set; }
		/// <summary>
		/// 서비스금액_영업수익
		/// </summary>
		[Column("서비스금액_영업수익")]
		public long ServiceAmount_BusinessProfit { get; set; }
	}
}