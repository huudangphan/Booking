namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_TM_MT_NEWS_DETAIL
/// </summary>
public class WSP_S_CMN_TM_MT_NEWS_DETAIL
{
	public const string SP_NAME = "WSP_S_CMN_TM_MT_NEWS_DETAIL";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Idx
		/// </summary>
		[Description("Idx")]
		public int Idx { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Idx
		/// </summary>
		[Column("Idx")]
		public int Idx { get; set; }
		/// <summary>
		/// Code
		/// </summary>
		[Column("Code")]
		public string Code { get; set; }
		/// <summary>
		/// Title
		/// </summary>
		[Column("Title")]
		public string Title { get; set; }
		/// <summary>
		/// RepFlag
		/// </summary>
		[Column("RepFlag")]
		public string RepFlag { get; set; }
		/// <summary>
		/// UseFlag
		/// </summary>
		[Column("UseFlag")]
		public string UseFlag { get; set; }
		/// <summary>
		/// DelFlag
		/// </summary>
		[Column("DelFlag")]
		public string DelFlag { get; set; }
		/// <summary>
		/// Img
		/// </summary>
		[Column("Img")]
		public string Img { get; set; }
		/// <summary>
		/// Contents
		/// </summary>
		[Column("Contents")]
		public string Contents { get; set; }
		/// <summary>
		/// RegDate
		/// </summary>
		[Column("RegDate")]
		public DateTime RegDate { get; set; }
	}
}