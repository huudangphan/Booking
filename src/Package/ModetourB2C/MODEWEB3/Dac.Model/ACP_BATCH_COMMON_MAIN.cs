namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_BATCH_COMMON_MAIN
/// </summary>
public class ACP_BATCH_COMMON_MAIN
{
	public const string SP_NAME = "ACP_BATCH_COMMON_MAIN";

	public class Result : IDbResult
	{
		/// <summary>
		/// RCODE
		/// </summary>
		[Column("RCODE")]
		public string RCODE { get; set; }
	}
}