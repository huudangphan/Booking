namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SVC_CREATE_CHECK
/// </summary>
public class ACP_SVC_CREATE_CHECK
{
	public const string SP_NAME = "ACP_SVC_CREATE_CHECK";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Description("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// IDX
		/// </summary>
		[Description("IDX")]
		public int IDX { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// TEST_REGDATE
		/// </summary>
		[Column("TEST_REGDATE")]
		public DateTime TEST_REGDATE { get; set; }
		/// <summary>
		/// SVC_REGDATE
		/// </summary>
		[Column("SVC_REGDATE")]
		public DateTime SVC_REGDATE { get; set; }
	}
}