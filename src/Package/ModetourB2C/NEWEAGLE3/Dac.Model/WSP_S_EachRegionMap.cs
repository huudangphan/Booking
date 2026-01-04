namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_지역별지도
/// </summary>
public class WSP_S_EachRegionMap
{
	public const string SP_NAME = "WSP_S_지역별지도";

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
		/// PID1
		/// </summary>
		[Column("PID1")]
		public int PID1 { get; set; }
		/// <summary>
		/// PLKNAME1
		/// </summary>
		[Column("PLKNAME1")]
		public string PLKNAME1 { get; set; }
		/// <summary>
		/// PLCODE
		/// </summary>
		[Column("PLCODE")]
		public string PLCODE { get; set; }
		/// <summary>
		/// 좌표
		/// </summary>
		[Column("좌표")]
		public string Coordinate { get; set; }
	}
}