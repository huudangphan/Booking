namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_회원중복가입_CI
/// </summary>
public class WSP_S_MemberDuplicationSignUp_CI
{
	public const string SP_NAME = "WSP_S_회원중복가입_CI";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// MODE
		/// </summary>
		[Description("MODE")]
		public string MODE { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// CI
		/// </summary>
		[Description("CI")]
		public string CI { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// MEM_ID
		/// </summary>
		[Column("MEM_ID")]
		public string MEM_ID { get; set; }
		/// <summary>
		/// CHANNEL
		/// </summary>
		[Column("CHANNEL")]
		public string CHANNEL { get; set; }
		/// <summary>
		/// CHANNELID
		/// </summary>
		[Column("CHANNELID")]
		public string CHANNELID { get; set; }
		/// <summary>
		/// CHANNEL_EMAIL
		/// </summary>
		[Column("CHANNEL_EMAIL")]
		public string CHANNEL_EMAIL { get; set; }
		/// <summary>
		/// REG_DATE
		/// </summary>
		[Column("REG_DATE")]
		public string REG_DATE { get; set; }
		/// <summary>
		/// CI
		/// </summary>
		[Column("CI")]
		public string CI { get; set; }
	}
}