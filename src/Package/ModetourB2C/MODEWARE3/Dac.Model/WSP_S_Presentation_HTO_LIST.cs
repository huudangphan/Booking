namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_설명회_HTO_LIST
/// </summary>
public class WSP_S_Presentation_HTO_LIST
{
	public const string SP_NAME = "WSP_S_설명회_HTO_LIST";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 호텔번호
		/// </summary>
		[Description("호텔번호")]
		public string HotelNumber { get; set; }
		/// <summary>
		/// 관광번호
		/// </summary>
		[Description("관광번호")]
		public string SightseeingNumber { get; set; }
		/// <summary>
		/// 옵션번호
		/// </summary>
		[Description("옵션번호")]
		public string OptionNumber { get; set; }
		/// <summary>
		/// 국가번호
		/// </summary>
		[Description("국가번호")]
		public string CountryNumber { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Description("도시번호")]
		public string CityNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 상위번호
		/// </summary>
		[Column("상위번호")]
		public int HighRankNumber { get; set; }
		/// <summary>
		/// 국가번호
		/// </summary>
		[Column("국가번호")]
		public int CountryNumber { get; set; }
		/// <summary>
		/// 지역1
		/// </summary>
		[Column("지역1")]
		public string Region1 { get; set; }
		/// <summary>
		/// SORT1
		/// </summary>
		[Column("SORT1")]
		public int SORT1 { get; set; }
		/// <summary>
		/// 지역영문
		/// </summary>
		[Column("지역영문")]
		public string RegionEnglish { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// 객체명
		/// </summary>
		[Column("객체명")]
		public string ObjectName { get; set; }
		/// <summary>
		/// 객체번호
		/// </summary>
		[Column("객체번호")]
		public int ObjectNumber { get; set; }
		/// <summary>
		/// SORT1
		/// </summary>
		[Column("SORT1")]
		public int SORT1 { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 국가번호
		/// </summary>
		[Column("국가번호")]
		public int CountryNumber { get; set; }
		/// <summary>
		/// 주번호
		/// </summary>
		[Column("주번호")]
		public int StateNumber { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// 지역1
		/// </summary>
		[Column("지역1")]
		public string Region1 { get; set; }
		/// <summary>
		/// SORT1
		/// </summary>
		[Column("SORT1")]
		public int SORT1 { get; set; }
		/// <summary>
		/// 지역영문
		/// </summary>
		[Column("지역영문")]
		public string RegionEnglish { get; set; }
	}
}