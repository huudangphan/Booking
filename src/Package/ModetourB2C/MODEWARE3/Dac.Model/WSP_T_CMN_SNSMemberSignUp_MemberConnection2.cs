namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_SNS회원가입_회원연결2
/// </summary>
public class WSP_T_CMN_SNSMemberSignUp_MemberConnection2
{
	public const string SP_NAME = "WSP_T_CMN_SNS회원가입_회원연결2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// MODE
		/// </summary>
		[Description("MODE")]
		public string MODE { get; set; }
		/// <summary>
		/// MEM_ID
		/// </summary>
		[Description("MEM_ID")]
		public string MEM_ID { get; set; }
		/// <summary>
		/// CHANNEL
		/// </summary>
		[Description("CHANNEL")]
		public string CHANNEL { get; set; }
		/// <summary>
		/// CHANNELID
		/// </summary>
		[Description("CHANNELID")]
		public string CHANNELID { get; set; }
		/// <summary>
		/// CHANNEL_EMAIL
		/// </summary>
		[Description("CHANNEL_EMAIL")]
		public string CHANNEL_EMAIL { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// RETURN_CODE
		/// </summary>
		[Column("RETURN_CODE")]
		public int RETURN_CODE { get; set; }
		/// <summary>
		/// RETURN_MSG
		/// </summary>
		[Column("RETURN_MSG")]
		public string RETURN_MSG { get; set; }
	}
}