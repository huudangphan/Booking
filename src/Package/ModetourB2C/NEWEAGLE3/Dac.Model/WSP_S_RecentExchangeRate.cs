namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_최근환율
/// </summary>
public class WSP_S_RecentExchangeRate
{
	public const string SP_NAME = "WSP_S_최근환율";

	public class Result : IDbResult
	{
		/// <summary>
		/// 국가코드
		/// </summary>
		[Column("국가코드")]
		public string CountryCode { get; set; }
		/// <summary>
		/// 고시일
		/// </summary>
		[Column("고시일")]
		public DateTime ExamDate { get; set; }
		/// <summary>
		/// 환율
		/// </summary>
		[Column("환율")]
		public string ExchangeRate { get; set; }
	}
}