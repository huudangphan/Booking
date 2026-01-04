namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_PERSOVAL_SELECT
/// </summary>
public class ACP_PERSOVAL_SELECT
{
	public const string SP_NAME = "ACP_PERSOVAL_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// SI
		/// </summary>
		[Description("SI")]
		public int SI { get; set; }
	}

	public class Result : IDbResult
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
	}
}