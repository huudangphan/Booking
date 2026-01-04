namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_BTMS_개인출장내역
/// </summary>
public class WSP_S_CMN_BTMS_PersonalBusinessTripHistory
{
	public const string SP_NAME = "WSP_S_CMN_BTMS_개인출장내역";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 요청자
		/// </summary>
		[Description("요청자")]
		public int Requester { get; set; }
		/// <summary>
		/// 리스트
		/// </summary>
		[Description("리스트")]
		public string List { get; set; }
		/// <summary>
		/// 검색시작일
		/// </summary>
		[Description("검색시작일")]
		public DateTime SearchingStartDate { get; set; }
		/// <summary>
		/// 검색종료일
		/// </summary>
		[Description("검색종료일")]
		public DateTime SearchingEndDate { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 견적상태
		/// </summary>
		[Column("견적상태")]
		public string EstimateState { get; set; }
		/// <summary>
		/// 견적상태명
		/// </summary>
		[Column("견적상태명")]
		public string EstimateStateName { get; set; }
		/// <summary>
		/// 건수
		/// </summary>
		[Column("건수")]
		public int Numberofcases { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 요청분류
		/// </summary>
		[Column("요청분류")]
		public string RequestClassification { get; set; }
		/// <summary>
		/// 요청분류명
		/// </summary>
		[Column("요청분류명")]
		public string RequestClassificationName { get; set; }
		/// <summary>
		/// 견적상태
		/// </summary>
		[Column("견적상태")]
		public string EstimateState { get; set; }
		/// <summary>
		/// 견적상태명
		/// </summary>
		[Column("견적상태명")]
		public string EstimateStateName { get; set; }
		/// <summary>
		/// 건수
		/// </summary>
		[Column("건수")]
		public int Numberofcases { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 견적번호
		/// </summary>
		[Column("견적번호")]
		public int EstimateNumber { get; set; }
		/// <summary>
		/// 출장명
		/// </summary>
		[Column("출장명")]
		public string BusinessTripName { get; set; }
		/// <summary>
		/// 세부번호
		/// </summary>
		[Column("세부번호")]
		public int DetailNumber { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 예약자번호
		/// </summary>
		[Column("예약자번호")]
		public int BookerNumber { get; set; }
		/// <summary>
		/// 요청분류
		/// </summary>
		[Column("요청분류")]
		public string RequestClassification { get; set; }
		/// <summary>
		/// 요청분류명
		/// </summary>
		[Column("요청분류명")]
		public string RequestClassificationName { get; set; }
		/// <summary>
		/// 요청구분
		/// </summary>
		[Column("요청구분")]
		public string RequestClassification2 { get; set; }
		/// <summary>
		/// 요청구분명
		/// </summary>
		[Column("요청구분명")]
		public string RequestClassificationName2 { get; set; }
		/// <summary>
		/// 출발도시
		/// </summary>
		[Column("출발도시")]
		public string DepartureCity { get; set; }
		/// <summary>
		/// 출장국가
		/// </summary>
		[Column("출장국가")]
		public string BusinessTripCountry { get; set; }
		/// <summary>
		/// 출장도시
		/// </summary>
		[Column("출장도시")]
		public string BusinessTripCity { get; set; }
		/// <summary>
		/// 요청일
		/// </summary>
		[Column("요청일")]
		public DateTime RequestDate { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public DateTime ArrivalDate { get; set; }
		/// <summary>
		/// 출장자
		/// </summary>
		[Column("출장자")]
		public string BusinessTripPerson { get; set; }
		/// <summary>
		/// 총액
		/// </summary>
		[Column("총액")]
		public long TotalAmount { get; set; }
		/// <summary>
		/// 수납액
		/// </summary>
		[Column("수납액")]
		public long ReceiptAmount { get; set; }
		/// <summary>
		/// 첨부파일
		/// </summary>
		[Column("첨부파일")]
		public string AttachFile { get; set; }
		/// <summary>
		/// 견적상태
		/// </summary>
		[Column("견적상태")]
		public string EstimateState { get; set; }
		/// <summary>
		/// 견적상태명
		/// </summary>
		[Column("견적상태명")]
		public string EstimateStateName { get; set; }
		/// <summary>
		/// 판매가
		/// </summary>
		[Column("판매가")]
		public long SellingPrice { get; set; }
		/// <summary>
		/// 추가_유류
		/// </summary>
		[Column("추가_유류")]
		public long Add_FeeCharged { get; set; }
		/// <summary>
		/// 추가_TAX
		/// </summary>
		[Column("추가_TAX")]
		public long Add_TAX { get; set; }
		/// <summary>
		/// 요청사항
		/// </summary>
		[Column("요청사항")]
		public string Request { get; set; }
		/// <summary>
		/// 체류기간
		/// </summary>
		[Column("체류기간")]
		public string SojournPeriod { get; set; }
		/// <summary>
		/// 비즈니스TL
		/// </summary>
		[Column("비즈니스TL")]
		public DateTime BusinessTL { get; set; }
		/// <summary>
		/// 비고사항
		/// </summary>
		[Column("비고사항")]
		public string NoteItem { get; set; }
		/// <summary>
		/// 수정불가여부
		/// </summary>
		[Column("수정불가여부")]
		public string EditionImpossibleOrNot { get; set; }
		/// <summary>
		/// 확정객실수
		/// </summary>
		[Column("확정객실수")]
		public int ConfirmGuestRoomNumber { get; set; }
		/// <summary>
		/// 확정박수
		/// </summary>
		[Column("확정박수")]
		public int ConfirmNightsNumber { get; set; }
	}
}