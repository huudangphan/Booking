namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_대륙국가도시
/// </summary>
public class WSP_S_ContinentCountryCity
{
	public const string SP_NAME = "WSP_S_대륙국가도시";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 지역번호
		/// </summary>
		[Description("지역번호")]
		public int RegionNumber { get; set; }
		/// <summary>
		/// 한글명
		/// </summary>
		[Description("한글명")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문명
		/// </summary>
		[Description("영문명")]
		public string EnglishName { get; set; }
		/// <summary>
		/// RETURN
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("RETURN")]
		public int RETURN { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 상위번호
		/// </summary>
		[Column("상위번호")]
		public int HighRankNumber { get; set; }
		/// <summary>
		/// 한글명
		/// </summary>
		[Column("한글명")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문명
		/// </summary>
		[Column("영문명")]
		public string EnglishName { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 한글명
		/// </summary>
		[Column("한글명")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문명
		/// </summary>
		[Column("영문명")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 대륙
		/// </summary>
		[Column("대륙")]
		public string Continent { get; set; }
		/// <summary>
		/// 국가
		/// </summary>
		[Column("국가")]
		public string Country { get; set; }
		/// <summary>
		/// 국가영문
		/// </summary>
		[Column("국가영문")]
		public string CountryEnglish { get; set; }
		/// <summary>
		/// 주
		/// </summary>
		[Column("주")]
		public string Week { get; set; }
		/// <summary>
		/// 주영문
		/// </summary>
		[Column("주영문")]
		public string StateEnglish { get; set; }
		/// <summary>
		/// 도시
		/// </summary>
		[Column("도시")]
		public string City { get; set; }
		/// <summary>
		/// 도시영문
		/// </summary>
		[Column("도시영문")]
		public string CityEnglish { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 대륙
		/// </summary>
		[Column("대륙")]
		public string Continent { get; set; }
		/// <summary>
		/// 국가
		/// </summary>
		[Column("국가")]
		public string Country { get; set; }
		/// <summary>
		/// 국가영문
		/// </summary>
		[Column("국가영문")]
		public string CountryEnglish { get; set; }
		/// <summary>
		/// 도시
		/// </summary>
		[Column("도시")]
		public string City { get; set; }
		/// <summary>
		/// 도시영문
		/// </summary>
		[Column("도시영문")]
		public string CityEnglish { get; set; }
	}
}