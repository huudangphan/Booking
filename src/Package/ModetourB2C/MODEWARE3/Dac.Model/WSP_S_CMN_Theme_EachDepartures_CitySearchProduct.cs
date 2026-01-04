namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_테마_출발지별_도시검색상품
/// </summary>
public class WSP_S_CMN_Theme_EachDepartures_CitySearchProduct
{
	public const string SP_NAME = "WSP_S_CMN_테마_출발지별_도시검색상품";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 검색도시명
		/// </summary>
		[Description("검색도시명")]
		public string SearchingCityName { get; set; }
		/// <summary>
		/// 테마명
		/// </summary>
		[Description("테마명")]
		public string ThemeName { get; set; }
		/// <summary>
		/// 출발일1
		/// </summary>
		[Description("출발일1")]
		public DateTime DepartureDate1 { get; set; }
		/// <summary>
		/// 출발일2
		/// </summary>
		[Description("출발일2")]
		public DateTime DepartureDate2 { get; set; }
		/// <summary>
		/// 출발지
		/// </summary>
		[Description("출발지")]
		public string Departures { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result : IDbResult
	{
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
		/// 테마번호
		/// </summary>
		[Column("테마번호")]
		public int ThemeNumber { get; set; }
		/// <summary>
		/// 출발지
		/// </summary>
		[Column("출발지")]
		public string Departures { get; set; }
		/// <summary>
		/// 테마명
		/// </summary>
		[Column("테마명")]
		public string ThemeName { get; set; }
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
		/// 출발요일
		/// </summary>
		[Column("출발요일")]
		public string DepartureDay { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public string ArrivalDate { get; set; }
		/// <summary>
		/// 도착요일
		/// </summary>
		[Column("도착요일")]
		public string ArrivalDay { get; set; }
		/// <summary>
		/// 출발시간
		/// </summary>
		[Column("출발시간")]
		public string DepartureTime { get; set; }
		/// <summary>
		/// 도착시간
		/// </summary>
		[Column("도착시간")]
		public string ArrivalTime { get; set; }
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
		/// 항공사명
		/// </summary>
		[Column("항공사명")]
		public string AirlineName { get; set; }
		/// <summary>
		/// 대한항공
		/// </summary>
		[Column("대한항공")]
		public string KoreanAir { get; set; }
		/// <summary>
		/// 아시아나
		/// </summary>
		[Column("아시아나")]
		public string Asiana { get; set; }
		/// <summary>
		/// 외국항공
		/// </summary>
		[Column("외국항공")]
		public string ForeignFlight { get; set; }
		/// <summary>
		/// 저가항공사
		/// </summary>
		[Column("저가항공사")]
		public string LowPriceAirline { get; set; }
		/// <summary>
		/// 선박
		/// </summary>
		[Column("선박")]
		public string Shipping { get; set; }
		/// <summary>
		/// 직항
		/// </summary>
		[Column("직항")]
		public string DirectFlight { get; set; }
		/// <summary>
		/// 이전가격
		/// </summary>
		[Column("이전가격")]
		public int PreviousPrice { get; set; }
		/// <summary>
		/// 판매가_어른
		/// </summary>
		[Column("판매가_어른")]
		public int SellingPrice_Adult { get; set; }
		/// <summary>
		/// 접두어
		/// </summary>
		[Column("접두어")]
		public string Prefix { get; set; }
		/// <summary>
		/// 접두어명
		/// </summary>
		[Column("접두어명")]
		public string PrefixName { get; set; }
		/// <summary>
		/// 단체상품명
		/// </summary>
		[Column("단체상품명")]
		public string GroupProductName { get; set; }
		/// <summary>
		/// 단체간략키워드
		/// </summary>
		[Column("단체간략키워드")]
		public string GroupBriefKeyword { get; set; }
		/// <summary>
		/// 판매마감
		/// </summary>
		[Column("판매마감")]
		public string SalesEnd { get; set; }
		/// <summary>
		/// 잔여좌석
		/// </summary>
		[Column("잔여좌석")]
		public string AvailableSeat { get; set; }
		/// <summary>
		/// 출발확정
		/// </summary>
		[Column("출발확정")]
		public string DepartureConfirm { get; set; }
		/// <summary>
		/// 대표호텔
		/// </summary>
		[Column("대표호텔")]
		public int RepresentativeHotel { get; set; }
		/// <summary>
		/// 대표호텔등급
		/// </summary>
		[Column("대표호텔등급")]
		public string RepresentativeHotelClass { get; set; }
		/// <summary>
		/// 코로나안심보장상품여부
		/// </summary>
		[Column("코로나안심보장상품여부")]
		public string CoronaSafetyGuaranteeProductOrNot { get; set; }
		/// <summary>
		/// 쇼핑횟수
		/// </summary>
		[Column("쇼핑횟수")]
		public int ShoppingTimes { get; set; }
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
		public int LocalRequiredExpense { get; set; }
		/// <summary>
		/// 인솔자확정
		/// </summary>
		[Column("인솔자확정")]
		public string LeaderConfirm { get; set; }
		/// <summary>
		/// 안내원동행인원
		/// </summary>
		[Column("안내원동행인원")]
		public int GuideAccompanyNumberOfPeople { get; set; }
		/// <summary>
		/// 가이드확정
		/// </summary>
		[Column("가이드확정")]
		public string GuideConfirmed { get; set; }
		/// <summary>
		/// 자유시간여부
		/// </summary>
		[Column("자유시간여부")]
		public string FreeTimeOrNot { get; set; }
		/// <summary>
		/// 대표골프장
		/// </summary>
		[Column("대표골프장")]
		public int RepresentativeGolfCourse { get; set; }
		/// <summary>
		/// 골프라운딩홀수
		/// </summary>
		[Column("골프라운딩홀수")]
		public string GolfRoundingOddNumber { get; set; }
		/// <summary>
		/// 골프라운딩홀수코드명
		/// </summary>
		[Column("골프라운딩홀수코드명")]
		public string GolfRoundingOddNumberCodeName { get; set; }
		/// <summary>
		/// 골프캐디
		/// </summary>
		[Column("골프캐디")]
		public string GolfCaddie { get; set; }
		/// <summary>
		/// 골프카트
		/// </summary>
		[Column("골프카트")]
		public string GolfCart { get; set; }
		/// <summary>
		/// 예약좌석수
		/// </summary>
		[Column("예약좌석수")]
		public int BookingSeatNumber { get; set; }
		/// <summary>
		/// 최소출발인원
		/// </summary>
		[Column("최소출발인원")]
		public int MinimumDepartureNumberOfPeople { get; set; }
		/// <summary>
		/// 지역번호
		/// </summary>
		[Column("지역번호")]
		public int RegionNumber { get; set; }
		/// <summary>
		/// 단체테마번호
		/// </summary>
		[Column("단체테마번호")]
		public int GroupThemeNumber { get; set; }
		/// <summary>
		/// 단체테마명
		/// </summary>
		[Column("단체테마명")]
		public string GroupThemeName { get; set; }
		/// <summary>
		/// 최고가순
		/// </summary>
		[Column("최고가순")]
		public long HighestPriceOrder { get; set; }
		/// <summary>
		/// 최저가순
		/// </summary>
		[Column("최저가순")]
		public long LowestPriceOrder { get; set; }
		/// <summary>
		/// 단체지역명
		/// </summary>
		[Column("단체지역명")]
		public string GroupRegionName { get; set; }
		/// <summary>
		/// 찜일련번호
		/// </summary>
		[Column("찜일련번호")]
		public int FavoriteSerialNumber { get; set; }
		/// <summary>
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// 단체이미지
		/// </summary>
		[Column("단체이미지")]
		public string GroupImage { get; set; }
		/// <summary>
		/// 할인아이콘
		/// </summary>
		[Column("할인아이콘")]
		public string DiscountIcon { get; set; }
		/// <summary>
		/// 할인
		/// </summary>
		[Column("할인")]
		public decimal Discount { get; set; }
		/// <summary>
		/// 로고파일
		/// </summary>
		[Column("로고파일")]
		public string LogoFile { get; set; }
		/// <summary>
		/// 마스터번호
		/// </summary>
		[Column("마스터번호")]
		public int MasterNumber { get; set; }
		/// <summary>
		/// 지급방식코드
		/// </summary>
		[Column("지급방식코드")]
		public string PaymentMethodCode { get; set; }
		/// <summary>
		/// 예약가능일
		/// </summary>
		[Column("예약가능일")]
		public string BookingPossibleDate { get; set; }
		/// <summary>
		/// 잔여좌석수
		/// </summary>
		[Column("잔여좌석수")]
		public int AvailableSeatNumber { get; set; }
		/// <summary>
		/// NameTL
		/// </summary>
		[Column("NameTL")]
		public string NameTL { get; set; }
		/// <summary>
		/// 인센티브여부
		/// </summary>
		[Column("인센티브여부")]
		public string IncentiveOrNot { get; set; }
	}
}