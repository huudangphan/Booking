namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_인재POOL_중복체크
/// </summary>
public class USP_T_Talent_POOL_DuplicationCheck
{
	public const string SP_NAME = "USP_T_인재POOL_중복체크";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 성명
		/// </summary>
		[Description("성명")]
		public string Name { get; set; }
		/// <summary>
		/// 주민등록번호
		/// </summary>
		[Description("주민등록번호")]
		public string CitizenRegisterNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 주민등록번호
		/// </summary>
		[Column("주민등록번호")]
		public string CitizenRegisterNumber { get; set; }
		/// <summary>
		/// 성명
		/// </summary>
		[Column("성명")]
		public string Name { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 연락처
		/// </summary>
		[Column("연락처")]
		public string Contact { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 군필여부
		/// </summary>
		[Column("군필여부")]
		public string FinishedMilitaryOrNot { get; set; }
		/// <summary>
		/// 근무여부
		/// </summary>
		[Column("근무여부")]
		public string WorkOrNot { get; set; }
		/// <summary>
		/// 결혼유무
		/// </summary>
		[Column("결혼유무")]
		public string MarriedOrNot { get; set; }
		/// <summary>
		/// 최종학력
		/// </summary>
		[Column("최종학력")]
		public string FinalEducationLevel { get; set; }
		/// <summary>
		/// 학교명
		/// </summary>
		[Column("학교명")]
		public string SchoolName { get; set; }
		/// <summary>
		/// 전공
		/// </summary>
		[Column("전공")]
		public string Major { get; set; }
		/// <summary>
		/// 여행업경력_년
		/// </summary>
		[Column("여행업경력_년")]
		public int TravelBusinessExperience_Year { get; set; }
		/// <summary>
		/// 여행업경력_월
		/// </summary>
		[Column("여행업경력_월")]
		public int TravelBusinessExperience_Month { get; set; }
		/// <summary>
		/// 최근직장명
		/// </summary>
		[Column("최근직장명")]
		public string RecentWorkingPlaceName { get; set; }
		/// <summary>
		/// 희망업무_직무중분류
		/// </summary>
		[Column("희망업무_직무중분류")]
		public string DesiredTask_DutyInternalClassification { get; set; }
		/// <summary>
		/// 희망업무_직무소분류
		/// </summary>
		[Column("희망업무_직무소분류")]
		public string DesiredTask_DutySubClassification { get; set; }
		/// <summary>
		/// 희망업무_부서
		/// </summary>
		[Column("희망업무_부서")]
		public string DesiredTask_Department { get; set; }
		/// <summary>
		/// 뉴스레터수신여부
		/// </summary>
		[Column("뉴스레터수신여부")]
		public string NewsletterReceptionOrNot { get; set; }
		/// <summary>
		/// 개인정보제공동의여부
		/// </summary>
		[Column("개인정보제공동의여부")]
		public string PersonalInfoPrivisionAgreeOrNot { get; set; }
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
		/// 채용구분
		/// </summary>
		[Column("채용구분")]
		public string RecruitmentClassification { get; set; }
		/// <summary>
		/// 채용구분상세
		/// </summary>
		[Column("채용구분상세")]
		public string RecruitmentClassificationDetail { get; set; }
		/// <summary>
		/// 근무평가
		/// </summary>
		[Column("근무평가")]
		public string WorkEvaluation { get; set; }
		/// <summary>
		/// 실습과제
		/// </summary>
		[Column("실습과제")]
		public string PracticeTask { get; set; }
		/// <summary>
		/// 실습과제_리포트
		/// </summary>
		[Column("실습과제_리포트")]
		public string PracticeTask_Report { get; set; }
		/// <summary>
		/// 과제평가
		/// </summary>
		[Column("과제평가")]
		public string TaskEvaluation { get; set; }
		/// <summary>
		/// 평가자
		/// </summary>
		[Column("평가자")]
		public int EvaluationPerson { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Column("등록자")]
		public int Registerer { get; set; }
		/// <summary>
		/// 인사팀확인
		/// </summary>
		[Column("인사팀확인")]
		public string HRTeamConfirm { get; set; }
		/// <summary>
		/// 인사팀비고
		/// </summary>
		[Column("인사팀비고")]
		public string HRTeamNote { get; set; }
		/// <summary>
		/// 인재일련번호
		/// </summary>
		[Column("인재일련번호")]
		public int TalentSerialNumber { get; set; }
		/// <summary>
		/// 추천자
		/// </summary>
		[Column("추천자")]
		public int Recommender { get; set; }
		/// <summary>
		/// 추천자비고
		/// </summary>
		[Column("추천자비고")]
		public string RecommenderNote { get; set; }
		/// <summary>
		/// 경력직무1
		/// </summary>
		[Column("경력직무1")]
		public string WorkExperienceDuty1 { get; set; }
		/// <summary>
		/// 경력개월1
		/// </summary>
		[Column("경력개월1")]
		public string WorkExperienceMonths1 { get; set; }
		/// <summary>
		/// 경력직무2
		/// </summary>
		[Column("경력직무2")]
		public string WorkExperienceDuty2 { get; set; }
		/// <summary>
		/// 경력개월2
		/// </summary>
		[Column("경력개월2")]
		public string WorkExperienceMonths2 { get; set; }
		/// <summary>
		/// 경력직무3
		/// </summary>
		[Column("경력직무3")]
		public string WorkExperienceDuty3 { get; set; }
		/// <summary>
		/// 경력개월3
		/// </summary>
		[Column("경력개월3")]
		public string WorkExperienceMonths3 { get; set; }
		/// <summary>
		/// 지원자희망직무1
		/// </summary>
		[Column("지원자희망직무1")]
		public string SupporterDesiredDuty1 { get; set; }
		/// <summary>
		/// 지원자희망직무2
		/// </summary>
		[Column("지원자희망직무2")]
		public string SupporterDesiredDuty2 { get; set; }
		/// <summary>
		/// 지원자희망지역1
		/// </summary>
		[Column("지원자희망지역1")]
		public string SupporterDesiredRegion1 { get; set; }
		/// <summary>
		/// 지원자희망지역2
		/// </summary>
		[Column("지원자희망지역2")]
		public string SupporterDesiredRegion2 { get; set; }
		/// <summary>
		/// 채용공고일련번호
		/// </summary>
		[Column("채용공고일련번호")]
		public int RecruitmentAnnounceSerialNumber { get; set; }
		/// <summary>
		/// CHK_주민번호
		/// </summary>
		[Column("CHK_주민번호")]
		public string CHK_CitizenIDNumber { get; set; }
		/// <summary>
		/// 지원자기소개
		/// </summary>
		[Column("지원자기소개")]
		public string SupportSelfIntroduction { get; set; }
	}
}