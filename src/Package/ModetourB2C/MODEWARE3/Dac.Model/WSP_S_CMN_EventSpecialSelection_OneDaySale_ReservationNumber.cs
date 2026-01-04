namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_이벤트특선_원데이세일_예약수
/// </summary>
public class WSP_S_CMN_EventSpecialSelection_OneDaySale_ReservationNumber
{
	public const string SP_NAME = "WSP_S_CMN_이벤트특선_원데이세일_예약수";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 기준일
		/// </summary>
		[Description("기준일")]
		public string StandardDate { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 전체좌석수
		/// </summary>
		[Column("전체좌석수")]
		public int EntireSeatNumber { get; set; }
		/// <summary>
		/// 전체예약수
		/// </summary>
		[Column("전체예약수")]
		public int EntireNumberOfBookings { get; set; }
		/// <summary>
		/// 예약수1
		/// </summary>
		[Column("예약수1")]
		public int NumberOfBookings1 { get; set; }
		/// <summary>
		/// 예약수2
		/// </summary>
		[Column("예약수2")]
		public int NumberOfBookings2 { get; set; }
		/// <summary>
		/// 예약수3
		/// </summary>
		[Column("예약수3")]
		public int NumberOfBookings3 { get; set; }
	}
}