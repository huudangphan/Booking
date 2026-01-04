namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_학력_등록
/// </summary>
public class WSP_T_Recruitment_Supporter_EducationLevel_Registration
{
	public const string SP_NAME = "WSP_T_채용_지원자_학력_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 학력구분코드번호
		/// </summary>
		[Description("학력구분코드번호")]
		public int EducationLevelClassificationCodeNumber { get; set; }
		/// <summary>
		/// 학력구분코드명
		/// </summary>
		[Description("학력구분코드명")]
		public string EducationLevelClassificationCodeName { get; set; }
		/// <summary>
		/// 학교코드번호
		/// </summary>
		[Description("학교코드번호")]
		public int SchoolCodeNumber { get; set; }
		/// <summary>
		/// 학교코드명
		/// </summary>
		[Description("학교코드명")]
		public string SchoolCodeName { get; set; }
		/// <summary>
		/// 입학일시
		/// </summary>
		[Description("입학일시")]
		public DateTime SchoolEnteringDateAndTime { get; set; }
		/// <summary>
		/// 졸업일시
		/// </summary>
		[Description("졸업일시")]
		public DateTime GraduationDateAndTime { get; set; }
		/// <summary>
		/// 기준학점
		/// </summary>
		[Description("기준학점")]
		public decimal StandardScore { get; set; }
		/// <summary>
		/// 이수학점
		/// </summary>
		[Description("이수학점")]
		public decimal 이NumberScore { get; set; }
		/// <summary>
		/// 전공코드번호1
		/// </summary>
		[Description("전공코드번호1")]
		public int MajorCodeNumber1 { get; set; }
		/// <summary>
		/// 전공코드명1
		/// </summary>
		[Description("전공코드명1")]
		public string MajorCodeName1 { get; set; }
		/// <summary>
		/// 전공코드번호2
		/// </summary>
		[Description("전공코드번호2")]
		public int MajorCodeNumber2 { get; set; }
		/// <summary>
		/// 전공코드명2
		/// </summary>
		[Description("전공코드명2")]
		public string MajorCodeName2 { get; set; }
		/// <summary>
		/// 편입전전공코드번호
		/// </summary>
		[Description("편입전전공코드번호")]
		public int MajorBeforeTransferingCodeNumber { get; set; }
		/// <summary>
		/// 편입전전공코드명
		/// </summary>
		[Description("편입전전공코드명")]
		public string MajorBeforeTransferingCodeName { get; set; }
		/// <summary>
		/// 편입여부
		/// </summary>
		[Description("편입여부")]
		public string TransferOrNot { get; set; }
		/// <summary>
		/// 주간여부
		/// </summary>
		[Description("주간여부")]
		public string DaytimeOrNot { get; set; }
		/// <summary>
		/// 최종학력여부
		/// </summary>
		[Description("최종학력여부")]
		public string FinalEducationLevelOrNot { get; set; }
		/// <summary>
		/// 본교여부
		/// </summary>
		[Description("본교여부")]
		public string ThisSchoolOrNot { get; set; }
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
		/// 논문명
		/// </summary>
		[Description("논문명")]
		public string ThesisName { get; set; }
		/// <summary>
		/// 세부전공명
		/// </summary>
		[Description("세부전공명")]
		public string DetailMajorName { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
	}

}