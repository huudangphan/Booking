namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_TM_LIKE_LIST
/// </summary>
public class WSP_S_CMN_TM_LIKE_LIST
{
	public const string SP_NAME = "WSP_S_CMN_TM_LIKE_LIST";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// UserPTID
		/// </summary>
		[Description("UserPTID")]
		public int UserPTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Like_Idx
		/// </summary>
		[Column("Like_Idx")]
		public int Like_Idx { get; set; }
		/// <summary>
		/// Gubun
		/// </summary>
		[Column("Gubun")]
		public string Gubun { get; set; }
		/// <summary>
		/// Img
		/// </summary>
		[Column("Img")]
		public string Img { get; set; }
		/// <summary>
		/// Title
		/// </summary>
		[Column("Title")]
		public string Title { get; set; }
	}
}