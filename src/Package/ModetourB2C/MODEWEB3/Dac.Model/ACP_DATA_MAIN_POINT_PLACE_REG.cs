namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_DATA_MAIN_POINT_PLACE_REG
/// </summary>
public class ACP_DATA_MAIN_POINT_PLACE_REG
{
	public const string SP_NAME = "ACP_DATA_MAIN_POINT_PLACE_REG";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Description("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Description("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// GPP_TYPE
		/// </summary>
		[Description("GPP_TYPE")]
		public string GPP_TYPE { get; set; }
		/// <summary>
		/// STR_MENU
		/// </summary>
		[Description("STR_MENU")]
		public string STR_MENU { get; set; }
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
	}
}