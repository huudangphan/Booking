namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_이벤트배너
/// </summary>
public class WSP_S_EventBanner
{
	public const string SP_NAME = "WSP_S_이벤트배너";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 배너태그
		/// </summary>
		[Column("배너태그")]
		public string BannerTag { get; set; }
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Column("이벤트번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// 이벤트종류코드
		/// </summary>
		[Column("이벤트종류코드")]
		public string EventTypeCode { get; set; }
		/// <summary>
		/// 모바일태그
		/// </summary>
		[Column("모바일태그")]
		public string MobileTag { get; set; }
	}
}