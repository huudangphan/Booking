namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_BTMS_출장등록리스트
/// </summary>
public class WSP_S_CMN_BTMS_BusinessTripRegistrationList
{
	public const string SP_NAME = "WSP_S_CMN_BTMS_출장등록리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 요청자
		/// </summary>
		[Description("요청자")]
		public int Requester { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 견적번호
		/// </summary>
		[Description("견적번호")]
		public int EstimateNumber { get; set; }
	}

	public class Result1 : IDbResult
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
	}

	public class Result2 : IDbResult
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
		/// 출발국가
		/// </summary>
		[Column("출발국가")]
		public string DepartureCountry { get; set; }
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
	}
}