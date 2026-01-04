namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_TP_BANNER_MAPPING
/// </summary>
public class ACP_TP_BANNER_MAPPING
{
	public const string SP_NAME = "ACP_TP_BANNER_MAPPING";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// MODE
		/// </summary>
		[Description("MODE")]
		public string MODE { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// BI_IDX
		/// </summary>
		[Column("BI_IDX")]
		public int BI_IDX { get; set; }
		/// <summary>
		/// TITLE
		/// </summary>
		[Column("TITLE")]
		public string TITLE { get; set; }
		/// <summary>
		/// START_DT
		/// </summary>
		[Column("START_DT")]
		public DateTime START_DT { get; set; }
		/// <summary>
		/// END_DT
		/// </summary>
		[Column("END_DT")]
		public DateTime END_DT { get; set; }
		/// <summary>
		/// PAY_DT
		/// </summary>
		[Column("PAY_DT")]
		public DateTime PAY_DT { get; set; }
	}
}