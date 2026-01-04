namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_이벤트_예약조회_항공2
/// </summary>
public class WSP_S_Event_ReservationFind_Flight2
{
	public const string SP_NAME = "WSP_S_이벤트_예약조회_항공2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 사이트번호
		/// </summary>
		[Description("사이트번호")]
		public int SiteNumber { get; set; }
		/// <summary>
		/// 영문성
		/// </summary>
		[Description("영문성")]
		public string EnglishLastName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Description("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 판매부서번호
		/// </summary>
		[Description("판매부서번호")]
		public int SalesDepartmentNumber { get; set; }
		/// <summary>
		/// 시작일
		/// </summary>
		[Description("시작일")]
		public string StartDate { get; set; }
		/// <summary>
		/// 마침일
		/// </summary>
		[Description("마침일")]
		public string FinishDate { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 예약일
		/// </summary>
		[Column("예약일")]
		public DateTime BookingDate { get; set; }
	}
}