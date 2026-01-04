namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_하위객체속성
/// </summary>
public class WSP_S_SubobjectFeature
{
	public const string SP_NAME = "WSP_S_하위객체속성";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Description("PLID")]
		public string PLID { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// PLKNAME
		/// </summary>
		[Column("PLKNAME")]
		public string PLKNAME { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// TYPEID
		/// </summary>
		[Column("TYPEID")]
		public int TYPEID { get; set; }
		/// <summary>
		/// P_PLID
		/// </summary>
		[Column("P_PLID")]
		public int P_PLID { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// SELPID
		/// </summary>
		[Column("SELPID")]
		public int SELPID { get; set; }
		/// <summary>
		/// sort
		/// </summary>
		[Column("sort")]
		public int sort { get; set; }
		/// <summary>
		/// PLENAME
		/// </summary>
		[Column("PLENAME")]
		public string PLENAME { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// P_PLID
		/// </summary>
		[Column("P_PLID")]
		public int P_PLID { get; set; }
		/// <summary>
		/// SELPID
		/// </summary>
		[Column("SELPID")]
		public int SELPID { get; set; }
		/// <summary>
		/// PLACEIMAGE번호
		/// </summary>
		[Column("PLACEIMAGE번호")]
		public int PLACEIMAGE_Number { get; set; }
		/// <summary>
		/// PLACEINFO번호
		/// </summary>
		[Column("PLACEINFO번호")]
		public int PLACEINFO_Number { get; set; }
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
	}
}