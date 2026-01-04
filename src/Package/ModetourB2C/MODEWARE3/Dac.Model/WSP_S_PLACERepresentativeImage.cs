namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_PLACE대표이미지
/// </summary>
public class WSP_S_PLACERepresentativeImage
{
	public const string SP_NAME = "WSP_S_PLACE대표이미지";

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
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
	}
}