namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_TM_TVM_DETAIL_V2
/// </summary>
public class WSP_S_CMN_TM_TVM_DETAIL_V2
{
	public const string SP_NAME = "WSP_S_CMN_TM_TVM_DETAIL_V2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Idx
		/// </summary>
		[Description("Idx")]
		public int Idx { get; set; }
		/// <summary>
		/// Admin
		/// </summary>
		[Description("Admin")]
		public string Admin { get; set; }
		/// <summary>
		/// UserPTID
		/// </summary>
		[Description("UserPTID")]
		public int UserPTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Idx
		/// </summary>
		[Column("Idx")]
		public int Idx { get; set; }
		/// <summary>
		/// AreaCode
		/// </summary>
		[Column("AreaCode")]
		public string AreaCode { get; set; }
		/// <summary>
		/// ThemeCode
		/// </summary>
		[Column("ThemeCode")]
		public string ThemeCode { get; set; }
		/// <summary>
		/// Subject
		/// </summary>
		[Column("Subject")]
		public string Subject { get; set; }
		/// <summary>
		/// HotFlag
		/// </summary>
		[Column("HotFlag")]
		public string HotFlag { get; set; }
		/// <summary>
		/// UseFlag
		/// </summary>
		[Column("UseFlag")]
		public string UseFlag { get; set; }
		/// <summary>
		/// Img
		/// </summary>
		[Column("Img")]
		public string Img { get; set; }
		/// <summary>
		/// VideoUrl
		/// </summary>
		[Column("VideoUrl")]
		public string VideoUrl { get; set; }
		/// <summary>
		/// Contents
		/// </summary>
		[Column("Contents")]
		public string Contents { get; set; }
		/// <summary>
		/// Hit
		/// </summary>
		[Column("Hit")]
		public int Hit { get; set; }
		/// <summary>
		/// LikeIdx
		/// </summary>
		[Column("LikeIdx")]
		public int LikeIdx { get; set; }
		/// <summary>
		/// PlanTitle
		/// </summary>
		[Column("PlanTitle")]
		public string PlanTitle { get; set; }
		/// <summary>
		/// PlanUrl
		/// </summary>
		[Column("PlanUrl")]
		public string PlanUrl { get; set; }
	}
}