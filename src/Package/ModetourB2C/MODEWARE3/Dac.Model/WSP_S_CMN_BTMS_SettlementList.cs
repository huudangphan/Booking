namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_BTMS_정산리스트
/// </summary>
public class WSP_S_CMN_BTMS_SettlementList
{
	public const string SP_NAME = "WSP_S_CMN_BTMS_정산리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 검색날짜조건
		/// </summary>
		[Description("검색날짜조건")]
		public string SearchingDateCondition { get; set; }
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
		/// <summary>
		/// 상품종류
		/// </summary>
		[Description("상품종류")]
		public string ProductType { get; set; }
		/// <summary>
		/// 검색필드
		/// </summary>
		[Description("검색필드")]
		public string SearchingField { get; set; }
		/// <summary>
		/// 검색어
		/// </summary>
		[Description("검색어")]
		public string SearchingKeyword { get; set; }
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

	public class Result : IDbResult
	{
		/// <summary>
		/// 세부번호
		/// </summary>
		[Column("세부번호")]
		public int DetailNumber { get; set; }
		/// <summary>
		/// 견적번호
		/// </summary>
		[Column("견적번호")]
		public int EstimateNumber { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 요청구분
		/// </summary>
		[Column("요청구분")]
		public string RequestClassification { get; set; }
		/// <summary>
		/// 요청구분명
		/// </summary>
		[Column("요청구분명")]
		public string RequestClassificationName { get; set; }
		/// <summary>
		/// 요청분류
		/// </summary>
		[Column("요청분류")]
		public string RequestClassification2 { get; set; }
		/// <summary>
		/// 요청분류명
		/// </summary>
		[Column("요청분류명")]
		public string RequestClassificationName2 { get; set; }
		/// <summary>
		/// 결제일
		/// </summary>
		[Column("결제일")]
		public string PaymentDate { get; set; }
		/// <summary>
		/// 결제방법
		/// </summary>
		[Column("결제방법")]
		public string PaymentWay { get; set; }
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
		/// 접수자
		/// </summary>
		[Column("접수자")]
		public string Receiver { get; set; }
		/// <summary>
		/// 요청부서
		/// </summary>
		[Column("요청부서")]
		public string RequestDepartment { get; set; }
		/// <summary>
		/// 출장자
		/// </summary>
		[Column("출장자")]
		public string BusinessTripPerson { get; set; }
		/// <summary>
		/// 항공사
		/// </summary>
		[Column("항공사")]
		public string Airline { get; set; }
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
		/// 비행구간
		/// </summary>
		[Column("비행구간")]
		public string FlightCity { get; set; }
		/// <summary>
		/// 총액
		/// </summary>
		[Column("총액")]
		public long TotalAmount { get; set; }
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
		/// 추가_비자
		/// </summary>
		[Column("추가_비자")]
		public long Add_Visa { get; set; }
		/// <summary>
		/// 추가_서비스
		/// </summary>
		[Column("추가_서비스")]
		public long Add_Service { get; set; }
		/// <summary>
		/// 승인금액
		/// </summary>
		[Column("승인금액")]
		public long ApprovalAmount { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 법인마일리지
		/// </summary>
		[Column("법인마일리지")]
		public int CorporationMileage { get; set; }
	}
}