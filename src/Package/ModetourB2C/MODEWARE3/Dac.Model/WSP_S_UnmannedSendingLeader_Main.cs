namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_메인
/// </summary>
public class WSP_S_UnmannedSendingLeader_Main
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_메인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 행사번호
		/// </summary>
		[Column("행사번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public string ArrivalDate { get; set; }
		/// <summary>
		/// 요일
		/// </summary>
		[Column("요일")]
		public string Day { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// DDAY
		/// </summary>
		[Column("DDAY")]
		public int DDAY { get; set; }
		/// <summary>
		/// 성인
		/// </summary>
		[Column("성인")]
		public int Adult { get; set; }
		/// <summary>
		/// 아동
		/// </summary>
		[Column("아동")]
		public int Children { get; set; }
		/// <summary>
		/// 유아
		/// </summary>
		[Column("유아")]
		public int Toddler { get; set; }
		/// <summary>
		/// 총여행객
		/// </summary>
		[Column("총여행객")]
		public int TotalTravelCustomer { get; set; }
		/// <summary>
		/// 출발시간
		/// </summary>
		[Column("출발시간")]
		public string DepartureTime { get; set; }
		/// <summary>
		/// 단체수
		/// </summary>
		[Column("단체수")]
		public int NumberOfGroups { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 여행기간
		/// </summary>
		[Column("여행기간")]
		public string TravelPeriod { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 가이드여부
		/// </summary>
		[Column("가이드여부")]
		public string GuideOrNot { get; set; }
		/// <summary>
		/// 가이드안내팝업노출여부
		/// </summary>
		[Column("가이드안내팝업노출여부")]
		public string GuideInfoPopupDisplayOrNot { get; set; }
	}
}