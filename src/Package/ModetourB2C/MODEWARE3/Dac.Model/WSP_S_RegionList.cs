namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_지역리스트
/// </summary>
public class WSP_S_RegionList
{
	public const string SP_NAME = "WSP_S_지역리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Description("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// AREA1
		/// </summary>
		[Description("AREA1")]
		public string AREA1 { get; set; }
		/// <summary>
		/// GUBUN
		/// </summary>
		[Description("GUBUN")]
		public string GUBUN { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public string Column1 { get; set; }
		/// <summary>
		/// Column2
		/// </summary>
		[Column("Column2")]
		public string Column2 { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// PLKNAME1
		/// </summary>
		[Column("PLKNAME1")]
		public string PLKNAME1 { get; set; }
		/// <summary>
		/// PLKNAME2
		/// </summary>
		[Column("PLKNAME2")]
		public string PLKNAME2 { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// PLENAME1
		/// </summary>
		[Column("PLENAME1")]
		public string PLENAME1 { get; set; }
		/// <summary>
		/// 좌표
		/// </summary>
		[Column("좌표")]
		public string Coordinate { get; set; }
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
		/// PLENAME
		/// </summary>
		[Column("PLENAME")]
		public string PLENAME { get; set; }
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