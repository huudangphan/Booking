namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_GOOGLESHAREKEY_SELECT
/// </summary>
public class ACP_SITE_GOOGLESHAREKEY_SELECT
{
	public const string SP_NAME = "ACP_SITE_GOOGLESHAREKEY_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// GO_IDX
		/// </summary>
		[Description("GO_IDX")]
		public int GO_IDX { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// GO_IDX
		/// </summary>
		[Column("GO_IDX")]
		public int GO_IDX { get; set; }
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Column("SI_IDX")]
		public int SI_IDX { get; set; }
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
		/// RSH_REGDATE
		/// </summary>
		[Column("RSH_REGDATE")]
		public DateTime RSH_REGDATE { get; set; }
		/// <summary>
		/// RSH_USE
		/// </summary>
		[Column("RSH_USE")]
		public string RSH_USE { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// GO_IDX
		/// </summary>
		[Column("GO_IDX")]
		public int GO_IDX { get; set; }
		/// <summary>
		/// SI_SVC
		/// </summary>
		[Column("SI_SVC")]
		public string SI_SVC { get; set; }
		/// <summary>
		/// SI_NAME
		/// </summary>
		[Column("SI_NAME")]
		public string SI_NAME { get; set; }
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
		/// RSH_REGDATE
		/// </summary>
		[Column("RSH_REGDATE")]
		public DateTime RSH_REGDATE { get; set; }
		/// <summary>
		/// RSH_USE
		/// </summary>
		[Column("RSH_USE")]
		public string RSH_USE { get; set; }
		/// <summary>
		/// SI_DOMAIN
		/// </summary>
		[Column("SI_DOMAIN")]
		public string SI_DOMAIN { get; set; }
	}
}