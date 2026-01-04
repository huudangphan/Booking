namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_PUSH_회원기기
/// </summary>
public class WSP_T_CMN_PUSH_MemberEquipment
{
	public const string SP_NAME = "WSP_T_CMN_PUSH_회원기기";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// AppKey
		/// </summary>
		[Description("AppKey")]
		public string AppKey { get; set; }
		/// <summary>
		/// DeviceId
		/// </summary>
		[Description("DeviceId")]
		public string DeviceId { get; set; }
		/// <summary>
		/// DeviceOs
		/// </summary>
		[Description("DeviceOs")]
		public string DeviceOs { get; set; }
		/// <summary>
		/// DeviceModel
		/// </summary>
		[Description("DeviceModel")]
		public string DeviceModel { get; set; }
		/// <summary>
		/// Push_UseYN
		/// </summary>
		[Description("Push_UseYN")]
		public string Push_UseYN { get; set; }
		/// <summary>
		/// Token
		/// </summary>
		[Description("Token")]
		public string Token { get; set; }
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