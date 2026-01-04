namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_단체_단체번호
/// </summary>
public class USP_S_Group_GroupNumber
{
	public const string SP_NAME = "USP_S_단체_단체번호";

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
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 보유좌석
		/// </summary>
		[Column("보유좌석")]
		public string HoldingSeat { get; set; }
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
		/// 상품가_어른
		/// </summary>
		[Column("상품가_어른")]
		public long ProductPrice_Adult { get; set; }
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
		/// PKGOK
		/// </summary>
		[Column("PKGOK")]
		public string PKGOK { get; set; }
		/// <summary>
		/// PKGWT
		/// </summary>
		[Column("PKGWT")]
		public string PKGWT { get; set; }
		/// <summary>
		/// PKGTTL
		/// </summary>
		[Column("PKGTTL")]
		public string PKGTTL { get; set; }
		/// <summary>
		/// TKTOK
		/// </summary>
		[Column("TKTOK")]
		public string TKTOK { get; set; }
		/// <summary>
		/// TKTWT
		/// </summary>
		[Column("TKTWT")]
		public string TKTWT { get; set; }
		/// <summary>
		/// TKTTTL
		/// </summary>
		[Column("TKTTTL")]
		public string TKTTTL { get; set; }
		/// <summary>
		/// LND
		/// </summary>
		[Column("LND")]
		public string LND { get; set; }
		/// <summary>
		/// INF
		/// </summary>
		[Column("INF")]
		public string INF { get; set; }
		/// <summary>
		/// 모객
		/// </summary>
		[Column("모객")]
		public string Audience { get; set; }
		/// <summary>
		/// 잔여
		/// </summary>
		[Column("잔여")]
		public string Balance { get; set; }
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
		/// 최소인원
		/// </summary>
		[Column("최소인원")]
		public int MinimumNumberOfPeople { get; set; }
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
		/// 상품수익1
		/// </summary>
		[Column("상품수익1")]
		public int ProductProfit1 { get; set; }
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
		/// 추가판매가
		/// </summary>
		[Column("추가판매가")]
		public long AddSellingPrice { get; set; }
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
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 재고보유좌석
		/// </summary>
		[Column("재고보유좌석")]
		public string StockHoldingSeat { get; set; }
		/// <summary>
		/// 재고PKGOK
		/// </summary>
		[Column("재고PKGOK")]
		public string Stock_PKGOK { get; set; }
		/// <summary>
		/// 재고PKGWT
		/// </summary>
		[Column("재고PKGWT")]
		public string Stock_PKGWT { get; set; }
		/// <summary>
		/// 재고PKGTTL
		/// </summary>
		[Column("재고PKGTTL")]
		public string Stock_PKGTTL { get; set; }
		/// <summary>
		/// 재고TKTOK
		/// </summary>
		[Column("재고TKTOK")]
		public string Stock_TKTOK { get; set; }
		/// <summary>
		/// 재고TKTWT
		/// </summary>
		[Column("재고TKTWT")]
		public string Stock_TKTWT { get; set; }
		/// <summary>
		/// 재고TKTTTL
		/// </summary>
		[Column("재고TKTTTL")]
		public string Stock_TKTTTL { get; set; }
		/// <summary>
		/// 재고LND
		/// </summary>
		[Column("재고LND")]
		public string Stock_LND { get; set; }
		/// <summary>
		/// 재고INF
		/// </summary>
		[Column("재고INF")]
		public string Stock_INF { get; set; }
		/// <summary>
		/// 재고모객
		/// </summary>
		[Column("재고모객")]
		public string StockAudience { get; set; }
		/// <summary>
		/// 재고잔여
		/// </summary>
		[Column("재고잔여")]
		public string StockBalance { get; set; }
		/// <summary>
		/// 재고연합
		/// </summary>
		[Column("재고연합")]
		public string StockCombination { get; set; }
		/// <summary>
		/// 재고대외모객
		/// </summary>
		[Column("재고대외모객")]
		public string StockInternationalAudience { get; set; }
	}
}