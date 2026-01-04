namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_XML_SYNC_11ST_2021
/// </summary>
public class WSP_S_CMN_XML_SYNC_11ST_2021
{
	public const string SP_NAME = "WSP_S_CMN_XML_SYNC_11ST_2021";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public string PTID { get; set; }
		/// <summary>
		/// RSVNO
		/// </summary>
		[Description("RSVNO")]
		public string RSVNO { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 유입경로
		/// </summary>
		[Column("유입경로")]
		public string InflowRoute { get; set; }
		/// <summary>
		/// 예약상태
		/// </summary>
		[Column("예약상태")]
		public string BookingState { get; set; }
		/// <summary>
		/// 판매종류코드
		/// </summary>
		[Column("판매종류코드")]
		public string SalesTypeCode { get; set; }
		/// <summary>
		/// 상품타입
		/// </summary>
		[Column("상품타입")]
		public string ProductType { get; set; }
	}
}