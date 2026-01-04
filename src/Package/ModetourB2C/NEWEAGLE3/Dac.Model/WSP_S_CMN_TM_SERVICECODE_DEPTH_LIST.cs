namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_TM_SERVICECODE_DEPTH_LIST
/// </summary>
public class WSP_S_CMN_TM_SERVICECODE_DEPTH_LIST
{
	public const string SP_NAME = "WSP_S_CMN_TM_SERVICECODE_DEPTH_LIST";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Code
		/// </summary>
		[Description("Code")]
		public string Code { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Depth
		/// </summary>
		[Column("Depth")]
		public int Depth { get; set; }
		/// <summary>
		/// Code
		/// </summary>
		[Column("Code")]
		public string Code { get; set; }
		/// <summary>
		/// KorName
		/// </summary>
		[Column("KorName")]
		public string KorName { get; set; }
	}
}