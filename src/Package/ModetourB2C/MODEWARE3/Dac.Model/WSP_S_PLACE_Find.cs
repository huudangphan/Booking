namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_PLACE_조회
/// </summary>
public class WSP_S_PLACE_Find
{
	public const string SP_NAME = "WSP_S_PLACE_조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Description("PLID")]
		public int PLID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// PLCODE
		/// </summary>
		[Column("PLCODE")]
		public string PLCODE { get; set; }
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
		/// PLCODE1
		/// </summary>
		[Column("PLCODE1")]
		public string PLCODE1 { get; set; }
		/// <summary>
		/// PLKNAME1
		/// </summary>
		[Column("PLKNAME1")]
		public string PLKNAME1 { get; set; }
		/// <summary>
		/// PLID2
		/// </summary>
		[Column("PLID2")]
		public int PLID2 { get; set; }
		/// <summary>
		/// PLCODE2
		/// </summary>
		[Column("PLCODE2")]
		public string PLCODE2 { get; set; }
		/// <summary>
		/// PLKNAME2
		/// </summary>
		[Column("PLKNAME2")]
		public string PLKNAME2 { get; set; }
	}
}