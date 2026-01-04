namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_GNB_SELECT
/// </summary>
public class ACP_SITE_GNB_SELECT
{
	public const string SP_NAME = "ACP_SITE_GNB_SELECT";

	public class Parameters : BaseDbParameters
	{
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
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// SGN_IDX
		/// </summary>
		[Column("SGN_IDX")]
		public int SGN_IDX { get; set; }
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Column("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// SGN_TITLE
		/// </summary>
		[Column("SGN_TITLE")]
		public string SGN_TITLE { get; set; }
		/// <summary>
		/// SGN_LINK
		/// </summary>
		[Column("SGN_LINK")]
		public string SGN_LINK { get; set; }
		/// <summary>
		/// SGN_SORT
		/// </summary>
		[Column("SGN_SORT")]
		public int SGN_SORT { get; set; }
		/// <summary>
		/// SGN_STATUS
		/// </summary>
		[Column("SGN_STATUS")]
		public string SGN_STATUS { get; set; }
		/// <summary>
		/// SGN_MODDATE
		/// </summary>
		[Column("SGN_MODDATE")]
		public DateTime SGN_MODDATE { get; set; }
		/// <summary>
		/// SGN_TARGET
		/// </summary>
		[Column("SGN_TARGET")]
		public string SGN_TARGET { get; set; }
	}
}