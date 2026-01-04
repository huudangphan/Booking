namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_XML_CREATION_LIST
/// </summary>
public class WSP_S_XML_CREATION_LIST
{
	public const string SP_NAME = "WSP_S_XML_CREATION_LIST";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// p1
		/// </summary>
		[Description("p1")]
		public int p1 { get; set; }
		/// <summary>
		/// p2
		/// </summary>
		[Description("p2")]
		public int p2 { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// PCODE
		/// </summary>
		[Column("PCODE")]
		public string PCODE { get; set; }
		/// <summary>
		/// DATE
		/// </summary>
		[Column("DATE")]
		public int DATE { get; set; }
	}
}