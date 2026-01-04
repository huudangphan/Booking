namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_INFO_USER_SELECT
/// </summary>
public class ACP_INFO_USER_SELECT
{
	public const string SP_NAME = "ACP_INFO_USER_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// AUGR_IDX
		/// </summary>
		[Description("AUGR_IDX")]
		public int AUGR_IDX { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Description("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// AUS_STATUS
		/// </summary>
		[Description("AUS_STATUS")]
		public string AUS_STATUS { get; set; }
		/// <summary>
		/// AUS_RIGHT
		/// </summary>
		[Description("AUS_RIGHT")]
		public string AUS_RIGHT { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// AUGR_RIGHT
		/// </summary>
		[Column("AUGR_RIGHT")]
		public string AUGR_RIGHT { get; set; }
		/// <summary>
		/// AUS_RIGHT
		/// </summary>
		[Column("AUS_RIGHT")]
		public string AUS_RIGHT { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Column("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// AUGR_IDX
		/// </summary>
		[Column("AUGR_IDX")]
		public int AUGR_IDX { get; set; }
		/// <summary>
		/// AUGR_PTID
		/// </summary>
		[Column("AUGR_PTID")]
		public int AUGR_PTID { get; set; }
		/// <summary>
		/// PTKNAME
		/// </summary>
		[Column("PTKNAME")]
		public string PTKNAME { get; set; }
		/// <summary>
		/// AUGR_RIGHT
		/// </summary>
		[Column("AUGR_RIGHT")]
		public string AUGR_RIGHT { get; set; }
		/// <summary>
		/// AUS_PTID_UP
		/// </summary>
		[Column("AUS_PTID_UP")]
		public int AUS_PTID_UP { get; set; }
		/// <summary>
		/// AUS_NAME
		/// </summary>
		[Column("AUS_NAME")]
		public string AUS_NAME { get; set; }
		/// <summary>
		/// AUGR_MEMO
		/// </summary>
		[Column("AUGR_MEMO")]
		public string AUGR_MEMO { get; set; }
		/// <summary>
		/// AUS_RIGHT
		/// </summary>
		[Column("AUS_RIGHT")]
		public string AUS_RIGHT { get; set; }
		/// <summary>
		/// AUS_STATUS
		/// </summary>
		[Column("AUS_STATUS")]
		public string AUS_STATUS { get; set; }
		/// <summary>
		/// AUS_REGDATE
		/// </summary>
		[Column("AUS_REGDATE")]
		public DateTime AUS_REGDATE { get; set; }
		/// <summary>
		/// AUS_MODDATE
		/// </summary>
		[Column("AUS_MODDATE")]
		public DateTime AUS_MODDATE { get; set; }
		/// <summary>
		/// MENU_COUNT
		/// </summary>
		[Column("MENU_COUNT")]
		public int MENU_COUNT { get; set; }
		/// <summary>
		/// MENU_MOD
		/// </summary>
		[Column("MENU_MOD")]
		public string MENU_MOD { get; set; }
		/// <summary>
		/// ENDYN
		/// </summary>
		[Column("ENDYN")]
		public string ENDYN { get; set; }
		/// <summary>
		/// PT_TYPE
		/// </summary>
		[Column("PT_TYPE")]
		public string PT_TYPE { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Column("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// AUS_NAME
		/// </summary>
		[Column("AUS_NAME")]
		public string AUS_NAME { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// AUGR_RIGHT
		/// </summary>
		[Column("AUGR_RIGHT")]
		public string AUGR_RIGHT { get; set; }
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Column("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// AUGR_IDX
		/// </summary>
		[Column("AUGR_IDX")]
		public int AUGR_IDX { get; set; }
		/// <summary>
		/// AUS_NAME
		/// </summary>
		[Column("AUS_NAME")]
		public string AUS_NAME { get; set; }
		/// <summary>
		/// AUS_PTID_UP
		/// </summary>
		[Column("AUS_PTID_UP")]
		public int AUS_PTID_UP { get; set; }
		/// <summary>
		/// AUS_RIGHT
		/// </summary>
		[Column("AUS_RIGHT")]
		public string AUS_RIGHT { get; set; }
		/// <summary>
		/// AUS_STATUS
		/// </summary>
		[Column("AUS_STATUS")]
		public string AUS_STATUS { get; set; }
		/// <summary>
		/// AUS_REGDATE
		/// </summary>
		[Column("AUS_REGDATE")]
		public DateTime AUS_REGDATE { get; set; }
		/// <summary>
		/// AUS_MODDATE
		/// </summary>
		[Column("AUS_MODDATE")]
		public DateTime AUS_MODDATE { get; set; }
	}
}