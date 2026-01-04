namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_국가개요
/// </summary>
public class WSP_S_CountrySummary
{
	public const string SP_NAME = "WSP_S_국가개요";

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
		/// AREA1
		/// </summary>
		[Description("AREA1")]
		public string AREA1 { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// NATION
		/// </summary>
		[Column("NATION")]
		public string NATION { get; set; }
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
		/// Column1
		/// </summary>
		[Column("Column1")]
		public string Column1 { get; set; }
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
		/// 좌표
		/// </summary>
		[Column("좌표")]
		public string Coordinate { get; set; }
		/// <summary>
		/// P_PLID
		/// </summary>
		[Column("P_PLID")]
		public int P_PLID { get; set; }
	}

	public class Result2 : IDbResult
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

	public class Result3 : IDbResult
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
		/// Column1
		/// </summary>
		[Column("Column1")]
		public string Column1 { get; set; }
	}

	public class Result4 : IDbResult
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
}