namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_경력_등록
/// </summary>
public class WSP_T_Recruitment_Supporter_Experience_Registration
{
	public const string SP_NAME = "WSP_T_채용_지원자_경력_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 업종코드번호
		/// </summary>
		[Description("업종코드번호")]
		public int BusinessTypeCodeNumber { get; set; }
		/// <summary>
		/// 업종코드명
		/// </summary>
		[Description("업종코드명")]
		public string BusinessTypeCodeName { get; set; }
		/// <summary>
		/// 근무시작일
		/// </summary>
		[Description("근무시작일")]
		public DateTime WorkStartDate { get; set; }
		/// <summary>
		/// 근무종료일
		/// </summary>
		[Description("근무종료일")]
		public DateTime WorkEndDate { get; set; }
		/// <summary>
		/// 근속개월
		/// </summary>
		[Description("근속개월")]
		public string ContinuousWorkMonths { get; set; }
		/// <summary>
		/// 직장명
		/// </summary>
		[Description("직장명")]
		public string WorkingPlaceName { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Description("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 최종직위코드번호
		/// </summary>
		[Description("최종직위코드번호")]
		public int FinalPositionCodeNumber { get; set; }
		/// <summary>
		/// 최종직위코드명
		/// </summary>
		[Description("최종직위코드명")]
		public string FinalPositionCodeName { get; set; }
		/// <summary>
		/// 최종직무
		/// </summary>
		[Description("최종직무")]
		public string FinalDuty { get; set; }
		/// <summary>
		/// 연봉수준
		/// </summary>
		[Description("연봉수준")]
		public string AnnualSalaryStandard { get; set; }
		/// <summary>
		/// 고용형태코드번호
		/// </summary>
		[Description("고용형태코드번호")]
		public int EmploymentFormatCodeNumber { get; set; }
		/// <summary>
		/// 고용형태코드명
		/// </summary>
		[Description("고용형태코드명")]
		public string EmploymentFormatCodeName { get; set; }
		/// <summary>
		/// 퇴직사유
		/// </summary>
		[Description("퇴직사유")]
		public string RetirementReason { get; set; }
		/// <summary>
		/// 소재지코드번호
		/// </summary>
		[Description("소재지코드번호")]
		public int LocationCodeNumber { get; set; }
		/// <summary>
		/// 소재지코드명
		/// </summary>
		[Description("소재지코드명")]
		public string LocationCodeName { get; set; }
		/// <summary>
		/// 근무내용
		/// </summary>
		[Description("근무내용")]
		public string WorkContent { get; set; }
	}

}