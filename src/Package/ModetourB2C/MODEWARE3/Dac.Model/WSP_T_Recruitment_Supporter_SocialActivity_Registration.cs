namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_사회활동_등록
/// </summary>
public class WSP_T_Recruitment_Supporter_SocialActivity_Registration
{
	public const string SP_NAME = "WSP_T_채용_지원자_사회활동_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 사회활동종류코드번호
		/// </summary>
		[Description("사회활동종류코드번호")]
		public int SocialActivityTypeCodeNumber { get; set; }
		/// <summary>
		/// 사회활동종류코드명
		/// </summary>
		[Description("사회활동종류코드명")]
		public string SocialActivityTypeCodeName { get; set; }
		/// <summary>
		/// 시작일
		/// </summary>
		[Description("시작일")]
		public DateTime StartDate { get; set; }
		/// <summary>
		/// 종료일
		/// </summary>
		[Description("종료일")]
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 단체명
		/// </summary>
		[Description("단체명")]
		public string GroupName { get; set; }
		/// <summary>
		/// 사회활동내용
		/// </summary>
		[Description("사회활동내용")]
		public string SocialActivityContent { get; set; }
	}

}