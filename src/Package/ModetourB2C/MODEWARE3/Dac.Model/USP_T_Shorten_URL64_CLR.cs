namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_단축URL64_CLR
/// </summary>
public class USP_T_Shorten_URL64_CLR
{
	public const string SP_NAME = "USP_T_단축URL64_CLR";

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
		/// Column1
		/// </summary>
		[Column("Column1")]
		public string Column1 { get; set; }
		/// <summary>
		/// Column2
		/// </summary>
		[Column("Column2")]
		public string Column2 { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// HASH_URL
		/// </summary>
		[Column("HASH_URL")]
		public string HASH_URL { get; set; }
		/// <summary>
		/// 원본_URL
		/// </summary>
		[Column("원본_URL")]
		public string Original_URL { get; set; }
	}
}