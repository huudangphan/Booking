namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_SITE_PERSOVAL_SELECT
/// </summary>
public class ACP_SITE_PERSOVAL_SELECT
{
	public const string SP_NAME = "ACP_SITE_PERSOVAL_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// IDX
		/// </summary>
		[Description("IDX")]
		public int IDX { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// IDX
		/// </summary>
		[Column("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// SI_NAME
		/// </summary>
		[Column("SI_NAME")]
		public string SI_NAME { get; set; }
		/// <summary>
		/// TITLE
		/// </summary>
		[Column("TITLE")]
		public string TITLE { get; set; }
		/// <summary>
		/// STARTDT
		/// </summary>
		[Column("STARTDT")]
		public string STARTDT { get; set; }
		/// <summary>
		/// ENDDT
		/// </summary>
		[Column("ENDDT")]
		public string ENDDT { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Column("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// PTKNAME
		/// </summary>
		[Column("PTKNAME")]
		public string PTKNAME { get; set; }
		/// <summary>
		/// REGDATE
		/// </summary>
		[Column("REGDATE")]
		public DateTime REGDATE { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// IDX
		/// </summary>
		[Column("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// SI_IDX
		/// </summary>
		[Column("SI_IDX")]
		public int SI_IDX { get; set; }
		/// <summary>
		/// TITLE
		/// </summary>
		[Column("TITLE")]
		public string TITLE { get; set; }
		/// <summary>
		/// FILENM
		/// </summary>
		[Column("FILENM")]
		public string FILENM { get; set; }
		/// <summary>
		/// STARTDT
		/// </summary>
		[Column("STARTDT")]
		public string STARTDT { get; set; }
		/// <summary>
		/// ENDDT
		/// </summary>
		[Column("ENDDT")]
		public string ENDDT { get; set; }
		/// <summary>
		/// MEMO
		/// </summary>
		[Column("MEMO")]
		public string MEMO { get; set; }
	}
}