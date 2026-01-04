namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_TM_AUDIOM_UPDATE
/// </summary>
public class WSP_T_CMN_TM_AUDIOM_UPDATE
{
	public const string SP_NAME = "WSP_T_CMN_TM_AUDIOM_UPDATE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Idx
		/// </summary>
		[Description("Idx")]
		public int Idx { get; set; }
		/// <summary>
		/// AreaCode
		/// </summary>
		[Description("AreaCode")]
		public string AreaCode { get; set; }
		/// <summary>
		/// Subject
		/// </summary>
		[Description("Subject")]
		public string Subject { get; set; }
		/// <summary>
		/// SubTile
		/// </summary>
		[Description("SubTile")]
		public string SubTile { get; set; }
		/// <summary>
		/// FrontFlag
		/// </summary>
		[Description("FrontFlag")]
		public string FrontFlag { get; set; }
		/// <summary>
		/// UseFlag
		/// </summary>
		[Description("UseFlag")]
		public string UseFlag { get; set; }
		/// <summary>
		/// Img
		/// </summary>
		[Description("Img")]
		public string Img { get; set; }
		/// <summary>
		/// AudioFile
		/// </summary>
		[Description("AudioFile")]
		public string AudioFile { get; set; }
		/// <summary>
		/// Contents
		/// </summary>
		[Description("Contents")]
		public string Contents { get; set; }
	}

}