namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_배너관리
/// </summary>
public class WSP_T_BannerManage
{
	public const string SP_NAME = "WSP_T_배너관리";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 배너관리번호
		/// </summary>
		[Description("배너관리번호")]
		public int BannerManageNumber { get; set; }
		/// <summary>
		/// 배너관리이력번호
		/// </summary>
		[Description("배너관리이력번호")]
		public int BannerManageHistoryNumber { get; set; }
		/// <summary>
		/// 범주
		/// </summary>
		[Description("범주")]
		public string Category { get; set; }
		/// <summary>
		/// 조건
		/// </summary>
		[Description("조건")]
		public string Condition { get; set; }
		/// <summary>
		/// 조건키
		/// </summary>
		[Description("조건키")]
		public string ConditionKey { get; set; }
		/// <summary>
		/// 이벤트명
		/// </summary>
		[Description("이벤트명")]
		public string EventName { get; set; }
		/// <summary>
		/// 노출기간_시작
		/// </summary>
		[Description("노출기간_시작")]
		public DateTime DisplayPeriod_Start { get; set; }
		/// <summary>
		/// 노출기간_종료
		/// </summary>
		[Description("노출기간_종료")]
		public DateTime DisplayPeriod_End { get; set; }
		/// <summary>
		/// PC태그
		/// </summary>
		[Description("PC태그")]
		public string PC_Tag { get; set; }
		/// <summary>
		/// MO태그
		/// </summary>
		[Description("MO태그")]
		public string MO_Tag { get; set; }
		/// <summary>
		/// PC링크
		/// </summary>
		[Description("PC링크")]
		public string PC_Link { get; set; }
		/// <summary>
		/// MO링크
		/// </summary>
		[Description("MO링크")]
		public string MO_Link { get; set; }
		/// <summary>
		/// 사용
		/// </summary>
		[Description("사용")]
		public string Use { get; set; }
		/// <summary>
		/// 등록자PTID
		/// </summary>
		[Description("등록자PTID")]
		public int Registerer_PTID { get; set; }
		/// <summary>
		/// 인센티브노출
		/// </summary>
		[Description("인센티브노출")]
		public string IncentiveDisplay { get; set; }
		/// <summary>
		/// 노출요일
		/// </summary>
		[Description("노출요일")]
		public string DisplayDay { get; set; }
		/// <summary>
		/// 위치
		/// </summary>
		[Description("위치")]
		public string Position { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Description("순서")]
		public int Order { get; set; }
		/// <summary>
		/// 출발일1
		/// </summary>
		[Description("출발일1")]
		public DateTime DepartureDate1 { get; set; }
		/// <summary>
		/// 출발일2
		/// </summary>
		[Description("출발일2")]
		public DateTime DepartureDate2 { get; set; }
	}

}