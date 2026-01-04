namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_OUTLOGIN_SELECT
/// </summary>
public class ACP_SITE_OUTLOGIN_SELECT
{
	public const string SP_NAME = "ACP_SITE_OUTLOGIN_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// IDX
		/// </summary>
		[Description("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Description("SI_IDX")]
		public int SI_IDX { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// IDX
		/// </summary>
		[Column("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// INPUTTEXT1
		/// </summary>
		[Column("INPUTTEXT1")]
		public string INPUTTEXT1 { get; set; }
		/// <summary>
		/// INPUTTEXT2
		/// </summary>
		[Column("INPUTTEXT2")]
		public string INPUTTEXT2 { get; set; }
		/// <summary>
		/// INPUTTEXT3
		/// </summary>
		[Column("INPUTTEXT3")]
		public string INPUTTEXT3 { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// IDX
		/// </summary>
		[Column("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// INPUTTEXT1
		/// </summary>
		[Column("INPUTTEXT1")]
		public string INPUTTEXT1 { get; set; }
		/// <summary>
		/// INPUTTEXT2
		/// </summary>
		[Column("INPUTTEXT2")]
		public string INPUTTEXT2 { get; set; }
		/// <summary>
		/// INPUTTEXT3
		/// </summary>
		[Column("INPUTTEXT3")]
		public string INPUTTEXT3 { get; set; }
		/// <summary>
		/// OT_STATUS
		/// </summary>
		[Column("OT_STATUS")]
		public string OT_STATUS { get; set; }
		/// <summary>
		/// REGDATE
		/// </summary>
		[Column("REGDATE")]
		public DateTime REGDATE { get; set; }
	}
}