namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_단체항공권_상세정보
/// </summary>
public class WSP_S_CMN_GroupFlightTicket_DetailInfo
{
	public const string SP_NAME = "WSP_S_CMN_단체항공권_상세정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// 판매마감
		/// </summary>
		[Column("판매마감")]
		public string SalesEnd { get; set; }
		/// <summary>
		/// 제휴여부
		/// </summary>
		[Column("제휴여부")]
		public string AffiliateOrNot { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
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
		/// 항공사명
		/// </summary>
		[Column("항공사명")]
		public string AirlineName { get; set; }
		/// <summary>
		/// 접두어
		/// </summary>
		[Column("접두어")]
		public string Prefix { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 접미어
		/// </summary>
		[Column("접미어")]
		public string Suffix { get; set; }
		/// <summary>
		/// 상품명2
		/// </summary>
		[Column("상품명2")]
		public string ProductName2 { get; set; }
		/// <summary>
		/// 상품가_어른
		/// </summary>
		[Column("상품가_어른")]
		public long ProductPrice_Adult { get; set; }
		/// <summary>
		/// 판매가_어른
		/// </summary>
		[Column("판매가_어른")]
		public int SellingPrice_Adult { get; set; }
		/// <summary>
		/// 판매가_소아N
		/// </summary>
		[Column("판매가_소아N")]
		public int SellingPrice_Kid_N { get; set; }
		/// <summary>
		/// 판매가_소아E
		/// </summary>
		[Column("판매가_소아E")]
		public int SellingPrice_Kid_E { get; set; }
		/// <summary>
		/// 판매가_유아
		/// </summary>
		[Column("판매가_유아")]
		public int SellingPrice_Toddler { get; set; }
		/// <summary>
		/// 판매가_랜드
		/// </summary>
		[Column("판매가_랜드")]
		public long SellingPrice_Land { get; set; }
		/// <summary>
		/// 추가요금_TAX
		/// </summary>
		[Column("추가요금_TAX")]
		public long AddFare_TAX { get; set; }
		/// <summary>
		/// 추가요금_기타
		/// </summary>
		[Column("추가요금_기타")]
		public long AddFare_Other { get; set; }
		/// <summary>
		/// 추가요금_기타비고
		/// </summary>
		[Column("추가요금_기타비고")]
		public string AddFare_OtherNote { get; set; }
		/// <summary>
		/// 제한수수료율
		/// </summary>
		[Column("제한수수료율")]
		public decimal LimitFeeRate { get; set; }
		/// <summary>
		/// 판매가_신부
		/// </summary>
		[Column("판매가_신부")]
		public long SellingPrice_Bride { get; set; }
		/// <summary>
		/// 판매마감
		/// </summary>
		[Column("판매마감")]
		public string SalesEnd { get; set; }
		/// <summary>
		/// 제휴여부
		/// </summary>
		[Column("제휴여부")]
		public string AffiliateOrNot { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public string RegisterDate { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Column("등록자")]
		public string Registerer { get; set; }
		/// <summary>
		/// 수정일
		/// </summary>
		[Column("수정일")]
		public string EditionDate { get; set; }
		/// <summary>
		/// 수정자
		/// </summary>
		[Column("수정자")]
		public string Editor { get; set; }
		/// <summary>
		/// 취소일
		/// </summary>
		[Column("취소일")]
		public string CancelDate { get; set; }
		/// <summary>
		/// 취소자
		/// </summary>
		[Column("취소자")]
		public string CancelPerson { get; set; }
		/// <summary>
		/// 정산마감일
		/// </summary>
		[Column("정산마감일")]
		public string SettlementEndDate { get; set; }
		/// <summary>
		/// 출발항공편
		/// </summary>
		[Column("출발항공편")]
		public string DepartureFlight { get; set; }
		/// <summary>
		/// 출발시간
		/// </summary>
		[Column("출발시간")]
		public string DepartureTime { get; set; }
		/// <summary>
		/// 현지도착시간
		/// </summary>
		[Column("현지도착시간")]
		public string LocalArrivalTime { get; set; }
		/// <summary>
		/// 현지출발시간
		/// </summary>
		[Column("현지출발시간")]
		public string LocalDepartureTime { get; set; }
		/// <summary>
		/// 도착항공편
		/// </summary>
		[Column("도착항공편")]
		public string ArrivalFlight { get; set; }
		/// <summary>
		/// 도착시간
		/// </summary>
		[Column("도착시간")]
		public string ArrivalTime { get; set; }
		/// <summary>
		/// 기내숙박
		/// </summary>
		[Column("기내숙박")]
		public byte InFlightLogment { get; set; }
		/// <summary>
		/// 직항여부
		/// </summary>
		[Column("직항여부")]
		public string DirectFlightOrNot { get; set; }
		/// <summary>
		/// 취소료규정
		/// </summary>
		[Column("취소료규정")]
		public string CancelFeeRegulations { get; set; }
		/// <summary>
		/// 항공비고
		/// </summary>
		[Column("항공비고")]
		public string FlightNote { get; set; }
		/// <summary>
		/// 항공비고노출용
		/// </summary>
		[Column("항공비고노출용")]
		public string FlightNoteDisplayUse { get; set; }
		/// <summary>
		/// 요금비고
		/// </summary>
		[Column("요금비고")]
		public string FareNote { get; set; }
		/// <summary>
		/// 불포함비고
		/// </summary>
		[Column("불포함비고")]
		public string UnincludedNote { get; set; }
		/// <summary>
		/// 유류할증료
		/// </summary>
		[Column("유류할증료")]
		public string FuelSurchargeFee { get; set; }
		/// <summary>
		/// 유류할증료비고
		/// </summary>
		[Column("유류할증료비고")]
		public string FuelSurchargeFeeNote { get; set; }
		/// <summary>
		/// 긴급연락처
		/// </summary>
		[Column("긴급연락처")]
		public string EmergencyContact { get; set; }
		/// <summary>
		/// 재고보유좌석수
		/// </summary>
		[Column("재고보유좌석수")]
		public int StockHoldingSeatNumber { get; set; }
		/// <summary>
		/// 재고예약좌석수
		/// </summary>
		[Column("재고예약좌석수")]
		public int StockBookingSeatNumber { get; set; }
		/// <summary>
		/// 연합
		/// </summary>
		[Column("연합")]
		public string Combination { get; set; }
		/// <summary>
		/// 연합모객
		/// </summary>
		[Column("연합모객")]
		public int CombinationAudience { get; set; }
		/// <summary>
		/// 잔여좌석수
		/// </summary>
		[Column("잔여좌석수")]
		public int AvailableSeatNumber { get; set; }
		/// <summary>
		/// 카드결제가능여부
		/// </summary>
		[Column("카드결제가능여부")]
		public string CardPaymentPossibleOrNot { get; set; }
		/// <summary>
		/// 출발편_도착일자
		/// </summary>
		[Column("출발편_도착일자")]
		public DateTime DepartureFlight_ArrivalDate { get; set; }
		/// <summary>
		/// 귀국편_출발일자
		/// </summary>
		[Column("귀국편_출발일자")]
		public DateTime ReturnToHomelandFlight_DepartureDate { get; set; }
		/// <summary>
		/// 귀국편_도착일자
		/// </summary>
		[Column("귀국편_도착일자")]
		public DateTime ReturnToHomelandFlight_ArrivalDate { get; set; }
		/// <summary>
		/// 재고_유류할증료_어른
		/// </summary>
		[Column("재고_유류할증료_어른")]
		public long Stock_FuelSurchargeFee_Adult { get; set; }
		/// <summary>
		/// 재고_유류할증료_소아
		/// </summary>
		[Column("재고_유류할증료_소아")]
		public long Stock_FuelSurchargeFee_Kid { get; set; }
		/// <summary>
		/// 재고_유류할증료_유아
		/// </summary>
		[Column("재고_유류할증료_유아")]
		public long Stock_FuelSurchargeFee_Toddler { get; set; }
		/// <summary>
		/// 재고_제세공과금_어른
		/// </summary>
		[Column("재고_제세공과금_어른")]
		public int Stock_PublicFacilitiesTax_Adult { get; set; }
		/// <summary>
		/// 재고_제세공과금_소아
		/// </summary>
		[Column("재고_제세공과금_소아")]
		public int Stock_PublicFacilitiesTax_Kid { get; set; }
		/// <summary>
		/// 재고_제세공과금_유아
		/// </summary>
		[Column("재고_제세공과금_유아")]
		public int Stock_PublicFacilitiesTax_Toddler { get; set; }
	}
}