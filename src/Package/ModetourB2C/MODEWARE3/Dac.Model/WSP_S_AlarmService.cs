namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_알림서비스
/// </summary>
public class WSP_S_AlarmService
{
	public const string SP_NAME = "WSP_S_알림서비스";

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
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 알림예약번호
		/// </summary>
		[Column("알림예약번호")]
		public int AlarmBookingNumber { get; set; }
		/// <summary>
		/// 회원번호
		/// </summary>
		[Column("회원번호")]
		public int MemberNumber { get; set; }
		/// <summary>
		/// 예약이름
		/// </summary>
		[Column("예약이름")]
		public string BookingName { get; set; }
		/// <summary>
		/// 예약핸드폰번호
		/// </summary>
		[Column("예약핸드폰번호")]
		public string BookingPhoneNumber { get; set; }
		/// <summary>
		/// 희망지역1
		/// </summary>
		[Column("희망지역1")]
		public int DesiredRegion1 { get; set; }
		/// <summary>
		/// 희망지역1_지역명
		/// </summary>
		[Column("희망지역1_지역명")]
		public string DesiredRegion1_RegionName { get; set; }
		/// <summary>
		/// 희망지역2
		/// </summary>
		[Column("희망지역2")]
		public int DesiredRegion2 { get; set; }
		/// <summary>
		/// 희망지역2_지역명
		/// </summary>
		[Column("희망지역2_지역명")]
		public string DesiredRegion2_RegionName { get; set; }
		/// <summary>
		/// 희망지역3
		/// </summary>
		[Column("희망지역3")]
		public int DesiredRegion3 { get; set; }
		/// <summary>
		/// 희망지역3_지역명
		/// </summary>
		[Column("희망지역3_지역명")]
		public string DesiredRegion3_RegionName { get; set; }
		/// <summary>
		/// 출발일1
		/// </summary>
		[Column("출발일1")]
		public string DepartureDate1 { get; set; }
		/// <summary>
		/// 종료일1
		/// </summary>
		[Column("종료일1")]
		public string EndDate1 { get; set; }
		/// <summary>
		/// 날짜1
		/// </summary>
		[Column("날짜1")]
		public string Date1 { get; set; }
		/// <summary>
		/// 출발일2
		/// </summary>
		[Column("출발일2")]
		public string DepartureDate2 { get; set; }
		/// <summary>
		/// 종료일2
		/// </summary>
		[Column("종료일2")]
		public string EndDate2 { get; set; }
		/// <summary>
		/// 날짜2
		/// </summary>
		[Column("날짜2")]
		public string Date2 { get; set; }
		/// <summary>
		/// 출발일3
		/// </summary>
		[Column("출발일3")]
		public string DepartureDate3 { get; set; }
		/// <summary>
		/// 종료일3
		/// </summary>
		[Column("종료일3")]
		public string EndDate3 { get; set; }
		/// <summary>
		/// 날짜3
		/// </summary>
		[Column("날짜3")]
		public string Date3 { get; set; }
		/// <summary>
		/// 여행기간
		/// </summary>
		[Column("여행기간")]
		public string TravelPeriod { get; set; }
		/// <summary>
		/// 여행기간_코드명
		/// </summary>
		[Column("여행기간_코드명")]
		public string TravelPeriod_CodeName { get; set; }
		/// <summary>
		/// 최소여행비용
		/// </summary>
		[Column("최소여행비용")]
		public int MinimumTravelExpense { get; set; }
		/// <summary>
		/// 최대여행비용
		/// </summary>
		[Column("최대여행비용")]
		public int MaximumTravelExpense { get; set; }
		/// <summary>
		/// 특가알림
		/// </summary>
		[Column("특가알림")]
		public string SpecialPriceAlarm { get; set; }
		/// <summary>
		/// 여행컨셉
		/// </summary>
		[Column("여행컨셉")]
		public string TravelConcept { get; set; }
		/// <summary>
		/// 예약경로
		/// </summary>
		[Column("예약경로")]
		public string BookingRoute { get; set; }
		/// <summary>
		/// 예약등록일시
		/// </summary>
		[Column("예약등록일시")]
		public DateTime BookingRegisterDateAndTime { get; set; }
		/// <summary>
		/// 예약취소일시
		/// </summary>
		[Column("예약취소일시")]
		public DateTime BookingCancelDateAndTime { get; set; }
	}
}