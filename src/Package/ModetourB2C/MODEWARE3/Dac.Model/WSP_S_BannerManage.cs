namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_배너관리
/// </summary>
public class WSP_S_BannerManage
{
	public const string SP_NAME = "WSP_S_배너관리";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 범주
		/// </summary>
		[Description("범주")]
		public string Category { get; set; }
		/// <summary>
		/// 위치
		/// </summary>
		[Description("위치")]
		public string Position { get; set; }
		/// <summary>
		/// 페이지번호
		/// </summary>
		[Description("페이지번호")]
		public int PageNumber { get; set; }
		/// <summary>
		/// 페이지아이템수
		/// </summary>
		[Description("페이지아이템수")]
		public int PageItemNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 총페이지수
		/// </summary>
		[Column("총페이지수")]
		public double TotalPageNumber { get; set; }
		/// <summary>
		/// 총아이템수
		/// </summary>
		[Column("총아이템수")]
		public int TotalItemNumber { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 배너관리번호
		/// </summary>
		[Column("배너관리번호")]
		public int BannerManageNumber { get; set; }
		/// <summary>
		/// 배너관리이력번호
		/// </summary>
		[Column("배너관리이력번호")]
		public int BannerManageHistoryNumber { get; set; }
		/// <summary>
		/// 범주
		/// </summary>
		[Column("범주")]
		public string Category { get; set; }
		/// <summary>
		/// 조건
		/// </summary>
		[Column("조건")]
		public string Condition { get; set; }
		/// <summary>
		/// 조건키
		/// </summary>
		[Column("조건키")]
		public string ConditionKey { get; set; }
		/// <summary>
		/// 이벤트명
		/// </summary>
		[Column("이벤트명")]
		public string EventName { get; set; }
		/// <summary>
		/// 노출기간_시작
		/// </summary>
		[Column("노출기간_시작")]
		public DateTime DisplayPeriod_Start { get; set; }
		/// <summary>
		/// 노출기간_종료
		/// </summary>
		[Column("노출기간_종료")]
		public DateTime DisplayPeriod_End { get; set; }
		/// <summary>
		/// PC태그
		/// </summary>
		[Column("PC태그")]
		public string PC_Tag { get; set; }
		/// <summary>
		/// MO태그
		/// </summary>
		[Column("MO태그")]
		public string MO_Tag { get; set; }
		/// <summary>
		/// PC링크
		/// </summary>
		[Column("PC링크")]
		public string PC_Link { get; set; }
		/// <summary>
		/// MO링크
		/// </summary>
		[Column("MO링크")]
		public string MO_Link { get; set; }
		/// <summary>
		/// 사용
		/// </summary>
		[Column("사용")]
		public string Use { get; set; }
		/// <summary>
		/// 등록자PTID
		/// </summary>
		[Column("등록자PTID")]
		public int Registerer_PTID { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 인센티브노출
		/// </summary>
		[Column("인센티브노출")]
		public string IncentiveDisplay { get; set; }
		/// <summary>
		/// 노출요일
		/// </summary>
		[Column("노출요일")]
		public string DisplayDay { get; set; }
		/// <summary>
		/// 위치
		/// </summary>
		[Column("위치")]
		public string Position { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
		/// <summary>
		/// 출발일1
		/// </summary>
		[Column("출발일1")]
		public DateTime DepartureDate1 { get; set; }
		/// <summary>
		/// 출발일2
		/// </summary>
		[Column("출발일2")]
		public DateTime DepartureDate2 { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Column("등록자")]
		public string Registerer { get; set; }
		/// <summary>
		/// 로우넘버
		/// </summary>
		[Column("로우넘버")]
		public long RowNumber { get; set; }
	}
}