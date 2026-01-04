namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_거래처_02
/// </summary>
public class USP_T_Customer_02
{
	public const string SP_NAME = "USP_T_거래처_02";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 거래처명
		/// </summary>
		[Description("거래처명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 법인명
		/// </summary>
		[Description("법인명")]
		public string CorporationName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Description("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 사업자번호
		/// </summary>
		[Description("사업자번호")]
		public string LicenseeNumber { get; set; }
		/// <summary>
		/// 거래처종류
		/// </summary>
		[Description("거래처종류")]
		public string CustomerType { get; set; }
		/// <summary>
		/// 결제수수료
		/// </summary>
		[Description("결제수수료")]
		public decimal PaymentFee { get; set; }
		/// <summary>
		/// 대표자
		/// </summary>
		[Description("대표자")]
		public string Representative { get; set; }
		/// <summary>
		/// 업태
		/// </summary>
		[Description("업태")]
		public string BusinessState { get; set; }
		/// <summary>
		/// 종목
		/// </summary>
		[Description("종목")]
		public string Event { get; set; }
		/// <summary>
		/// 전화번호
		/// </summary>
		[Description("전화번호")]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// 팩스번호
		/// </summary>
		[Description("팩스번호")]
		public string FaxNumber { get; set; }
		/// <summary>
		/// 우편번호
		/// </summary>
		[Description("우편번호")]
		public string ZipCode { get; set; }
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
		/// 담당사원명
		/// </summary>
		[Description("담당사원명")]
		public string ResponsibilityStaffName { get; set; }
		/// <summary>
		/// 담당사원번호
		/// </summary>
		[Description("담당사원번호")]
		public int ResponsibilityStaffNumber { get; set; }
		/// <summary>
		/// 내부결제가능
		/// </summary>
		[Description("내부결제가능")]
		public string InternalPaymentPossible { get; set; }
		/// <summary>
		/// BP
		/// </summary>
		[Description("BP")]
		public string BP { get; set; }
		/// <summary>
		/// MP
		/// </summary>
		[Description("MP")]
		public string MP { get; set; }
		/// <summary>
		/// BSP
		/// </summary>
		[Description("BSP")]
		public string BSP { get; set; }
		/// <summary>
		/// 미수유예
		/// </summary>
		[Description("미수유예")]
		public string UnpayedDelay { get; set; }
		/// <summary>
		/// 미수유예기간
		/// </summary>
		[Description("미수유예기간")]
		public int UnpayedDelayPeriod { get; set; }
		/// <summary>
		/// 미수유예단위
		/// </summary>
		[Description("미수유예단위")]
		public string UnpayedDelayUnit { get; set; }
		/// <summary>
		/// 분류
		/// </summary>
		[Description("분류")]
		public string Classification2 { get; set; }
		/// <summary>
		/// 분류2
		/// </summary>
		[Description("분류2")]
		public string Classification22 { get; set; }
		/// <summary>
		/// BP신청일
		/// </summary>
		[Description("BP신청일")]
		public DateTime BP_RequestDate { get; set; }
		/// <summary>
		/// 보증보험증권번호
		/// </summary>
		[Description("보증보험증권번호")]
		public string GuaranteeInsurancePolicyNumber { get; set; }
		/// <summary>
		/// 지급보증만료일
		/// </summary>
		[Description("지급보증만료일")]
		public DateTime PaymentGuaranteeExpirationDate { get; set; }
		/// <summary>
		/// BP등급
		/// </summary>
		[Description("BP등급")]
		public string BP_Class { get; set; }
		/// <summary>
		/// 영업보증보험만료일
		/// </summary>
		[Description("영업보증보험만료일")]
		public DateTime BusinessGuaranteeInsuranceExpirationDate { get; set; }
		/// <summary>
		/// 영업보증보험만료일국내
		/// </summary>
		[Description("영업보증보험만료일국내")]
		public DateTime BusinessGuaranteeInsuranceExpirationDateDomestic { get; set; }
		/// <summary>
		/// 여행업종류
		/// </summary>
		[Description("여행업종류")]
		public string TravelBusinessType { get; set; }
		/// <summary>
		/// 계약조건기준월
		/// </summary>
		[Description("계약조건기준월")]
		public byte ContractConditionStandardMonth { get; set; }
		/// <summary>
		/// 계약조건기준매출
		/// </summary>
		[Description("계약조건기준매출")]
		public long ContractConditionStandardSales { get; set; }
		/// <summary>
		/// 오버라이딩기준
		/// </summary>
		[Description("오버라이딩기준")]
		public string OverridingStandard { get; set; }
		/// <summary>
		/// BP비고
		/// </summary>
		[Description("BP비고")]
		public string BP_Note { get; set; }
		/// <summary>
		/// 현지연락처
		/// </summary>
		[Description("현지연락처")]
		public string LocalContact { get; set; }
		/// <summary>
		/// 이전담당사원
		/// </summary>
		[Description("이전담당사원")]
		public int PreviousResponsibilityStaff { get; set; }
		/// <summary>
		/// 사업자등록증확인
		/// </summary>
		[Description("사업자등록증확인")]
		public string BusinessLicenseConfirm { get; set; }
		/// <summary>
		/// 사업자등록증확인2
		/// </summary>
		[Description("사업자등록증확인2")]
		public string BusinessLicenseConfirm2 { get; set; }
		/// <summary>
		/// 거래중지유형
		/// </summary>
		[Description("거래중지유형")]
		public string TransactionStopType { get; set; }
		/// <summary>
		/// 거래중지사유
		/// </summary>
		[Description("거래중지사유")]
		public string TransactionStopReason { get; set; }
		/// <summary>
		/// 제휴신청일
		/// </summary>
		[Description("제휴신청일")]
		public DateTime AffiliateRequestDate { get; set; }
		/// <summary>
		/// 홈페이지주소
		/// </summary>
		[Description("홈페이지주소")]
		public string HomePageAddress { get; set; }
		/// <summary>
		/// 사이트종류1
		/// </summary>
		[Description("사이트종류1")]
		public string SiteType1 { get; set; }
		/// <summary>
		/// 사이트종류2
		/// </summary>
		[Description("사이트종류2")]
		public string SiteType2 { get; set; }
		/// <summary>
		/// 홈페이지비고
		/// </summary>
		[Description("홈페이지비고")]
		public string HomePageNote { get; set; }
		/// <summary>
		/// 입력자부서번호
		/// </summary>
		[Description("입력자부서번호")]
		public int InputPersonDepartmentNumber { get; set; }
		/// <summary>
		/// 입력자
		/// </summary>
		[Description("입력자")]
		public int InputPerson { get; set; }
		/// <summary>
		/// 영업보증보험사본
		/// </summary>
		[Description("영업보증보험사본")]
		public string BusinessGuaranteeInsuranceCopy { get; set; }
		/// <summary>
		/// 지급보증보험원본
		/// </summary>
		[Description("지급보증보험원본")]
		public string PaymentGuaranteeInsuranceOriginal { get; set; }
		/// <summary>
		/// 옥외광고물표시허가증
		/// </summary>
		[Description("옥외광고물표시허가증")]
		public string OutdoorAdvertisementItemDisplayPermission { get; set; }
		/// <summary>
		/// 인감증명서사본
		/// </summary>
		[Description("인감증명서사본")]
		public string AuthCertificationCopy { get; set; }
		/// <summary>
		/// 사업자등록증사본
		/// </summary>
		[Description("사업자등록증사본")]
		public string BusinessLicenseCopy { get; set; }
		/// <summary>
		/// 관광사업자등록증사본
		/// </summary>
		[Description("관광사업자등록증사본")]
		public string SightseeingBusinessLicenseCopy { get; set; }
		/// <summary>
		/// 등기부등본
		/// </summary>
		[Description("등기부등본")]
		public string RegisterbookCopy { get; set; }
		/// <summary>
		/// 임대차계약서
		/// </summary>
		[Description("임대차계약서")]
		public string RentalContract { get; set; }
		/// <summary>
		/// 키워드광고
		/// </summary>
		[Description("키워드광고")]
		public string KeywordAdvertisement { get; set; }
		/// <summary>
		/// 거래처분류
		/// </summary>
		[Description("거래처분류")]
		public string CustomerClassification { get; set; }
		/// <summary>
		/// 미수유예분류
		/// </summary>
		[Description("미수유예분류")]
		public string UnpayedDelayClassification { get; set; }
		/// <summary>
		/// 거래처비고
		/// </summary>
		[Description("거래처비고")]
		public string CustomerNote { get; set; }
		/// <summary>
		/// 주소3
		/// </summary>
		[Description("주소3")]
		public string Address3 { get; set; }
		/// <summary>
		/// 인보이스미첨부가능
		/// </summary>
		[Description("인보이스미첨부가능")]
		public string InvoiceNotAttachPossible { get; set; }
		/// <summary>
		/// 콜센터예약우선배분
		/// </summary>
		[Description("콜센터예약우선배분")]
		public string CallCenterBookingPriorityDistribution { get; set; }
		/// <summary>
		/// 콜센터배분유형
		/// </summary>
		[Description("콜센터배분유형")]
		public string CallCenterDistributionType { get; set; }
		/// <summary>
		/// 회사대표자메일
		/// </summary>
		[Description("회사대표자메일")]
		public string CompanyRepresentativeMail { get; set; }
		/// <summary>
		/// BP거래처명
		/// </summary>
		[Description("BP거래처명")]
		public string BP_CustomerName { get; set; }
		/// <summary>
		/// 담당OP번호
		/// </summary>
		[Description("담당OP번호")]
		public int Responsibility_OP_Number { get; set; }
		/// <summary>
		/// 전자세금계산서사용
		/// </summary>
		[Description("전자세금계산서사용")]
		public string DigitalTaxInvoiceUse { get; set; }
		/// <summary>
		/// 회계담당자
		/// </summary>
		[Description("회계담당자")]
		public string AccountantManager { get; set; }
		/// <summary>
		/// 회계담당연락처
		/// </summary>
		[Description("회계담당연락처")]
		public string AccountantResponsibilityContact { get; set; }
		/// <summary>
		/// 회계담당이메일
		/// </summary>
		[Description("회계담당이메일")]
		public string AccountantResponsibilityEmail { get; set; }
		/// <summary>
		/// 회계팀체크
		/// </summary>
		[Description("회계팀체크")]
		public string AccountantTeamCheck { get; set; }
		/// <summary>
		/// VI지급대상여부
		/// </summary>
		[Description("VI지급대상여부")]
		public string VI_PaymentCandidateOrNot { get; set; }
		/// <summary>
		/// VI모거래처번호
		/// </summary>
		[Description("VI모거래처번호")]
		public int VI_UnknownNumber { get; set; }
		/// <summary>
		/// VICRS사용율제외
		/// </summary>
		[Description("VICRS사용율제외")]
		public string VICRS_UseRateExemption { get; set; }
		/// <summary>
		/// 컨텐츠사용여부
		/// </summary>
		[Description("컨텐츠사용여부")]
		public string ContentUseOrNot { get; set; }
		/// <summary>
		/// 홈페이지사용계약여부
		/// </summary>
		[Description("홈페이지사용계약여부")]
		public string HomePageUseContractOrNot { get; set; }
		/// <summary>
		/// 온라인BP계약여부
		/// </summary>
		[Description("온라인BP계약여부")]
		public string Online_BP_ContractOrNot { get; set; }
		/// <summary>
		/// 키워드광고계약여부
		/// </summary>
		[Description("키워드광고계약여부")]
		public string KeywordAdvertisementContractOrNot { get; set; }
		/// <summary>
		/// 기안번호
		/// </summary>
		[Description("기안번호")]
		public string DraftNumber { get; set; }
		/// <summary>
		/// 기준커미션동기화
		/// </summary>
		[Description("기준커미션동기화")]
		public string StandardCommissionSynchronization { get; set; }
		/// <summary>
		/// ATRTASF_토파스
		/// </summary>
		[Description("ATRTASF_토파스")]
		public string ATRTASF_TOPAS { get; set; }
		/// <summary>
		/// ATRTASF_아바쿠스
		/// </summary>
		[Description("ATRTASF_아바쿠스")]
		public string ATRTASF_Abaqus { get; set; }
		/// <summary>
		/// ATRTASF_갈릴레오
		/// </summary>
		[Description("ATRTASF_갈릴레오")]
		public string ATRTASF_Galileo { get; set; }
		/// <summary>
		/// ATRTASF_월드스팬
		/// </summary>
		[Description("ATRTASF_월드스팬")]
		public string ATRTASF_Worldspan { get; set; }
		/// <summary>
		/// BTMS사용
		/// </summary>
		[Description("BTMS사용")]
		public string BTMS_Use { get; set; }
		/// <summary>
		/// BTMSID
		/// </summary>
		[Description("BTMSID")]
		public string BTMSID { get; set; }
		/// <summary>
		/// 발권담당자
		/// </summary>
		[Description("발권담당자")]
		public int TicketIssuanceManager { get; set; }
		/// <summary>
		/// 법인통장사본
		/// </summary>
		[Description("법인통장사본")]
		public string CorporationBankbookCopy { get; set; }
		/// <summary>
		/// 간판미설치기안
		/// </summary>
		[Description("간판미설치기안")]
		public string SignNotInstalledDraft { get; set; }
		/// <summary>
		/// 담당OP부서
		/// </summary>
		[Description("담당OP부서")]
		public int Responsibility_OP_Department { get; set; }
		/// <summary>
		/// BP약도URL
		/// </summary>
		[Description("BP약도URL")]
		public string BP_SketchMap_URL { get; set; }
		/// <summary>
		/// 거래처중문명
		/// </summary>
		[Description("거래처중문명")]
		public string CustomerChineseName { get; set; }
		/// <summary>
		/// 거래처중문주소
		/// </summary>
		[Description("거래처중문주소")]
		public string CustomerChineseAddress { get; set; }
		/// <summary>
		/// 중국현지번호
		/// </summary>
		[Description("중국현지번호")]
		public string ChinaLocalNumber { get; set; }
		/// <summary>
		/// 담당자중문명
		/// </summary>
		[Description("담당자중문명")]
		public string ManagerChineseName { get; set; }
		/// <summary>
		/// BP_금융종합보험
		/// </summary>
		[Description("BP_금융종합보험")]
		public string BP_FinancialComprehensiveInsurance { get; set; }
		/// <summary>
		/// BP_명함
		/// </summary>
		[Description("BP_명함")]
		public string BP_NameCard { get; set; }
		/// <summary>
		/// BP_유니폼
		/// </summary>
		[Description("BP_유니폼")]
		public string BP_Uniform { get; set; }
		/// <summary>
		/// BP_사원증
		/// </summary>
		[Description("BP_사원증")]
		public string BP_StaffIDCard { get; set; }
		/// <summary>
		/// BP_링고
		/// </summary>
		[Description("BP_링고")]
		public string BP_Lingo { get; set; }
		/// <summary>
		/// BP_링고불가사유
		/// </summary>
		[Description("BP_링고불가사유")]
		public string BP_LingoImpossibleReason { get; set; }
		/// <summary>
		/// BP_안내멘트
		/// </summary>
		[Description("BP_안내멘트")]
		public string BP_InfoComment { get; set; }
		/// <summary>
		/// BP_내부간판
		/// </summary>
		[Description("BP_내부간판")]
		public string BP_InternalSignboard { get; set; }
		/// <summary>
		/// BP_외부간판
		/// </summary>
		[Description("BP_외부간판")]
		public string BP_ExternalSignboard { get; set; }
		/// <summary>
		/// BP_측면간판
		/// </summary>
		[Description("BP_측면간판")]
		public string BP_SideSignboard { get; set; }
		/// <summary>
		/// BP_내부간판_파일명
		/// </summary>
		[Description("BP_내부간판_파일명")]
		public string BP_InternalSignboard_FileName { get; set; }
		/// <summary>
		/// BP_외부간판_파일명
		/// </summary>
		[Description("BP_외부간판_파일명")]
		public string BP_ExternalSignboard_FileName { get; set; }
		/// <summary>
		/// BP_측면간판_파일명
		/// </summary>
		[Description("BP_측면간판_파일명")]
		public string BP_SideSignboard_FileName { get; set; }
		/// <summary>
		/// VI_CRS노출여부
		/// </summary>
		[Description("VI_CRS노출여부")]
		public string VI_CRS_DisplayOrNot { get; set; }
		/// <summary>
		/// 도로명주소
		/// </summary>
		[Description("도로명주소")]
		public string StreetNameAddress { get; set; }
		/// <summary>
		/// 상용항공_담당자
		/// </summary>
		[Description("상용항공_담당자")]
		public string CommercialFlight_Manager { get; set; }
		/// <summary>
		/// 상용항공_휴대폰
		/// </summary>
		[Description("상용항공_휴대폰")]
		public string CommercialFlight_Phone { get; set; }
		/// <summary>
		/// 상용항공_이메일
		/// </summary>
		[Description("상용항공_이메일")]
		public string CommercialFlight_Email { get; set; }
		/// <summary>
		/// 상용항공_FAX
		/// </summary>
		[Description("상용항공_FAX")]
		public string CommercialFlight_FAX { get; set; }
		/// <summary>
		/// 상용항공_항공지식
		/// </summary>
		[Description("상용항공_항공지식")]
		public string CommercialFlight_FlightKnowledge { get; set; }
		/// <summary>
		/// GDS_토파스
		/// </summary>
		[Description("GDS_토파스")]
		public string GDS_TOPAS { get; set; }
		/// <summary>
		/// GDS_아바쿠스
		/// </summary>
		[Description("GDS_아바쿠스")]
		public string GDS_Abaqus { get; set; }
		/// <summary>
		/// GDS_갈릴레오
		/// </summary>
		[Description("GDS_갈릴레오")]
		public string GDS_Galileo { get; set; }
		/// <summary>
		/// GDS_월드스팬
		/// </summary>
		[Description("GDS_월드스팬")]
		public string GDS_Worldspan { get; set; }
		/// <summary>
		/// 상용항공_원천징수대상자
		/// </summary>
		[Description("상용항공_원천징수대상자")]
		public string CommercialFlight_WithholdingTaxCandidate { get; set; }
		/// <summary>
		/// 상용항공_은행
		/// </summary>
		[Description("상용항공_은행")]
		public string CommercialFlight_Bank { get; set; }
		/// <summary>
		/// 상용항공_계좌번호
		/// </summary>
		[Description("상용항공_계좌번호")]
		public string CommercialFlight_AccountNumber { get; set; }
		/// <summary>
		/// 상용항공_토파스Q
		/// </summary>
		[Description("상용항공_토파스Q")]
		public string CommercialFlight_TOPAS_Q { get; set; }
		/// <summary>
		/// 상용항공_ABS사용자
		/// </summary>
		[Description("상용항공_ABS사용자")]
		public string CommercialFlight_ABS_User { get; set; }
		/// <summary>
		/// 상용항공_ABSID
		/// </summary>
		[Description("상용항공_ABSID")]
		public string CommercialFlight_ABSID { get; set; }
		/// <summary>
		/// 상용항공_지급커미션
		/// </summary>
		[Description("상용항공_지급커미션")]
		public decimal CommercialFlight_PaymentCommission { get; set; }
		/// <summary>
		/// 상용항공_커미션
		/// </summary>
		[Description("상용항공_커미션")]
		public string CommercialFlight_Commission { get; set; }
		/// <summary>
		/// 상용항공_입금성향
		/// </summary>
		[Description("상용항공_입금성향")]
		public string CommercialFlight_DepositTendency { get; set; }
		/// <summary>
		/// 상용항공_특이사항
		/// </summary>
		[Description("상용항공_특이사항")]
		public string CommercialFlight_Specific { get; set; }
		/// <summary>
		/// 아바쿠스PCC
		/// </summary>
		[Description("아바쿠스PCC")]
		public string Abaqus_PCC { get; set; }
		/// <summary>
		/// 아바쿠스DK
		/// </summary>
		[Description("아바쿠스DK")]
		public string Abaqus_DK { get; set; }
		/// <summary>
		/// 콜센터우선배분권역
		/// </summary>
		[Description("콜센터우선배분권역")]
		public string CallCenterPriorityDistributionLimitedZone { get; set; }
		/// <summary>
		/// 대외모객제외여부
		/// </summary>
		[Description("대외모객제외여부")]
		public string InternationalAudienceExemptionOrNot { get; set; }
		/// <summary>
		/// 첨부파일_영업보증보험
		/// </summary>
		[Description("첨부파일_영업보증보험")]
		public string AttachFile_BusinessGuaranteeInsurance { get; set; }
		/// <summary>
		/// 첨부파일_옥외광고허가증
		/// </summary>
		[Description("첨부파일_옥외광고허가증")]
		public string AttachFile_OutdoorAdvertisementPermission { get; set; }
		/// <summary>
		/// 첨부파일_사업자등록증
		/// </summary>
		[Description("첨부파일_사업자등록증")]
		public string AttachFile_BusinessLicense { get; set; }
		/// <summary>
		/// 첨부파일_관광사업자
		/// </summary>
		[Description("첨부파일_관광사업자")]
		public string AttachFile_SightseeingLicensee { get; set; }
		/// <summary>
		/// 첨부파일_등기부
		/// </summary>
		[Description("첨부파일_등기부")]
		public string AttachFile_Register { get; set; }
		/// <summary>
		/// 총액대비커미션여부
		/// </summary>
		[Description("총액대비커미션여부")]
		public string TotalAmountPrepareCommissionOrNot { get; set; }
		/// <summary>
		/// 상용항공_서약서첨부파일
		/// </summary>
		[Description("상용항공_서약서첨부파일")]
		public string CommercialFlight_PledgeAttachFile { get; set; }
		/// <summary>
		/// 커미션_VAT포함여부
		/// </summary>
		[Description("커미션_VAT포함여부")]
		public string Commission_VAT_IncludedOrNot { get; set; }
		/// <summary>
		/// 온라인BP_광고집행
		/// </summary>
		[Description("온라인BP_광고집행")]
		public string Online_BP_AdvertisementExecution { get; set; }
		/// <summary>
		/// 항공CRT정보
		/// </summary>
		[Description("항공CRT정보")]
		public string Flight_CRT_Info { get; set; }
		/// <summary>
		/// 해외계좌정보
		/// </summary>
		[Description("해외계좌정보")]
		public string OverseaAccountInfo { get; set; }
		/// <summary>
		/// 대리점VI실적노출
		/// </summary>
		[Description("대리점VI실적노출")]
		public string AgencyVIResultDisplay { get; set; }
		/// <summary>
		/// 상담직원_부재시웹예약제외여부
		/// </summary>
		[Description("상담직원_부재시웹예약제외여부")]
		public string ConsultantEmployee_AbsenceWebBookingExemptionOrNot { get; set; }
		/// <summary>
		/// 신규예약시SMS발송
		/// </summary>
		[Description("신규예약시SMS발송")]
		public string SMS_SendingWhenNewBooking { get; set; }
		/// <summary>
		/// 해외거래처여부
		/// </summary>
		[Description("해외거래처여부")]
		public string OverseaCustomerOrNot { get; set; }
		/// <summary>
		/// 통합인보이스거래처
		/// </summary>
		[Description("통합인보이스거래처")]
		public string CombinedInvoiceCustomer { get; set; }
		/// <summary>
		/// 홈쇼핑예약여부
		/// </summary>
		[Description("홈쇼핑예약여부")]
		public string HomeShoppingBookingOrNot { get; set; }
		/// <summary>
		/// 홈플러스점포코드
		/// </summary>
		[Description("홈플러스점포코드")]
		public string HomePlusStoreCode { get; set; }
		/// <summary>
		/// TPVI지급대상여부
		/// </summary>
		[Description("TPVI지급대상여부")]
		public string TPVI_PaymentCandidateOrNot { get; set; }
		/// <summary>
		/// TPVI모거래처번호
		/// </summary>
		[Description("TPVI모거래처번호")]
		public int TPVI_UnknownNumber { get; set; }
		/// <summary>
		/// 영업지원
		/// </summary>
		[Description("영업지원")]
		public int BusinessSupport { get; set; }
		/// <summary>
		/// 발권담당부서
		/// </summary>
		[Description("발권담당부서")]
		public int TicketIssuanceResponsibilityDepartment { get; set; }
		/// <summary>
		/// 인센티브전용BP
		/// </summary>
		[Description("인센티브전용BP")]
		public string IncentiveUseOnlyBP { get; set; }
		/// <summary>
		/// 영업지원부서
		/// </summary>
		[Description("영업지원부서")]
		public int BusinessSupportDepartment { get; set; }
		/// <summary>
		/// 이전담당OP
		/// </summary>
		[Description("이전담당OP")]
		public int PreviousResponsibility_OP { get; set; }
		/// <summary>
		/// 이전담당OP부서
		/// </summary>
		[Description("이전담당OP부서")]
		public int PreviousResponsibility_OP_Department { get; set; }
		/// <summary>
		/// 이전영업지원
		/// </summary>
		[Description("이전영업지원")]
		public int PreviousBusinessSupport { get; set; }
		/// <summary>
		/// 이전영업지원부서
		/// </summary>
		[Description("이전영업지원부서")]
		public int PreviousBusinessSupportDepartment { get; set; }
		/// <summary>
		/// 영업담당_성과그룹2
		/// </summary>
		[Description("영업담당_성과그룹2")]
		public string BusinessResponsibility_PerformanceGroup2 { get; set; }
		/// <summary>
		/// 예약운영_성과그룹2
		/// </summary>
		[Description("예약운영_성과그룹2")]
		public string BookingOperation_PerformanceGroup2 { get; set; }
		/// <summary>
		/// 영업지원_성과그룹2
		/// </summary>
		[Description("영업지원_성과그룹2")]
		public string BusinessSupport_PerformanceGroup2 { get; set; }
		/// <summary>
		/// 현지연락처2
		/// </summary>
		[Description("현지연락처2")]
		public string LocalContact2 { get; set; }
		/// <summary>
		/// 현지연락처3
		/// </summary>
		[Description("현지연락처3")]
		public string LocalContact3 { get; set; }
		/// <summary>
		/// 여행계약서_기준금액
		/// </summary>
		[Description("여행계약서_기준금액")]
		public string TravelContract_StandardAmount { get; set; }
		/// <summary>
		/// 상용티켓대리점VI지급대상
		/// </summary>
		[Description("상용티켓대리점VI지급대상")]
		public string CommercialTicketAgencyVIPaymentCandidate { get; set; }
		/// <summary>
		/// 비즈전용BP
		/// </summary>
		[Description("비즈전용BP")]
		public string BusinessUseOnlyBP { get; set; }
		/// <summary>
		/// 으뜸BP
		/// </summary>
		[Description("으뜸BP")]
		public string Best_BP { get; set; }
		/// <summary>
		/// 거래처번호집합
		/// </summary>
		[Description("거래처번호집합")]
		public string CustomerNumberGathering { get; set; }
		/// <summary>
		/// BTMS_사이트주소
		/// </summary>
		[Description("BTMS_사이트주소")]
		public string BTMS_SiteAddress { get; set; }
		/// <summary>
		/// BTMS_항공담당자
		/// </summary>
		[Description("BTMS_항공담당자")]
		public int BTMS_FlightManager { get; set; }
		/// <summary>
		/// BTMS_호텔담당자
		/// </summary>
		[Description("BTMS_호텔담당자")]
		public int BTMS_HotelManager { get; set; }
		/// <summary>
		/// BTMS_비자담당자
		/// </summary>
		[Description("BTMS_비자담당자")]
		public int BTMS_VisaManager { get; set; }
		/// <summary>
		/// BTMS_출장규정파일
		/// </summary>
		[Description("BTMS_출장규정파일")]
		public string BTMS_BusinessTripRegulationsFile { get; set; }
		/// <summary>
		/// BTMS_승인기능사용여부
		/// </summary>
		[Description("BTMS_승인기능사용여부")]
		public string BTMS_ApprovalFunctionUseOrNot { get; set; }
		/// <summary>
		/// 박람회거래처여부
		/// </summary>
		[Description("박람회거래처여부")]
		public string ExhibitionCustomerOrNot { get; set; }
		/// <summary>
		/// 국내발권담당
		/// </summary>
		[Description("국내발권담당")]
		public int DomesticTicketIssuanceResponsibility { get; set; }
		/// <summary>
		/// 국내발권담당부서
		/// </summary>
		[Description("국내발권담당부서")]
		public int DomesticTicketIssuanceResponsibilityDepartment { get; set; }
		/// <summary>
		/// 샌드빌가입여부
		/// </summary>
		[Description("샌드빌가입여부")]
		public string SendbillSignUpOrNot { get; set; }
		/// <summary>
		/// 닷컴_통신판매업신고번호
		/// </summary>
		[Description("닷컴_통신판매업신고번호")]
		public string DotCom_TelemarketingBusinessRegisterNumber { get; set; }
		/// <summary>
		/// 닷컴_개인정보보호책임자
		/// </summary>
		[Description("닷컴_개인정보보호책임자")]
		public string DotCom_PersonalInfoProtectManager { get; set; }
		/// <summary>
		/// 닷컴_영업보증보험
		/// </summary>
		[Description("닷컴_영업보증보험")]
		public string DotCom_BusinessGuaranteeInsurance { get; set; }
		/// <summary>
		/// 닷컴_관광사업자등록번호
		/// </summary>
		[Description("닷컴_관광사업자등록번호")]
		public string DotCom_SightseeingBusinessLicenseNumber { get; set; }
		/// <summary>
		/// 이전영업코디
		/// </summary>
		[Description("이전영업코디")]
		public int PreviousBusinessCoordination { get; set; }
		/// <summary>
		/// 이전영업코디부서
		/// </summary>
		[Description("이전영업코디부서")]
		public int PreviousBusinessCoordinationDepartment { get; set; }
		/// <summary>
		/// 영업코디
		/// </summary>
		[Description("영업코디")]
		public int BusinessCoordination { get; set; }
		/// <summary>
		/// 영업코디부서
		/// </summary>
		[Description("영업코디부서")]
		public int BusinessCoordinationDepartment { get; set; }
		/// <summary>
		/// 영업코디_성과그룹2
		/// </summary>
		[Description("영업코디_성과그룹2")]
		public string BusinessCoordination_PerformanceGroup2 { get; set; }
		/// <summary>
		/// 마일리지샵_대표아이디
		/// </summary>
		[Description("마일리지샵_대표아이디")]
		public string MileageShop_Representative_ID { get; set; }
		/// <summary>
		/// 결제수단
		/// </summary>
		[Description("결제수단")]
		public string PaymentMethod { get; set; }
		/// <summary>
		/// 홈페이지주소_모바일
		/// </summary>
		[Description("홈페이지주소_모바일")]
		public string HomePageAddress_Mobile { get; set; }
	}

}