namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_특선상품단체검색
/// </summary>
public class USP_S_SpecialSelectionProductGroupSearch
{
	public const string SP_NAME = "USP_S_특선상품단체검색";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 출발시작일
		/// </summary>
		[Description("출발시작일")]
		public DateTime DepartureStartDate { get; set; }
		/// <summary>
		/// 출발종료일
		/// </summary>
		[Description("출발종료일")]
		public DateTime DepartureEndDate { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 항공코드
		/// </summary>
		[Description("항공코드")]
		public string FlightCode { get; set; }
		/// <summary>
		/// 일요일
		/// </summary>
		[Description("일요일")]
		public string DateDay { get; set; }
		/// <summary>
		/// 월요일
		/// </summary>
		[Description("월요일")]
		public string MonthDay { get; set; }
		/// <summary>
		/// 화요일
		/// </summary>
		[Description("화요일")]
		public string Tuesday { get; set; }
		/// <summary>
		/// 수요일
		/// </summary>
		[Description("수요일")]
		public string NumberDay { get; set; }
		/// <summary>
		/// 목요일
		/// </summary>
		[Description("목요일")]
		public string Thursday { get; set; }
		/// <summary>
		/// 금요일
		/// </summary>
		[Description("금요일")]
		public string ThisDate { get; set; }
		/// <summary>
		/// 토요일
		/// </summary>
		[Description("토요일")]
		public string Saturday { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Description("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 어른금액1
		/// </summary>
		[Description("어른금액1")]
		public int AdultAmount1 { get; set; }
		/// <summary>
		/// 어른금액2
		/// </summary>
		[Description("어른금액2")]
		public int AdultAmount2 { get; set; }
		/// <summary>
		/// 상품등급
		/// </summary>
		[Description("상품등급")]
		public string ProductClass { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 항공코드
		/// </summary>
		[Column("항공코드")]
		public string FlightCode { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 상품가_어른
		/// </summary>
		[Column("상품가_어른")]
		public long ProductPrice_Adult { get; set; }
		/// <summary>
		/// 판매가_어른
		/// </summary>
		[Column("판매가_어른")]
		public long SellingPrice_Adult { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 선택
		/// </summary>
		[Column("선택")]
		public string Select { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 잔여좌석
		/// </summary>
		[Column("잔여좌석")]
		public string AvailableSeat { get; set; }
		/// <summary>
		/// 접두어
		/// </summary>
		[Column("접두어")]
		public string Prefix { get; set; }
		/// <summary>
		/// 총상품가격
		/// </summary>
		[Column("총상품가격")]
		public long TotalProductPrice { get; set; }
		/// <summary>
		/// 제세공과금어른
		/// </summary>
		[Column("제세공과금어른")]
		public long PublicFacilitiesTaxAdult { get; set; }
		/// <summary>
		/// 유류할증료어른
		/// </summary>
		[Column("유류할증료어른")]
		public long FuelSurchargeFeeAdult { get; set; }
		/// <summary>
		/// 모객
		/// </summary>
		[Column("모객")]
		public string Audience { get; set; }
		/// <summary>
		/// 출발확정
		/// </summary>
		[Column("출발확정")]
		public string DepartureConfirm { get; set; }
	}
}