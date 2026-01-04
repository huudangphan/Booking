namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_LIKE_SET
/// </summary>
public class WSP_T_CMN_LIKE_SET
{
	public const string SP_NAME = "WSP_T_CMN_LIKE_SET";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// LikeIdx
		/// </summary>
		[Description("LikeIdx")]
		public int LikeIdx { get; set; }
		/// <summary>
		/// Gubun
		/// </summary>
		[Description("Gubun")]
		public string Gubun { get; set; }
		/// <summary>
		/// UserPTID
		/// </summary>
		[Description("UserPTID")]
		public int UserPTID { get; set; }
	}

}