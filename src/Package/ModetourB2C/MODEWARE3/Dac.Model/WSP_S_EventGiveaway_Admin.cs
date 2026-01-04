namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_이벤트경품_관리자
/// </summary>
public class WSP_S_EventGiveaway_Admin
{
	public const string SP_NAME = "WSP_S_이벤트경품_관리자";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 아이디1
		/// </summary>
		[Description("아이디1")]
		public string ID1 { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 경품품목번호
		/// </summary>
		[Description("경품품목번호")]
		public int GiveawayItemNumber { get; set; }
		/// <summary>
		/// 배송상태
		/// </summary>
		[Description("배송상태")]
		public string ShippingState { get; set; }
		/// <summary>
		/// 입금상태
		/// </summary>
		[Description("입금상태")]
		public string DepositState { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Description("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 날짜종류
		/// </summary>
		[Description("날짜종류")]
		public string DateType { get; set; }
		/// <summary>
		/// 시작날짜
		/// </summary>
		[Description("시작날짜")]
		public string StartDate { get; set; }
		/// <summary>
		/// 종료날짜
		/// </summary>
		[Description("종료날짜")]
		public string EndDate { get; set; }
		/// <summary>
		/// 현재페이지
		/// </summary>
		[Description("현재페이지")]
		public int CurrentPage { get; set; }
		/// <summary>
		/// 페이지당글개수
		/// </summary>
		[Description("페이지당글개수")]
		public int EachPageCharactersNumber { get; set; }
		/// <summary>
		/// GU
		/// </summary>
		[Description("GU")]
		public string GU { get; set; }
		/// <summary>
		/// 전체게시글수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체게시글수")]
		public int EntirePostCharactersNumber { get; set; }
		/// <summary>
		/// 전체페이지수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체페이지수")]
		public int EntirePageNumber { get; set; }
	}

}