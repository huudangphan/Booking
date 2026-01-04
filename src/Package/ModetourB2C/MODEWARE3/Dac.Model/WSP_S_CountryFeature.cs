namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_국가속성
/// </summary>
public class WSP_S_CountryFeature
{
	public const string SP_NAME = "WSP_S_국가속성";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Description("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// INFOTYPE번호
		/// </summary>
		[Description("INFOTYPE번호")]
		public int INFOTYPE_Number { get; set; }
		/// <summary>
		/// WEATHER
		/// </summary>
		[Description("WEATHER")]
		public string WEATHER { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// PLKNAME
		/// </summary>
		[Column("PLKNAME")]
		public string PLKNAME { get; set; }
		/// <summary>
		/// PLKNAME1
		/// </summary>
		[Column("PLKNAME1")]
		public string PLKNAME1 { get; set; }
		/// <summary>
		/// PLENAME
		/// </summary>
		[Column("PLENAME")]
		public string PLENAME { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// PLKNAME
		/// </summary>
		[Column("PLKNAME")]
		public string PLKNAME { get; set; }
		/// <summary>
		/// PLKNAME1
		/// </summary>
		[Column("PLKNAME1")]
		public string PLKNAME1 { get; set; }
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
		/// PLENAME
		/// </summary>
		[Column("PLENAME")]
		public string PLENAME { get; set; }
		/// <summary>
		/// sort
		/// </summary>
		[Column("sort")]
		public int sort { get; set; }
		/// <summary>
		/// 좌표
		/// </summary>
		[Column("좌표")]
		public string Coordinate { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// PLACEIMAGE번호
		/// </summary>
		[Column("PLACEIMAGE번호")]
		public int PLACEIMAGE_Number { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
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
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// PLKNAME
		/// </summary>
		[Column("PLKNAME")]
		public string PLKNAME { get; set; }
		/// <summary>
		/// PLENAME
		/// </summary>
		[Column("PLENAME")]
		public string PLENAME { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// INFOTYPE번호
		/// </summary>
		[Column("INFOTYPE번호")]
		public int INFOTYPE_Number { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
	}
}