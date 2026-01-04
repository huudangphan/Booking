namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_채용_중복지원자_정보_NEW
/// </summary>
public class WSP_S_Recruitment_DuplicationSupporter_Info_NEW
{
	public const string SP_NAME = "WSP_S_채용_중복지원자_정보_NEW";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Description("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 핸드폰번호
		/// </summary>
		[Description("핸드폰번호")]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 사진명
		/// </summary>
		[Column("사진명")]
		public string PictureName { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문성
		/// </summary>
		[Column("영문성")]
		public string EnglishLastName { get; set; }
		/// <summary>
		/// 영문중간이름
		/// </summary>
		[Column("영문중간이름")]
		public string EnglishMiddleName { get; set; }
		/// <summary>
		/// 주민등록번호
		/// </summary>
		[Column("주민등록번호")]
		public string CitizenRegisterNumber { get; set; }
		/// <summary>
		/// 집전화번호
		/// </summary>
		[Column("집전화번호")]
		public string HomePhoneNumber { get; set; }
		/// <summary>
		/// 핸드폰번호
		/// </summary>
		[Column("핸드폰번호")]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// 비상연락처
		/// </summary>
		[Column("비상연락처")]
		public string EmergencyContact { get; set; }
		/// <summary>
		/// 본적지우편번호
		/// </summary>
		[Column("본적지우편번호")]
		public string PermanentDomicileZipCode { get; set; }
		/// <summary>
		/// 본적지주소
		/// </summary>
		[Column("본적지주소")]
		public string PermanentDomicileAddress { get; set; }
		/// <summary>
		/// 본적지상세주소
		/// </summary>
		[Column("본적지상세주소")]
		public string PermanentDomicileDetailAddress { get; set; }
		/// <summary>
		/// 현주소우편번호
		/// </summary>
		[Column("현주소우편번호")]
		public string CurrentAddressZipCode { get; set; }
		/// <summary>
		/// 현주소
		/// </summary>
		[Column("현주소")]
		public string CurrentAddress { get; set; }
		/// <summary>
		/// 현주소상세주소
		/// </summary>
		[Column("현주소상세주소")]
		public string CurrentAddressDetailAddress { get; set; }
		/// <summary>
		/// 주민등록지우편번호
		/// </summary>
		[Column("주민등록지우편번호")]
		public string CitizenRegisterPlaceZipCode { get; set; }
		/// <summary>
		/// 주민등록지주소
		/// </summary>
		[Column("주민등록지주소")]
		public string CitizenRegisterPlaceAddress { get; set; }
		/// <summary>
		/// 주민등록지상세주소
		/// </summary>
		[Column("주민등록지상세주소")]
		public string CitizenRegisterPlaceDetailAddress { get; set; }
		/// <summary>
		/// 결혼여부
		/// </summary>
		[Column("결혼여부")]
		public string MarriedOrNot { get; set; }
		/// <summary>
		/// 전자우편주소
		/// </summary>
		[Column("전자우편주소")]
		public string DigitalPostalAddress { get; set; }
		/// <summary>
		/// 입사가능일즉시여부
		/// </summary>
		[Column("입사가능일즉시여부")]
		public string CompanyJoiningPossibleDateImmediateOrNot { get; set; }
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
		/// 지원경로명
		/// </summary>
		[Column("지원경로명")]
		public string SupportRouteName { get; set; }
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
		/// 최종등록여부
		/// </summary>
		[Column("최종등록여부")]
		public string FinalRegisterOrNot { get; set; }
		/// <summary>
		/// 연고지우편번호
		/// </summary>
		[Column("연고지우편번호")]
		public string HometownZipCode { get; set; }
		/// <summary>
		/// 연고지주소
		/// </summary>
		[Column("연고지주소")]
		public string HometownAddress { get; set; }
		/// <summary>
		/// 연고지상세주소
		/// </summary>
		[Column("연고지상세주소")]
		public string HometownDetailAddress { get; set; }
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
		/// <summary>
		/// 희망근무지해당없음
		/// </summary>
		[Column("희망근무지해당없음")]
		public string DesiredWorkPlaceNA { get; set; }
		/// <summary>
		/// 고등학교해당사항없음
		/// </summary>
		[Column("고등학교해당사항없음")]
		public string HighSchoolNA { get; set; }
		/// <summary>
		/// 전문대해당사항없음
		/// </summary>
		[Column("전문대해당사항없음")]
		public string CollegeNA { get; set; }
		/// <summary>
		/// 대학교해당사항없음
		/// </summary>
		[Column("대학교해당사항없음")]
		public string UniversityNA { get; set; }
		/// <summary>
		/// 대학원석사해당사항없음
		/// </summary>
		[Column("대학원석사해당사항없음")]
		public string MasterDegreeNA { get; set; }
		/// <summary>
		/// 대학원박사해당사항없음
		/// </summary>
		[Column("대학원박사해당사항없음")]
		public string DoctorDegreeNA { get; set; }
		/// <summary>
		/// 지원직무수강해당사항없음
		/// </summary>
		[Column("지원직무수강해당사항없음")]
		public string SupportDutyCourseNA { get; set; }
		/// <summary>
		/// 경력사항해당사항없음
		/// </summary>
		[Column("경력사항해당사항없음")]
		public string WorkExperienceNA { get; set; }
		/// <summary>
		/// 희망직위해당사항없음
		/// </summary>
		[Column("희망직위해당사항없음")]
		public string DesiredPositionNA { get; set; }
		/// <summary>
		/// 외국어능력해당사항없음
		/// </summary>
		[Column("외국어능력해당사항없음")]
		public string ForeignLanguageAbilityNA { get; set; }
		/// <summary>
		/// 회화능력해당사항없음
		/// </summary>
		[Column("회화능력해당사항없음")]
		public string ConversationAbilityNA { get; set; }
		/// <summary>
		/// 자격증해당사항없음
		/// </summary>
		[Column("자격증해당사항없음")]
		public string CertificateNA { get; set; }
		/// <summary>
		/// 수상경력해당사항없음
		/// </summary>
		[Column("수상경력해당사항없음")]
		public string PrizeReceiptExperienceNA { get; set; }
		/// <summary>
		/// 지원직무여행업해당사항없음
		/// </summary>
		[Column("지원직무여행업해당사항없음")]
		public string SupportDutyTravelBusinessNA { get; set; }
		/// <summary>
		/// 사회활동해당사항없음
		/// </summary>
		[Column("사회활동해당사항없음")]
		public string SocialActivityNA { get; set; }
		/// <summary>
		/// 국적명
		/// </summary>
		[Column("국적명")]
		public string NationalityName { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 신장
		/// </summary>
		[Column("신장")]
		public string Height { get; set; }
		/// <summary>
		/// 체중
		/// </summary>
		[Column("체중")]
		public string Weight { get; set; }
		/// <summary>
		/// 시력좌
		/// </summary>
		[Column("시력좌")]
		public string EyesightLeft { get; set; }
		/// <summary>
		/// 시력우
		/// </summary>
		[Column("시력우")]
		public string EyesightRight { get; set; }
		/// <summary>
		/// 혈액형
		/// </summary>
		[Column("혈액형")]
		public string BloodType { get; set; }
		/// <summary>
		/// 특이사항
		/// </summary>
		[Column("특이사항")]
		public string Specific { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 기념일구분코드번호
		/// </summary>
		[Column("기념일구분코드번호")]
		public int AnniversaryClassificationCodeNumber { get; set; }
		/// <summary>
		/// 기념일자
		/// </summary>
		[Column("기념일자")]
		public DateTime AnniversaryDate { get; set; }
		/// <summary>
		/// 음양구분
		/// </summary>
		[Column("음양구분")]
		public string NegativePositiveClassification { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 병역구분코드번호
		/// </summary>
		[Column("병역구분코드번호")]
		public int MilitaryServiceClassificationCodeNumber { get; set; }
		/// <summary>
		/// 군별코드번호
		/// </summary>
		[Column("군별코드번호")]
		public int MilitaryGroupCodeNumber { get; set; }
		/// <summary>
		/// 입대일
		/// </summary>
		[Column("입대일")]
		public DateTime JoinMilitaryDate { get; set; }
		/// <summary>
		/// 제대일
		/// </summary>
		[Column("제대일")]
		public DateTime ArmyDischargeDate { get; set; }
		/// <summary>
		/// 계급코드번호
		/// </summary>
		[Column("계급코드번호")]
		public int RankingCodeNumber { get; set; }
		/// <summary>
		/// 병과코드번호
		/// </summary>
		[Column("병과코드번호")]
		public int MilitaryBranchCodeNumber { get; set; }
		/// <summary>
		/// 전역사유코드번호
		/// </summary>
		[Column("전역사유코드번호")]
		public int MilitaryDischargeReasonCodeNumber { get; set; }
		/// <summary>
		/// 미필사유코드번호
		/// </summary>
		[Column("미필사유코드번호")]
		public string UnfinishedReasonCodeNumber { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 보훈대상여부
		/// </summary>
		[Column("보훈대상여부")]
		public string WarVeteranCandidateOrNot { get; set; }
		/// <summary>
		/// 보훈번호
		/// </summary>
		[Column("보훈번호")]
		public string WarVeteranNumber { get; set; }
		/// <summary>
		/// 보훈사유코드번호
		/// </summary>
		[Column("보훈사유코드번호")]
		public int WarVeteranReasonCodeNumber { get; set; }
		/// <summary>
		/// 보훈대상자와의관계
		/// </summary>
		[Column("보훈대상자와의관계")]
		public string RelationshipWithWarVeteranCandidateperson { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// 장애인등록일자
		/// </summary>
		[Column("장애인등록일자")]
		public DateTime DisabledPersonRegisterDate { get; set; }
		/// <summary>
		/// 장애인등록번호
		/// </summary>
		[Column("장애인등록번호")]
		public string DisabledPersonRegisterNumber { get; set; }
		/// <summary>
		/// 장애구분코드번호
		/// </summary>
		[Column("장애구분코드번호")]
		public int DisabilityClassificationCodeNumber { get; set; }
		/// <summary>
		/// 장애유형코드번호
		/// </summary>
		[Column("장애유형코드번호")]
		public int DisabilityTypeCodeNumber { get; set; }
		/// <summary>
		/// 장애등급코드번호
		/// </summary>
		[Column("장애등급코드번호")]
		public int DisabilityClassCodeNumber { get; set; }
		/// <summary>
		/// 중증여부
		/// </summary>
		[Column("중증여부")]
		public string SeriousOrNot { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// 추천인성명
		/// </summary>
		[Column("추천인성명")]
		public string RecommenderName { get; set; }
		/// <summary>
		/// 추천인근무처
		/// </summary>
		[Column("추천인근무처")]
		public string RecommenderWorkPlace { get; set; }
		/// <summary>
		/// 추천인직위
		/// </summary>
		[Column("추천인직위")]
		public string RecommenderPosition { get; set; }
		/// <summary>
		/// 추천인관계
		/// </summary>
		[Column("추천인관계")]
		public string RecommenderRelationship { get; set; }
	}

	public class Result8 : IDbResult
	{
		/// <summary>
		/// 기타사항내용
		/// </summary>
		[Column("기타사항내용")]
		public string OthersContent { get; set; }
	}

	public class Result9 : IDbResult
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 입학일시
		/// </summary>
		[Column("입학일시")]
		public DateTime SchoolEnteringDateAndTime { get; set; }
		/// <summary>
		/// 졸업일시
		/// </summary>
		[Column("졸업일시")]
		public DateTime GraduationDateAndTime { get; set; }
		/// <summary>
		/// 학교코드명
		/// </summary>
		[Column("학교코드명")]
		public string SchoolCodeName { get; set; }
		/// <summary>
		/// 학교코드번호
		/// </summary>
		[Column("학교코드번호")]
		public int SchoolCodeNumber { get; set; }
		/// <summary>
		/// 소재지코드번호
		/// </summary>
		[Column("소재지코드번호")]
		public int LocationCodeNumber { get; set; }
		/// <summary>
		/// 학력구분코드번호
		/// </summary>
		[Column("학력구분코드번호")]
		public int EducationLevelClassificationCodeNumber { get; set; }
		/// <summary>
		/// 전공코드명1
		/// </summary>
		[Column("전공코드명1")]
		public string MajorCodeName1 { get; set; }
		/// <summary>
		/// 전공코드번호1
		/// </summary>
		[Column("전공코드번호1")]
		public int MajorCodeNumber1 { get; set; }
		/// <summary>
		/// 이수학점
		/// </summary>
		[Column("이수학점")]
		public decimal 이NumberScore { get; set; }
		/// <summary>
		/// 기준학점
		/// </summary>
		[Column("기준학점")]
		public decimal StandardScore { get; set; }
		/// <summary>
		/// 주간여부
		/// </summary>
		[Column("주간여부")]
		public string DaytimeOrNot { get; set; }
		/// <summary>
		/// 전공코드명2
		/// </summary>
		[Column("전공코드명2")]
		public string MajorCodeName2 { get; set; }
		/// <summary>
		/// 전공코드번호2
		/// </summary>
		[Column("전공코드번호2")]
		public int MajorCodeNumber2 { get; set; }
		/// <summary>
		/// 편입여부
		/// </summary>
		[Column("편입여부")]
		public string TransferOrNot { get; set; }
		/// <summary>
		/// 본교여부
		/// </summary>
		[Column("본교여부")]
		public string ThisSchoolOrNot { get; set; }
		/// <summary>
		/// 세부전공명
		/// </summary>
		[Column("세부전공명")]
		public string DetailMajorName { get; set; }
		/// <summary>
		/// 논문명
		/// </summary>
		[Column("논문명")]
		public string ThesisName { get; set; }
		/// <summary>
		/// 편입전전공코드번호
		/// </summary>
		[Column("편입전전공코드번호")]
		public int MajorBeforeTransferingCodeNumber { get; set; }
		/// <summary>
		/// 편입전전공코드명
		/// </summary>
		[Column("편입전전공코드명")]
		public string MajorBeforeTransferingCodeName { get; set; }
	}

	public class Result10 : IDbResult
	{
		/// <summary>
		/// 업종코드번호
		/// </summary>
		[Column("업종코드번호")]
		public int BusinessTypeCodeNumber { get; set; }
		/// <summary>
		/// 근무시작일
		/// </summary>
		[Column("근무시작일")]
		public DateTime WorkStartDate { get; set; }
		/// <summary>
		/// 근무종료일
		/// </summary>
		[Column("근무종료일")]
		public DateTime WorkEndDate { get; set; }
		/// <summary>
		/// 근속개월
		/// </summary>
		[Column("근속개월")]
		public string ContinuousWorkMonths { get; set; }
		/// <summary>
		/// 직장명
		/// </summary>
		[Column("직장명")]
		public string WorkingPlaceName { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 최종직위코드번호
		/// </summary>
		[Column("최종직위코드번호")]
		public int FinalPositionCodeNumber { get; set; }
		/// <summary>
		/// 최종직무
		/// </summary>
		[Column("최종직무")]
		public string FinalDuty { get; set; }
		/// <summary>
		/// 연봉수준
		/// </summary>
		[Column("연봉수준")]
		public string AnnualSalaryStandard { get; set; }
		/// <summary>
		/// 고용형태코드번호
		/// </summary>
		[Column("고용형태코드번호")]
		public int EmploymentFormatCodeNumber { get; set; }
		/// <summary>
		/// 퇴직사유
		/// </summary>
		[Column("퇴직사유")]
		public string RetirementReason { get; set; }
		/// <summary>
		/// 소재지코드번호
		/// </summary>
		[Column("소재지코드번호")]
		public int LocationCodeNumber { get; set; }
		/// <summary>
		/// 근무내용
		/// </summary>
		[Column("근무내용")]
		public string WorkContent { get; set; }
	}

	public class Result11 : IDbResult
	{
		/// <summary>
		/// 현재직위
		/// </summary>
		[Column("현재직위")]
		public string CurrentPosition { get; set; }
		/// <summary>
		/// 현재입사일
		/// </summary>
		[Column("현재입사일")]
		public DateTime CurrentCompanyJoiningDate { get; set; }
		/// <summary>
		/// 현재승진일
		/// </summary>
		[Column("현재승진일")]
		public DateTime CurrentPromotedDate { get; set; }
		/// <summary>
		/// 현재연봉
		/// </summary>
		[Column("현재연봉")]
		public string CurrentAnnualSalary { get; set; }
		/// <summary>
		/// 희망직위
		/// </summary>
		[Column("희망직위")]
		public string DesiredPosition { get; set; }
		/// <summary>
		/// 희망연봉
		/// </summary>
		[Column("희망연봉")]
		public string DesiredAnnualSalary { get; set; }
		/// <summary>
		/// 기타희망사항
		/// </summary>
		[Column("기타희망사항")]
		public string OtherWishList { get; set; }
	}

	public class Result12 : IDbResult
	{
		/// <summary>
		/// 발급일
		/// </summary>
		[Column("발급일")]
		public DateTime IssuanceDate { get; set; }
		/// <summary>
		/// 자격코드명
		/// </summary>
		[Column("자격코드명")]
		public string QualificationCodeName { get; set; }
		/// <summary>
		/// 자격코드번호
		/// </summary>
		[Column("자격코드번호")]
		public int QualificationCodeNumber { get; set; }
		/// <summary>
		/// 자격증번호
		/// </summary>
		[Column("자격증번호")]
		public string CertificateNumber { get; set; }
		/// <summary>
		/// 발급기관
		/// </summary>
		[Column("발급기관")]
		public string IssuanceOffice { get; set; }
	}

	public class Result13 : IDbResult
	{
		/// <summary>
		/// 수상일
		/// </summary>
		[Column("수상일")]
		public DateTime PrizeReceiptDate { get; set; }
		/// <summary>
		/// 수상명
		/// </summary>
		[Column("수상명")]
		public string PrizeReceiptName { get; set; }
		/// <summary>
		/// 수상기관
		/// </summary>
		[Column("수상기관")]
		public string PrizeReceiptOffice { get; set; }
		/// <summary>
		/// 수상내역
		/// </summary>
		[Column("수상내역")]
		public string PrizeReceiptHistory { get; set; }
	}

	public class Result14 : IDbResult
	{
		/// <summary>
		/// 사회활동종류코드번호
		/// </summary>
		[Column("사회활동종류코드번호")]
		public int SocialActivityTypeCodeNumber { get; set; }
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
		/// 단체명
		/// </summary>
		[Column("단체명")]
		public string GroupName { get; set; }
		/// <summary>
		/// 사회활동내용
		/// </summary>
		[Column("사회활동내용")]
		public string SocialActivityContent { get; set; }
	}

	public class Result15 : IDbResult
	{
		/// <summary>
		/// 시험일자
		/// </summary>
		[Column("시험일자")]
		public DateTime TestDate { get; set; }
		/// <summary>
		/// 어학구분코드번호
		/// </summary>
		[Column("어학구분코드번호")]
		public int LanguageClassificationCodeNumber { get; set; }
		/// <summary>
		/// 어학구분코드명
		/// </summary>
		[Column("어학구분코드명")]
		public string LanguageClassificationCodeName { get; set; }
		/// <summary>
		/// 어학시험코드번호
		/// </summary>
		[Column("어학시험코드번호")]
		public int LanguageTestCodeNumber { get; set; }
		/// <summary>
		/// 어학시험코드명
		/// </summary>
		[Column("어학시험코드명")]
		public string LanguageTestCodeName { get; set; }
		/// <summary>
		/// 점수
		/// </summary>
		[Column("점수")]
		public int Score { get; set; }
		/// <summary>
		/// 어학등급코드번호
		/// </summary>
		[Column("어학등급코드번호")]
		public int LanguageClassCodeNumber { get; set; }
		/// <summary>
		/// 어학등급코드명
		/// </summary>
		[Column("어학등급코드명")]
		public string LanguageClassCodeName { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Column("비고")]
		public string Note { get; set; }
	}

	public class Result16 : IDbResult
	{
		/// <summary>
		/// 어학구분코드번호
		/// </summary>
		[Column("어학구분코드번호")]
		public int LanguageClassificationCodeNumber { get; set; }
		/// <summary>
		/// 회화수준코드번호
		/// </summary>
		[Column("회화수준코드번호")]
		public int ConversationStandardCodeNumber { get; set; }
		/// <summary>
		/// 특이사항
		/// </summary>
		[Column("특이사항")]
		public string Specific { get; set; }
	}

	public class Result17 : IDbResult
	{
		/// <summary>
		/// 가족관계코드번호
		/// </summary>
		[Column("가족관계코드번호")]
		public int FamilyRelationshipCodeNumber { get; set; }
		/// <summary>
		/// 가족성명
		/// </summary>
		[Column("가족성명")]
		public string FamilyName { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Column("생년월일")]
		public DateTime BirthYearMonthDay { get; set; }
		/// <summary>
		/// 출신학교
		/// </summary>
		[Column("출신학교")]
		public string OriginSchool { get; set; }
		/// <summary>
		/// 직장
		/// </summary>
		[Column("직장")]
		public string WorkingPlace { get; set; }
		/// <summary>
		/// 직위
		/// </summary>
		[Column("직위")]
		public string Position { get; set; }
		/// <summary>
		/// 동거여부
		/// </summary>
		[Column("동거여부")]
		public string CohabitOrNot { get; set; }
	}

	public class Result18 : IDbResult
	{
		/// <summary>
		/// 자기소개서일련번호
		/// </summary>
		[Column("자기소개서일련번호")]
		public int SelfIntroductionFormSerialNumber { get; set; }
		/// <summary>
		/// 자기소개서문항일련번호
		/// </summary>
		[Column("자기소개서문항일련번호")]
		public int SelfIntroductionFormQuestionSerialNumber { get; set; }
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Column("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 자기소개답변
		/// </summary>
		[Column("자기소개답변")]
		public string SelfIntroductionAnswer { get; set; }
	}

	public class Result19 : IDbResult
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

	public class Result20 : IDbResult
	{
		/// <summary>
		/// 자기소개서문항일련번호
		/// </summary>
		[Column("자기소개서문항일련번호")]
		public int SelfIntroductionFormQuestionSerialNumber { get; set; }
		/// <summary>
		/// 자기소개답변
		/// </summary>
		[Column("자기소개답변")]
		public string SelfIntroductionAnswer { get; set; }
	}

	public class Result21 : IDbResult
	{
		/// <summary>
		/// 코드번호
		/// </summary>
		[Column("코드번호")]
		public int CodeNumber { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
	}

	public class Result22 : IDbResult
	{
		/// <summary>
		/// 코드번호
		/// </summary>
		[Column("코드번호")]
		public int CodeNumber { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 횟수
		/// </summary>
		[Column("횟수")]
		public int Times { get; set; }
	}

	public class Result23 : IDbResult
	{
		/// <summary>
		/// 설문번호
		/// </summary>
		[Column("설문번호")]
		public int SurveyNumber { get; set; }
		/// <summary>
		/// 코드번호
		/// </summary>
		[Column("코드번호")]
		public string CodeNumber { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 직접입력
		/// </summary>
		[Column("직접입력")]
		public string DirectInput { get; set; }
	}

	public class Result24 : IDbResult
	{
		/// <summary>
		/// 교육기관
		/// </summary>
		[Column("교육기관")]
		public string EducationOffice { get; set; }
		/// <summary>
		/// 교육과정
		/// </summary>
		[Column("교육과정")]
		public string EducationProcess { get; set; }
		/// <summary>
		/// 주요내용
		/// </summary>
		[Column("주요내용")]
		public string MainContent { get; set; }
		/// <summary>
		/// 강사
		/// </summary>
		[Column("강사")]
		public string Instructor { get; set; }
		/// <summary>
		/// 시작일
		/// </summary>
		[Column("시작일")]
		public DateTime StartDate { get; set; }
		/// <summary>
		/// 마감일
		/// </summary>
		[Column("마감일")]
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 기준점수
		/// </summary>
		[Column("기준점수")]
		public double StandardScore { get; set; }
		/// <summary>
		/// 취득점수
		/// </summary>
		[Column("취득점수")]
		public double AccquirementScore { get; set; }
	}

	public class Result25 : IDbResult
	{
		/// <summary>
		/// 기관
		/// </summary>
		[Column("기관")]
		public string Office { get; set; }
		/// <summary>
		/// 행사명
		/// </summary>
		[Column("행사명")]
		public string EventName { get; set; }
		/// <summary>
		/// 행사내용
		/// </summary>
		[Column("행사내용")]
		public string EventContent { get; set; }
		/// <summary>
		/// 시작일
		/// </summary>
		[Column("시작일")]
		public DateTime StartDate { get; set; }
		/// <summary>
		/// 마감일
		/// </summary>
		[Column("마감일")]
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 활동내역및느낀점
		/// </summary>
		[Column("활동내역및느낀점")]
		public string ActivityHistoryAndReview { get; set; }
	}
}