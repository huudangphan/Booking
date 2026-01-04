namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_SNS_SHARE_INSERT
/// </summary>
public class WSP_T_CMN_SNS_SHARE_INSERT
{
	public const string SP_NAME = "WSP_T_CMN_SNS_SHARE_INSERT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PageIdx
		/// </summary>
		[Description("PageIdx")]
		public int PageIdx { get; set; }
		/// <summary>
		/// PageGubun
		/// </summary>
		[Description("PageGubun")]
		public string PageGubun { get; set; }
		/// <summary>
		/// SNSGubun
		/// </summary>
		[Description("SNSGubun")]
		public string SNSGubun { get; set; }
		/// <summary>
		/// UserPTID
		/// </summary>
		[Description("UserPTID")]
		public int UserPTID { get; set; }
	}

}