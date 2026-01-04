namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_입사지원서_미리보기_NEW
/// </summary>
public class USP_S_CompanyJoiningLetter_Preview_NEW
{
	public const string SP_NAME = "USP_S_입사지원서_미리보기_NEW";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자ID
		/// </summary>
		[Description("지원자ID")]
		public int Supporter_ID { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Column("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 지원자ID
		/// </summary>
		[Column("지원자ID")]
		public decimal Supporter_ID { get; set; }
		/// <summary>
		/// 성명
		/// </summary>
		[Column("성명")]
		public string Name { get; set; }
		/// <summary>
		/// 영문성
		/// </summary>
		[Column("영문성")]
		public string EnglishLastName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 주민등록번호
		/// </summary>
		[Column("주민등록번호")]
		public string CitizenRegisterNumber { get; set; }
		/// <summary>
		/// 집사무실
		/// </summary>
		[Column("집사무실")]
		public string HouseOffice { get; set; }
		/// <summary>
		/// 비상연락처
		/// </summary>
		[Column("비상연락처")]
		public string EmergencyContact { get; set; }
		/// <summary>
		/// 휴대전화
		/// </summary>
		[Column("휴대전화")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 본적지
		/// </summary>
		[Column("본적지")]
		public string Domicile { get; set; }
		/// <summary>
		/// 현주소
		/// </summary>
		[Column("현주소")]
		public string CurrentAddress { get; set; }
		/// <summary>
		/// 주민등록상거주지
		/// </summary>
		[Column("주민등록상거주지")]
		public string AddressOnResidenceRegistrationCard { get; set; }
		/// <summary>
		/// 결혼여부
		/// </summary>
		[Column("결혼여부")]
		public string MarriedOrNot { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 입사가능일
		/// </summary>
		[Column("입사가능일")]
		public string CompanyJoiningPossibleDate { get; set; }
		/// <summary>
		/// 지원경로
		/// </summary>
		[Column("지원경로")]
		public string SupportRoute { get; set; }
		/// <summary>
		/// 국적
		/// </summary>
		[Column("국적")]
		public string Nationality { get; set; }
		/// <summary>
		/// 희망부문1
		/// </summary>
		[Column("희망부문1")]
		public string DesiredSection1 { get; set; }
		/// <summary>
		/// 희망부문2
		/// </summary>
		[Column("희망부문2")]
		public string DesiredSection2 { get; set; }
		/// <summary>
		/// 희망근무지1
		/// </summary>
		[Column("희망근무지1")]
		public string DesiredWorkPlace1 { get; set; }
		/// <summary>
		/// 희망근무지2
		/// </summary>
		[Column("희망근무지2")]
		public string DesiredWorkPlace2 { get; set; }
		/// <summary>
		/// 사진명
		/// </summary>
		[Column("사진명")]
		public string PictureName { get; set; }
		/// <summary>
		/// 채용설문노출여부
		/// </summary>
		[Column("채용설문노출여부")]
		public string RecruitSurveyDisplayOrNot { get; set; }
		/// <summary>
		/// 연고지주소
		/// </summary>
		[Column("연고지주소")]
		public string HometownAddress { get; set; }
		/// <summary>
		/// 연고지주소인관계
		/// </summary>
		[Column("연고지주소인관계")]
		public string HometownAddress인Relationship { get; set; }
		/// <summary>
		/// 한문성명
		/// </summary>
		[Column("한문성명")]
		public string ChineseCharacterName { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 신장
		/// </summary>
		[Column("신장")]
		public int Height { get; set; }
		/// <summary>
		/// 체중
		/// </summary>
		[Column("체중")]
		public int Weight { get; set; }
		/// <summary>
		/// 시력좌
		/// </summary>
		[Column("시력좌")]
		public int EyesightLeft { get; set; }
		/// <summary>
		/// 시력우
		/// </summary>
		[Column("시력우")]
		public int EyesightRight { get; set; }
		/// <summary>
		/// 혈액형
		/// </summary>
		[Column("혈액형")]
		public int BloodType { get; set; }
		/// <summary>
		/// 특이사항
		/// </summary>
		[Column("특이사항")]
		public int Specific { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 기념일종류
		/// </summary>
		[Column("기념일종류")]
		public int AnniversaryDateType { get; set; }
		/// <summary>
		/// 일자
		/// </summary>
		[Column("일자")]
		public int Date { get; set; }
		/// <summary>
		/// 음양구분
		/// </summary>
		[Column("음양구분")]
		public int NegativePositiveClassification { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 병역구분
		/// </summary>
		[Column("병역구분")]
		public int MilitaryServiceClassification { get; set; }
		/// <summary>
		/// 군별
		/// </summary>
		[Column("군별")]
		public int EachMilitary { get; set; }
		/// <summary>
		/// 입대일
		/// </summary>
		[Column("입대일")]
		public int JoinMilitaryDate { get; set; }
		/// <summary>
		/// 제대일
		/// </summary>
		[Column("제대일")]
		public int ArmyDischargeDate { get; set; }
		/// <summary>
		/// 계급
		/// </summary>
		[Column("계급")]
		public int Class { get; set; }
		/// <summary>
		/// 병과
		/// </summary>
		[Column("병과")]
		public int MilitaryServiceBranch { get; set; }
		/// <summary>
		/// 전역사유
		/// </summary>
		[Column("전역사유")]
		public int ChangeMilitaryReason { get; set; }
		/// <summary>
		/// 미필사유
		/// </summary>
		[Column("미필사유")]
		public int UnfinishReason { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 보훈대상여부
		/// </summary>
		[Column("보훈대상여부")]
		public int WarVeteranCandidateOrNot { get; set; }
		/// <summary>
		/// 보훈번호
		/// </summary>
		[Column("보훈번호")]
		public int WarVeteranNumber { get; set; }
		/// <summary>
		/// 보훈사유
		/// </summary>
		[Column("보훈사유")]
		public int WarVeteranReason { get; set; }
		/// <summary>
		/// 보훈대상자와의관계
		/// </summary>
		[Column("보훈대상자와의관계")]
		public int RelationshipWithWarVeteranCandidateperson { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// 장애인등록일자
		/// </summary>
		[Column("장애인등록일자")]
		public int DisabledPersonRegisterDate { get; set; }
		/// <summary>
		/// 장애인등록번호
		/// </summary>
		[Column("장애인등록번호")]
		public int DisabledPersonRegisterNumber { get; set; }
		/// <summary>
		/// 장애구분
		/// </summary>
		[Column("장애구분")]
		public int ObstacleClassification { get; set; }
		/// <summary>
		/// 장애유형
		/// </summary>
		[Column("장애유형")]
		public int ObstacleType { get; set; }
		/// <summary>
		/// 장애등급
		/// </summary>
		[Column("장애등급")]
		public int ObstacleClass { get; set; }
		/// <summary>
		/// 중증여부
		/// </summary>
		[Column("중증여부")]
		public int SeriousOrNot { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// 성명
		/// </summary>
		[Column("성명")]
		public int Name { get; set; }
		/// <summary>
		/// 근무처
		/// </summary>
		[Column("근무처")]
		public int WorkingPlace { get; set; }
		/// <summary>
		/// 직위
		/// </summary>
		[Column("직위")]
		public int Position { get; set; }
		/// <summary>
		/// 관계
		/// </summary>
		[Column("관계")]
		public int Relationship { get; set; }
	}

	public class Result8 : IDbResult
	{
		/// <summary>
		/// 취미
		/// </summary>
		[Column("취미")]
		public int Hobby { get; set; }
		/// <summary>
		/// 특기
		/// </summary>
		[Column("특기")]
		public int Special { get; set; }
		/// <summary>
		/// 종교
		/// </summary>
		[Column("종교")]
		public int Religion { get; set; }
		/// <summary>
		/// 흡연여부
		/// </summary>
		[Column("흡연여부")]
		public int SmokingOrNot { get; set; }
		/// <summary>
		/// 주량
		/// </summary>
		[Column("주량")]
		public int DrinkingLevel { get; set; }
	}

	public class Result9 : IDbResult
	{
		/// <summary>
		/// 학력구분
		/// </summary>
		[Column("학력구분")]
		public int EducationLevelClassification { get; set; }
		/// <summary>
		/// 입학월
		/// </summary>
		[Column("입학월")]
		public int SchoolStartingMonth { get; set; }
		/// <summary>
		/// 졸업월
		/// </summary>
		[Column("졸업월")]
		public int GraduationMonth { get; set; }
		/// <summary>
		/// 학교명
		/// </summary>
		[Column("학교명")]
		public int SchoolName { get; set; }
		/// <summary>
		/// 소재지
		/// </summary>
		[Column("소재지")]
		public int Location { get; set; }
		/// <summary>
		/// 최종학력
		/// </summary>
		[Column("최종학력")]
		public int FinalEducationLevel { get; set; }
	}

	public class Result10 : IDbResult
	{
		/// <summary>
		/// 학력구분
		/// </summary>
		[Column("학력구분")]
		public int EducationLevelClassification { get; set; }
		/// <summary>
		/// 입학월
		/// </summary>
		[Column("입학월")]
		public int SchoolStartingMonth { get; set; }
		/// <summary>
		/// 졸업월
		/// </summary>
		[Column("졸업월")]
		public int GraduationMonth { get; set; }
		/// <summary>
		/// 학교명
		/// </summary>
		[Column("학교명")]
		public int SchoolName { get; set; }
		/// <summary>
		/// 소재지
		/// </summary>
		[Column("소재지")]
		public int Location { get; set; }
		/// <summary>
		/// 최종학력
		/// </summary>
		[Column("최종학력")]
		public int FinalEducationLevel { get; set; }
		/// <summary>
		/// 전공
		/// </summary>
		[Column("전공")]
		public int Major { get; set; }
		/// <summary>
		/// 취득학점
		/// </summary>
		[Column("취득학점")]
		public int AcquiredCredit { get; set; }
		/// <summary>
		/// 기준학점
		/// </summary>
		[Column("기준학점")]
		public int StandardScore { get; set; }
		/// <summary>
		/// 주야간
		/// </summary>
		[Column("주야간")]
		public int DayAndNight { get; set; }
	}

	public class Result11 : IDbResult
	{
		/// <summary>
		/// 학력구분
		/// </summary>
		[Column("학력구분")]
		public int EducationLevelClassification { get; set; }
		/// <summary>
		/// 입학월
		/// </summary>
		[Column("입학월")]
		public int SchoolStartingMonth { get; set; }
		/// <summary>
		/// 졸업월
		/// </summary>
		[Column("졸업월")]
		public int GraduationMonth { get; set; }
		/// <summary>
		/// 학교명
		/// </summary>
		[Column("학교명")]
		public int SchoolName { get; set; }
		/// <summary>
		/// 소재지
		/// </summary>
		[Column("소재지")]
		public int Location { get; set; }
		/// <summary>
		/// 최종학력
		/// </summary>
		[Column("최종학력")]
		public int FinalEducationLevel { get; set; }
		/// <summary>
		/// 전공
		/// </summary>
		[Column("전공")]
		public int Major { get; set; }
		/// <summary>
		/// 제2전공명
		/// </summary>
		[Column("제2전공명")]
		public int SecondMajorName { get; set; }
		/// <summary>
		/// 취득학점
		/// </summary>
		[Column("취득학점")]
		public int AcquiredCredit { get; set; }
		/// <summary>
		/// 기준학점
		/// </summary>
		[Column("기준학점")]
		public int StandardScore { get; set; }
		/// <summary>
		/// 주야간
		/// </summary>
		[Column("주야간")]
		public int DayAndNight { get; set; }
		/// <summary>
		/// 편입여부
		/// </summary>
		[Column("편입여부")]
		public int TransferOrNot { get; set; }
		/// <summary>
		/// 본분교
		/// </summary>
		[Column("본분교")]
		public int MainBrandSchool { get; set; }
	}

	public class Result12 : IDbResult
	{
		/// <summary>
		/// 학력구분
		/// </summary>
		[Column("학력구분")]
		public int EducationLevelClassification { get; set; }
		/// <summary>
		/// 입학월
		/// </summary>
		[Column("입학월")]
		public int SchoolStartingMonth { get; set; }
		/// <summary>
		/// 졸업월
		/// </summary>
		[Column("졸업월")]
		public int GraduationMonth { get; set; }
		/// <summary>
		/// 학교명
		/// </summary>
		[Column("학교명")]
		public int SchoolName { get; set; }
		/// <summary>
		/// 소재지
		/// </summary>
		[Column("소재지")]
		public int Location { get; set; }
		/// <summary>
		/// 최종학력
		/// </summary>
		[Column("최종학력")]
		public int FinalEducationLevel { get; set; }
		/// <summary>
		/// 전공
		/// </summary>
		[Column("전공")]
		public int Major { get; set; }
		/// <summary>
		/// 세부전공명
		/// </summary>
		[Column("세부전공명")]
		public int DetailMajorName { get; set; }
		/// <summary>
		/// 취득학점
		/// </summary>
		[Column("취득학점")]
		public int AcquiredCredit { get; set; }
		/// <summary>
		/// 기준학점
		/// </summary>
		[Column("기준학점")]
		public int StandardScore { get; set; }
		/// <summary>
		/// 논문명
		/// </summary>
		[Column("논문명")]
		public int ThesisName { get; set; }
		/// <summary>
		/// 졸업수료
		/// </summary>
		[Column("졸업수료")]
		public int GraduationCompletion { get; set; }
	}

	public class Result13 : IDbResult
	{
		/// <summary>
		/// 업종
		/// </summary>
		[Column("업종")]
		public int BusinessType { get; set; }
		/// <summary>
		/// 근무시작일
		/// </summary>
		[Column("근무시작일")]
		public int WorkStartDate { get; set; }
		/// <summary>
		/// 근무종료일
		/// </summary>
		[Column("근무종료일")]
		public int WorkEndDate { get; set; }
		/// <summary>
		/// 근속년도
		/// </summary>
		[Column("근속년도")]
		public int ContinuouslyWorkingYears { get; set; }
		/// <summary>
		/// 직장명
		/// </summary>
		[Column("직장명")]
		public int WorkingPlaceName { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public int DepartmentName { get; set; }
		/// <summary>
		/// 최종직위
		/// </summary>
		[Column("최종직위")]
		public int FinalPosition { get; set; }
		/// <summary>
		/// 직무
		/// </summary>
		[Column("직무")]
		public int Duty { get; set; }
		/// <summary>
		/// 연봉수준
		/// </summary>
		[Column("연봉수준")]
		public int AnnualSalaryStandard { get; set; }
		/// <summary>
		/// 고용형태
		/// </summary>
		[Column("고용형태")]
		public int EmploymentFormat { get; set; }
		/// <summary>
		/// 퇴직사유
		/// </summary>
		[Column("퇴직사유")]
		public int RetirementReason { get; set; }
		/// <summary>
		/// 소재지
		/// </summary>
		[Column("소재지")]
		public int Location { get; set; }
		/// <summary>
		/// 근무내용
		/// </summary>
		[Column("근무내용")]
		public int WorkContent { get; set; }
		/// <summary>
		/// 근무개월
		/// </summary>
		[Column("근무개월")]
		public int WorkingMonths { get; set; }
	}

	public class Result14 : IDbResult
	{
		/// <summary>
		/// 현재직위
		/// </summary>
		[Column("현재직위")]
		public int CurrentPosition { get; set; }
		/// <summary>
		/// 현재입사일
		/// </summary>
		[Column("현재입사일")]
		public int CurrentCompanyJoiningDate { get; set; }
		/// <summary>
		/// 현재승진일
		/// </summary>
		[Column("현재승진일")]
		public int CurrentPromotedDate { get; set; }
		/// <summary>
		/// 현재연봉
		/// </summary>
		[Column("현재연봉")]
		public int CurrentAnnualSalary { get; set; }
		/// <summary>
		/// 희망직위
		/// </summary>
		[Column("희망직위")]
		public int DesiredPosition { get; set; }
		/// <summary>
		/// 희망연봉
		/// </summary>
		[Column("희망연봉")]
		public int DesiredAnnualSalary { get; set; }
		/// <summary>
		/// 기타희망사항
		/// </summary>
		[Column("기타희망사항")]
		public int OtherWishList { get; set; }
	}

	public class Result15 : IDbResult
	{
		/// <summary>
		/// 발급일
		/// </summary>
		[Column("발급일")]
		public int IssuanceDate { get; set; }
		/// <summary>
		/// 자격면허명
		/// </summary>
		[Column("자격면허명")]
		public int QualificationLicenseName { get; set; }
		/// <summary>
		/// 자격증번호
		/// </summary>
		[Column("자격증번호")]
		public int CertificateNumber { get; set; }
		/// <summary>
		/// 발급기관
		/// </summary>
		[Column("발급기관")]
		public int IssuanceOffice { get; set; }
	}

	public class Result16 : IDbResult
	{
		/// <summary>
		/// 수상일
		/// </summary>
		[Column("수상일")]
		public int PrizeReceiptDate { get; set; }
		/// <summary>
		/// 수상명
		/// </summary>
		[Column("수상명")]
		public int PrizeReceiptName { get; set; }
		/// <summary>
		/// 수상기관
		/// </summary>
		[Column("수상기관")]
		public int PrizeReceiptOffice { get; set; }
		/// <summary>
		/// 수상내용
		/// </summary>
		[Column("수상내용")]
		public int PrizeReceivingContent { get; set; }
	}

	public class Result17 : IDbResult
	{
		/// <summary>
		/// 사회활동종류
		/// </summary>
		[Column("사회활동종류")]
		public int SocialActivityType { get; set; }
		/// <summary>
		/// 시작일
		/// </summary>
		[Column("시작일")]
		public int StartDate { get; set; }
		/// <summary>
		/// 종료일
		/// </summary>
		[Column("종료일")]
		public int EndDate { get; set; }
		/// <summary>
		/// 단체명
		/// </summary>
		[Column("단체명")]
		public int GroupName { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public int Content { get; set; }
	}

	public class Result18 : IDbResult
	{
		/// <summary>
		/// 시험일자
		/// </summary>
		[Column("시험일자")]
		public int TestDate { get; set; }
		/// <summary>
		/// 어학종류
		/// </summary>
		[Column("어학종류")]
		public int LinguisticType { get; set; }
		/// <summary>
		/// 어학시험종류
		/// </summary>
		[Column("어학시험종류")]
		public int LinguisticExamType { get; set; }
		/// <summary>
		/// 어학평가점수
		/// </summary>
		[Column("어학평가점수")]
		public int LinguisticEvaluationScore { get; set; }
		/// <summary>
		/// 어학평가등급
		/// </summary>
		[Column("어학평가등급")]
		public int LinguisticEvaluationClass { get; set; }
		/// <summary>
		/// 어학특이사항
		/// </summary>
		[Column("어학특이사항")]
		public int LinguisticUnusualMatters { get; set; }
	}

	public class Result19 : IDbResult
	{
		/// <summary>
		/// 어학종류
		/// </summary>
		[Column("어학종류")]
		public int LinguisticType { get; set; }
		/// <summary>
		/// 회화수준
		/// </summary>
		[Column("회화수준")]
		public int SpeechLevel { get; set; }
		/// <summary>
		/// 특이사항
		/// </summary>
		[Column("특이사항")]
		public int Specific { get; set; }
	}

	public class Result20 : IDbResult
	{
		/// <summary>
		/// 가족관계
		/// </summary>
		[Column("가족관계")]
		public int FamilyRelationship { get; set; }
		/// <summary>
		/// 가족성명
		/// </summary>
		[Column("가족성명")]
		public int FamilyName { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Column("생년월일")]
		public int BirthYearMonthDay { get; set; }
		/// <summary>
		/// 출신학교
		/// </summary>
		[Column("출신학교")]
		public int OriginSchool { get; set; }
		/// <summary>
		/// 학교
		/// </summary>
		[Column("학교")]
		public int School { get; set; }
		/// <summary>
		/// 학년
		/// </summary>
		[Column("학년")]
		public int SchoolYear { get; set; }
		/// <summary>
		/// 동거여부
		/// </summary>
		[Column("동거여부")]
		public int CohabitOrNot { get; set; }
	}

	public class Result21 : IDbResult
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public int Classification { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public int Content { get; set; }
	}

	public class Result22 : IDbResult
	{
		/// <summary>
		/// 학력구분
		/// </summary>
		[Column("학력구분")]
		public string EducationLevelClassification { get; set; }
		/// <summary>
		/// 입학월
		/// </summary>
		[Column("입학월")]
		public string SchoolStartingMonth { get; set; }
		/// <summary>
		/// 졸업월
		/// </summary>
		[Column("졸업월")]
		public string GraduationMonth { get; set; }
		/// <summary>
		/// 학교명
		/// </summary>
		[Column("학교명")]
		public string SchoolName { get; set; }
		/// <summary>
		/// 소재지
		/// </summary>
		[Column("소재지")]
		public string Location { get; set; }
		/// <summary>
		/// 최종학력
		/// </summary>
		[Column("최종학력")]
		public string FinalEducationLevel { get; set; }
		/// <summary>
		/// 전공
		/// </summary>
		[Column("전공")]
		public string Major { get; set; }
		/// <summary>
		/// 제2전공명
		/// </summary>
		[Column("제2전공명")]
		public string SecondMajorName { get; set; }
		/// <summary>
		/// 취득학점
		/// </summary>
		[Column("취득학점")]
		public decimal AcquiredCredit { get; set; }
		/// <summary>
		/// 기준학점
		/// </summary>
		[Column("기준학점")]
		public decimal StandardScore { get; set; }
		/// <summary>
		/// 주야간
		/// </summary>
		[Column("주야간")]
		public string DayAndNight { get; set; }
		/// <summary>
		/// 편입여부
		/// </summary>
		[Column("편입여부")]
		public string TransferOrNot { get; set; }
		/// <summary>
		/// 본분교
		/// </summary>
		[Column("본분교")]
		public string MainBrandSchool { get; set; }
		/// <summary>
		/// 논문명
		/// </summary>
		[Column("논문명")]
		public string ThesisName { get; set; }
		/// <summary>
		/// 졸업수료
		/// </summary>
		[Column("졸업수료")]
		public string GraduationCompletion { get; set; }
	}

	public class Result23 : IDbResult
	{
		/// <summary>
		/// 종류
		/// </summary>
		[Column("종류")]
		public int Type { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public int ID { get; set; }
	}

	public class Result24 : IDbResult
	{
		/// <summary>
		/// 업종
		/// </summary>
		[Column("업종")]
		public int BusinessType { get; set; }
		/// <summary>
		/// 횟수
		/// </summary>
		[Column("횟수")]
		public int Times { get; set; }
	}

	public class Result25 : IDbResult
	{
		/// <summary>
		/// 설문내용
		/// </summary>
		[Column("설문내용")]
		public int SurveyContent { get; set; }
		/// <summary>
		/// 답변
		/// </summary>
		[Column("답변")]
		public int Answer { get; set; }
		/// <summary>
		/// 직접입력
		/// </summary>
		[Column("직접입력")]
		public int DirectInput { get; set; }
	}

	public class Result26 : IDbResult
	{
		/// <summary>
		/// 교육기관
		/// </summary>
		[Column("교육기관")]
		public int EducationOffice { get; set; }
		/// <summary>
		/// 교육과정
		/// </summary>
		[Column("교육과정")]
		public int EducationProcess { get; set; }
		/// <summary>
		/// 주요내용
		/// </summary>
		[Column("주요내용")]
		public int MainContent { get; set; }
		/// <summary>
		/// 강사
		/// </summary>
		[Column("강사")]
		public int Instructor { get; set; }
		/// <summary>
		/// 시작일
		/// </summary>
		[Column("시작일")]
		public int StartDate { get; set; }
		/// <summary>
		/// 마감일
		/// </summary>
		[Column("마감일")]
		public int EndDate { get; set; }
		/// <summary>
		/// 기준점수
		/// </summary>
		[Column("기준점수")]
		public int StandardScore { get; set; }
		/// <summary>
		/// 취득점수
		/// </summary>
		[Column("취득점수")]
		public int AccquirementScore { get; set; }
	}

	public class Result27 : IDbResult
	{
		/// <summary>
		/// 기관
		/// </summary>
		[Column("기관")]
		public int Office { get; set; }
		/// <summary>
		/// 행사명
		/// </summary>
		[Column("행사명")]
		public int EventName { get; set; }
		/// <summary>
		/// 행사내용
		/// </summary>
		[Column("행사내용")]
		public int EventContent { get; set; }
		/// <summary>
		/// 시작일
		/// </summary>
		[Column("시작일")]
		public int StartDate { get; set; }
		/// <summary>
		/// 마감일
		/// </summary>
		[Column("마감일")]
		public int EndDate { get; set; }
		/// <summary>
		/// 활동내역및느낀점
		/// </summary>
		[Column("활동내역및느낀점")]
		public int ActivityHistoryAndReview { get; set; }
	}

	public class Result28 : IDbResult
	{
		/// <summary>
		/// 첨부파일일련번호
		/// </summary>
		[Column("첨부파일일련번호")]
		public int AttachFileSerialNumber { get; set; }
		/// <summary>
		/// 파일종류코드번호
		/// </summary>
		[Column("파일종류코드번호")]
		public int FileTypeCodeNumber { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
		/// <summary>
		/// 파일종류코드명
		/// </summary>
		[Column("파일종류코드명")]
		public string FileTypeCodeName { get; set; }
	}
}