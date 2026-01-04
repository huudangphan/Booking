namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_TM_AUDIOM_LIST
/// </summary>
public class WSP_S_CMN_TM_AUDIOM_LIST
{
	public const string SP_NAME = "WSP_S_CMN_TM_AUDIOM_LIST";

	public class Parameters : BaseDbParameters
	{
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
		/// AreaCode
		/// </summary>
		[Column("AreaCode")]
		public string AreaCode { get; set; }
		/// <summary>
		/// Subject
		/// </summary>
		[Column("Subject")]
		public string Subject { get; set; }
		/// <summary>
		/// SubTile
		/// </summary>
		[Column("SubTile")]
		public string SubTile { get; set; }
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
		/// AudioFile
		/// </summary>
		[Column("AudioFile")]
		public string AudioFile { get; set; }
		/// <summary>
		/// Contents
		/// </summary>
		[Column("Contents")]
		public string Contents { get; set; }
		/// <summary>
		/// FrontFlag
		/// </summary>
		[Column("FrontFlag")]
		public string FrontFlag { get; set; }
		/// <summary>
		/// RegDate
		/// </summary>
		[Column("RegDate")]
		public DateTime RegDate { get; set; }
		/// <summary>
		/// Hit
		/// </summary>
		[Column("Hit")]
		public int Hit { get; set; }
	}
}