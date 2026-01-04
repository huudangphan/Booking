namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_MPLE_랜드사가이드관계
/// </summary>
public class WSP_T_MPLE_LandCompanyGuideRelationship
{
	public const string SP_NAME = "WSP_T_MPLE_랜드사가이드관계";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 랜드사번호
		/// </summary>
		[Description("랜드사번호")]
		public int LandCompanyNumber { get; set; }
		/// <summary>
		/// 랜드사입사년도
		/// </summary>
		[Description("랜드사입사년도")]
		public int LandCompanyJoiningYear { get; set; }
		/// <summary>
		/// 직위
		/// </summary>
		[Description("직위")]
		public string Position { get; set; }
	}

}