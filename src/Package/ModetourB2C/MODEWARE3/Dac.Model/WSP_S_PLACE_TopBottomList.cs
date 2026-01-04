namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_PLACE_상하위리스트
/// </summary>
public class WSP_S_PLACE_TopBottomList
{
	public const string SP_NAME = "WSP_S_PLACE_상하위리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// GUBUN
		/// </summary>
		[Description("GUBUN")]
		public string GUBUN { get; set; }
		/// <summary>
		/// PLID
		/// </summary>
		[Description("PLID")]
		public int PLID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 객체명
		/// </summary>
		[Column("객체명")]
		public string ObjectName { get; set; }
		/// <summary>
		/// 객체영문명
		/// </summary>
		[Column("객체영문명")]
		public string ObjectEnglishName { get; set; }
		/// <summary>
		/// 객체코드
		/// </summary>
		[Column("객체코드")]
		public string ObjectCode { get; set; }
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
	}
}