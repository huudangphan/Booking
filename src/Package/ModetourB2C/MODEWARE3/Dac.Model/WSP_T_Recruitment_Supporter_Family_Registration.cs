namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_가족사항_등록
/// </summary>
public class WSP_T_Recruitment_Supporter_Family_Registration
{
	public const string SP_NAME = "WSP_T_채용_지원자_가족사항_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 가족관계코드번호
		/// </summary>
		[Description("가족관계코드번호")]
		public int FamilyRelationshipCodeNumber { get; set; }
		/// <summary>
		/// 가족관계코드명
		/// </summary>
		[Description("가족관계코드명")]
		public string FamilyRelationshipCodeName { get; set; }
		/// <summary>
		/// 가족성명
		/// </summary>
		[Description("가족성명")]
		public string FamilyName { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Description("생년월일")]
		public DateTime BirthYearMonthDay { get; set; }
		/// <summary>
		/// 출신학교
		/// </summary>
		[Description("출신학교")]
		public string OriginSchool { get; set; }
		/// <summary>
		/// 직장
		/// </summary>
		[Description("직장")]
		public string WorkingPlace { get; set; }
		/// <summary>
		/// 직위
		/// </summary>
		[Description("직위")]
		public string Position { get; set; }
		/// <summary>
		/// 동거여부
		/// </summary>
		[Description("동거여부")]
		public string CohabitOrNot { get; set; }
	}

}