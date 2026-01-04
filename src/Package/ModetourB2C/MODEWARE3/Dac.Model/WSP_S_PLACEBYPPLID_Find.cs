namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_PLACEBYPPLID_조회
/// </summary>
public class WSP_S_PLACEBYPPLID_Find
{
	public const string SP_NAME = "WSP_S_PLACEBYPPLID_조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PPLID
		/// </summary>
		[Description("PPLID")]
		public string PPLID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// P_PLID
		/// </summary>
		[Column("P_PLID")]
		public int P_PLID { get; set; }
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// PLKNAME
		/// </summary>
		[Column("PLKNAME")]
		public string PLKNAME { get; set; }
		/// <summary>
		/// PLID1
		/// </summary>
		[Column("PLID1")]
		public int PLID1 { get; set; }
		/// <summary>
		/// PLKNAME1
		/// </summary>
		[Column("PLKNAME1")]
		public string PLKNAME1 { get; set; }
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public int Column1 { get; set; }
		/// <summary>
		/// Column2
		/// </summary>
		[Column("Column2")]
		public string Column2 { get; set; }
	}
}