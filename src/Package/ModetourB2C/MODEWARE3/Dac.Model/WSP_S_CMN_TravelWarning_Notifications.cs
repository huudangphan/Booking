namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_여행경보_공지사항
/// </summary>
public class WSP_S_CMN_TravelWarning_Notifications
{
	public const string SP_NAME = "WSP_S_CMN_여행경보_공지사항";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
	}

	public class Result : IDbResult
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
		/// TITLE
		/// </summary>
		[Column("TITLE")]
		public string TITLE { get; set; }
		/// <summary>
		/// CONTENT
		/// </summary>
		[Column("CONTENT")]
		public string CONTENT { get; set; }
		/// <summary>
		/// WRTDT
		/// </summary>
		[Column("WRTDT")]
		public string WRTDT { get; set; }
	}
}