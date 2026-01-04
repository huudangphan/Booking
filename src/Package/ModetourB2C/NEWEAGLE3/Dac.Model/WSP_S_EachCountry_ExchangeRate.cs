namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_국가별_환율
/// </summary>
public class WSP_S_EachCountry_ExchangeRate
{
	public const string SP_NAME = "WSP_S_국가별_환율";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 국가코드
		/// </summary>
		[Description("국가코드")]
		public string CountryCode { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 국가코드
		/// </summary>
		[Column("국가코드")]
		public string CountryCode { get; set; }
		/// <summary>
		/// 국가명
		/// </summary>
		[Column("국가명")]
		public string CountryName { get; set; }
		/// <summary>
		/// 화폐명
		/// </summary>
		[Column("화폐명")]
		public string CurrencyName { get; set; }
		/// <summary>
		/// 화폐한글명
		/// </summary>
		[Column("화폐한글명")]
		public string CurrencyKoreanName { get; set; }
		/// <summary>
		/// 단위
		/// </summary>
		[Column("단위")]
		public string Unit { get; set; }
		/// <summary>
		/// 환율
		/// </summary>
		[Column("환율")]
		public string ExchangeRate { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public string Order { get; set; }
		/// <summary>
		/// 고시일
		/// </summary>
		[Column("고시일")]
		public DateTime ExamDate { get; set; }
	}
}