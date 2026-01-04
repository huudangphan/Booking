namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_S_단축URL_회원
/// </summary>
public class WSP_T_S_Shorten_URL_Member
{
	public const string SP_NAME = "WSP_T_S_단축URL_회원";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// HashURL
		/// </summary>
		[Description("HashURL")]
		public string HashURL { get; set; }
		/// <summary>
		/// 원본URL
		/// </summary>
		[Description("원본URL")]
		public string Original_URL { get; set; }
	}

	public class Result : IDbResult
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