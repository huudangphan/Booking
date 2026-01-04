namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_알림서비스
/// </summary>
public class WSP_T_AlarmService
{
	public const string SP_NAME = "WSP_T_알림서비스";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 알림예약번호
		/// </summary>
		[Description("알림예약번호")]
		public int AlarmBookingNumber { get; set; }
		/// <summary>
		/// 회원번호
		/// </summary>
		[Description("회원번호")]
		public int MemberNumber { get; set; }
		/// <summary>
		/// 예약이름
		/// </summary>
		[Description("예약이름")]
		public string BookingName { get; set; }
		/// <summary>
		/// 예약핸드폰번호
		/// </summary>
		[Description("예약핸드폰번호")]
		public string BookingPhoneNumber { get; set; }
		/// <summary>
		/// 희망지역1
		/// </summary>
		[Description("희망지역1")]
		public string DesiredRegion1 { get; set; }
		/// <summary>
		/// 희망지역2
		/// </summary>
		[Description("희망지역2")]
		public string DesiredRegion2 { get; set; }
		/// <summary>
		/// 희망지역3
		/// </summary>
		[Description("희망지역3")]
		public string DesiredRegion3 { get; set; }
		/// <summary>
		/// 출발일1
		/// </summary>
		[Description("출발일1")]
		public DateTime DepartureDate1 { get; set; }
		/// <summary>
		/// 종료일1
		/// </summary>
		[Description("종료일1")]
		public DateTime EndDate1 { get; set; }
		/// <summary>
		/// 출발일2
		/// </summary>
		[Description("출발일2")]
		public DateTime DepartureDate2 { get; set; }
		/// <summary>
		/// 종료일2
		/// </summary>
		[Description("종료일2")]
		public DateTime EndDate2 { get; set; }
		/// <summary>
		/// 출발일3
		/// </summary>
		[Description("출발일3")]
		public DateTime DepartureDate3 { get; set; }
		/// <summary>
		/// 종료일3
		/// </summary>
		[Description("종료일3")]
		public DateTime EndDate3 { get; set; }
		/// <summary>
		/// 여행기간
		/// </summary>
		[Description("여행기간")]
		public string TravelPeriod { get; set; }
		/// <summary>
		/// 최소여행비용
		/// </summary>
		[Description("최소여행비용")]
		public int MinimumTravelExpense { get; set; }
		/// <summary>
		/// 최대여행비용
		/// </summary>
		[Description("최대여행비용")]
		public int MaximumTravelExpense { get; set; }
		/// <summary>
		/// 특가알림
		/// </summary>
		[Description("특가알림")]
		public string SpecialPriceAlarm { get; set; }
		/// <summary>
		/// 여행컨셉
		/// </summary>
		[Description("여행컨셉")]
		public string TravelConcept { get; set; }
		/// <summary>
		/// 예약경로
		/// </summary>
		[Description("예약경로")]
		public string BookingRoute { get; set; }
	}

}