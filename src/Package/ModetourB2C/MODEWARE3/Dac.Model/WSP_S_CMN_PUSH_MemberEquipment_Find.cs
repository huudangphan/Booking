namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_PUSH_회원기기_조회
/// </summary>
public class WSP_S_CMN_PUSH_MemberEquipment_Find
{
	public const string SP_NAME = "WSP_S_CMN_PUSH_회원기기_조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// APP_KEY
		/// </summary>
		[Description("APP_KEY")]
		public string APP_KEY { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// AppKey
		/// </summary>
		[Column("AppKey")]
		public string AppKey { get; set; }
		/// <summary>
		/// DeviceId
		/// </summary>
		[Column("DeviceId")]
		public string DeviceId { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// DeviceOs
		/// </summary>
		[Column("DeviceOs")]
		public string DeviceOs { get; set; }
		/// <summary>
		/// DeviceModel
		/// </summary>
		[Column("DeviceModel")]
		public string DeviceModel { get; set; }
		/// <summary>
		/// Push_UseYN
		/// </summary>
		[Column("Push_UseYN")]
		public string Push_UseYN { get; set; }
		/// <summary>
		/// Regdate
		/// </summary>
		[Column("Regdate")]
		public DateTime Regdate { get; set; }
		/// <summary>
		/// Upddate
		/// </summary>
		[Column("Upddate")]
		public DateTime Upddate { get; set; }
		/// <summary>
		/// Token
		/// </summary>
		[Column("Token")]
		public string Token { get; set; }
	}
}