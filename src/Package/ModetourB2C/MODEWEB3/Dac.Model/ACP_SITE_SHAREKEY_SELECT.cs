namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_SHAREKEY_SELECT
/// </summary>
public class ACP_SITE_SHAREKEY_SELECT
{
	public const string SP_NAME = "ACP_SITE_SHAREKEY_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// RSH_IDX
		/// </summary>
		[Description("RSH_IDX")]
		public int RSH_IDX { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// RSH_IDX
		/// </summary>
		[Column("RSH_IDX")]
		public int RSH_IDX { get; set; }
		/// <summary>
		/// SNS_TYPE
		/// </summary>
		[Column("SNS_TYPE")]
		public string SNS_TYPE { get; set; }
		/// <summary>
		/// RSH_KEY
		/// </summary>
		[Column("RSH_KEY")]
		public string RSH_KEY { get; set; }
		/// <summary>
		/// RSH_MEMO
		/// </summary>
		[Column("RSH_MEMO")]
		public string RSH_MEMO { get; set; }
		/// <summary>
		/// RSH_ICON_CLASS
		/// </summary>
		[Column("RSH_ICON_CLASS")]
		public string RSH_ICON_CLASS { get; set; }
		/// <summary>
		/// RSH_USE
		/// </summary>
		[Column("RSH_USE")]
		public string RSH_USE { get; set; }
		/// <summary>
		/// RSH_REGDATE
		/// </summary>
		[Column("RSH_REGDATE")]
		public DateTime RSH_REGDATE { get; set; }
	}
}