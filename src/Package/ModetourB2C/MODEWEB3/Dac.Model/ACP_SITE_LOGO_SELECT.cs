namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_LOGO_SELECT
/// </summary>
public class ACP_SITE_LOGO_SELECT
{
	public const string SP_NAME = "ACP_SITE_LOGO_SELECT";

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
		/// SI_IDX
		/// </summary>
		[Description("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// SLO_IDX
		/// </summary>
		[Description("SLO_IDX")]
		public int SLO_IDX { get; set; }
		/// <summary>
		/// SLO_STATUS
		/// </summary>
		[Description("SLO_STATUS")]
		public string SLO_STATUS { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// SLO_IDX
		/// </summary>
		[Column("SLO_IDX")]
		public int SLO_IDX { get; set; }
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Column("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// SLO_IMG
		/// </summary>
		[Column("SLO_IMG")]
		public string SLO_IMG { get; set; }
		/// <summary>
		/// SLO_STATUS
		/// </summary>
		[Column("SLO_STATUS")]
		public string SLO_STATUS { get; set; }
		/// <summary>
		/// ROLL_CHK
		/// </summary>
		[Column("ROLL_CHK")]
		public string ROLL_CHK { get; set; }
	}
}