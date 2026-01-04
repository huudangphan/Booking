namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_2020_거래처
/// </summary>
public class USP_S_2020_Customer
{
	public const string SP_NAME = "USP_S_2020_거래처";

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Column("웹사이트번호")]
		public int WebSiteNumber { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// BP여부
		/// </summary>
		[Column("BP여부")]
		public string BP_OrNot { get; set; }
		/// <summary>
		/// 파일타입
		/// </summary>
		[Column("파일타입")]
		public string FileType { get; set; }
		/// <summary>
		/// 결제수단
		/// </summary>
		[Column("결제수단")]
		public string PaymentMethod { get; set; }
		/// <summary>
		/// 법인명
		/// </summary>
		[Column("법인명")]
		public string CorporationName { get; set; }
		/// <summary>
		/// 거래처명
		/// </summary>
		[Column("거래처명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 담당사원명
		/// </summary>
		[Column("담당사원명")]
		public string ResponsibilityStaffName { get; set; }
		/// <summary>
		/// 담당사원번호
		/// </summary>
		[Column("담당사원번호")]
		public int ResponsibilityStaffNumber { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Column("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 모두웨어등록일
		/// </summary>
		[Column("모두웨어등록일")]
		public DateTime ModeWareRegisterDate { get; set; }
		/// <summary>
		/// 리뉴얼등록여부
		/// </summary>
		[Column("리뉴얼등록여부")]
		public string RenewalRegisterOrNot { get; set; }
		/// <summary>
		/// 웹사이트
		/// </summary>
		[Column("웹사이트")]
		public string WebSite { get; set; }
		/// <summary>
		/// 어드민인덱스
		/// </summary>
		[Column("어드민인덱스")]
		public int AdminIndex { get; set; }
		/// <summary>
		/// 그룹IDX
		/// </summary>
		[Column("그룹IDX")]
		public int Group_IDX { get; set; }
		/// <summary>
		/// 타입구분
		/// </summary>
		[Column("타입구분")]
		public string TypeClassification { get; set; }
		/// <summary>
		/// 서비스구분
		/// </summary>
		[Column("서비스구분")]
		public string ServiceClassification { get; set; }
		/// <summary>
		/// 보안구분
		/// </summary>
		[Column("보안구분")]
		public string SecurityClassification { get; set; }
		/// <summary>
		/// 사이트이름
		/// </summary>
		[Column("사이트이름")]
		public string SiteName { get; set; }
		/// <summary>
		/// 사이트도메인명
		/// </summary>
		[Column("사이트도메인명")]
		public string SiteDomainName { get; set; }
		/// <summary>
		/// 사이트코드
		/// </summary>
		[Column("사이트코드")]
		public int SiteCode { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Column("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 담당자직원코드
		/// </summary>
		[Column("담당자직원코드")]
		public int ManagerEmployeeCode { get; set; }
		/// <summary>
		/// xml코드
		/// </summary>
		[Column("xml코드")]
		public string XML_Code { get; set; }
		/// <summary>
		/// iFRAME타입
		/// </summary>
		[Column("iFRAME타입")]
		public string IFRAME_Type { get; set; }
		/// <summary>
		/// 태그IDX
		/// </summary>
		[Column("태그IDX")]
		public int Tag_IDX { get; set; }
		/// <summary>
		/// 결제가능유무
		/// </summary>
		[Column("결제가능유무")]
		public string PaymentPossibleOrNot { get; set; }
		/// <summary>
		/// 상태
		/// </summary>
		[Column("상태")]
		public string State { get; set; }
		/// <summary>
		/// 서비스서버IP
		/// </summary>
		[Column("서비스서버IP")]
		public string ServiceServerIP { get; set; }
		/// <summary>
		/// 사용자PTID
		/// </summary>
		[Column("사용자PTID")]
		public int UserPTID { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 수정일
		/// </summary>
		[Column("수정일")]
		public DateTime EditionDate { get; set; }
		/// <summary>
		/// TEST데이터생성일
		/// </summary>
		[Column("TEST데이터생성일")]
		public DateTime TEST_DataCreationDate { get; set; }
		/// <summary>
		/// SVC데이터생성일
		/// </summary>
		[Column("SVC데이터생성일")]
		public DateTime SVC_DataCreationDate { get; set; }
		/// <summary>
		/// PC주소
		/// </summary>
		[Column("PC주소")]
		public string PC_Address { get; set; }
		/// <summary>
		/// MOBILE주소
		/// </summary>
		[Column("MOBILE주소")]
		public string MOBILE_Address { get; set; }
		/// <summary>
		/// SNS사용여부
		/// </summary>
		[Column("SNS사용여부")]
		public string SNS_UseOrNot { get; set; }
		/// <summary>
		/// 버튼숨김여부
		/// </summary>
		[Column("버튼숨김여부")]
		public string ButtonHideOrNot { get; set; }
		/// <summary>
		/// 하단사용여부
		/// </summary>
		[Column("하단사용여부")]
		public string BottomUseOrNot { get; set; }
		/// <summary>
		/// API사용여부
		/// </summary>
		[Column("API사용여부")]
		public string API_UseOrNot { get; set; }
		/// <summary>
		/// 페이지새창유무
		/// </summary>
		[Column("페이지새창유무")]
		public string PageNewWindowOrNot { get; set; }
		/// <summary>
		/// 분기처리유무
		/// </summary>
		[Column("분기처리유무")]
		public string DivertedHandleOrNot { get; set; }
		/// <summary>
		/// 거래처종류
		/// </summary>
		[Column("거래처종류")]
		public string CustomerType { get; set; }
		/// <summary>
		/// 사용
		/// </summary>
		[Column("사용")]
		public string Use { get; set; }
		/// <summary>
		/// 키워드광고
		/// </summary>
		[Column("키워드광고")]
		public string KeywordAdvertisement { get; set; }
		/// <summary>
		/// 온라인BP_광고집행
		/// </summary>
		[Column("온라인BP_광고집행")]
		public string Online_BP_AdvertisementExecution { get; set; }
		/// <summary>
		/// 홈페이지주소
		/// </summary>
		[Column("홈페이지주소")]
		public string HomePageAddress { get; set; }
		/// <summary>
		/// 홈페이지비고
		/// </summary>
		[Column("홈페이지비고")]
		public string HomePageNote { get; set; }
		/// <summary>
		/// 홈페이지주소_모바일
		/// </summary>
		[Column("홈페이지주소_모바일")]
		public string HomePageAddress_Mobile { get; set; }
		/// <summary>
		/// 그룹메모
		/// </summary>
		[Column("그룹메모")]
		public string GroupMemo { get; set; }
		/// <summary>
		/// 그룹상태
		/// </summary>
		[Column("그룹상태")]
		public string GroupState { get; set; }
		/// <summary>
		/// 구글공유키
		/// </summary>
		[Column("구글공유키")]
		public string GoogleSharingKey { get; set; }
		/// <summary>
		/// 어제부터현재예약건
		/// </summary>
		[Column("어제부터현재예약건")]
		public int YesterdayToTodayBookings { get; set; }
		/// <summary>
		/// 거래중지유형
		/// </summary>
		[Column("거래중지유형")]
		public string TransactionStopType { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Column("사용여부")]
		public string UseOrNot { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 시작
		/// </summary>
		[Column("시작")]
		public DateTime Start { get; set; }
		/// <summary>
		/// 끝
		/// </summary>
		[Column("끝")]
		public DateTime End { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 거래처종류
		/// </summary>
		[Column("거래처종류")]
		public string CustomerType { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 대표자
		/// </summary>
		[Column("대표자")]
		public string Representative { get; set; }
		/// <summary>
		/// 업태
		/// </summary>
		[Column("업태")]
		public string BusinessState { get; set; }
		/// <summary>
		/// 종목
		/// </summary>
		[Column("종목")]
		public string Event { get; set; }
		/// <summary>
		/// 내부결제가능
		/// </summary>
		[Column("내부결제가능")]
		public string InternalPaymentPossible { get; set; }
		/// <summary>
		/// 결제수수료
		/// </summary>
		[Column("결제수수료")]
		public decimal PaymentFee { get; set; }
		/// <summary>
		/// BP
		/// </summary>
		[Column("BP")]
		public string BP { get; set; }
		/// <summary>
		/// 미수유예
		/// </summary>
		[Column("미수유예")]
		public string UnpayedDelay { get; set; }
		/// <summary>
		/// 미수유예기간
		/// </summary>
		[Column("미수유예기간")]
		public byte UnpayedDelayPeriod { get; set; }
		/// <summary>
		/// 미수유예단위
		/// </summary>
		[Column("미수유예단위")]
		public string UnpayedDelayUnit { get; set; }
		/// <summary>
		/// 분류
		/// </summary>
		[Column("분류")]
		public string Classification { get; set; }
		/// <summary>
		/// 분류2
		/// </summary>
		[Column("분류2")]
		public string Classification2 { get; set; }
		/// <summary>
		/// BP신청일
		/// </summary>
		[Column("BP신청일")]
		public DateTime BP_RequestDate { get; set; }
		/// <summary>
		/// 오버라이딩기준
		/// </summary>
		[Column("오버라이딩기준")]
		public string OverridingStandard { get; set; }
		/// <summary>
		/// 보증보험증권번호
		/// </summary>
		[Column("보증보험증권번호")]
		public string GuaranteeInsurancePolicyNumber { get; set; }
		/// <summary>
		/// 지급보증만료일
		/// </summary>
		[Column("지급보증만료일")]
		public DateTime PaymentGuaranteeExpirationDate { get; set; }
		/// <summary>
		/// BP등급
		/// </summary>
		[Column("BP등급")]
		public string BP_Class { get; set; }
		/// <summary>
		/// 계약조건기준월
		/// </summary>
		[Column("계약조건기준월")]
		public byte ContractConditionStandardMonth { get; set; }
		/// <summary>
		/// 계약조건기준매출
		/// </summary>
		[Column("계약조건기준매출")]
		public long ContractConditionStandardSales { get; set; }
		/// <summary>
		/// 현지연락처
		/// </summary>
		[Column("현지연락처")]
		public string LocalContact { get; set; }
		/// <summary>
		/// 사업자등록증확인
		/// </summary>
		[Column("사업자등록증확인")]
		public string BusinessLicenseConfirm { get; set; }
		/// <summary>
		/// 거래중지유형
		/// </summary>
		[Column("거래중지유형")]
		public string TransactionStopType { get; set; }
		/// <summary>
		/// 거래중지사유
		/// </summary>
		[Column("거래중지사유")]
		public string TransactionStopReason { get; set; }
		/// <summary>
		/// 사업자등록증확인2
		/// </summary>
		[Column("사업자등록증확인2")]
		public string BusinessLicenseConfirm2 { get; set; }
		/// <summary>
		/// 제휴신청일
		/// </summary>
		[Column("제휴신청일")]
		public DateTime AffiliateRequestDate { get; set; }
		/// <summary>
		/// 홈페이지주소
		/// </summary>
		[Column("홈페이지주소")]
		public string HomePageAddress { get; set; }
		/// <summary>
		/// 홈페이지비고
		/// </summary>
		[Column("홈페이지비고")]
		public string HomePageNote { get; set; }
		/// <summary>
		/// 영업보증보험사본
		/// </summary>
		[Column("영업보증보험사본")]
		public string BusinessGuaranteeInsuranceCopy { get; set; }
		/// <summary>
		/// 지급보증보험원본
		/// </summary>
		[Column("지급보증보험원본")]
		public string PaymentGuaranteeInsuranceOriginal { get; set; }
		/// <summary>
		/// 옥외광고표시허가증
		/// </summary>
		[Column("옥외광고표시허가증")]
		public string OutdoorAdvertisementDisplayPermission { get; set; }
		/// <summary>
		/// 인감증명서사본
		/// </summary>
		[Column("인감증명서사본")]
		public string AuthCertificationCopy { get; set; }
		/// <summary>
		/// 사업자등록증사본
		/// </summary>
		[Column("사업자등록증사본")]
		public string BusinessLicenseCopy { get; set; }
		/// <summary>
		/// 관광사업자등록증사본
		/// </summary>
		[Column("관광사업자등록증사본")]
		public string SightseeingBusinessLicenseCopy { get; set; }
		/// <summary>
		/// 등기부등본
		/// </summary>
		[Column("등기부등본")]
		public string RegisterbookCopy { get; set; }
		/// <summary>
		/// 임대차계약서
		/// </summary>
		[Column("임대차계약서")]
		public string RentalContract { get; set; }
		/// <summary>
		/// 사이트종류1
		/// </summary>
		[Column("사이트종류1")]
		public string SiteType1 { get; set; }
		/// <summary>
		/// 사이트종류2
		/// </summary>
		[Column("사이트종류2")]
		public string SiteType2 { get; set; }
		/// <summary>
		/// 키워드광고
		/// </summary>
		[Column("키워드광고")]
		public string KeywordAdvertisement { get; set; }
		/// <summary>
		/// BSP
		/// </summary>
		[Column("BSP")]
		public string BSP { get; set; }
		/// <summary>
		/// MP
		/// </summary>
		[Column("MP")]
		public string MP { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Column("비고")]
		public string Note { get; set; }
		/// <summary>
		/// 부가세미수유예
		/// </summary>
		[Column("부가세미수유예")]
		public string SurtaxUnpayedDelay { get; set; }
		/// <summary>
		/// 부가세미수유예기간
		/// </summary>
		[Column("부가세미수유예기간")]
		public byte SurtaxUnpayedDelayPeriod { get; set; }
		/// <summary>
		/// 부가세미수유예단위
		/// </summary>
		[Column("부가세미수유예단위")]
		public string SurtaxUnpayedDelayUnit { get; set; }
		/// <summary>
		/// 거래처분류
		/// </summary>
		[Column("거래처분류")]
		public string CustomerClassification { get; set; }
		/// <summary>
		/// 미수유예분류
		/// </summary>
		[Column("미수유예분류")]
		public string UnpayedDelayClassification { get; set; }
		/// <summary>
		/// 거래처비고
		/// </summary>
		[Column("거래처비고")]
		public string CustomerNote { get; set; }
		/// <summary>
		/// 인보이스미첨부가능
		/// </summary>
		[Column("인보이스미첨부가능")]
		public string InvoiceNotAttachPossible { get; set; }
		/// <summary>
		/// 콜센터예약우선배분
		/// </summary>
		[Column("콜센터예약우선배분")]
		public string CallCenterBookingPriorityDistribution { get; set; }
		/// <summary>
		/// 콜센터배분유형
		/// </summary>
		[Column("콜센터배분유형")]
		public string CallCenterDistributionType { get; set; }
		/// <summary>
		/// BP거래처명
		/// </summary>
		[Column("BP거래처명")]
		public string BP_CustomerName { get; set; }
		/// <summary>
		/// 전자세금계산서사용
		/// </summary>
		[Column("전자세금계산서사용")]
		public string DigitalTaxInvoiceUse { get; set; }
		/// <summary>
		/// 회계담당자
		/// </summary>
		[Column("회계담당자")]
		public string AccountantManager { get; set; }
		/// <summary>
		/// 회계담당연락처
		/// </summary>
		[Column("회계담당연락처")]
		public string AccountantResponsibilityContact { get; set; }
		/// <summary>
		/// 회계담당이메일
		/// </summary>
		[Column("회계담당이메일")]
		public string AccountantResponsibilityEmail { get; set; }
		/// <summary>
		/// 회계팀체크
		/// </summary>
		[Column("회계팀체크")]
		public string AccountantTeamCheck { get; set; }
		/// <summary>
		/// VI지급대상여부
		/// </summary>
		[Column("VI지급대상여부")]
		public string VI_PaymentCandidateOrNot { get; set; }
		/// <summary>
		/// 계약서이름
		/// </summary>
		[Column("계약서이름")]
		public string ContractName { get; set; }
		/// <summary>
		/// 계약비고사항
		/// </summary>
		[Column("계약비고사항")]
		public string ContractNote { get; set; }
		/// <summary>
		/// VI모거래처번호
		/// </summary>
		[Column("VI모거래처번호")]
		public int VI_UnknownNumber { get; set; }
		/// <summary>
		/// TOPASQ
		/// </summary>
		[Column("TOPASQ")]
		public string TOPASQ { get; set; }
		/// <summary>
		/// VICRS사용율제외여부
		/// </summary>
		[Column("VICRS사용율제외여부")]
		public string VICRS_UseRateExemptionOrNot { get; set; }
		/// <summary>
		/// 컨텐츠사용여부
		/// </summary>
		[Column("컨텐츠사용여부")]
		public string ContentUseOrNot { get; set; }
		/// <summary>
		/// 홈페이지사용계약여부
		/// </summary>
		[Column("홈페이지사용계약여부")]
		public string HomePageUseContractOrNot { get; set; }
		/// <summary>
		/// 온라인BP계약여부
		/// </summary>
		[Column("온라인BP계약여부")]
		public string Online_BP_ContractOrNot { get; set; }
		/// <summary>
		/// 키워드광고계약여부
		/// </summary>
		[Column("키워드광고계약여부")]
		public string KeywordAdvertisementContractOrNot { get; set; }
		/// <summary>
		/// 기안번호
		/// </summary>
		[Column("기안번호")]
		public string DraftNumber { get; set; }
		/// <summary>
		/// 기준커미션동기화여부
		/// </summary>
		[Column("기준커미션동기화여부")]
		public string StandardCommissionSynchronizationOrNot { get; set; }
		/// <summary>
		/// 모두투어Q
		/// </summary>
		[Column("모두투어Q")]
		public string MODETOUR_Q { get; set; }
		/// <summary>
		/// ATRTASF_토파스
		/// </summary>
		[Column("ATRTASF_토파스")]
		public string ATRTASF_TOPAS { get; set; }
		/// <summary>
		/// ATRTASF_아바쿠스
		/// </summary>
		[Column("ATRTASF_아바쿠스")]
		public string ATRTASF_Abaqus { get; set; }
		/// <summary>
		/// ATRTASF_갈릴레오
		/// </summary>
		[Column("ATRTASF_갈릴레오")]
		public string ATRTASF_Galileo { get; set; }
		/// <summary>
		/// ATRTASH_월드스팬
		/// </summary>
		[Column("ATRTASH_월드스팬")]
		public string ATRTASH_Worldspan { get; set; }
		/// <summary>
		/// 해피콜마일리지제외여부
		/// </summary>
		[Column("해피콜마일리지제외여부")]
		public string HappyCallMileageExemptionOrNot { get; set; }
		/// <summary>
		/// BTMS사용유무
		/// </summary>
		[Column("BTMS사용유무")]
		public string BTMS_UseOrNot { get; set; }
		/// <summary>
		/// BTMSID
		/// </summary>
		[Column("BTMSID")]
		public string BTMSID { get; set; }
		/// <summary>
		/// 마일리지카드약정유무
		/// </summary>
		[Column("마일리지카드약정유무")]
		public string MileageCardContractOrNot { get; set; }
		/// <summary>
		/// 마일리지카드약정등록자
		/// </summary>
		[Column("마일리지카드약정등록자")]
		public int MileageCardContractRegisterer { get; set; }
		/// <summary>
		/// 마일리지카드약정등록일
		/// </summary>
		[Column("마일리지카드약정등록일")]
		public DateTime MileageCardContractRegisterDate { get; set; }
		/// <summary>
		/// 발권담당자
		/// </summary>
		[Column("발권담당자")]
		public int TicketIssuanceManager { get; set; }
		/// <summary>
		/// 법인통장사본유무
		/// </summary>
		[Column("법인통장사본유무")]
		public string CorporationBankbookCopyOrNot { get; set; }
		/// <summary>
		/// 간판미설치기안여부
		/// </summary>
		[Column("간판미설치기안여부")]
		public string SignNotInstalledDraftOrNot { get; set; }
		/// <summary>
		/// 대외모객제외여부
		/// </summary>
		[Column("대외모객제외여부")]
		public string InternationalAudienceExemptionOrNot { get; set; }
		/// <summary>
		/// ABACUSPCC
		/// </summary>
		[Column("ABACUSPCC")]
		public string ABACUSPCC { get; set; }
		/// <summary>
		/// ABACUSDK
		/// </summary>
		[Column("ABACUSDK")]
		public string ABACUSDK { get; set; }
		/// <summary>
		/// BPURL
		/// </summary>
		[Column("BPURL")]
		public string BPURL { get; set; }
		/// <summary>
		/// 영업보증보험만료일
		/// </summary>
		[Column("영업보증보험만료일")]
		public DateTime BusinessGuaranteeInsuranceExpirationDate { get; set; }
		/// <summary>
		/// 여행업구분
		/// </summary>
		[Column("여행업구분")]
		public string TravelBusinessClassification { get; set; }
		/// <summary>
		/// 거래처직인
		/// </summary>
		[Column("거래처직인")]
		public string CustomerSeal { get; set; }
		/// <summary>
		/// 거래처직인_등록일
		/// </summary>
		[Column("거래처직인_등록일")]
		public DateTime CustomerSeal_RegistrationDate { get; set; }
		/// <summary>
		/// 거래처직인_수정일
		/// </summary>
		[Column("거래처직인_수정일")]
		public DateTime CustomerSeal_EditionDate { get; set; }
		/// <summary>
		/// BP_금융종합보험
		/// </summary>
		[Column("BP_금융종합보험")]
		public string BP_FinancialComprehensiveInsurance { get; set; }
		/// <summary>
		/// BP_명함
		/// </summary>
		[Column("BP_명함")]
		public string BP_NameCard { get; set; }
		/// <summary>
		/// BP_유니폼
		/// </summary>
		[Column("BP_유니폼")]
		public string BP_Uniform { get; set; }
		/// <summary>
		/// BP_링고
		/// </summary>
		[Column("BP_링고")]
		public string BP_Lingo { get; set; }
		/// <summary>
		/// BP_안내멘트
		/// </summary>
		[Column("BP_안내멘트")]
		public string BP_InfoComment { get; set; }
		/// <summary>
		/// BP_내부간판
		/// </summary>
		[Column("BP_내부간판")]
		public string BP_InternalSignboard { get; set; }
		/// <summary>
		/// BP_외부간판
		/// </summary>
		[Column("BP_외부간판")]
		public string BP_ExternalSignboard { get; set; }
		/// <summary>
		/// BP_측면간판
		/// </summary>
		[Column("BP_측면간판")]
		public string BP_SideSignboard { get; set; }
		/// <summary>
		/// BP_내부간판_파일명
		/// </summary>
		[Column("BP_내부간판_파일명")]
		public string BP_InternalSignboard_FileName { get; set; }
		/// <summary>
		/// BP_외부간판_파일명
		/// </summary>
		[Column("BP_외부간판_파일명")]
		public string BP_ExternalSignboard_FileName { get; set; }
		/// <summary>
		/// BP_측면간판_파일명
		/// </summary>
		[Column("BP_측면간판_파일명")]
		public string BP_SideSignboard_FileName { get; set; }
		/// <summary>
		/// BP_링고_불가사유
		/// </summary>
		[Column("BP_링고_불가사유")]
		public string BP_Lingo_ImpossibleReason { get; set; }
		/// <summary>
		/// VI_CRS노출여부
		/// </summary>
		[Column("VI_CRS노출여부")]
		public string VI_CRS_DisplayOrNot { get; set; }
		/// <summary>
		/// 업무_순위정렬
		/// </summary>
		[Column("업무_순위정렬")]
		public int Work_RankingSorting { get; set; }
		/// <summary>
		/// 상용항공_담당자
		/// </summary>
		[Column("상용항공_담당자")]
		public string CommercialFlight_Manager { get; set; }
		/// <summary>
		/// 상용항공_휴대폰
		/// </summary>
		[Column("상용항공_휴대폰")]
		public string CommercialFlight_Phone { get; set; }
		/// <summary>
		/// 상용항공_이메일
		/// </summary>
		[Column("상용항공_이메일")]
		public string CommercialFlight_Email { get; set; }
		/// <summary>
		/// 상용항공_FAX
		/// </summary>
		[Column("상용항공_FAX")]
		public string CommercialFlight_FAX { get; set; }
		/// <summary>
		/// 상용항공_항공지식
		/// </summary>
		[Column("상용항공_항공지식")]
		public string CommercialFlight_FlightKnowledge { get; set; }
		/// <summary>
		/// GDS_토파스
		/// </summary>
		[Column("GDS_토파스")]
		public string GDS_TOPAS { get; set; }
		/// <summary>
		/// GDS_아바쿠스
		/// </summary>
		[Column("GDS_아바쿠스")]
		public string GDS_Abaqus { get; set; }
		/// <summary>
		/// GDS_갈릴레오
		/// </summary>
		[Column("GDS_갈릴레오")]
		public string GDS_Galileo { get; set; }
		/// <summary>
		/// GDS_월드스팬
		/// </summary>
		[Column("GDS_월드스팬")]
		public string GDS_Worldspan { get; set; }
		/// <summary>
		/// 상용항공_원천징수대상자
		/// </summary>
		[Column("상용항공_원천징수대상자")]
		public string CommercialFlight_WithholdingTaxCandidate { get; set; }
		/// <summary>
		/// 상용항공_은행
		/// </summary>
		[Column("상용항공_은행")]
		public string CommercialFlight_Bank { get; set; }
		/// <summary>
		/// 상용항공_계좌번호
		/// </summary>
		[Column("상용항공_계좌번호")]
		public string CommercialFlight_AccountNumber { get; set; }
		/// <summary>
		/// 상용항공_토파스Q
		/// </summary>
		[Column("상용항공_토파스Q")]
		public string CommercialFlight_TOPAS_Q { get; set; }
		/// <summary>
		/// 상용항공_ABS사용자
		/// </summary>
		[Column("상용항공_ABS사용자")]
		public string CommercialFlight_ABS_User { get; set; }
		/// <summary>
		/// 상용항공_ABSID
		/// </summary>
		[Column("상용항공_ABSID")]
		public string CommercialFlight_ABSID { get; set; }
		/// <summary>
		/// 상용항공_지급커미션
		/// </summary>
		[Column("상용항공_지급커미션")]
		public decimal CommercialFlight_PaymentCommission { get; set; }
		/// <summary>
		/// 상용항공_입금성향
		/// </summary>
		[Column("상용항공_입금성향")]
		public string CommercialFlight_DepositTendency { get; set; }
		/// <summary>
		/// 상용항공_특이사항
		/// </summary>
		[Column("상용항공_특이사항")]
		public string CommercialFlight_Specific { get; set; }
		/// <summary>
		/// 상용항공_커미션
		/// </summary>
		[Column("상용항공_커미션")]
		public string CommercialFlight_Commission { get; set; }
		/// <summary>
		/// 콜센터우선배분권역
		/// </summary>
		[Column("콜센터우선배분권역")]
		public string CallCenterPriorityDistributionLimitedZone { get; set; }
		/// <summary>
		/// BP_사원증
		/// </summary>
		[Column("BP_사원증")]
		public string BP_StaffIDCard { get; set; }
		/// <summary>
		/// 첨부파일_영업보증보험
		/// </summary>
		[Column("첨부파일_영업보증보험")]
		public string AttachFile_BusinessGuaranteeInsurance { get; set; }
		/// <summary>
		/// 첨부파일_옥외광고허가증
		/// </summary>
		[Column("첨부파일_옥외광고허가증")]
		public string AttachFile_OutdoorAdvertisementPermission { get; set; }
		/// <summary>
		/// 첨부파일_사업자등록증
		/// </summary>
		[Column("첨부파일_사업자등록증")]
		public string AttachFile_BusinessLicense { get; set; }
		/// <summary>
		/// 첨부파일_관광사업자
		/// </summary>
		[Column("첨부파일_관광사업자")]
		public string AttachFile_SightseeingLicensee { get; set; }
		/// <summary>
		/// 첨부파일_등기부
		/// </summary>
		[Column("첨부파일_등기부")]
		public string AttachFile_Register { get; set; }
		/// <summary>
		/// 총액대비커미션여부
		/// </summary>
		[Column("총액대비커미션여부")]
		public string TotalAmountPrepareCommissionOrNot { get; set; }
		/// <summary>
		/// 상용항공_서약서첨부여부
		/// </summary>
		[Column("상용항공_서약서첨부여부")]
		public string CommercialFlight_PledgeAttachOrNot { get; set; }
		/// <summary>
		/// 상용항공_서약서첨부파일
		/// </summary>
		[Column("상용항공_서약서첨부파일")]
		public string CommercialFlight_PledgeAttachFile { get; set; }
		/// <summary>
		/// 상용항공_서약서첨부일
		/// </summary>
		[Column("상용항공_서약서첨부일")]
		public DateTime CommercialFlight_PledgeAttachDate { get; set; }
		/// <summary>
		/// 상용항공_서약서_작업자
		/// </summary>
		[Column("상용항공_서약서_작업자")]
		public int CommercialFlight_Pledge_Worker { get; set; }
		/// <summary>
		/// 커미션_VAT포함여부
		/// </summary>
		[Column("커미션_VAT포함여부")]
		public string Commission_VAT_IncludedOrNot { get; set; }
		/// <summary>
		/// 온라인BP_광고집행
		/// </summary>
		[Column("온라인BP_광고집행")]
		public string Online_BP_AdvertisementExecution { get; set; }
		/// <summary>
		/// 항공CRT정보
		/// </summary>
		[Column("항공CRT정보")]
		public string Flight_CRT_Info { get; set; }
		/// <summary>
		/// 대리점VI실적노출
		/// </summary>
		[Column("대리점VI실적노출")]
		public string AgencyVIResultDisplay { get; set; }
		/// <summary>
		/// 상담직원_부재시웹예약제외여부
		/// </summary>
		[Column("상담직원_부재시웹예약제외여부")]
		public string ConsultantEmployee_AbsenceWebBookingExemptionOrNot { get; set; }
		/// <summary>
		/// 신규예약시SMS발송
		/// </summary>
		[Column("신규예약시SMS발송")]
		public string SMS_SendingWhenNewBooking { get; set; }
		/// <summary>
		/// 호텔공급계약서_동의여부
		/// </summary>
		[Column("호텔공급계약서_동의여부")]
		public string HotelSupplyContract_AgreeOrNot { get; set; }
		/// <summary>
		/// 호텔공급계약서_첨부파일
		/// </summary>
		[Column("호텔공급계약서_첨부파일")]
		public string HotelSupplyContract_AttachFile { get; set; }
		/// <summary>
		/// 홈플러스점포코드
		/// </summary>
		[Column("홈플러스점포코드")]
		public string HomePlusStoreCode { get; set; }
		/// <summary>
		/// 해외거래처여부
		/// </summary>
		[Column("해외거래처여부")]
		public string OverseaCustomerOrNot { get; set; }
		/// <summary>
		/// 통합인보이스거래처여부
		/// </summary>
		[Column("통합인보이스거래처여부")]
		public string CombinedInvoiceCustomerOrNot { get; set; }
		/// <summary>
		/// TPVI지급대상여부
		/// </summary>
		[Column("TPVI지급대상여부")]
		public string TPVI_PaymentCandidateOrNot { get; set; }
		/// <summary>
		/// TPVI모거래처번호
		/// </summary>
		[Column("TPVI모거래처번호")]
		public int TPVI_UnknownNumber { get; set; }
		/// <summary>
		/// 개인정보자율점검_확인자
		/// </summary>
		[Column("개인정보자율점검_확인자")]
		public int PersonalInfoselfAudit_ConfirmPerson { get; set; }
		/// <summary>
		/// 개인정보자율점검_확인일
		/// </summary>
		[Column("개인정보자율점검_확인일")]
		public DateTime PersonalInfoSelfAudit_ConfirmDate { get; set; }
		/// <summary>
		/// 카드사_가맹점번호
		/// </summary>
		[Column("카드사_가맹점번호")]
		public string CardCompany_AffiliateNumber { get; set; }
		/// <summary>
		/// 발권담당부서
		/// </summary>
		[Column("발권담당부서")]
		public int TicketIssuanceResponsibilityDepartment { get; set; }
		/// <summary>
		/// 인센티브전용BP
		/// </summary>
		[Column("인센티브전용BP")]
		public string IncentiveUseOnlyBP { get; set; }
		/// <summary>
		/// 첨부파일_공제영업보증서
		/// </summary>
		[Column("첨부파일_공제영업보증서")]
		public string AttachFile_DeductionBusinessGuaranteeLetter { get; set; }
		/// <summary>
		/// 거래처_성과그룹2
		/// </summary>
		[Column("거래처_성과그룹2")]
		public string Customer_PerformanceGroup2 { get; set; }
		/// <summary>
		/// 예약운영_성과그룹2
		/// </summary>
		[Column("예약운영_성과그룹2")]
		public string BookingOperation_PerformanceGroup2 { get; set; }
		/// <summary>
		/// 영업지원_성과그룹2
		/// </summary>
		[Column("영업지원_성과그룹2")]
		public string BusinessSupport_PerformanceGroup2 { get; set; }
		/// <summary>
		/// 현지연락처2
		/// </summary>
		[Column("현지연락처2")]
		public string LocalContact2 { get; set; }
		/// <summary>
		/// 현지연락처3
		/// </summary>
		[Column("현지연락처3")]
		public string LocalContact3 { get; set; }
		/// <summary>
		/// 여행계약서_기준금액
		/// </summary>
		[Column("여행계약서_기준금액")]
		public string TravelContract_StandardAmount { get; set; }
		/// <summary>
		/// 상용티켓대리점VI지급대상
		/// </summary>
		[Column("상용티켓대리점VI지급대상")]
		public string CommercialTicketAgencyVIPaymentCandidate { get; set; }
		/// <summary>
		/// 비즈전용BP여부
		/// </summary>
		[Column("비즈전용BP여부")]
		public string BusinessUseOnlyBPOrNot { get; set; }
		/// <summary>
		/// 으뜸BP여부
		/// </summary>
		[Column("으뜸BP여부")]
		public string Best_BP_OrNot { get; set; }
		/// <summary>
		/// 해외계좌정보
		/// </summary>
		[Column("해외계좌정보")]
		public string OverseaAccountInfo { get; set; }
		/// <summary>
		/// BTMS웹사이트
		/// </summary>
		[Column("BTMS웹사이트")]
		public string BTMS_WebSite { get; set; }
		/// <summary>
		/// BTMS_항공담당자
		/// </summary>
		[Column("BTMS_항공담당자")]
		public int BTMS_FlightManager { get; set; }
		/// <summary>
		/// BTMS_호텔담당자
		/// </summary>
		[Column("BTMS_호텔담당자")]
		public int BTMS_HotelManager { get; set; }
		/// <summary>
		/// BTMS_비자담당자
		/// </summary>
		[Column("BTMS_비자담당자")]
		public int BTMS_VisaManager { get; set; }
		/// <summary>
		/// BTMS_출장규정파일
		/// </summary>
		[Column("BTMS_출장규정파일")]
		public string BTMS_BusinessTripRegulationsFile { get; set; }
		/// <summary>
		/// BTMS_승인기능사용여부
		/// </summary>
		[Column("BTMS_승인기능사용여부")]
		public string BTMS_ApprovalFunctionUseOrNot { get; set; }
		/// <summary>
		/// 박람회거래처여부
		/// </summary>
		[Column("박람회거래처여부")]
		public string ExhibitionCustomerOrNot { get; set; }
		/// <summary>
		/// 국내발권담당
		/// </summary>
		[Column("국내발권담당")]
		public int DomesticTicketIssuanceResponsibility { get; set; }
		/// <summary>
		/// 국내발권담당부서
		/// </summary>
		[Column("국내발권담당부서")]
		public int DomesticTicketIssuanceResponsibilityDepartment { get; set; }
		/// <summary>
		/// TASF처리방법
		/// </summary>
		[Column("TASF처리방법")]
		public string TASF_HandleWay { get; set; }
		/// <summary>
		/// 샌드빌가입여부
		/// </summary>
		[Column("샌드빌가입여부")]
		public string SendbillSignUpOrNot { get; set; }
		/// <summary>
		/// 홈쇼핑예약여부
		/// </summary>
		[Column("홈쇼핑예약여부")]
		public string HomeShoppingBookingOrNot { get; set; }
		/// <summary>
		/// 마일리지샵_대표아이디
		/// </summary>
		[Column("마일리지샵_대표아이디")]
		public string MileageShop_Representative_ID { get; set; }
		/// <summary>
		/// 닷컴_통신판매업신고번호
		/// </summary>
		[Column("닷컴_통신판매업신고번호")]
		public string DotCom_TelemarketingBusinessRegisterNumber { get; set; }
		/// <summary>
		/// 닷컴_개인정보보호책임자
		/// </summary>
		[Column("닷컴_개인정보보호책임자")]
		public string DotCom_PersonalInfoProtectManager { get; set; }
		/// <summary>
		/// 닷컴_영업보증보험
		/// </summary>
		[Column("닷컴_영업보증보험")]
		public string DotCom_BusinessGuaranteeInsurance { get; set; }
		/// <summary>
		/// 닷컴_관광사업자등록번호
		/// </summary>
		[Column("닷컴_관광사업자등록번호")]
		public string DotCom_SightseeingBusinessLicenseNumber { get; set; }
		/// <summary>
		/// 계약일
		/// </summary>
		[Column("계약일")]
		public DateTime ContractDate { get; set; }
		/// <summary>
		/// 영업코디_성과그룹2
		/// </summary>
		[Column("영업코디_성과그룹2")]
		public string BusinessCoordination_PerformanceGroup2 { get; set; }
		/// <summary>
		/// 결제수단
		/// </summary>
		[Column("결제수단")]
		public string PaymentMethod { get; set; }
		/// <summary>
		/// 주소기준_광역시도
		/// </summary>
		[Column("주소기준_광역시도")]
		public string AddressStandard_MetropolisCityProvince { get; set; }
		/// <summary>
		/// 주소기준_시군구
		/// </summary>
		[Column("주소기준_시군구")]
		public string AddressStandard_CityDistrictWard { get; set; }
		/// <summary>
		/// 운영기준_광역시도
		/// </summary>
		[Column("운영기준_광역시도")]
		public string OperationStandard_MetropolitanCityProvince { get; set; }
		/// <summary>
		/// 운영기준_시군구
		/// </summary>
		[Column("운영기준_시군구")]
		public string OperationStandard_CityDistrictWard { get; set; }
		/// <summary>
		/// 홈페이지주소_모바일
		/// </summary>
		[Column("홈페이지주소_모바일")]
		public string HomePageAddress_Mobile { get; set; }
		/// <summary>
		/// 영업보증보험만료일_국내
		/// </summary>
		[Column("영업보증보험만료일_국내")]
		public DateTime BusinessGuaranteeInsuranceExpirationDate_Domestic { get; set; }
	}
}