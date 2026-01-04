namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_패스상세정보
/// </summary>
public class WSP_S_PASSDetailInfo
{
	public const string SP_NAME = "WSP_S_패스상세정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 품목코드
		/// </summary>
		[Description("품목코드")]
		public string ProductListCode { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 품목코드
		/// </summary>
		[Column("품목코드")]
		public string ProductListCode { get; set; }
		/// <summary>
		/// 열차아이템번호
		/// </summary>
		[Column("열차아이템번호")]
		public int TrainItemNumber { get; set; }
		/// <summary>
		/// 열차명
		/// </summary>
		[Column("열차명")]
		public string TrainName { get; set; }
		/// <summary>
		/// 패스번호
		/// </summary>
		[Column("패스번호")]
		public string PASSNumber { get; set; }
		/// <summary>
		/// 패스명
		/// </summary>
		[Column("패스명")]
		public string PASSName { get; set; }
		/// <summary>
		/// 소개
		/// </summary>
		[Column("소개")]
		public string Introduction { get; set; }
		/// <summary>
		/// 비고사항
		/// </summary>
		[Column("비고사항")]
		public string NoteItem { get; set; }
		/// <summary>
		/// 좌석형태
		/// </summary>
		[Column("좌석형태")]
		public string SeatFormat { get; set; }
		/// <summary>
		/// 환불조건
		/// </summary>
		[Column("환불조건")]
		public string RefundCondition { get; set; }
		/// <summary>
		/// 이용조건
		/// </summary>
		[Column("이용조건")]
		public string UseCondition { get; set; }
		/// <summary>
		/// 주의사항
		/// </summary>
		[Column("주의사항")]
		public string Notices { get; set; }
		/// <summary>
		/// 이용가능국가
		/// </summary>
		[Column("이용가능국가")]
		public string UsePossibleCountry { get; set; }
		/// <summary>
		/// 연령기준
		/// </summary>
		[Column("연령기준")]
		public string AgeStandard { get; set; }
		/// <summary>
		/// 이용방법
		/// </summary>
		[Column("이용방법")]
		public string UseWay { get; set; }
		/// <summary>
		/// 보너스사항
		/// </summary>
		[Column("보너스사항")]
		public string Bonus { get; set; }
		/// <summary>
		/// 배송안내
		/// </summary>
		[Column("배송안내")]
		public string ShippingInfo { get; set; }
		/// <summary>
		/// 유효기간
		/// </summary>
		[Column("유효기간")]
		public string ValidPeriod { get; set; }
		/// <summary>
		/// 티켓형태
		/// </summary>
		[Column("티켓형태")]
		public string TicketFormat { get; set; }
		/// <summary>
		/// 운행국가
		/// </summary>
		[Column("운행국가")]
		public string OperationCountry { get; set; }
		/// <summary>
		/// 사전구매
		/// </summary>
		[Column("사전구매")]
		public string PreBuy { get; set; }
		/// <summary>
		/// 사용
		/// </summary>
		[Column("사용")]
		public string Use { get; set; }
		/// <summary>
		/// 이티켓
		/// </summary>
		[Column("이티켓")]
		public string ETicket { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 품목코드
		/// </summary>
		[Column("품목코드")]
		public string ProductListCode { get; set; }
		/// <summary>
		/// 열차아이템번호
		/// </summary>
		[Column("열차아이템번호")]
		public int TrainItemNumber { get; set; }
		/// <summary>
		/// 열차명
		/// </summary>
		[Column("열차명")]
		public string TrainName { get; set; }
		/// <summary>
		/// 패스번호
		/// </summary>
		[Column("패스번호")]
		public string PASSNumber { get; set; }
		/// <summary>
		/// 패스명
		/// </summary>
		[Column("패스명")]
		public string PASSName { get; set; }
		/// <summary>
		/// 소개
		/// </summary>
		[Column("소개")]
		public string Introduction { get; set; }
		/// <summary>
		/// 비고사항
		/// </summary>
		[Column("비고사항")]
		public string NoteItem { get; set; }
		/// <summary>
		/// 좌석형태
		/// </summary>
		[Column("좌석형태")]
		public string SeatFormat { get; set; }
		/// <summary>
		/// 환불조건
		/// </summary>
		[Column("환불조건")]
		public string RefundCondition { get; set; }
		/// <summary>
		/// 이용조건
		/// </summary>
		[Column("이용조건")]
		public string UseCondition { get; set; }
		/// <summary>
		/// 주의사항
		/// </summary>
		[Column("주의사항")]
		public string Notices { get; set; }
		/// <summary>
		/// 이용가능국가
		/// </summary>
		[Column("이용가능국가")]
		public string UsePossibleCountry { get; set; }
		/// <summary>
		/// 연령기준
		/// </summary>
		[Column("연령기준")]
		public string AgeStandard { get; set; }
		/// <summary>
		/// 이용방법
		/// </summary>
		[Column("이용방법")]
		public string UseWay { get; set; }
		/// <summary>
		/// 보너스사항
		/// </summary>
		[Column("보너스사항")]
		public string Bonus { get; set; }
		/// <summary>
		/// 배송안내
		/// </summary>
		[Column("배송안내")]
		public string ShippingInfo { get; set; }
		/// <summary>
		/// 유효기간
		/// </summary>
		[Column("유효기간")]
		public string ValidPeriod { get; set; }
		/// <summary>
		/// 티켓형태
		/// </summary>
		[Column("티켓형태")]
		public string TicketFormat { get; set; }
		/// <summary>
		/// 운행국가
		/// </summary>
		[Column("운행국가")]
		public string OperationCountry { get; set; }
		/// <summary>
		/// 사전구매
		/// </summary>
		[Column("사전구매")]
		public string PreBuy { get; set; }
		/// <summary>
		/// 사용
		/// </summary>
		[Column("사용")]
		public string Use { get; set; }
		/// <summary>
		/// 이티켓
		/// </summary>
		[Column("이티켓")]
		public string ETicket { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 품목코드
		/// </summary>
		[Column("품목코드")]
		public string ProductListCode { get; set; }
		/// <summary>
		/// 열차아이템번호
		/// </summary>
		[Column("열차아이템번호")]
		public int TrainItemNumber { get; set; }
		/// <summary>
		/// 열차명
		/// </summary>
		[Column("열차명")]
		public string TrainName { get; set; }
		/// <summary>
		/// 패스번호
		/// </summary>
		[Column("패스번호")]
		public string PASSNumber { get; set; }
		/// <summary>
		/// 패스명
		/// </summary>
		[Column("패스명")]
		public string PASSName { get; set; }
		/// <summary>
		/// 소개
		/// </summary>
		[Column("소개")]
		public string Introduction { get; set; }
		/// <summary>
		/// 비고사항
		/// </summary>
		[Column("비고사항")]
		public string NoteItem { get; set; }
		/// <summary>
		/// 좌석형태
		/// </summary>
		[Column("좌석형태")]
		public string SeatFormat { get; set; }
		/// <summary>
		/// 환불조건
		/// </summary>
		[Column("환불조건")]
		public string RefundCondition { get; set; }
		/// <summary>
		/// 이용조건
		/// </summary>
		[Column("이용조건")]
		public string UseCondition { get; set; }
		/// <summary>
		/// 주의사항
		/// </summary>
		[Column("주의사항")]
		public string Notices { get; set; }
		/// <summary>
		/// 이용가능국가
		/// </summary>
		[Column("이용가능국가")]
		public string UsePossibleCountry { get; set; }
		/// <summary>
		/// 연령기준
		/// </summary>
		[Column("연령기준")]
		public string AgeStandard { get; set; }
		/// <summary>
		/// 이용방법
		/// </summary>
		[Column("이용방법")]
		public string UseWay { get; set; }
		/// <summary>
		/// 보너스사항
		/// </summary>
		[Column("보너스사항")]
		public string Bonus { get; set; }
		/// <summary>
		/// 배송안내
		/// </summary>
		[Column("배송안내")]
		public string ShippingInfo { get; set; }
		/// <summary>
		/// 유효기간
		/// </summary>
		[Column("유효기간")]
		public string ValidPeriod { get; set; }
		/// <summary>
		/// 티켓형태
		/// </summary>
		[Column("티켓형태")]
		public string TicketFormat { get; set; }
		/// <summary>
		/// 운행국가
		/// </summary>
		[Column("운행국가")]
		public string OperationCountry { get; set; }
		/// <summary>
		/// 사전구매
		/// </summary>
		[Column("사전구매")]
		public string PreBuy { get; set; }
		/// <summary>
		/// 사용
		/// </summary>
		[Column("사용")]
		public string Use { get; set; }
		/// <summary>
		/// 이티켓
		/// </summary>
		[Column("이티켓")]
		public string ETicket { get; set; }
		/// <summary>
		/// 국가수
		/// </summary>
		[Column("국가수")]
		public int CountryNumber { get; set; }
		/// <summary>
		/// 셀렉트구분
		/// </summary>
		[Column("셀렉트구분")]
		public string SelectClassification { get; set; }
	}
}