namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_LOG_ERROR_DASHBOARD
/// </summary>
public class WSP_S_CMN_LOG_ERROR_DASHBOARD
{
	public const string SP_NAME = "WSP_S_CMN_LOG_ERROR_DASHBOARD";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Start
		/// </summary>
		[Description("Start")]
		public DateTime Start { get; set; }
		/// <summary>
		/// End
		/// </summary>
		[Description("End")]
		public DateTime End { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 페이지경로
		/// </summary>
		[Column("페이지경로")]
		public string PageRoute { get; set; }
		/// <summary>
		/// CNT
		/// </summary>
		[Column("CNT")]
		public int CNT { get; set; }
	}
}