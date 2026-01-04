namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_세계문화축제_메인
/// </summary>
public class WSP_S_CMN_WorldCultureFestival_Main
{
	public const string SP_NAME = "WSP_S_CMN_세계문화축제_메인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 글개수
		/// </summary>
		[Description("글개수")]
		public int CharactersNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// CITY
		/// </summary>
		[Column("CITY")]
		public string CITY { get; set; }
		/// <summary>
		/// FESTIVAL
		/// </summary>
		[Column("FESTIVAL")]
		public string FESTIVAL { get; set; }
		/// <summary>
		/// IMAGENAME
		/// </summary>
		[Column("IMAGENAME")]
		public string IMAGENAME { get; set; }
	}
}