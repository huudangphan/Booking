namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_사원_부서번호
/// </summary>
public class USP_S_Employee_DepartmentNumber
{
	public const string SP_NAME = "USP_S_사원_부서번호";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 사원명
		/// </summary>
		[Description("사원명")]
		public string StaffName { get; set; }
		/// <summary>
		/// 부서번호
		/// </summary>
		[Description("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 퇴직
		/// </summary>
		[Description("퇴직")]
		public string Retirement { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 사원번호
		/// </summary>
		[Column("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 사원한글명
		/// </summary>
		[Column("사원한글명")]
		public string StaffKoreanName { get; set; }
		/// <summary>
		/// 사원영문명
		/// </summary>
		[Column("사원영문명")]
		public string StaffEnglishName { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Column("주민번호")]
		public string CitizenIDNumber { get; set; }
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
		/// 직통번호
		/// </summary>
		[Column("직통번호")]
		public string DirectPhoneLineNumber { get; set; }
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
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 소속부서
		/// </summary>
		[Column("소속부서")]
		public string AffiliationDepartment { get; set; }
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
		/// 영업결재자한글명
		/// </summary>
		[Column("영업결재자한글명")]
		public string BusinessApproverKoreanName { get; set; }
		/// <summary>
		/// 영업결재자번호
		/// </summary>
		[Column("영업결재자번호")]
		public int BusinessApproverNumber { get; set; }
		/// <summary>
		/// 수배결재자한글명
		/// </summary>
		[Column("수배결재자한글명")]
		public string WantedApproverKoreanName { get; set; }
		/// <summary>
		/// 수배결재자번호
		/// </summary>
		[Column("수배결재자번호")]
		public int WantedApproverNumber { get; set; }
		/// <summary>
		/// 영업대결자한글명
		/// </summary>
		[Column("영업대결자한글명")]
		public string BusinessCompetitorKoreanName { get; set; }
		/// <summary>
		/// 영업대결자번호
		/// </summary>
		[Column("영업대결자번호")]
		public int BusinessCompetitorNumber { get; set; }
		/// <summary>
		/// 수배대결자한글명
		/// </summary>
		[Column("수배대결자한글명")]
		public string WantedCompetitorKoreanName { get; set; }
		/// <summary>
		/// 수배대결자번호
		/// </summary>
		[Column("수배대결자번호")]
		public int WantedCompetitorNumber { get; set; }
		/// <summary>
		/// 담당OP
		/// </summary>
		[Column("담당OP")]
		public string Responsibility_OP { get; set; }
		/// <summary>
		/// 담당OP번호
		/// </summary>
		[Column("담당OP번호")]
		public int Responsibility_OP_Number { get; set; }
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
		/// 직위
		/// </summary>
		[Column("직위")]
		public string Position { get; set; }
		/// <summary>
		/// 직무
		/// </summary>
		[Column("직무")]
		public string Duty { get; set; }
		/// <summary>
		/// 임원
		/// </summary>
		[Column("임원")]
		public string Executive { get; set; }
		/// <summary>
		/// 팀장
		/// </summary>
		[Column("팀장")]
		public string TeamLeader { get; set; }
		/// <summary>
		/// 결재권한
		/// </summary>
		[Column("결재권한")]
		public string ApprovalAuthority { get; set; }
		/// <summary>
		/// 직책_수당
		/// </summary>
		[Column("직책_수당")]
		public string Duty_ExtraPay { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 작업그룹
		/// </summary>
		[Column("작업그룹")]
		public string WorkingGroup { get; set; }
		/// <summary>
		/// 퇴직
		/// </summary>
		[Column("퇴직")]
		public string Retirement { get; set; }
		/// <summary>
		/// 담당업무
		/// </summary>
		[Column("담당업무")]
		public string ResponsibilityTask { get; set; }
		/// <summary>
		/// 입사일
		/// </summary>
		[Column("입사일")]
		public DateTime CompanyJoiningDate { get; set; }
		/// <summary>
		/// 경력기준일
		/// </summary>
		[Column("경력기준일")]
		public DateTime WorkExperienceStandardDate { get; set; }
		/// <summary>
		/// 대결사용
		/// </summary>
		[Column("대결사용")]
		public string CompetitionUse { get; set; }
		/// <summary>
		/// 출근카드번호
		/// </summary>
		[Column("출근카드번호")]
		public string WorkingCardNumber { get; set; }
		/// <summary>
		/// 사번
		/// </summary>
		[Column("사번")]
		public string EmployeeIdentifiedNumber { get; set; }
		/// <summary>
		/// 대표전화
		/// </summary>
		[Column("대표전화")]
		public string RepresentativePhone { get; set; }
		/// <summary>
		/// 화면잠금시간
		/// </summary>
		[Column("화면잠금시간")]
		public int ScreenLockingTime { get; set; }
		/// <summary>
		/// 휴가
		/// </summary>
		[Column("휴가")]
		public string Vacation { get; set; }
		/// <summary>
		/// 단기휴직일
		/// </summary>
		[Column("단기휴직일")]
		public DateTime ShortTermAbsenceDate { get; set; }
		/// <summary>
		/// 단기휴직시작
		/// </summary>
		[Column("단기휴직시작")]
		public DateTime ShortTermAbsenceStart { get; set; }
		/// <summary>
		/// 단기휴직종료
		/// </summary>
		[Column("단기휴직종료")]
		public DateTime ShortTermAbsenceEnd { get; set; }
		/// <summary>
		/// 출산육아구분
		/// </summary>
		[Column("출산육아구분")]
		public string ChildbirthMaternityClassification { get; set; }
		/// <summary>
		/// 출산육아시작
		/// </summary>
		[Column("출산육아시작")]
		public DateTime ChildbirthMaternityStart { get; set; }
		/// <summary>
		/// 출산육아종료
		/// </summary>
		[Column("출산육아종료")]
		public DateTime ChildbirthMaternityEnd { get; set; }
		/// <summary>
		/// 퇴직예정일
		/// </summary>
		[Column("퇴직예정일")]
		public DateTime RetirementExpectationDate { get; set; }
		/// <summary>
		/// 고유번호
		/// </summary>
		[Column("고유번호")]
		public string UniqueNumber { get; set; }
		/// <summary>
		/// 발권대행자
		/// </summary>
		[Column("발권대행자")]
		public string TicketIssuanceProcurator { get; set; }
		/// <summary>
		/// 발권대행자번호
		/// </summary>
		[Column("발권대행자번호")]
		public int TicketIssuanceProcuratorNumber { get; set; }
		/// <summary>
		/// 선택
		/// </summary>
		[Column("선택")]
		public string Select { get; set; }
		/// <summary>
		/// 근무지
		/// </summary>
		[Column("근무지")]
		public string WorkPlace { get; set; }
		/// <summary>
		/// 근무지코드
		/// </summary>
		[Column("근무지코드")]
		public string WorkPlaceCode { get; set; }
		/// <summary>
		/// 근무지선택
		/// </summary>
		[Column("근무지선택")]
		public string WorkPlaceSelect { get; set; }
		/// <summary>
		/// 유급휴직시작
		/// </summary>
		[Column("유급휴직시작")]
		public DateTime PaidAbsenceStart { get; set; }
		/// <summary>
		/// 유급휴직종료
		/// </summary>
		[Column("유급휴직종료")]
		public DateTime PaidAbsenceEnd { get; set; }
		/// <summary>
		/// 입력구분
		/// </summary>
		[Column("입력구분")]
		public string InputClassification { get; set; }
		/// <summary>
		/// 삼자카드결제권한
		/// </summary>
		[Column("삼자카드결제권한")]
		public string ThirdPartyCardPaymentAuthority { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Column("SORT")]
		public int SORT { get; set; }
	}
}