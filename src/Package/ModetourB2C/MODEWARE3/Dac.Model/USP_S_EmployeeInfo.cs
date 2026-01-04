namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_사원정보
/// </summary>
public class USP_S_EmployeeInfo
{
	public const string SP_NAME = "USP_S_사원정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 고용형태
		/// </summary>
		[Column("고용형태")]
		public string EmploymentFormat { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Column("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 근무지
		/// </summary>
		[Column("근무지")]
		public string WorkPlace { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 부서번호
		/// </summary>
		[Column("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 사원명
		/// </summary>
		[Column("사원명")]
		public string StaffName { get; set; }
		/// <summary>
		/// 본부
		/// </summary>
		[Column("본부")]
		public string Headoffice { get; set; }
		/// <summary>
		/// 영문주소1
		/// </summary>
		[Column("영문주소1")]
		public string EnglishAddress1 { get; set; }
		/// <summary>
		/// 영문주소2
		/// </summary>
		[Column("영문주소2")]
		public string EnglishAddress2 { get; set; }
		/// <summary>
		/// 영문부서명
		/// </summary>
		[Column("영문부서명")]
		public string EnglishDepartmentName { get; set; }
		/// <summary>
		/// 직위
		/// </summary>
		[Column("직위")]
		public string Position { get; set; }
		/// <summary>
		/// 직위_호칭
		/// </summary>
		[Column("직위_호칭")]
		public string Position_Name { get; set; }
		/// <summary>
		/// 직급
		/// </summary>
		[Column("직급")]
		public string JobPosition { get; set; }
		/// <summary>
		/// 운영상직책
		/// </summary>
		[Column("운영상직책")]
		public string OperationDuty { get; set; }
		/// <summary>
		/// 직책_수당
		/// </summary>
		[Column("직책_수당")]
		public string Duty_ExtraPay { get; set; }
		/// <summary>
		/// 영문직위
		/// </summary>
		[Column("영문직위")]
		public string EnglishPosition { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
		/// <summary>
		/// 직통번호
		/// </summary>
		[Column("직통번호")]
		public string DirectPhoneLineNumber { get; set; }
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
		/// 부서대표
		/// </summary>
		[Column("부서대표")]
		public string DepartmentRepresentative { get; set; }
		/// <summary>
		/// 회사주소
		/// </summary>
		[Column("회사주소")]
		public string CompanyAddress { get; set; }
		/// <summary>
		/// 회사주소명함용
		/// </summary>
		[Column("회사주소명함용")]
		public string CompanyAddressNameCardUse { get; set; }
		/// <summary>
		/// 영문직급
		/// </summary>
		[Column("영문직급")]
		public string EnglishJobPosition { get; set; }
		/// <summary>
		/// 직위호칭
		/// </summary>
		[Column("직위호칭")]
		public string PositionName { get; set; }
		/// <summary>
		/// 영문성
		/// </summary>
		[Column("영문성")]
		public string EnglishLastName { get; set; }
		/// <summary>
		/// 영문이름2
		/// </summary>
		[Column("영문이름2")]
		public string EnglishName2 { get; set; }
		/// <summary>
		/// 소속본부
		/// </summary>
		[Column("소속본부")]
		public string AffiliationHeadoffice { get; set; }
		/// <summary>
		/// 소속부서명
		/// </summary>
		[Column("소속부서명")]
		public string AffiliationDepartmentName { get; set; }
		/// <summary>
		/// 소속부서번호
		/// </summary>
		[Column("소속부서번호")]
		public int AffiliationDepartmentNumber { get; set; }
		/// <summary>
		/// 소속소팀명
		/// </summary>
		[Column("소속소팀명")]
		public string AffiliationSubTeamName { get; set; }
		/// <summary>
		/// 소속소팀
		/// </summary>
		[Column("소속소팀")]
		public int AffiliationSubTeam { get; set; }
		/// <summary>
		/// 소속영문주소1
		/// </summary>
		[Column("소속영문주소1")]
		public string AffiliationEnglishAddress1 { get; set; }
		/// <summary>
		/// 소속영문주소2
		/// </summary>
		[Column("소속영문주소2")]
		public string AffiliationEnglishAddress2 { get; set; }
		/// <summary>
		/// 소속영문부서명
		/// </summary>
		[Column("소속영문부서명")]
		public string AffiliationEnglishDepartmentName { get; set; }
		/// <summary>
		/// 대본부번호
		/// </summary>
		[Column("대본부번호")]
		public int HeadOfficeNumber { get; set; }
		/// <summary>
		/// 소본부번호
		/// </summary>
		[Column("소본부번호")]
		public int SubHeadofficeNumber { get; set; }
		/// <summary>
		/// 소본부명
		/// </summary>
		[Column("소본부명")]
		public string SubHeadofficeName { get; set; }
		/// <summary>
		/// 근무부서명
		/// </summary>
		[Column("근무부서명")]
		public string WorkDepartmentName { get; set; }
		/// <summary>
		/// 근무부서번호
		/// </summary>
		[Column("근무부서번호")]
		public int WorkDepartmentNumber { get; set; }
		/// <summary>
		/// 소팀번호
		/// </summary>
		[Column("소팀번호")]
		public int SubTeamNumber { get; set; }
		/// <summary>
		/// 소팀명
		/// </summary>
		[Column("소팀명")]
		public string SubTeamName { get; set; }
		/// <summary>
		/// 내선
		/// </summary>
		[Column("내선")]
		public string Interphone { get; set; }
		/// <summary>
		/// 테블릿_HP
		/// </summary>
		[Column("테블릿_HP")]
		public string Tablet_HP { get; set; }
		/// <summary>
		/// 사번
		/// </summary>
		[Column("사번")]
		public string EmployeeIdentifiedNumber { get; set; }
		/// <summary>
		/// 입사일자
		/// </summary>
		[Column("입사일자")]
		public DateTime CompanyJoiningDate { get; set; }
		/// <summary>
		/// 직무
		/// </summary>
		[Column("직무")]
		public string Duty { get; set; }
	}
}