namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// ASP_MY_CHOICE_INFO_SELECT
/// </summary>
public class ASP_MY_CHOICE_INFO_SELECT
{
	public const string SP_NAME = "ASP_MY_CHOICE_INFO_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// SUS_USERKEY
		/// </summary>
		[Description("SUS_USERKEY")]
		public string SUS_USERKEY { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// COHICE_CNT
		/// </summary>
		[Column("COHICE_CNT")]
		public int COHICE_CNT { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// RECENT_GRO_IDX
		/// </summary>
		[Column("RECENT_GRO_IDX")]
		public int RECENT_GRO_IDX { get; set; }
		/// <summary>
		/// RECENT_THUMB
		/// </summary>
		[Column("RECENT_THUMB")]
		public string RECENT_THUMB { get; set; }
	}
}