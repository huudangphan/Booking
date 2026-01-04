namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_SO_거래처_단체
/// </summary>
public class WSP_SO_Customer_Group
{
	public const string SP_NAME = "WSP_SO_거래처_단체";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 출발시작일
		/// </summary>
		[Description("출발시작일")]
		public string DepartureStartDate { get; set; }
		/// <summary>
		/// 출발종료일
		/// </summary>
		[Description("출발종료일")]
		public string DepartureEndDate { get; set; }
		/// <summary>
		/// 검색구분
		/// </summary>
		[Description("검색구분")]
		public string SearchingClassification { get; set; }
		/// <summary>
		/// 키워드
		/// </summary>
		[Description("키워드")]
		public string Keyword { get; set; }
		/// <summary>
		/// 모객
		/// </summary>
		[Description("모객")]
		public string Audience { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 출발일2
		/// </summary>
		[Column("출발일2")]
		public string DepartureDate2 { get; set; }
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
		/// 판매가_어른
		/// </summary>
		[Column("판매가_어른")]
		public long SellingPrice_Adult { get; set; }
		/// <summary>
		/// 이전가격
		/// </summary>
		[Column("이전가격")]
		public long PreviousPrice { get; set; }
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
		/// 공유
		/// </summary>
		[Column("공유")]
		public string Sharing { get; set; }
		/// <summary>
		/// 선택
		/// </summary>
		[Column("선택")]
		public string Select { get; set; }
		/// <summary>
		/// 보유좌석
		/// </summary>
		[Column("보유좌석")]
		public string HoldingSeat { get; set; }
		/// <summary>
		/// OK
		/// </summary>
		[Column("OK")]
		public int OK { get; set; }
		/// <summary>
		/// NC
		/// </summary>
		[Column("NC")]
		public int NC { get; set; }
		/// <summary>
		/// WT
		/// </summary>
		[Column("WT")]
		public int WT { get; set; }
		/// <summary>
		/// OK잔여
		/// </summary>
		[Column("OK잔여")]
		public string OK_Balance { get; set; }
		/// <summary>
		/// WT잔여
		/// </summary>
		[Column("WT잔여")]
		public string WT_Balance { get; set; }
		/// <summary>
		/// PKG
		/// </summary>
		[Column("PKG")]
		public int PKG { get; set; }
		/// <summary>
		/// TKT
		/// </summary>
		[Column("TKT")]
		public int TKT { get; set; }
		/// <summary>
		/// LND
		/// </summary>
		[Column("LND")]
		public int LND { get; set; }
		/// <summary>
		/// INF
		/// </summary>
		[Column("INF")]
		public int INF { get; set; }
		/// <summary>
		/// 모객
		/// </summary>
		[Column("모객")]
		public string Audience { get; set; }
		/// <summary>
		/// 지급방식
		/// </summary>
		[Column("지급방식")]
		public string PaymentMethod { get; set; }
		/// <summary>
		/// 지급방식2
		/// </summary>
		[Column("지급방식2")]
		public string PaymentMethod2 { get; set; }
		/// <summary>
		/// 재고번호
		/// </summary>
		[Column("재고번호")]
		public int StockNumber { get; set; }
		/// <summary>
		/// 요일
		/// </summary>
		[Column("요일")]
		public string Day { get; set; }
		/// <summary>
		/// 항공편
		/// </summary>
		[Column("항공편")]
		public string Flight { get; set; }
		/// <summary>
		/// 수배담당
		/// </summary>
		[Column("수배담당")]
		public string WantedResponsibility { get; set; }
		/// <summary>
		/// 수배비고
		/// </summary>
		[Column("수배비고")]
		public string WantedNote { get; set; }
		/// <summary>
		/// 항공담당
		/// </summary>
		[Column("항공담당")]
		public string FlightResponsibility { get; set; }
		/// <summary>
		/// 항공비고
		/// </summary>
		[Column("항공비고")]
		public string FlightNote { get; set; }
		/// <summary>
		/// 상품일정명
		/// </summary>
		[Column("상품일정명")]
		public string ProductScheduleName { get; set; }
		/// <summary>
		/// 확정
		/// </summary>
		[Column("확정")]
		public string Confirm { get; set; }
		/// <summary>
		/// 출발확정
		/// </summary>
		[Column("출발확정")]
		public string DepartureConfirm { get; set; }
		/// <summary>
		/// 가격확정
		/// </summary>
		[Column("가격확정")]
		public string PriceConfirm { get; set; }
		/// <summary>
		/// 호텔확정
		/// </summary>
		[Column("호텔확정")]
		public string HotelConfirm { get; set; }
		/// <summary>
		/// 항공확정
		/// </summary>
		[Column("항공확정")]
		public string FlightConfirm { get; set; }
		/// <summary>
		/// 인솔자확정
		/// </summary>
		[Column("인솔자확정")]
		public string LeaderConfirm { get; set; }
		/// <summary>
		/// 정산상태코드
		/// </summary>
		[Column("정산상태코드")]
		public string SettlementStateCode { get; set; }
		/// <summary>
		/// 일정확정
		/// </summary>
		[Column("일정확정")]
		public string ScheduleConfirm { get; set; }
		/// <summary>
		/// 연합
		/// </summary>
		[Column("연합")]
		public string Combination { get; set; }
		/// <summary>
		/// 연합모객
		/// </summary>
		[Column("연합모객")]
		public string CombinationAudience { get; set; }
		/// <summary>
		/// PKG2
		/// </summary>
		[Column("PKG2")]
		public string PKG2 { get; set; }
		/// <summary>
		/// TKT2
		/// </summary>
		[Column("TKT2")]
		public string TKT2 { get; set; }
		/// <summary>
		/// 구분정렬
		/// </summary>
		[Column("구분정렬")]
		public int ClassificationSorting { get; set; }
		/// <summary>
		/// 지급방식정렬
		/// </summary>
		[Column("지급방식정렬")]
		public int PaymentMethodSorting { get; set; }
		/// <summary>
		/// 랜드사
		/// </summary>
		[Column("랜드사")]
		public string LandCompany { get; set; }
		/// <summary>
		/// 인솔자
		/// </summary>
		[Column("인솔자")]
		public string Leader { get; set; }
		/// <summary>
		/// 타사비교
		/// </summary>
		[Column("타사비교")]
		public string CompareWithOtherCompanies { get; set; }
		/// <summary>
		/// 타사비교2
		/// </summary>
		[Column("타사비교2")]
		public string CompareWithOtherCompanies2 { get; set; }
		/// <summary>
		/// OK기준
		/// </summary>
		[Column("OK기준")]
		public string OK_Standard { get; set; }
		/// <summary>
		/// 일정명
		/// </summary>
		[Column("일정명")]
		public string ScheduleName { get; set; }
		/// <summary>
		/// 인원변경
		/// </summary>
		[Column("인원변경")]
		public string NumberOfPeopleChange { get; set; }
		/// <summary>
		/// 메세지수신
		/// </summary>
		[Column("메세지수신")]
		public string MessageReception { get; set; }
		/// <summary>
		/// 최소출발인원
		/// </summary>
		[Column("최소출발인원")]
		public int MinimumDepartureNumberOfPeople { get; set; }
		/// <summary>
		/// 대외모객
		/// </summary>
		[Column("대외모객")]
		public int InternationalAudience { get; set; }
		/// <summary>
		/// TL적용
		/// </summary>
		[Column("TL적용")]
		public string TL_Apply { get; set; }
		/// <summary>
		/// TL적용일
		/// </summary>
		[Column("TL적용일")]
		public string TL_ApplyDate { get; set; }
		/// <summary>
		/// 단체모객
		/// </summary>
		[Column("단체모객")]
		public int GroupAudience { get; set; }
		/// <summary>
		/// 영업수익률
		/// </summary>
		[Column("영업수익률")]
		public decimal BusinessProfitPercent { get; set; }
		/// <summary>
		/// 영업수익
		/// </summary>
		[Column("영업수익")]
		public long BusinessProfit { get; set; }
		/// <summary>
		/// 상품수익
		/// </summary>
		[Column("상품수익")]
		public long ProductProfit { get; set; }
		/// <summary>
		/// 상품등급
		/// </summary>
		[Column("상품등급")]
		public string ProductClass { get; set; }
		/// <summary>
		/// 단체번호2
		/// </summary>
		[Column("단체번호2")]
		public string GroupNumber2 { get; set; }
		/// <summary>
		/// 판매가_소아N
		/// </summary>
		[Column("판매가_소아N")]
		public long SellingPrice_Kid_N { get; set; }
		/// <summary>
		/// 대체가격
		/// </summary>
		[Column("대체가격")]
		public long TransferPrice { get; set; }
		/// <summary>
		/// 유류할증료
		/// </summary>
		[Column("유류할증료")]
		public long FuelSurchargeFee { get; set; }
		/// <summary>
		/// 출발보장
		/// </summary>
		[Column("출발보장")]
		public string DepartureGuarantee { get; set; }
		/// <summary>
		/// 이름변경TL
		/// </summary>
		[Column("이름변경TL")]
		public string NameChangeTL { get; set; }
		/// <summary>
		/// 단체분류
		/// </summary>
		[Column("단체분류")]
		public string GroupClassification { get; set; }
		/// <summary>
		/// NAMETL
		/// </summary>
		[Column("NAMETL")]
		public string NAMETL { get; set; }
		/// <summary>
		/// NAMETL적용일
		/// </summary>
		[Column("NAMETL적용일")]
		public string NAMETL_ApplyDate { get; set; }
		/// <summary>
		/// 시리즈연동
		/// </summary>
		[Column("시리즈연동")]
		public string SeriesConnected { get; set; }
		/// <summary>
		/// 총공헌이익
		/// </summary>
		[Column("총공헌이익")]
		public long TotalContributionProfit { get; set; }
		/// <summary>
		/// 박수
		/// </summary>
		[Column("박수")]
		public byte NightNumber { get; set; }
		/// <summary>
		/// 일수
		/// </summary>
		[Column("일수")]
		public byte DaysNumber { get; set; }
		/// <summary>
		/// 단체좌석사용여부
		/// </summary>
		[Column("단체좌석사용여부")]
		public string GroupSeatUseOrNot { get; set; }
		/// <summary>
		/// 단체종류
		/// </summary>
		[Column("단체종류")]
		public string GroupType { get; set; }
		/// <summary>
		/// 시리즈명
		/// </summary>
		[Column("시리즈명")]
		public string SeriesName { get; set; }
		/// <summary>
		/// 접두어
		/// </summary>
		[Column("접두어")]
		public string Prefix { get; set; }
		/// <summary>
		/// 상품코디SIT
		/// </summary>
		[Column("상품코디SIT")]
		public string ProductCoordinationSIT { get; set; }
		/// <summary>
		/// 제세공과금
		/// </summary>
		[Column("제세공과금")]
		public long PublicFacilitiesTax { get; set; }
		/// <summary>
		/// 총상품가격
		/// </summary>
		[Column("총상품가격")]
		public long TotalProductPrice { get; set; }
		/// <summary>
		/// 수배담당내선
		/// </summary>
		[Column("수배담당내선")]
		public string WantedResponsibilityInterphone { get; set; }
		/// <summary>
		/// 항공담당내선
		/// </summary>
		[Column("항공담당내선")]
		public string FlightResponsibilityInterphone { get; set; }
	}
}