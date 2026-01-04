namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_주요도시_관광거리
/// </summary>
public class WSP_S_MainCity_SightseeingDistance
{
	public const string SP_NAME = "WSP_S_주요도시_관광거리";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 도시번호
		/// </summary>
		[Description("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// 도시명
		/// </summary>
		[Description("도시명")]
		public string CityName { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 지역1
		/// </summary>
		[Column("지역1")]
		public string Region1 { get; set; }
		/// <summary>
		/// 지역2
		/// </summary>
		[Column("지역2")]
		public string Region2 { get; set; }
		/// <summary>
		/// 지역3
		/// </summary>
		[Column("지역3")]
		public string Region3 { get; set; }
		/// <summary>
		/// 지역3영문명
		/// </summary>
		[Column("지역3영문명")]
		public string Region3EnglishName { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// 도시개요
		/// </summary>
		[Column("도시개요")]
		public string CitySummary { get; set; }
		/// <summary>
		/// 명칭
		/// </summary>
		[Column("명칭")]
		public string Name { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 사진1
		/// </summary>
		[Column("사진1")]
		public string Picture1 { get; set; }
		/// <summary>
		/// 사진2
		/// </summary>
		[Column("사진2")]
		public string Picture2 { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 지역1
		/// </summary>
		[Column("지역1")]
		public string Region1 { get; set; }
		/// <summary>
		/// 지역2
		/// </summary>
		[Column("지역2")]
		public string Region2 { get; set; }
		/// <summary>
		/// 지역3
		/// </summary>
		[Column("지역3")]
		public string Region3 { get; set; }
		/// <summary>
		/// 지역3영문명
		/// </summary>
		[Column("지역3영문명")]
		public string Region3EnglishName { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// 도시개요
		/// </summary>
		[Column("도시개요")]
		public string CitySummary { get; set; }
		/// <summary>
		/// 명칭
		/// </summary>
		[Column("명칭")]
		public string Name { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 사진1
		/// </summary>
		[Column("사진1")]
		public string Picture1 { get; set; }
		/// <summary>
		/// 사진2
		/// </summary>
		[Column("사진2")]
		public string Picture2 { get; set; }
		/// <summary>
		/// 도시코드
		/// </summary>
		[Column("도시코드")]
		public int CityCode { get; set; }
	}
}