namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_PLACE_지도좌표
/// </summary>
public class WSP_S_CMN_PLACE_SeatMap
{
	public const string SP_NAME = "WSP_S_CMN_PLACE_지도좌표";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 도시번호
		/// </summary>
		[Description("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// 객체번호
		/// </summary>
		[Description("객체번호")]
		public string ObjectNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 도시명
		/// </summary>
		[Column("도시명")]
		public string CityName { get; set; }
		/// <summary>
		/// 좌표
		/// </summary>
		[Column("좌표")]
		public string Coordinate { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 객체번호
		/// </summary>
		[Column("객체번호")]
		public int ObjectNumber { get; set; }
		/// <summary>
		/// 객체타입
		/// </summary>
		[Column("객체타입")]
		public string ObjectType { get; set; }
		/// <summary>
		/// 객체명
		/// </summary>
		[Column("객체명")]
		public string ObjectName { get; set; }
		/// <summary>
		/// 좌표
		/// </summary>
		[Column("좌표")]
		public string Coordinate { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
	}
}