namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_추천_등록
/// </summary>
public class WSP_T_Recruitment_Supporter_Recommendation_Registration
{
	public const string SP_NAME = "WSP_T_채용_지원자_추천_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 추천인성명
		/// </summary>
		[Description("추천인성명")]
		public string RecommenderName { get; set; }
		/// <summary>
		/// 추천인근무처
		/// </summary>
		[Description("추천인근무처")]
		public string RecommenderWorkPlace { get; set; }
		/// <summary>
		/// 추천인직위
		/// </summary>
		[Description("추천인직위")]
		public string RecommenderPosition { get; set; }
		/// <summary>
		/// 추천인관계
		/// </summary>
		[Description("추천인관계")]
		public string RecommenderRelationship { get; set; }
	}

}