namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_인센티브_관리자_단체정보
/// </summary>
public class WSP_S_Incentive_Admin_GroupInfo
{
	public const string SP_NAME = "WSP_S_인센티브_관리자_단체정보";

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
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public DateTime ArrivalDate { get; set; }
		/// <summary>
		/// 등록좌석수
		/// </summary>
		[Column("등록좌석수")]
		public int RegisterSeatNumber { get; set; }
		/// <summary>
		/// 예약좌석수
		/// </summary>
		[Column("예약좌석수")]
		public int BookingSeatNumber { get; set; }
		/// <summary>
		/// 대기좌석수
		/// </summary>
		[Column("대기좌석수")]
		public int WaitingSeatNumber { get; set; }
		/// <summary>
		/// 마감유무
		/// </summary>
		[Column("마감유무")]
		public string EndOrNot { get; set; }
	}
}