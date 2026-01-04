namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_장소_외부연동
/// </summary>
public class WSP_S_CMN_Place_ExternalIntegration
{
	public const string SP_NAME = "WSP_S_CMN_장소_외부연동";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 연동방식
		/// </summary>
		[Description("연동방식")]
		public string ConnectedMethod { get; set; }
		/// <summary>
		/// 연동키
		/// </summary>
		[Description("연동키")]
		public string ConnectedKey { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 장소번호
		/// </summary>
		[Column("장소번호")]
		public int PlaceNumber { get; set; }
		/// <summary>
		/// 연동방식
		/// </summary>
		[Column("연동방식")]
		public string ConnectedMethod { get; set; }
		/// <summary>
		/// 연동키
		/// </summary>
		[Column("연동키")]
		public string ConnectedKey { get; set; }
		/// <summary>
		/// 연동DATA_JSON
		/// </summary>
		[Column("연동DATA_JSON")]
		public string Connected_DATA_JSON { get; set; }
		/// <summary>
		/// MAP_URL
		/// </summary>
		[Column("MAP_URL")]
		public string MAP_URL { get; set; }
	}
}