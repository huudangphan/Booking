namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자원본_등록_NEW
/// </summary>
public class WSP_T_Recruitment_SupporterOriginal_Registration_NEW
{
	public const string SP_NAME = "WSP_T_채용_지원자원본_등록_NEW";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 작업모드
		/// </summary>
		[Description("작업모드")]
		public string WorkingMode { get; set; }
		/// <summary>
		/// 채용공고ID
		/// </summary>
		[Description("채용공고ID")]
		public decimal RecruitmentAnnounce_ID { get; set; }
		/// <summary>
		/// 주민등록번호
		/// </summary>
		[Description("주민등록번호")]
		public string CitizenRegisterNumber { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Description("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 결혼여부
		/// </summary>
		[Description("결혼여부")]
		public string MarriedOrNot { get; set; }
		/// <summary>
		/// 전자우편주소
		/// </summary>
		[Description("전자우편주소")]
		public string DigitalPostalAddress { get; set; }
		/// <summary>
		/// 지원경로
		/// </summary>
		[Description("지원경로")]
		public string SupportRoute { get; set; }
		/// <summary>
		/// 사진명
		/// </summary>
		[Description("사진명")]
		public string PictureName { get; set; }
		/// <summary>
		/// 입사가능일
		/// </summary>
		[Description("입사가능일")]
		public string CompanyJoiningPossibleDate { get; set; }
		/// <summary>
		/// 국적
		/// </summary>
		[Description("국적")]
		public string Nationality { get; set; }
		/// <summary>
		/// 국적명
		/// </summary>
		[Description("국적명")]
		public string NationalityName { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Description("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문성
		/// </summary>
		[Description("영문성")]
		public string EnglishLastName { get; set; }
		/// <summary>
		/// 영문중간이름
		/// </summary>
		[Description("영문중간이름")]
		public string EnglishMiddleName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Description("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 핸드폰번호
		/// </summary>
		[Description("핸드폰번호")]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// 보훈대상여부
		/// </summary>
		[Description("보훈대상여부")]
		public string WarVeteranCandidateOrNot { get; set; }
		/// <summary>
		/// 현주소
		/// </summary>
		[Description("현주소")]
		public string CurrentAddress { get; set; }
		/// <summary>
		/// 본교여부
		/// </summary>
		[Description("본교여부")]
		public string ThisSchoolOrNot { get; set; }
		/// <summary>
		/// 전공명
		/// </summary>
		[Description("전공명")]
		public string MajorName { get; set; }
		/// <summary>
		/// 편입여부
		/// </summary>
		[Description("편입여부")]
		public string TransferOrNot { get; set; }
		/// <summary>
		/// 주야간구분
		/// </summary>
		[Description("주야간구분")]
		public string DayNightTimeClassification { get; set; }
		/// <summary>
		/// 졸업학교
		/// </summary>
		[Description("졸업학교")]
		public string GraduationSchool { get; set; }
		/// <summary>
		/// 최종학력
		/// </summary>
		[Description("최종학력")]
		public string FinalEducationLevel { get; set; }
		/// <summary>
		/// 희망근무지1
		/// </summary>
		[Description("희망근무지1")]
		public string DesiredWorkPlace1 { get; set; }
		/// <summary>
		/// 희망근무지2
		/// </summary>
		[Description("희망근무지2")]
		public string DesiredWorkPlace2 { get; set; }
		/// <summary>
		/// 희망부문1
		/// </summary>
		[Description("희망부문1")]
		public string DesiredSection1 { get; set; }
		/// <summary>
		/// 희망부문2
		/// </summary>
		[Description("희망부문2")]
		public string DesiredSection2 { get; set; }
		/// <summary>
		/// 제2전공
		/// </summary>
		[Description("제2전공")]
		public string SecondMajor { get; set; }
		/// <summary>
		/// 석사여부
		/// </summary>
		[Description("석사여부")]
		public string MasterDegreeOrNot { get; set; }
		/// <summary>
		/// 박사여부
		/// </summary>
		[Description("박사여부")]
		public string DoctorDegreeOrNot { get; set; }
		/// <summary>
		/// 군미필여부
		/// </summary>
		[Description("군미필여부")]
		public string NowInMilitaryOrNot { get; set; }
		/// <summary>
		/// 군면제여부
		/// </summary>
		[Description("군면제여부")]
		public string MilitaryExemptionOrNot { get; set; }
		/// <summary>
		/// 집전화번호
		/// </summary>
		[Description("집전화번호")]
		public string HomePhoneNumber { get; set; }
		/// <summary>
		/// 비상연락처
		/// </summary>
		[Description("비상연락처")]
		public string EmergencyContact { get; set; }
		/// <summary>
		/// 본적지주소
		/// </summary>
		[Description("본적지주소")]
		public string PermanentDomicileAddress { get; set; }
		/// <summary>
		/// 주민등록지주소
		/// </summary>
		[Description("주민등록지주소")]
		public string CitizenRegisterPlaceAddress { get; set; }
		/// <summary>
		/// 본적지우편번호
		/// </summary>
		[Description("본적지우편번호")]
		public string PermanentDomicileZipCode { get; set; }
		/// <summary>
		/// 현주소우편번호
		/// </summary>
		[Description("현주소우편번호")]
		public string CurrentAddressZipCode { get; set; }
		/// <summary>
		/// 주민등록지우편번호
		/// </summary>
		[Description("주민등록지우편번호")]
		public string CitizenRegisterPlaceZipCode { get; set; }
		/// <summary>
		/// 지원경로명
		/// </summary>
		[Description("지원경로명")]
		public string SupportRouteName { get; set; }
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 입사가능일즉시여부
		/// </summary>
		[Description("입사가능일즉시여부")]
		public string CompanyJoiningPossibleDateImmediateOrNot { get; set; }
		/// <summary>
		/// 최종등록여부
		/// </summary>
		[Description("최종등록여부")]
		public string FinalRegisterOrNot { get; set; }
		/// <summary>
		/// CI
		/// </summary>
		[Description("CI")]
		public string CI { get; set; }
		/// <summary>
		/// 현주소상세주소
		/// </summary>
		[Description("현주소상세주소")]
		public string CurrentAddressDetailAddress { get; set; }
		/// <summary>
		/// 본적지상세주소
		/// </summary>
		[Description("본적지상세주소")]
		public string PermanentDomicileDetailAddress { get; set; }
		/// <summary>
		/// 주민등록지상세주소
		/// </summary>
		[Description("주민등록지상세주소")]
		public string CitizenRegisterPlaceDetailAddress { get; set; }
		/// <summary>
		/// 편입전전공
		/// </summary>
		[Description("편입전전공")]
		public string MajorBeforeTransfering { get; set; }
		/// <summary>
		/// 연고지우편번호
		/// </summary>
		[Description("연고지우편번호")]
		public string HometownZipCode { get; set; }
		/// <summary>
		/// 연고지주소
		/// </summary>
		[Description("연고지주소")]
		public string HometownAddress { get; set; }
		/// <summary>
		/// 연고지상세주소
		/// </summary>
		[Description("연고지상세주소")]
		public string HometownDetailAddress { get; set; }
		/// <summary>
		/// 연고지주소인관계
		/// </summary>
		[Description("연고지주소인관계")]
		public string HometownAddress인Relationship { get; set; }
		/// <summary>
		/// 임시저장단계
		/// </summary>
		[Description("임시저장단계")]
		public string TemporarySavingStep { get; set; }
		/// <summary>
		/// 한문성명
		/// </summary>
		[Description("한문성명")]
		public string ChineseCharacterName { get; set; }
		/// <summary>
		/// 희망근무지해당없음
		/// </summary>
		[Description("희망근무지해당없음")]
		public string DesiredWorkPlaceNA { get; set; }
		/// <summary>
		/// 추천지인해당사항없음
		/// </summary>
		[Description("추천지인해당사항없음")]
		public string RecommenderNA { get; set; }
		/// <summary>
		/// 고등학교해당사항없음
		/// </summary>
		[Description("고등학교해당사항없음")]
		public string HighSchoolNA { get; set; }
		/// <summary>
		/// 전문대해당사항없음
		/// </summary>
		[Description("전문대해당사항없음")]
		public string CollegeNA { get; set; }
		/// <summary>
		/// 대학교해당사항없음
		/// </summary>
		[Description("대학교해당사항없음")]
		public string UniversityNA { get; set; }
		/// <summary>
		/// 대학원석사해당사항없음
		/// </summary>
		[Description("대학원석사해당사항없음")]
		public string MasterDegreeNA { get; set; }
		/// <summary>
		/// 대학원박사해당사항없음
		/// </summary>
		[Description("대학원박사해당사항없음")]
		public string DoctorDegreeNA { get; set; }
		/// <summary>
		/// 지원직무수강해당사항없음
		/// </summary>
		[Description("지원직무수강해당사항없음")]
		public string SupportDutyCourseNA { get; set; }
		/// <summary>
		/// 경력사항해당사항없음
		/// </summary>
		[Description("경력사항해당사항없음")]
		public string WorkExperienceNA { get; set; }
		/// <summary>
		/// 희망직위해당사항없음
		/// </summary>
		[Description("희망직위해당사항없음")]
		public string DesiredPositionNA { get; set; }
		/// <summary>
		/// 외국어능력해당사항없음
		/// </summary>
		[Description("외국어능력해당사항없음")]
		public string ForeignLanguageAbilityNA { get; set; }
		/// <summary>
		/// 회화능력해당사항없음
		/// </summary>
		[Description("회화능력해당사항없음")]
		public string ConversationAbilityNA { get; set; }
		/// <summary>
		/// 자격증해당사항없음
		/// </summary>
		[Description("자격증해당사항없음")]
		public string CertificateNA { get; set; }
		/// <summary>
		/// 수상경력해당사항없음
		/// </summary>
		[Description("수상경력해당사항없음")]
		public string PrizeReceiptExperienceNA { get; set; }
		/// <summary>
		/// 지원직무여행업해당사항없음
		/// </summary>
		[Description("지원직무여행업해당사항없음")]
		public string SupportDutyTravelBusinessNA { get; set; }
		/// <summary>
		/// 사회활동해당사항없음
		/// </summary>
		[Description("사회활동해당사항없음")]
		public string SocialActivityNA { get; set; }
		/// <summary>
		/// 파일종류코드번호1
		/// </summary>
		[Description("파일종류코드번호1")]
		public int FileTypeCodeNumber1 { get; set; }
		/// <summary>
		/// 파일종류코드번호2
		/// </summary>
		[Description("파일종류코드번호2")]
		public int FileTypeCodeNumber2 { get; set; }
		/// <summary>
		/// 파일종류코드번호3
		/// </summary>
		[Description("파일종류코드번호3")]
		public int FileTypeCodeNumber3 { get; set; }
		/// <summary>
		/// 파일종류코드번호4
		/// </summary>
		[Description("파일종류코드번호4")]
		public int FileTypeCodeNumber4 { get; set; }
		/// <summary>
		/// 파일종류코드번호5
		/// </summary>
		[Description("파일종류코드번호5")]
		public int FileTypeCodeNumber5 { get; set; }
		/// <summary>
		/// 파일종류코드번호6
		/// </summary>
		[Description("파일종류코드번호6")]
		public int FileTypeCodeNumber6 { get; set; }
		/// <summary>
		/// 파일종류코드번호7
		/// </summary>
		[Description("파일종류코드번호7")]
		public int FileTypeCodeNumber7 { get; set; }
		/// <summary>
		/// 파일종류코드번호8
		/// </summary>
		[Description("파일종류코드번호8")]
		public int FileTypeCodeNumber8 { get; set; }
		/// <summary>
		/// 파일종류코드번호9
		/// </summary>
		[Description("파일종류코드번호9")]
		public int FileTypeCodeNumber9 { get; set; }
		/// <summary>
		/// 파일종류코드번호10
		/// </summary>
		[Description("파일종류코드번호10")]
		public int FileTypeCodeNumber10 { get; set; }
		/// <summary>
		/// 파일종류코드명1
		/// </summary>
		[Description("파일종류코드명1")]
		public string FileTypeCodeName1 { get; set; }
		/// <summary>
		/// 파일종류코드명2
		/// </summary>
		[Description("파일종류코드명2")]
		public string FileTypeCodeName2 { get; set; }
		/// <summary>
		/// 파일종류코드명3
		/// </summary>
		[Description("파일종류코드명3")]
		public string FileTypeCodeName3 { get; set; }
		/// <summary>
		/// 파일종류코드명4
		/// </summary>
		[Description("파일종류코드명4")]
		public string FileTypeCodeName4 { get; set; }
		/// <summary>
		/// 파일종류코드명5
		/// </summary>
		[Description("파일종류코드명5")]
		public string FileTypeCodeName5 { get; set; }
		/// <summary>
		/// 파일종류코드명6
		/// </summary>
		[Description("파일종류코드명6")]
		public string FileTypeCodeName6 { get; set; }
		/// <summary>
		/// 파일종류코드명7
		/// </summary>
		[Description("파일종류코드명7")]
		public string FileTypeCodeName7 { get; set; }
		/// <summary>
		/// 파일종류코드명8
		/// </summary>
		[Description("파일종류코드명8")]
		public string FileTypeCodeName8 { get; set; }
		/// <summary>
		/// 파일종류코드명9
		/// </summary>
		[Description("파일종류코드명9")]
		public string FileTypeCodeName9 { get; set; }
		/// <summary>
		/// 파일종류코드명10
		/// </summary>
		[Description("파일종류코드명10")]
		public string FileTypeCodeName10 { get; set; }
		/// <summary>
		/// 첨부파일명1
		/// </summary>
		[Description("첨부파일명1")]
		public string AttachFileName1 { get; set; }
		/// <summary>
		/// 첨부파일명2
		/// </summary>
		[Description("첨부파일명2")]
		public string AttachFileName2 { get; set; }
		/// <summary>
		/// 첨부파일명3
		/// </summary>
		[Description("첨부파일명3")]
		public string AttachFileName3 { get; set; }
		/// <summary>
		/// 첨부파일명4
		/// </summary>
		[Description("첨부파일명4")]
		public string AttachFileName4 { get; set; }
		/// <summary>
		/// 첨부파일명5
		/// </summary>
		[Description("첨부파일명5")]
		public string AttachFileName5 { get; set; }
		/// <summary>
		/// 첨부파일명6
		/// </summary>
		[Description("첨부파일명6")]
		public string AttachFileName6 { get; set; }
		/// <summary>
		/// 첨부파일명7
		/// </summary>
		[Description("첨부파일명7")]
		public string AttachFileName7 { get; set; }
		/// <summary>
		/// 첨부파일명8
		/// </summary>
		[Description("첨부파일명8")]
		public string AttachFileName8 { get; set; }
		/// <summary>
		/// 첨부파일명9
		/// </summary>
		[Description("첨부파일명9")]
		public string AttachFileName9 { get; set; }
		/// <summary>
		/// 첨부파일명10
		/// </summary>
		[Description("첨부파일명10")]
		public string AttachFileName10 { get; set; }
	}

}