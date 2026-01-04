namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_BATCH_SPECIAL_PRODUCT
/// </summary>
public class ACP_BATCH_SPECIAL_PRODUCT
{
	public const string SP_NAME = "ACP_BATCH_SPECIAL_PRODUCT";

	public class Result : IDbResult
	{
		/// <summary>
		/// RCODE
		/// </summary>
		[Column("RCODE")]
		public string RCODE { get; set; }
	}
}