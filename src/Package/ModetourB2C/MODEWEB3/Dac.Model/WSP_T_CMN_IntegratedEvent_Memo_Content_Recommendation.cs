namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_통합이벤트_메모_내용_추천
/// </summary>
public class WSP_T_CMN_IntegratedEvent_Memo_Content_Recommendation
{
	public const string SP_NAME = "WSP_T_CMN_통합이벤트_메모_내용_추천";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Description("이벤트번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 추천가능수
		/// </summary>
		[Description("추천가능수")]
		public int RecommendPossibleNumber { get; set; }
		/// <summary>
		/// 결과코드
		/// </summary>
		[Description("결과코드")]
		public int ResultCode { get; set; }
		/// <summary>
		/// 결과메세지
		/// </summary>
		[Description("결과메세지")]
		public string ResultMessage { get; set; }
		/// <summary>
		/// 추천수집계
		/// </summary>
		[Description("추천수집계")]
		public int RecommendCollectionSystem { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 결과코드
		/// </summary>
		[Column("결과코드")]
		public int ResultCode { get; set; }
		/// <summary>
		/// 결과메세지
		/// </summary>
		[Column("결과메세지")]
		public string ResultMessage { get; set; }
		/// <summary>
		/// 추천수집계
		/// </summary>
		[Column("추천수집계")]
		public int RecommendCollectionSystem { get; set; }
	}
}