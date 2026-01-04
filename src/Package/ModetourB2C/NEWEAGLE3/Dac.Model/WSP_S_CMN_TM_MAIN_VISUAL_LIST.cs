namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_TM_MAIN_VISUAL_LIST
/// </summary>
public class WSP_S_CMN_TM_MAIN_VISUAL_LIST
{
	public const string SP_NAME = "WSP_S_CMN_TM_MAIN_VISUAL_LIST";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// IsAdmin
		/// </summary>
		[Description("IsAdmin")]
		public string IsAdmin { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Idx
		/// </summary>
		[Column("Idx")]
		public int Idx { get; set; }
		/// <summary>
		/// Img
		/// </summary>
		[Column("Img")]
		public string Img { get; set; }
		/// <summary>
		/// URL
		/// </summary>
		[Column("URL")]
		public string URL { get; set; }
		/// <summary>
		/// HeadTitle
		/// </summary>
		[Column("HeadTitle")]
		public string HeadTitle { get; set; }
		/// <summary>
		/// SubTitle
		/// </summary>
		[Column("SubTitle")]
		public string SubTitle { get; set; }
		/// <summary>
		/// ButtonText
		/// </summary>
		[Column("ButtonText")]
		public string ButtonText { get; set; }
		/// <summary>
		/// TextColor
		/// </summary>
		[Column("TextColor")]
		public string TextColor { get; set; }
	}
}