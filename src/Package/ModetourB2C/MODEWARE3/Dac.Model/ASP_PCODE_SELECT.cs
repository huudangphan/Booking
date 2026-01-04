namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// ASP_PCODE_SELECT
/// </summary>
public class ASP_PCODE_SELECT
{
	public const string SP_NAME = "ASP_PCODE_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// GRO_IDX
		/// </summary>
		[Description("GRO_IDX")]
		public int GRO_IDX { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// PCODE
		/// </summary>
		[Column("PCODE")]
		public string PCODE { get; set; }
	}
}