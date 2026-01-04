namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_MPLE_직위코드
/// </summary>
public class WSP_S_MPLE_DutyPositionCode
{
	public const string SP_NAME = "WSP_S_MPLE_직위코드";

	public class Result : IDbResult
	{
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
	}
}