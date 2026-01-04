namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_INFO_START_SELECT
/// </summary>
public class ACP_INFO_START_SELECT
{
	public const string SP_NAME = "ACP_INFO_START_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// CODE
		/// </summary>
		[Description("CODE")]
		public string CODE { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// CODENAME
		/// </summary>
		[Column("CODENAME")]
		public string CODENAME { get; set; }
		/// <summary>
		/// CODE
		/// </summary>
		[Column("CODE")]
		public string CODE { get; set; }
	}
}