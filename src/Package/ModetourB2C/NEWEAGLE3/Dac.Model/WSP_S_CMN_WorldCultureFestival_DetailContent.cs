namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_세계문화축제_상세내용
/// </summary>
public class WSP_S_CMN_WorldCultureFestival_DetailContent
{
	public const string SP_NAME = "WSP_S_CMN_세계문화축제_상세내용";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 번호
		/// </summary>
		[Description("번호")]
		public int Number { get; set; }
	}

	public class Result1 : IDbResult
	{
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
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
	}
}