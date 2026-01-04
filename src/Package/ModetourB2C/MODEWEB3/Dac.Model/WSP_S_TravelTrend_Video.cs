namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_여행트렌드_동영상
/// </summary>
public class WSP_S_TravelTrend_Video
{
	public const string SP_NAME = "WSP_S_여행트렌드_동영상";

	public class Result : IDbResult
	{
		/// <summary>
		/// Idx
		/// </summary>
		[Column("Idx")]
		public int Idx { get; set; }
		/// <summary>
		/// Subject
		/// </summary>
		[Column("Subject")]
		public string Subject { get; set; }
		/// <summary>
		/// VideoUrl
		/// </summary>
		[Column("VideoUrl")]
		public string VideoUrl { get; set; }
		/// <summary>
		/// Contents
		/// </summary>
		[Column("Contents")]
		public string Contents { get; set; }
		/// <summary>
		/// PlanTitle
		/// </summary>
		[Column("PlanTitle")]
		public string PlanTitle { get; set; }
		/// <summary>
		/// PlanUrl
		/// </summary>
		[Column("PlanUrl")]
		public string PlanUrl { get; set; }
		/// <summary>
		/// AreaName
		/// </summary>
		[Column("AreaName")]
		public string AreaName { get; set; }
	}
}