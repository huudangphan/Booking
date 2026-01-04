namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_상품비교리스트
/// </summary>
public class WSP_S_CMN_ProductComparisionList
{
	public const string SP_NAME = "WSP_S_CMN_상품비교리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호리스트
		/// </summary>
		[Description("단체번호리스트")]
		public string GroupNumberList { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 지역1
		/// </summary>
		[Column("지역1")]
		public string Region1 { get; set; }
		/// <summary>
		/// 지역1번호
		/// </summary>
		[Column("지역1번호")]
		public int Region1Number { get; set; }
		/// <summary>
		/// 지역2
		/// </summary>
		[Column("지역2")]
		public string Region2 { get; set; }
		/// <summary>
		/// 지역2번호
		/// </summary>
		[Column("지역2번호")]
		public int Region2Number { get; set; }
		/// <summary>
		/// 지역2_영문
		/// </summary>
		[Column("지역2_영문")]
		public string Region2_English { get; set; }
		/// <summary>
		/// 객체명
		/// </summary>
		[Column("객체명")]
		public string ObjectName { get; set; }
		/// <summary>
		/// 객체번호
		/// </summary>
		[Column("객체번호")]
		public int ObjectNumber { get; set; }
		/// <summary>
		/// 객체명_영문
		/// </summary>
		[Column("객체명_영문")]
		public string ObjectName_English { get; set; }
		/// <summary>
		/// 객체타입
		/// </summary>
		[Column("객체타입")]
		public string ObjectType { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 보유좌석
		/// </summary>
		[Column("보유좌석")]
		public int HoldingSeat { get; set; }
		/// <summary>
		/// 예약좌석수
		/// </summary>
		[Column("예약좌석수")]
		public int BookingSeatNumber { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// NameTL
		/// </summary>
		[Column("NameTL")]
		public string NameTL { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
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
		/// 접미어
		/// </summary>
		[Column("접미어")]
		public string Suffix { get; set; }
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
		/// 판매마감
		/// </summary>
		[Column("판매마감")]
		public string SalesEnd { get; set; }
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
		/// 출발시간
		/// </summary>
		[Column("출발시간")]
		public string DepartureTime { get; set; }
		/// <summary>
		/// 최소출발인원
		/// </summary>
		[Column("최소출발인원")]
		public int MinimumDepartureNumberOfPeople { get; set; }
		/// <summary>
		/// 인솔자동행
		/// </summary>
		[Column("인솔자동행")]
		public string LeaderAccompany { get; set; }
		/// <summary>
		/// 안내원동행인원
		/// </summary>
		[Column("안내원동행인원")]
		public int GuideAccompanyNumberOfPeople { get; set; }
		/// <summary>
		/// 인솔자확정
		/// </summary>
		[Column("인솔자확정")]
		public string LeaderConfirm { get; set; }
		/// <summary>
		/// 가격확정
		/// </summary>
		[Column("가격확정")]
		public string PriceConfirm { get; set; }
		/// <summary>
		/// 출발확정
		/// </summary>
		[Column("출발확정")]
		public string DepartureConfirm { get; set; }
		/// <summary>
		/// 일정확정
		/// </summary>
		[Column("일정확정")]
		public string ScheduleConfirm { get; set; }
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
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
		/// <summary>
		/// 대표국가
		/// </summary>
		[Column("대표국가")]
		public string RepresentativeCountry { get; set; }
		/// <summary>
		/// 대표도시
		/// </summary>
		[Column("대표도시")]
		public string RepresentativeCity { get; set; }
		/// <summary>
		/// 상품등급
		/// </summary>
		[Column("상품등급")]
		public string ProductClass { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 보유좌석
		/// </summary>
		[Column("보유좌석")]
		public int HoldingSeat { get; set; }
		/// <summary>
		/// 예약좌석수
		/// </summary>
		[Column("예약좌석수")]
		public int BookingSeatNumber { get; set; }
		/// <summary>
		/// 잔여좌석수
		/// </summary>
		[Column("잔여좌석수")]
		public int AvailableSeatNumber { get; set; }
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
		/// NameTL
		/// </summary>
		[Column("NameTL")]
		public string NameTL { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
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
		/// 접미어
		/// </summary>
		[Column("접미어")]
		public string Suffix { get; set; }
		/// <summary>
		/// 접두어명
		/// </summary>
		[Column("접두어명")]
		public string PrefixName { get; set; }
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
		/// 판매가_소아N
		/// </summary>
		[Column("판매가_소아N")]
		public long SellingPrice_Kid_N { get; set; }
		/// <summary>
		/// 판매가_소아E
		/// </summary>
		[Column("판매가_소아E")]
		public long SellingPrice_Kid_E { get; set; }
		/// <summary>
		/// 판매가_유아
		/// </summary>
		[Column("판매가_유아")]
		public long SellingPrice_Toddler { get; set; }
		/// <summary>
		/// 판매가_랜드
		/// </summary>
		[Column("판매가_랜드")]
		public long SellingPrice_Land { get; set; }
		/// <summary>
		/// 판매마감
		/// </summary>
		[Column("판매마감")]
		public string SalesEnd { get; set; }
		/// <summary>
		/// 추가요금_TAX
		/// </summary>
		[Column("추가요금_TAX")]
		public int AddFare_TAX { get; set; }
		/// <summary>
		/// 상품가_어른2
		/// </summary>
		[Column("상품가_어른2")]
		public long ProductPrice_Adult2 { get; set; }
		/// <summary>
		/// 판매가_어른2
		/// </summary>
		[Column("판매가_어른2")]
		public long SellingPrice_Adult2 { get; set; }
		/// <summary>
		/// 판매가_소아N2
		/// </summary>
		[Column("판매가_소아N2")]
		public long SellingPrice_Kid_N2 { get; set; }
		/// <summary>
		/// 판매가_소아E2
		/// </summary>
		[Column("판매가_소아E2")]
		public long SellingPrice_Kid_E2 { get; set; }
		/// <summary>
		/// 판매가_유아2
		/// </summary>
		[Column("판매가_유아2")]
		public long SellingPrice_Toddler2 { get; set; }
		/// <summary>
		/// 유류할증료_어른2
		/// </summary>
		[Column("유류할증료_어른2")]
		public long FuelSurchargeFee_Adult2 { get; set; }
		/// <summary>
		/// 유류할증료_소아N2
		/// </summary>
		[Column("유류할증료_소아N2")]
		public long FuelSurchargeFee_Kid_N2 { get; set; }
		/// <summary>
		/// 유류할증료_소아E2
		/// </summary>
		[Column("유류할증료_소아E2")]
		public long FuelSurchargeFee_Kid_E2 { get; set; }
		/// <summary>
		/// 유류할증료_유아2
		/// </summary>
		[Column("유류할증료_유아2")]
		public long FuelSurchargeFee_Toddler2 { get; set; }
		/// <summary>
		/// 제세공과금_어른2
		/// </summary>
		[Column("제세공과금_어른2")]
		public long PublicFacilitiesTax_Adult2 { get; set; }
		/// <summary>
		/// 제세공과금_소아N2
		/// </summary>
		[Column("제세공과금_소아N2")]
		public long PublicFacilitiesTax_Kid_N2 { get; set; }
		/// <summary>
		/// 제세공과금_소아E2
		/// </summary>
		[Column("제세공과금_소아E2")]
		public long PublicFacilitiesTax_Kid_E2 { get; set; }
		/// <summary>
		/// 제세공과금_유아2
		/// </summary>
		[Column("제세공과금_유아2")]
		public long PublicFacilitiesTax_Toddler2 { get; set; }
		/// <summary>
		/// 추가요금_싱글룸
		/// </summary>
		[Column("추가요금_싱글룸")]
		public long AddFare_SingleRoom { get; set; }
		/// <summary>
		/// 현지필수경비여부
		/// </summary>
		[Column("현지필수경비여부")]
		public string LocalRequiredExpenseOrNot { get; set; }
		/// <summary>
		/// 현지필수경비_통화
		/// </summary>
		[Column("현지필수경비_통화")]
		public string LocalRequiredExpense_Call { get; set; }
		/// <summary>
		/// 현지필수경비
		/// </summary>
		[Column("현지필수경비")]
		public long LocalRequiredExpense { get; set; }
		/// <summary>
		/// 현지필수경비_소아
		/// </summary>
		[Column("현지필수경비_소아")]
		public int LocalRequiredExpense_Kid { get; set; }
		/// <summary>
		/// 현지필수경비_유아
		/// </summary>
		[Column("현지필수경비_유아")]
		public int LocalRequiredExpense_Toddler { get; set; }
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
		/// 도착항공편
		/// </summary>
		[Column("도착항공편")]
		public string ArrivalFlight { get; set; }
		/// <summary>
		/// 현지출발시간
		/// </summary>
		[Column("현지출발시간")]
		public string LocalDepartureTime { get; set; }
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
		/// 미팅장소
		/// </summary>
		[Column("미팅장소")]
		public string MeetingPlace { get; set; }
		/// <summary>
		/// 미팅시간
		/// </summary>
		[Column("미팅시간")]
		public string MeetingTime { get; set; }
		/// <summary>
		/// 이인일실
		/// </summary>
		[Column("이인일실")]
		public string TwoPersonOneRoom { get; set; }
		/// <summary>
		/// 포함비고
		/// </summary>
		[Column("포함비고")]
		public string IncludedNote { get; set; }
		/// <summary>
		/// 불포함비고
		/// </summary>
		[Column("불포함비고")]
		public string UnincludedNote { get; set; }
		/// <summary>
		/// 특전비고
		/// </summary>
		[Column("특전비고")]
		public string SpecialEventNote { get; set; }
		/// <summary>
		/// 추가경비비고
		/// </summary>
		[Column("추가경비비고")]
		public string AddExpenseNote { get; set; }
		/// <summary>
		/// 여행추천비고
		/// </summary>
		[Column("여행추천비고")]
		public string TravelRecommendNote { get; set; }
		/// <summary>
		/// 유류할증료불포함비고
		/// </summary>
		[Column("유류할증료불포함비고")]
		public string FuelSurchargeFeeUnincludedNote { get; set; }
		/// <summary>
		/// 최소출발인원
		/// </summary>
		[Column("최소출발인원")]
		public int MinimumDepartureNumberOfPeople { get; set; }
		/// <summary>
		/// 인솔자동행
		/// </summary>
		[Column("인솔자동행")]
		public string LeaderAccompany { get; set; }
		/// <summary>
		/// 안내원동행인원
		/// </summary>
		[Column("안내원동행인원")]
		public int GuideAccompanyNumberOfPeople { get; set; }
		/// <summary>
		/// 인솔자확정
		/// </summary>
		[Column("인솔자확정")]
		public string LeaderConfirm { get; set; }
		/// <summary>
		/// 가격확정
		/// </summary>
		[Column("가격확정")]
		public string PriceConfirm { get; set; }
		/// <summary>
		/// 출발확정
		/// </summary>
		[Column("출발확정")]
		public string DepartureConfirm { get; set; }
		/// <summary>
		/// 일정확정
		/// </summary>
		[Column("일정확정")]
		public string ScheduleConfirm { get; set; }
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
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
		/// <summary>
		/// MLOC
		/// </summary>
		[Column("MLOC")]
		public string MLOC { get; set; }
		/// <summary>
		/// 대표국가
		/// </summary>
		[Column("대표국가")]
		public string RepresentativeCountry { get; set; }
		/// <summary>
		/// 대표도시
		/// </summary>
		[Column("대표도시")]
		public string RepresentativeCity { get; set; }
		/// <summary>
		/// 상품등급
		/// </summary>
		[Column("상품등급")]
		public string ProductClass { get; set; }
		/// <summary>
		/// 단체간략키워드
		/// </summary>
		[Column("단체간략키워드")]
		public string GroupBriefKeyword { get; set; }
		/// <summary>
		/// 평균비행시간
		/// </summary>
		[Column("평균비행시간")]
		public string AverageFlightDuration { get; set; }
	}
}