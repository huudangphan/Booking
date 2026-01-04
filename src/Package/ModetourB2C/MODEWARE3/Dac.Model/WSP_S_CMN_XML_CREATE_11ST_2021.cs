namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_XML_CREATE_11ST_2021
/// </summary>
public class WSP_S_CMN_XML_CREATE_11ST_2021
{
	public const string SP_NAME = "WSP_S_CMN_XML_CREATE_11ST_2021";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 단체그룹코드
		/// </summary>
		[Description("단체그룹코드")]
		public string GroupGroupCode { get; set; }
		/// <summary>
		/// 박수
		/// </summary>
		[Description("박수")]
		public int NightNumber { get; set; }
		/// <summary>
		/// 일수
		/// </summary>
		[Description("일수")]
		public int DaysNumber { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 수정시간
		/// </summary>
		[Description("수정시간")]
		public int EditionTime { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 방문지리스트
		/// </summary>
		[Column("방문지리스트")]
		public string VisitPlaceList { get; set; }
	}

	public class Result2 : IDbResult
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
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
		/// <summary>
		/// 상품분류
		/// </summary>
		[Column("상품분류")]
		public string ProductClassification { get; set; }
		/// <summary>
		/// 간략설명
		/// </summary>
		[Column("간략설명")]
		public string BriefDescription { get; set; }
		/// <summary>
		/// 상품설명
		/// </summary>
		[Column("상품설명")]
		public string ProductExplaination { get; set; }
		/// <summary>
		/// 대륙코드
		/// </summary>
		[Column("대륙코드")]
		public string ContinentCode { get; set; }
		/// <summary>
		/// 대륙명
		/// </summary>
		[Column("대륙명")]
		public string ContinentName { get; set; }
		/// <summary>
		/// 국가코드
		/// </summary>
		[Column("국가코드")]
		public string CountryCode { get; set; }
		/// <summary>
		/// 국가명
		/// </summary>
		[Column("국가명")]
		public string CountryName { get; set; }
		/// <summary>
		/// 도시코드
		/// </summary>
		[Column("도시코드")]
		public string CityCode { get; set; }
		/// <summary>
		/// 도시명
		/// </summary>
		[Column("도시명")]
		public string CityName { get; set; }
		/// <summary>
		/// 11번가국가도시
		/// </summary>
		[Column("11번가국가도시")]
		public string ElevenStCountryCity { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 단체그룹코드
		/// </summary>
		[Column("단체그룹코드")]
		public string GroupGroupCode { get; set; }
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
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 출발도시
		/// </summary>
		[Column("출발도시")]
		public string DepartureCity { get; set; }
		/// <summary>
		/// 도착국가
		/// </summary>
		[Column("도착국가")]
		public string ArrivalCountry { get; set; }
		/// <summary>
		/// 도착도시
		/// </summary>
		[Column("도착도시")]
		public string ArrivalCity { get; set; }
		/// <summary>
		/// 도착도시명
		/// </summary>
		[Column("도착도시명")]
		public string ArrivalCityName { get; set; }
		/// <summary>
		/// 대표이미지0
		/// </summary>
		[Column("대표이미지0")]
		public string RepresentativeImage0 { get; set; }
		/// <summary>
		/// 대표이미지1
		/// </summary>
		[Column("대표이미지1")]
		public string RepresentativeImage1 { get; set; }
		/// <summary>
		/// 대표이미지2
		/// </summary>
		[Column("대표이미지2")]
		public string RepresentativeImage2 { get; set; }
		/// <summary>
		/// 대표이미지3
		/// </summary>
		[Column("대표이미지3")]
		public string RepresentativeImage3 { get; set; }
		/// <summary>
		/// 대표이미지4
		/// </summary>
		[Column("대표이미지4")]
		public string RepresentativeImage4 { get; set; }
		/// <summary>
		/// 대표이미지5
		/// </summary>
		[Column("대표이미지5")]
		public string RepresentativeImage5 { get; set; }
		/// <summary>
		/// 대표이미지6
		/// </summary>
		[Column("대표이미지6")]
		public string RepresentativeImage6 { get; set; }
		/// <summary>
		/// 그룹대표단체번호
		/// </summary>
		[Column("그룹대표단체번호")]
		public int GroupRepresentativeGroupNumber { get; set; }
		/// <summary>
		/// 방문지리스트
		/// </summary>
		[Column("방문지리스트")]
		public string VisitPlaceList { get; set; }
	}

	public class Result4 : IDbResult
	{
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
		/// 항공코드
		/// </summary>
		[Column("항공코드")]
		public string FlightCode { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 수정일
		/// </summary>
		[Column("수정일")]
		public DateTime EditionDate { get; set; }
		/// <summary>
		/// 대표CLASS
		/// </summary>
		[Column("대표CLASS")]
		public string Representative_CLASS { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 출발시간
		/// </summary>
		[Column("출발시간")]
		public string DepartureTime { get; set; }
		/// <summary>
		/// 출발항공편
		/// </summary>
		[Column("출발항공편")]
		public string DepartureFlight { get; set; }
		/// <summary>
		/// 출발항공사명
		/// </summary>
		[Column("출발항공사명")]
		public string DepartureAirlineName { get; set; }
		/// <summary>
		/// 출발편_도착일자
		/// </summary>
		[Column("출발편_도착일자")]
		public string DepartureFlight_ArrivalDate { get; set; }
		/// <summary>
		/// 현지도착시간
		/// </summary>
		[Column("현지도착시간")]
		public string LocalArrivalTime { get; set; }
		/// <summary>
		/// 출발비행시간
		/// </summary>
		[Column("출발비행시간")]
		public string DepartureFlightDuration { get; set; }
		/// <summary>
		/// 경유출발일정표시
		/// </summary>
		[Column("경유출발일정표시")]
		public string TransitDepartureScheduleDisplay { get; set; }
		/// <summary>
		/// 출발편_경유도시_도착일
		/// </summary>
		[Column("출발편_경유도시_도착일")]
		public DateTime DepartureFlight_TransitCity_ArrivalDate { get; set; }
		/// <summary>
		/// 출발편경유비행시간
		/// </summary>
		[Column("출발편경유비행시간")]
		public string DepartureFlightTransitFlightDuration { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public string ArrivalDate { get; set; }
		/// <summary>
		/// 도착시간
		/// </summary>
		[Column("도착시간")]
		public string ArrivalTime { get; set; }
		/// <summary>
		/// 도착항공편
		/// </summary>
		[Column("도착항공편")]
		public string ArrivalFlight { get; set; }
		/// <summary>
		/// 도착항공사명
		/// </summary>
		[Column("도착항공사명")]
		public string ArrivalAirlineName { get; set; }
		/// <summary>
		/// 귀국편_출발일자
		/// </summary>
		[Column("귀국편_출발일자")]
		public string ReturnToHomelandFlight_DepartureDate { get; set; }
		/// <summary>
		/// 현지출발시간
		/// </summary>
		[Column("현지출발시간")]
		public string LocalDepartureTime { get; set; }
		/// <summary>
		/// 도착비행시간
		/// </summary>
		[Column("도착비행시간")]
		public string ArrivalFlightDuration { get; set; }
		/// <summary>
		/// 경유도착일정표시
		/// </summary>
		[Column("경유도착일정표시")]
		public string TransitArrivalScheduleDisplay { get; set; }
		/// <summary>
		/// 귀국편_경유도시_도착일
		/// </summary>
		[Column("귀국편_경유도시_도착일")]
		public DateTime ReturnToHomelandFlight_TransitCity_ArrivalDate { get; set; }
		/// <summary>
		/// 귀국편경유비행시간
		/// </summary>
		[Column("귀국편경유비행시간")]
		public string ReturnToHomelandFlightTransitFlightDuration { get; set; }
		/// <summary>
		/// 원가_판매가_어른
		/// </summary>
		[Column("원가_판매가_어른")]
		public long OriginalPrice_SellingPrice_Adult { get; set; }
		/// <summary>
		/// 순수판매가어른
		/// </summary>
		[Column("순수판매가어른")]
		public long PureSellingPriceAdult { get; set; }
		/// <summary>
		/// 유류할증료_어른
		/// </summary>
		[Column("유류할증료_어른")]
		public long FuelSurchargeFee_Adult { get; set; }
		/// <summary>
		/// 제세공과금_어른
		/// </summary>
		[Column("제세공과금_어른")]
		public long PublicFacilitiesTax_Adult { get; set; }
		/// <summary>
		/// 순수판매가_소아N
		/// </summary>
		[Column("순수판매가_소아N")]
		public long PureSellingPrice_Kid_N { get; set; }
		/// <summary>
		/// 유류할증료_소아N
		/// </summary>
		[Column("유류할증료_소아N")]
		public long FuelSurchargeFee_Kid_N { get; set; }
		/// <summary>
		/// 제세공과금_소아N
		/// </summary>
		[Column("제세공과금_소아N")]
		public long PublicFacilitiesTax_Kid_N { get; set; }
		/// <summary>
		/// 순수판매가_소아E
		/// </summary>
		[Column("순수판매가_소아E")]
		public long PureSellingPrice_Kid_E { get; set; }
		/// <summary>
		/// 유류할증료_소아E
		/// </summary>
		[Column("유류할증료_소아E")]
		public long FuelSurchargeFee_Kid_E { get; set; }
		/// <summary>
		/// 제세공과금_소아E
		/// </summary>
		[Column("제세공과금_소아E")]
		public long PublicFacilitiesTax_Kid_E { get; set; }
		/// <summary>
		/// 순수판매가_유아
		/// </summary>
		[Column("순수판매가_유아")]
		public long PureSellingPrice_Toddler { get; set; }
		/// <summary>
		/// 유류할증료_유아
		/// </summary>
		[Column("유류할증료_유아")]
		public long FuelSurchargeFee_Toddler { get; set; }
		/// <summary>
		/// 제세공과금_유아
		/// </summary>
		[Column("제세공과금_유아")]
		public long PublicFacilitiesTax_Toddler { get; set; }
		/// <summary>
		/// 미팅장소
		/// </summary>
		[Column("미팅장소")]
		public string MeetingPlace { get; set; }
		/// <summary>
		/// 마감
		/// </summary>
		[Column("마감")]
		public string End { get; set; }
		/// <summary>
		/// 잔여좌석
		/// </summary>
		[Column("잔여좌석")]
		public string AvailableSeat { get; set; }
		/// <summary>
		/// NameTL
		/// </summary>
		[Column("NameTL")]
		public string NameTL { get; set; }
		/// <summary>
		/// 출발확정
		/// </summary>
		[Column("출발확정")]
		public string DepartureConfirm { get; set; }
		/// <summary>
		/// 보유좌석수
		/// </summary>
		[Column("보유좌석수")]
		public int HoldingSeatNumber { get; set; }
		/// <summary>
		/// 판매좌석
		/// </summary>
		[Column("판매좌석")]
		public string SalesSeat { get; set; }
		/// <summary>
		/// 최소출발인원
		/// </summary>
		[Column("최소출발인원")]
		public int MinimumDepartureNumberOfPeople { get; set; }
		/// <summary>
		/// 특별약관여부
		/// </summary>
		[Column("특별약관여부")]
		public string SpecialTermsOrNot { get; set; }
		/// <summary>
		/// 긴급모객여부
		/// </summary>
		[Column("긴급모객여부")]
		public string EmergencyAudienceOrNot { get; set; }
		/// <summary>
		/// 비자포함여부
		/// </summary>
		[Column("비자포함여부")]
		public string VisaIncludedOrNot { get; set; }
		/// <summary>
		/// 조기예약할인
		/// </summary>
		[Column("조기예약할인")]
		public string EarlyBookingDiscount { get; set; }
		/// <summary>
		/// 쇼핑횟수
		/// </summary>
		[Column("쇼핑횟수")]
		public int ShoppingTimes { get; set; }
		/// <summary>
		/// 가이드확정
		/// </summary>
		[Column("가이드확정")]
		public string GuideConfirmed { get; set; }
		/// <summary>
		/// 가격확정
		/// </summary>
		[Column("가격확정")]
		public string PriceConfirm { get; set; }
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
		/// 인솔자확정
		/// </summary>
		[Column("인솔자확정")]
		public string LeaderConfirm { get; set; }
		/// <summary>
		/// 현지가이드포함여부
		/// </summary>
		[Column("현지가이드포함여부")]
		public string LocalGuideIncludedOrNot { get; set; }
		/// <summary>
		/// 현지필수경비발생여부
		/// </summary>
		[Column("현지필수경비발생여부")]
		public string LocalRequiredExpenseOccurOrNot { get; set; }
		/// <summary>
		/// 공통특전비고
		/// </summary>
		[Column("공통특전비고")]
		public string GeneralBonusNote { get; set; }
		/// <summary>
		/// 가이드포함
		/// </summary>
		[Column("가이드포함")]
		public string GuideIncluded { get; set; }
		/// <summary>
		/// 출발비행시간1
		/// </summary>
		[Column("출발비행시간1")]
		public string DepartureFlightDuration1 { get; set; }
		/// <summary>
		/// 출발편_경유도시_경유편_비행시간
		/// </summary>
		[Column("출발편_경유도시_경유편_비행시간")]
		public string DepartureFlight_TransitCity_TransitFlight_FlightDuration { get; set; }
		/// <summary>
		/// 항공좌석등급코드
		/// </summary>
		[Column("항공좌석등급코드")]
		public string FlightSeatClassCode { get; set; }
		/// <summary>
		/// 취소료규정
		/// </summary>
		[Column("취소료규정")]
		public string CancelFeeRegulations { get; set; }
		/// <summary>
		/// 여권비자비고
		/// </summary>
		[Column("여권비자비고")]
		public string PassportVisaNote { get; set; }
		/// <summary>
		/// 여행자보험
		/// </summary>
		[Column("여행자보험")]
		public string TravelerInsurance { get; set; }
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
	}
}