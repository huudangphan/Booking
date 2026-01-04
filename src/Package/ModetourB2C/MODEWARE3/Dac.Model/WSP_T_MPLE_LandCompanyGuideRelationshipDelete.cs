namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_MPLE_랜드사가이드관계삭제
/// </summary>
public class WSP_T_MPLE_LandCompanyGuideRelationshipDelete
{
	public const string SP_NAME = "WSP_T_MPLE_랜드사가이드관계삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// MPLE랜드사번호리스트
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("MPLE랜드사번호리스트")]
		public List<TYPE_MPLE_LandCompanyNumberList> MPLE_LandCompanyNumberList { get; set; }
	}

}