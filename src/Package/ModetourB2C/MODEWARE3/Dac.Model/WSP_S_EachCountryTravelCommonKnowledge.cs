namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_나라별여행상식
/// </summary>
public class WSP_S_EachCountryTravelCommonKnowledge
{
	public const string SP_NAME = "WSP_S_나라별여행상식";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 국가개요
		/// </summary>
		[Description("국가개요")]
		public int CountrySummary { get; set; }
		/// <summary>
		/// 도시
		/// </summary>
		[Description("도시")]
		public int City { get; set; }
		/// <summary>
		/// 도시_Sub
		/// </summary>
		[Description("도시_Sub")]
		public int City_SUB { get; set; }
		/// <summary>
		/// PLACEINFO번호
		/// </summary>
		[Description("PLACEINFO번호")]
		public int PLACEINFO_Number { get; set; }
		/// <summary>
		/// Gubun
		/// </summary>
		[Description("Gubun")]
		public string Gubun { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 국가
		/// </summary>
		[Column("국가")]
		public string Country { get; set; }
		/// <summary>
		/// 국가번호
		/// </summary>
		[Column("국가번호")]
		public int CountryNumber { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 주
		/// </summary>
		[Column("주")]
		public string Week { get; set; }
		/// <summary>
		/// 주번호
		/// </summary>
		[Column("주번호")]
		public int StateNumber { get; set; }
		/// <summary>
		/// 도시
		/// </summary>
		[Column("도시")]
		public string City { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 도시
		/// </summary>
		[Column("도시")]
		public string City { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 하위제목
		/// </summary>
		[Column("하위제목")]
		public string LowRankTitle { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// PLACEINFO번호
		/// </summary>
		[Column("PLACEINFO번호")]
		public int PLACEINFO_Number { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 하위제목
		/// </summary>
		[Column("하위제목")]
		public string LowRankTitle { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// PLACEINFO번호
		/// </summary>
		[Column("PLACEINFO번호")]
		public int PLACEINFO_Number { get; set; }
		/// <summary>
		/// INFOTYPE번호
		/// </summary>
		[Column("INFOTYPE번호")]
		public int INFOTYPE_Number { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// 대륙번호
		/// </summary>
		[Column("대륙번호")]
		public int ContinentNumber { get; set; }
		/// <summary>
		/// 국가
		/// </summary>
		[Column("국가")]
		public string Country { get; set; }
		/// <summary>
		/// 국가번호
		/// </summary>
		[Column("국가번호")]
		public int CountryNumber { get; set; }
	}
}