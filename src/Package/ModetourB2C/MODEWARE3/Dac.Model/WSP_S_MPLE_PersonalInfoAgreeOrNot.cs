namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_MPLE_개인정보동의여부
/// </summary>
public class WSP_S_MPLE_PersonalInfoAgreeOrNot
{
	public const string SP_NAME = "WSP_S_MPLE_개인정보동의여부";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 동의여부노출
		/// </summary>
		[Column("동의여부노출")]
		public string AgreeOrNotDisplay { get; set; }
	}
}