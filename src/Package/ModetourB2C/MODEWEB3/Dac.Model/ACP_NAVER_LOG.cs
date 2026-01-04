namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_NAVER_LOG
/// </summary>
public class ACP_NAVER_LOG
{
	public const string SP_NAME = "ACP_NAVER_LOG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// CODE
		/// </summary>
		[Description("CODE")]
		public int CODE { get; set; }
		/// <summary>
		/// PATH
		/// </summary>
		[Description("PATH")]
		public string PATH { get; set; }
		/// <summary>
		/// DATA
		/// </summary>
		[Description("DATA")]
		public string DATA { get; set; }
		/// <summary>
		/// RESULT
		/// </summary>
		[Description("RESULT")]
		public string RESULT { get; set; }
		/// <summary>
		/// STARTTIME
		/// </summary>
		[Description("STARTTIME")]
		public DateTime STARTTIME { get; set; }
		/// <summary>
		/// ENDTIME
		/// </summary>
		[Description("ENDTIME")]
		public DateTime ENDTIME { get; set; }
	}

}