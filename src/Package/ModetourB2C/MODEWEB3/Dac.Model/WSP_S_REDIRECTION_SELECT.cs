namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_REDIRECTION_SELECT
/// </summary>
public class WSP_S_REDIRECTION_SELECT
{
	public const string SP_NAME = "WSP_S_REDIRECTION_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// URL
		/// </summary>
		[Description("URL")]
		public string URL { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// RESULT
		/// </summary>
		[Column("RESULT")]
		public string RESULT { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// HOST
		/// </summary>
		[Column("HOST")]
		public string HOST { get; set; }
	}
}