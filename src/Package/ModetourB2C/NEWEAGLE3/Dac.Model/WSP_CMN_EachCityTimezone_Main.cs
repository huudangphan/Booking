namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_CMN_도시별시차_메인
/// </summary>
public class WSP_CMN_EachCityTimezone_Main
{
	public const string SP_NAME = "WSP_CMN_도시별시차_메인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Description("PLID")]
		public string PLID { get; set; }
	}

	public class Result : IDbResult
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
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// INFOTYPE번호
		/// </summary>
		[Column("INFOTYPE번호")]
		public int INFOTYPE_Number { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// 국가
		/// </summary>
		[Column("국가")]
		public string Country { get; set; }
	}
}