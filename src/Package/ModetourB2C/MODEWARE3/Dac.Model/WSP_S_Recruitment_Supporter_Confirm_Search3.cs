namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_채용_지원자_확인_검색3
/// </summary>
public class WSP_S_Recruitment_Supporter_Confirm_Search3
{
	public const string SP_NAME = "WSP_S_채용_지원자_확인_검색3";

	public class Parameters : BaseDbParameters
	{
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
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 지원자ID
		/// </summary>
		[Column("지원자ID")]
		public decimal Supporter_ID { get; set; }
		/// <summary>
		/// 채용공고ID
		/// </summary>
		[Column("채용공고ID")]
		public decimal RecruitmentAnnounce_ID { get; set; }
		/// <summary>
		/// 접수번호
		/// </summary>
		[Column("접수번호")]
		public string ReceiptNumber { get; set; }
		/// <summary>
		/// 지원일자
		/// </summary>
		[Column("지원일자")]
		public string SupportDate { get; set; }
		/// <summary>
		/// 주민등록번호
		/// </summary>
		[Column("주민등록번호")]
		public string CitizenRegisterNumber { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
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
		/// 최종등록여부
		/// </summary>
		[Column("최종등록여부")]
		public string FinalRegisterOrNot { get; set; }
		/// <summary>
		/// 면점참고사항
		/// </summary>
		[Column("면점참고사항")]
		public string 면점Reference { get; set; }
		/// <summary>
		/// 지원경로
		/// </summary>
		[Column("지원경로")]
		public string SupportRoute { get; set; }
		/// <summary>
		/// 사진명
		/// </summary>
		[Column("사진명")]
		public string PictureName { get; set; }
		/// <summary>
		/// 입사가능일
		/// </summary>
		[Column("입사가능일")]
		public string CompanyJoiningPossibleDate { get; set; }
		/// <summary>
		/// 국적
		/// </summary>
		[Column("국적")]
		public string Nationality { get; set; }
		/// <summary>
		/// 출신지역코드
		/// </summary>
		[Column("출신지역코드")]
		public string OriginRegionCode { get; set; }
		/// <summary>
		/// 출신지역명
		/// </summary>
		[Column("출신지역명")]
		public string OriginRegionName { get; set; }
		/// <summary>
		/// 지원자특이사항
		/// </summary>
		[Column("지원자특이사항")]
		public string SupporterSpecific { get; set; }
		/// <summary>
		/// 지원자메모사항
		/// </summary>
		[Column("지원자메모사항")]
		public string SupporterMemoItem { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Column("비고")]
		public string Note { get; set; }
		/// <summary>
		/// 변경자
		/// </summary>
		[Column("변경자")]
		public decimal Changer { get; set; }
		/// <summary>
		/// 변경일시
		/// </summary>
		[Column("변경일시")]
		public DateTime ChangeDateAndTime { get; set; }
		/// <summary>
		/// 국적명
		/// </summary>
		[Column("국적명")]
		public string NationalityName { get; set; }
		/// <summary>
		/// 남
		/// </summary>
		[Column("남")]
		public string Male { get; set; }
		/// <summary>
		/// 녀
		/// </summary>
		[Column("녀")]
		public string Female { get; set; }
		/// <summary>
		/// 째
		/// </summary>
		[Column("째")]
		public string RankingSuffix { get; set; }
		/// <summary>
		/// 인증번호
		/// </summary>
		[Column("인증번호")]
		public string VerificationNumber { get; set; }
		/// <summary>
		/// 출생지
		/// </summary>
		[Column("출생지")]
		public string Birthplace { get; set; }
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
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 핸드폰번호
		/// </summary>
		[Column("핸드폰번호")]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// 보훈대상여부
		/// </summary>
		[Column("보훈대상여부")]
		public string WarVeteranCandidateOrNot { get; set; }
		/// <summary>
		/// 현주소
		/// </summary>
		[Column("현주소")]
		public string CurrentAddress { get; set; }
		/// <summary>
		/// 본교여부
		/// </summary>
		[Column("본교여부")]
		public string ThisSchoolOrNot { get; set; }
		/// <summary>
		/// 전공명
		/// </summary>
		[Column("전공명")]
		public string MajorName { get; set; }
		/// <summary>
		/// 편입여부
		/// </summary>
		[Column("편입여부")]
		public string TransferOrNot { get; set; }
		/// <summary>
		/// 주야간구분
		/// </summary>
		[Column("주야간구분")]
		public string DayNightTimeClassification { get; set; }
		/// <summary>
		/// 졸업학교
		/// </summary>
		[Column("졸업학교")]
		public string GraduationSchool { get; set; }
		/// <summary>
		/// 최종학력
		/// </summary>
		[Column("최종학력")]
		public string FinalEducationLevel { get; set; }
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
		/// 거주지역
		/// </summary>
		[Column("거주지역")]
		public string LivingRegion { get; set; }
		/// <summary>
		/// 제2전공
		/// </summary>
		[Column("제2전공")]
		public string SecondMajor { get; set; }
		/// <summary>
		/// 석사여부
		/// </summary>
		[Column("석사여부")]
		public string MasterDegreeOrNot { get; set; }
		/// <summary>
		/// 박사여부
		/// </summary>
		[Column("박사여부")]
		public string DoctorDegreeOrNot { get; set; }
		/// <summary>
		/// 군미필여부
		/// </summary>
		[Column("군미필여부")]
		public string NowInMilitaryOrNot { get; set; }
		/// <summary>
		/// 군면제여부
		/// </summary>
		[Column("군면제여부")]
		public string MilitaryExemptionOrNot { get; set; }
		/// <summary>
		/// 집전화번호
		/// </summary>
		[Column("집전화번호")]
		public string HomePhoneNumber { get; set; }
		/// <summary>
		/// 비상연락처
		/// </summary>
		[Column("비상연락처")]
		public string EmergencyContact { get; set; }
		/// <summary>
		/// 본적지주소
		/// </summary>
		[Column("본적지주소")]
		public string PermanentDomicileAddress { get; set; }
		/// <summary>
		/// 주민등록지주소
		/// </summary>
		[Column("주민등록지주소")]
		public string CitizenRegisterPlaceAddress { get; set; }
		/// <summary>
		/// 본적지우편번호
		/// </summary>
		[Column("본적지우편번호")]
		public string PermanentDomicileZipCode { get; set; }
		/// <summary>
		/// 현주소우편번호
		/// </summary>
		[Column("현주소우편번호")]
		public string CurrentAddressZipCode { get; set; }
		/// <summary>
		/// 주민등록지우편번호
		/// </summary>
		[Column("주민등록지우편번호")]
		public string CitizenRegisterPlaceZipCode { get; set; }
		/// <summary>
		/// 지원경로명
		/// </summary>
		[Column("지원경로명")]
		public string SupportRouteName { get; set; }
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Column("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 입사가능일즉시여부
		/// </summary>
		[Column("입사가능일즉시여부")]
		public string CompanyJoiningPossibleDateImmediateOrNot { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Column("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 현주소상세주소
		/// </summary>
		[Column("현주소상세주소")]
		public string CurrentAddressDetailAddress { get; set; }
		/// <summary>
		/// 본적지상세주소
		/// </summary>
		[Column("본적지상세주소")]
		public string PermanentDomicileDetailAddress { get; set; }
		/// <summary>
		/// 주민등록지상세주소
		/// </summary>
		[Column("주민등록지상세주소")]
		public string CitizenRegisterPlaceDetailAddress { get; set; }
		/// <summary>
		/// 지원횟수COUNT
		/// </summary>
		[Column("지원횟수COUNT")]
		public string SupportTimes_COUNT { get; set; }
		/// <summary>
		/// 검사인증코드
		/// </summary>
		[Column("검사인증코드")]
		public string TestingVerificationCode { get; set; }
		/// <summary>
		/// 검사코드
		/// </summary>
		[Column("검사코드")]
		public string TestingCode { get; set; }
		/// <summary>
		/// 검사일
		/// </summary>
		[Column("검사일")]
		public string TestingDate { get; set; }
		/// <summary>
		/// 검사완료코드
		/// </summary>
		[Column("검사완료코드")]
		public string FinishTestingCode { get; set; }
		/// <summary>
		/// 순번
		/// </summary>
		[Column("순번")]
		public int Order { get; set; }
		/// <summary>
		/// SHA비밀번호
		/// </summary>
		[Column("SHA비밀번호")]
		public string SHA_Password { get; set; }
		/// <summary>
		/// 편입전전공
		/// </summary>
		[Column("편입전전공")]
		public string MajorBeforeTransfering { get; set; }
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
		/// 인사부첨부파일
		/// </summary>
		[Column("인사부첨부파일")]
		public string HRDepartmentAttachFile { get; set; }
		/// <summary>
		/// 임시저장단계
		/// </summary>
		[Column("임시저장단계")]
		public string TemporarySavingStep { get; set; }
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
		/// 추천지인해당사항없음
		/// </summary>
		[Column("추천지인해당사항없음")]
		public string RecommenderNA { get; set; }
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
		/// CI
		/// </summary>
		[Column("CI")]
		public string CI { get; set; }
	}
}