namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// ASP_MY_CHOICE_INSERT
/// </summary>
public class ASP_MY_CHOICE_INSERT
{
	public const string SP_NAME = "ASP_MY_CHOICE_INSERT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// SUS_USERKEY
		/// </summary>
		[Description("SUS_USERKEY")]
		public string SUS_USERKEY { get; set; }
		/// <summary>
		/// SUS_TYPE
		/// </summary>
		[Description("SUS_TYPE")]
		public string SUS_TYPE { get; set; }
		/// <summary>
		/// GRO_IDX
		/// </summary>
		[Description("GRO_IDX")]
		public int GRO_IDX { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// RCODE
		/// </summary>
		[Column("RCODE")]
		public string RCODE { get; set; }
		/// <summary>
		/// RMSG
		/// </summary>
		[Column("RMSG")]
		public string RMSG { get; set; }
		/// <summary>
		/// TOTAL_CNT
		/// </summary>
		[Column("TOTAL_CNT")]
		public int TOTAL_CNT { get; set; }
		/// <summary>
		/// RESULT
		/// </summary>
		[Column("RESULT")]
		public string RESULT { get; set; }
	}
}