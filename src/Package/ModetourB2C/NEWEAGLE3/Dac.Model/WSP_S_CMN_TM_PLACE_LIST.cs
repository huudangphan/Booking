namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_TM_PLACE_LIST
/// </summary>
public class WSP_S_CMN_TM_PLACE_LIST
{
	public const string SP_NAME = "WSP_S_CMN_TM_PLACE_LIST";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// GubunCode
		/// </summary>
		[Description("GubunCode")]
		public string GubunCode { get; set; }
		/// <summary>
		/// AreaCode
		/// </summary>
		[Description("AreaCode")]
		public string AreaCode { get; set; }
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
		/// GubunCode
		/// </summary>
		[Column("GubunCode")]
		public string GubunCode { get; set; }
		/// <summary>
		/// Subject
		/// </summary>
		[Column("Subject")]
		public string Subject { get; set; }
		/// <summary>
		/// FrontFlag
		/// </summary>
		[Column("FrontFlag")]
		public string FrontFlag { get; set; }
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
		/// Img2
		/// </summary>
		[Column("Img2")]
		public string Img2 { get; set; }
		/// <summary>
		/// Hit
		/// </summary>
		[Column("Hit")]
		public int Hit { get; set; }
		/// <summary>
		/// KorName
		/// </summary>
		[Column("KorName")]
		public string KorName { get; set; }
	}
}