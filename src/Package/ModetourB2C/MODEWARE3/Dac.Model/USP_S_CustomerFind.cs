namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_거래처조회
/// </summary>
public class USP_S_CustomerFind
{
	public const string SP_NAME = "USP_S_거래처조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처명
		/// </summary>
		[Description("거래처명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 부서번호
		/// </summary>
		[Description("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 담당사원
		/// </summary>
		[Description("담당사원")]
		public int ResponsibilityStaff { get; set; }
		/// <summary>
		/// 담당OP
		/// </summary>
		[Description("담당OP")]
		public int Responsibility_OP { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 사업자번호
		/// </summary>
		[Description("사업자번호")]
		public string LicenseeNumber { get; set; }
		/// <summary>
		/// 대표자
		/// </summary>
		[Description("대표자")]
		public string Representative { get; set; }
		/// <summary>
		/// 거래처종류
		/// </summary>
		[Description("거래처종류")]
		public string CustomerType { get; set; }
		/// <summary>
		/// 담당OP부서
		/// </summary>
		[Description("담당OP부서")]
		public int Responsibility_OP_Department { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 거래처명
		/// </summary>
		[Column("거래처명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 거래처영문명
		/// </summary>
		[Column("거래처영문명")]
		public string CustomerEnglishName { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
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
		/// 결제수수료
		/// </summary>
		[Column("결제수수료")]
		public decimal PaymentFee { get; set; }
		/// <summary>
		/// 대표자
		/// </summary>
		[Column("대표자")]
		public string Representative { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 법인명
		/// </summary>
		[Column("법인명")]
		public string CorporationName { get; set; }
		/// <summary>
		/// 사업자번호
		/// </summary>
		[Column("사업자번호")]
		public string LicenseeNumber { get; set; }
		/// <summary>
		/// 업태
		/// </summary>
		[Column("업태")]
		public string BusinessState { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 회사우편번호
		/// </summary>
		[Column("회사우편번호")]
		public string CompanyZipCode { get; set; }
		/// <summary>
		/// 전화번호
		/// </summary>
		[Column("전화번호")]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// 종목
		/// </summary>
		[Column("종목")]
		public string Event { get; set; }
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
		/// 팩스번호
		/// </summary>
		[Column("팩스번호")]
		public string FaxNumber { get; set; }
		/// <summary>
		/// BP
		/// </summary>
		[Column("BP")]
		public string BP { get; set; }
		/// <summary>
		/// MP
		/// </summary>
		[Column("MP")]
		public string MP { get; set; }
		/// <summary>
		/// BSP
		/// </summary>
		[Column("BSP")]
		public string BSP { get; set; }
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
		/// 분류1
		/// </summary>
		[Column("분류1")]
		public string Classification1 { get; set; }
		/// <summary>
		/// 분류2
		/// </summary>
		[Column("분류2")]
		public string Classification2 { get; set; }
		/// <summary>
		/// 보증보험증권번호
		/// </summary>
		[Column("보증보험증권번호")]
		public string GuaranteeInsurancePolicyNumber { get; set; }
		/// <summary>
		/// 지급보증만료일
		/// </summary>
		[Column("지급보증만료일")]
		public string PaymentGuaranteeExpirationDate { get; set; }
		/// <summary>
		/// BP신청일
		/// </summary>
		[Column("BP신청일")]
		public string BP_RequestDate { get; set; }
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
		/// 오버라이딩기준
		/// </summary>
		[Column("오버라이딩기준")]
		public string OverridingStandard { get; set; }
		/// <summary>
		/// 현지연락처
		/// </summary>
		[Column("현지연락처")]
		public string LocalContact { get; set; }
		/// <summary>
		/// 담당부서
		/// </summary>
		[Column("담당부서")]
		public string ResponsibilityDepartment { get; set; }
		/// <summary>
		/// 담당부서번호
		/// </summary>
		[Column("담당부서번호")]
		public int ResponsibilityDepartmentNumber { get; set; }
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
		/// 키워드광고
		/// </summary>
		[Column("키워드광고")]
		public string KeywordAdvertisement { get; set; }
		/// <summary>
		/// BP비고
		/// </summary>
		[Column("BP비고")]
		public string BP_Note { get; set; }
		/// <summary>
		/// 제휴신청일
		/// </summary>
		[Column("제휴신청일")]
		public string AffiliateRequestDate { get; set; }
		/// <summary>
		/// 홈페이지주소
		/// </summary>
		[Column("홈페이지주소")]
		public string HomePageAddress { get; set; }
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
		/// 비고
		/// </summary>
		[Column("비고")]
		public string Note { get; set; }
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
		/// 주문횟수
		/// </summary>
		[Column("주문횟수")]
		public int OrderTimes { get; set; }
		/// <summary>
		/// 거래처분류
		/// </summary>
		[Column("거래처분류")]
		public string CustomerClassification { get; set; }
		/// <summary>
		/// 거래처분류2
		/// </summary>
		[Column("거래처분류2")]
		public string CustomerClassification2 { get; set; }
		/// <summary>
		/// 거래처분류3
		/// </summary>
		[Column("거래처분류3")]
		public string CustomerClassification3 { get; set; }
		/// <summary>
		/// 거래처분류4
		/// </summary>
		[Column("거래처분류4")]
		public string CustomerClassification4 { get; set; }
		/// <summary>
		/// 거래처대분류
		/// </summary>
		[Column("거래처대분류")]
		public string CustomerMajorClassification { get; set; }
		/// <summary>
		/// 거래처중분류
		/// </summary>
		[Column("거래처중분류")]
		public string CustomerInternalClassification { get; set; }
		/// <summary>
		/// 거래처분류참고사항
		/// </summary>
		[Column("거래처분류참고사항")]
		public string CustomerClassificationRequirement { get; set; }
		/// <summary>
		/// 거래처분류코드
		/// </summary>
		[Column("거래처분류코드")]
		public string CustomerClassificationCode { get; set; }
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
		/// 본부구분
		/// </summary>
		[Column("본부구분")]
		public string HeadofficeClassification { get; set; }
		/// <summary>
		/// 회사주소3
		/// </summary>
		[Column("회사주소3")]
		public string CompanyAddress3 { get; set; }
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
		/// 회사대표자메일
		/// </summary>
		[Column("회사대표자메일")]
		public string CompanyRepresentativeMail { get; set; }
		/// <summary>
		/// BP거래처명
		/// </summary>
		[Column("BP거래처명")]
		public string BP_CustomerName { get; set; }
		/// <summary>
		/// 담당OP명
		/// </summary>
		[Column("담당OP명")]
		public string Responsibility_OP_Name { get; set; }
		/// <summary>
		/// 담당OP번호
		/// </summary>
		[Column("담당OP번호")]
		public int Responsibility_OP_Number { get; set; }
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
		/// VI모거래처명
		/// </summary>
		[Column("VI모거래처명")]
		public string VI_UnknownName { get; set; }
		/// <summary>
		/// VI모거래처번호
		/// </summary>
		[Column("VI모거래처번호")]
		public string VI_UnknownNumber { get; set; }
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
		/// 발권담당
		/// </summary>
		[Column("발권담당")]
		public string TicketIssuanceResponsibility { get; set; }
		/// <summary>
		/// 발권담당번호
		/// </summary>
		[Column("발권담당번호")]
		public int TicketIssuanceResponsibilityNumber { get; set; }
		/// <summary>
		/// 기준커미션동기화
		/// </summary>
		[Column("기준커미션동기화")]
		public string StandardCommissionSynchronization { get; set; }
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
		/// ATRTASF_월드스팬
		/// </summary>
		[Column("ATRTASF_월드스팬")]
		public string ATRTASF_Worldspan { get; set; }
		/// <summary>
		/// ATRTASF_전체미가입
		/// </summary>
		[Column("ATRTASF_전체미가입")]
		public string ATRTASF_EntireNotSignUp { get; set; }
		/// <summary>
		/// 마일리지해피콜제외
		/// </summary>
		[Column("마일리지해피콜제외")]
		public string MileageHappyCallExemption { get; set; }
		/// <summary>
		/// BTMS사용
		/// </summary>
		[Column("BTMS사용")]
		public string BTMS_Use { get; set; }
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
		public string MileageCardContractRegisterer { get; set; }
		/// <summary>
		/// 마일리지카드약정등록일
		/// </summary>
		[Column("마일리지카드약정등록일")]
		public string MileageCardContractRegisterDate { get; set; }
		/// <summary>
		/// 법인통장사본
		/// </summary>
		[Column("법인통장사본")]
		public string CorporationBankbookCopy { get; set; }
		/// <summary>
		/// 간판미설치기안
		/// </summary>
		[Column("간판미설치기안")]
		public string SignNotInstalledDraft { get; set; }
		/// <summary>
		/// 등기부등본2
		/// </summary>
		[Column("등기부등본2")]
		public string RegisterbookCopy2 { get; set; }
		/// <summary>
		/// 담당OP부서
		/// </summary>
		[Column("담당OP부서")]
		public string Responsibility_OP_Department { get; set; }
		/// <summary>
		/// 담당OP부서번호
		/// </summary>
		[Column("담당OP부서번호")]
		public int Responsibility_OP_DepartmentNumber { get; set; }
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
		/// BP약도URL
		/// </summary>
		[Column("BP약도URL")]
		public string BP_SketchMap_URL { get; set; }
		/// <summary>
		/// 영업보증보험만료일
		/// </summary>
		[Column("영업보증보험만료일")]
		public string BusinessGuaranteeInsuranceExpirationDate { get; set; }
		/// <summary>
		/// 여행업종류
		/// </summary>
		[Column("여행업종류")]
		public string TravelBusinessType { get; set; }
		/// <summary>
		/// 거래처직인
		/// </summary>
		[Column("거래처직인")]
		public string CustomerSeal { get; set; }
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
		/// BP_사원증
		/// </summary>
		[Column("BP_사원증")]
		public string BP_StaffIDCard { get; set; }
		/// <summary>
		/// BP_링고
		/// </summary>
		[Column("BP_링고")]
		public string BP_Lingo { get; set; }
		/// <summary>
		/// BP_링고불가사유
		/// </summary>
		[Column("BP_링고불가사유")]
		public string BP_LingoImpossibleReason { get; set; }
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
		/// VI_CRS노출여부
		/// </summary>
		[Column("VI_CRS노출여부")]
		public string VI_CRS_DisplayOrNot { get; set; }
		/// <summary>
		/// 도로명주소
		/// </summary>
		[Column("도로명주소")]
		public string StreetNameAddress { get; set; }
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
		/// 상용항공_커미션
		/// </summary>
		[Column("상용항공_커미션")]
		public string CommercialFlight_Commission { get; set; }
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
		/// 콜센터우선배분권역
		/// </summary>
		[Column("콜센터우선배분권역")]
		public string CallCenterPriorityDistributionLimitedZone { get; set; }
		/// <summary>
		/// 대외모객제외여부
		/// </summary>
		[Column("대외모객제외여부")]
		public string InternationalAudienceExemptionOrNot { get; set; }
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
		public string CommercialFlight_PledgeAttachDate { get; set; }
		/// <summary>
		/// 상용항공_서약서_작업자
		/// </summary>
		[Column("상용항공_서약서_작업자")]
		public string CommercialFlight_Pledge_Worker { get; set; }
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
		/// 해외거래처여부
		/// </summary>
		[Column("해외거래처여부")]
		public string OverseaCustomerOrNot { get; set; }
		/// <summary>
		/// 홈플러스점포코드
		/// </summary>
		[Column("홈플러스점포코드")]
		public string HomePlusStoreCode { get; set; }
		/// <summary>
		/// 회사우편번호2
		/// </summary>
		[Column("회사우편번호2")]
		public string CompanyZipCode2 { get; set; }
		/// <summary>
		/// 통합인보이스거래처
		/// </summary>
		[Column("통합인보이스거래처")]
		public string CombinedInvoiceCustomer { get; set; }
		/// <summary>
		/// TPVI지급대상여부
		/// </summary>
		[Column("TPVI지급대상여부")]
		public string TPVI_PaymentCandidateOrNot { get; set; }
		/// <summary>
		/// TPVI모거래처명
		/// </summary>
		[Column("TPVI모거래처명")]
		public string TPVI_UnknownName { get; set; }
		/// <summary>
		/// TPVI모거래처번호
		/// </summary>
		[Column("TPVI모거래처번호")]
		public string TPVI_UnknownNumber { get; set; }
		/// <summary>
		/// 영업지원
		/// </summary>
		[Column("영업지원")]
		public string BusinessSupport { get; set; }
		/// <summary>
		/// 영업지원번호
		/// </summary>
		[Column("영업지원번호")]
		public int BusinessSupportNumber { get; set; }
		/// <summary>
		/// 발권담당부서
		/// </summary>
		[Column("발권담당부서")]
		public string TicketIssuanceResponsibilityDepartment { get; set; }
		/// <summary>
		/// 발권담당부서번호
		/// </summary>
		[Column("발권담당부서번호")]
		public int TicketIssuanceResponsibilityDepartmentNumber { get; set; }
		/// <summary>
		/// 인센티브전용BP
		/// </summary>
		[Column("인센티브전용BP")]
		public string IncentiveUseOnlyBP { get; set; }
		/// <summary>
		/// 영업지원부서
		/// </summary>
		[Column("영업지원부서")]
		public string BusinessSupportDepartment { get; set; }
		/// <summary>
		/// 영업지원부서번호
		/// </summary>
		[Column("영업지원부서번호")]
		public int BusinessSupportDepartmentNumber { get; set; }
		/// <summary>
		/// 영업담당_성과그룹2
		/// </summary>
		[Column("영업담당_성과그룹2")]
		public string BusinessResponsibility_PerformanceGroup2 { get; set; }
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
		/// 이전담당OP
		/// </summary>
		[Column("이전담당OP")]
		public int PreviousResponsibility_OP { get; set; }
		/// <summary>
		/// 이전담당OP부서
		/// </summary>
		[Column("이전담당OP부서")]
		public int PreviousResponsibility_OP_Department { get; set; }
		/// <summary>
		/// 이전영업지원
		/// </summary>
		[Column("이전영업지원")]
		public int PreviousBusinessSupport { get; set; }
		/// <summary>
		/// 이전영업지원부서
		/// </summary>
		[Column("이전영업지원부서")]
		public int PreviousBusinessSupportDepartment { get; set; }
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
		/// 상용티켓추가VI지급대상여부
		/// </summary>
		[Column("상용티켓추가VI지급대상여부")]
		public string CommercialTicketAddVIPaymentCandidateOrNot { get; set; }
		/// <summary>
		/// 비즈전용BP
		/// </summary>
		[Column("비즈전용BP")]
		public string BusinessUseOnlyBP { get; set; }
		/// <summary>
		/// 으뜸BP
		/// </summary>
		[Column("으뜸BP")]
		public string Best_BP { get; set; }
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
		public string BTMS_FlightManager { get; set; }
		/// <summary>
		/// BTMS_호텔담당자
		/// </summary>
		[Column("BTMS_호텔담당자")]
		public string BTMS_HotelManager { get; set; }
		/// <summary>
		/// BTMS_비자담당자
		/// </summary>
		[Column("BTMS_비자담당자")]
		public string BTMS_VisaManager { get; set; }
		/// <summary>
		/// BTMS_항공담당번호
		/// </summary>
		[Column("BTMS_항공담당번호")]
		public int BTMS_FlightResponsibilityNumber { get; set; }
		/// <summary>
		/// BTMS_호텔담당번호
		/// </summary>
		[Column("BTMS_호텔담당번호")]
		public int BTMS_HotelResponsibilityNumber { get; set; }
		/// <summary>
		/// BTMS_비자담당번호
		/// </summary>
		[Column("BTMS_비자담당번호")]
		public int BTMS_VisaResponsibilityNumber { get; set; }
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
		public string DomesticTicketIssuanceResponsibility { get; set; }
		/// <summary>
		/// 국내발권담당번호
		/// </summary>
		[Column("국내발권담당번호")]
		public int DomesticTicketIssuanceResponsibilityNumber { get; set; }
		/// <summary>
		/// 국내발권담당부서
		/// </summary>
		[Column("국내발권담당부서")]
		public string DomesticTicketIssuanceResponsibilityDepartment { get; set; }
		/// <summary>
		/// 국내발권담당부서번호
		/// </summary>
		[Column("국내발권담당부서번호")]
		public int DomesticTicketIssuanceResponsibilityDepartmentNumber { get; set; }
		/// <summary>
		/// 샌드빌가입여부
		/// </summary>
		[Column("샌드빌가입여부")]
		public string SendbillSignUpOrNot { get; set; }
	}
}