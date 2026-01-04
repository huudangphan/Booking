namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_TM_FEATURE_LIST
/// </summary>
public class WSP_S_CMN_TM_FEATURE_LIST
{
	public const string SP_NAME = "WSP_S_CMN_TM_FEATURE_LIST";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Code
		/// </summary>
		[Description("Code")]
		public string Code { get; set; }
		/// <summary>
		/// UseFlag
		/// </summary>
		[Description("UseFlag")]
		public string UseFlag { get; set; }
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