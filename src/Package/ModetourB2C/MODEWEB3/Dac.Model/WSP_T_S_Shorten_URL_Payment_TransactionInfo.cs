namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_S_단축URL_결제_거래정보
/// </summary>
public class WSP_T_S_Shorten_URL_Payment_TransactionInfo
{
	public const string SP_NAME = "WSP_T_S_단축URL_결제_거래정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// HashURL
		/// </summary>
		[Description("HashURL")]
		public string HashURL { get; set; }
		/// <summary>
		/// 정보
		/// </summary>
		[Description("정보")]
		public string Info { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 정보
		/// </summary>
		[Column("정보")]
		public string Info { get; set; }
	}
}