namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// ASP_MAIN_SELECT_CHECK
/// </summary>
public class ASP_MAIN_SELECT_CHECK
{
	public const string SP_NAME = "ASP_MAIN_SELECT_CHECK";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Description("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// EVENT_STR
		/// </summary>
		[Description("EVENT_STR")]
		public string EVENT_STR { get; set; }
		/// <summary>
		/// PRODUCT_STR
		/// </summary>
		[Description("PRODUCT_STR")]
		public string PRODUCT_STR { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// SEL_IDX
		/// </summary>
		[Column("SEL_IDX")]
		public int SEL_IDX { get; set; }
	}
}