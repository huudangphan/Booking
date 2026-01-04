namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// 신세계면세점_난수리스트
/// </summary>
public class NewWorldTaxFree_RandomNumberList
{
	public const string SP_NAME = "신세계면세점_난수리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 난수
		/// </summary>
		[Description("난수")]
		public string RandomNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 난수
		/// </summary>
		[Column("난수")]
		public string RandomNumber { get; set; }
	}
}