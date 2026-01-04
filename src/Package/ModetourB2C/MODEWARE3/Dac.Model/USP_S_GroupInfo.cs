namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_단체정보
/// </summary>
public class USP_S_GroupInfo
{
	public const string SP_NAME = "USP_S_단체정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 단체구분코드
		/// </summary>
		[Column("단체구분코드")]
		public string GroupClassificationCode { get; set; }
		/// <summary>
		/// 단체구분
		/// </summary>
		[Column("단체구분")]
		public string GroupClassification { get; set; }
		/// <summary>
		/// 보유좌석
		/// </summary>
		[Column("보유좌석")]
		public int HoldingSeat { get; set; }
		/// <summary>
		/// 재고번호
		/// </summary>
		[Column("재고번호")]
		public int StockNumber { get; set; }
		/// <summary>
		/// 일정번호
		/// </summary>
		[Column("일정번호")]
		public int ScheduleNumber { get; set; }
		/// <summary>
		/// 일정명
		/// </summary>
		[Column("일정명")]
		public string ScheduleName { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 출발편_도착일자
		/// </summary>
		[Column("출발편_도착일자")]
		public string DepartureFlight_ArrivalDate { get; set; }
		/// <summary>
		/// 귀국편_출발일자
		/// </summary>
		[Column("귀국편_출발일자")]
		public string ReturnToHomelandFlight_DepartureDate { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public string ArrivalDate { get; set; }
		/// <summary>
		/// 출발도시명
		/// </summary>
		[Column("출발도시명")]
		public string DepartureCityName { get; set; }
		/// <summary>
		/// 도착도시명
		/// </summary>
		[Column("도착도시명")]
		public string ArrivalCityName { get; set; }
		/// <summary>
		/// 출발도시코드
		/// </summary>
		[Column("출발도시코드")]
		public string DepartureCityCode { get; set; }
		/// <summary>
		/// 도착도시코드
		/// </summary>
		[Column("도착도시코드")]
		public string ArrivalCityCode { get; set; }
		/// <summary>
		/// 한국출발도시명
		/// </summary>
		[Column("한국출발도시명")]
		public string KoreanDepartureCityName { get; set; }
		/// <summary>
		/// 한국도착도시명
		/// </summary>
		[Column("한국도착도시명")]
		public string KoreanArrivalCityName { get; set; }
		/// <summary>
		/// 한국출발도시코드
		/// </summary>
		[Column("한국출발도시코드")]
		public string KoreanDepartureCityCode { get; set; }
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
		/// 접두어명
		/// </summary>
		[Column("접두어명")]
		public string PrefixName { get; set; }
		/// <summary>
		/// 접두어로고파일
		/// </summary>
		[Column("접두어로고파일")]
		public string PrefixLogoFile { get; set; }
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
		/// 상품가_소아N
		/// </summary>
		[Column("상품가_소아N")]
		public long ProductPrice_Kid_N { get; set; }
		/// <summary>
		/// 상품가_소아E
		/// </summary>
		[Column("상품가_소아E")]
		public long ProductPrice_Kid_E { get; set; }
		/// <summary>
		/// 상품가_유아
		/// </summary>
		[Column("상품가_유아")]
		public long ProductPrice_Toddler { get; set; }
		/// <summary>
		/// 상품가_랜드
		/// </summary>
		[Column("상품가_랜드")]
		public long ProductPrice_Land { get; set; }
		/// <summary>
		/// 상품가_소아N_총액
		/// </summary>
		[Column("상품가_소아N_총액")]
		public long ProductPrice_Kid_N_TotalAmount { get; set; }
		/// <summary>
		/// 상품가_소아E_총액
		/// </summary>
		[Column("상품가_소아E_총액")]
		public long ProductPrice_Kid_E_TotalAmount { get; set; }
		/// <summary>
		/// 상품가_유아_총액
		/// </summary>
		[Column("상품가_유아_총액")]
		public long ProductPrice_Toddler_TotalAmount { get; set; }
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
		/// 비지니스추가요금
		/// </summary>
		[Column("비지니스추가요금")]
		public long BusinessAddFare { get; set; }
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
		/// 추가요금_TAX
		/// </summary>
		[Column("추가요금_TAX")]
		public int AddFare_TAX { get; set; }
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
		/// 지상원가
		/// </summary>
		[Column("지상원가")]
		public long LocalOriginalPrice { get; set; }
		/// <summary>
		/// 판매마감
		/// </summary>
		[Column("판매마감")]
		public string SalesEnd { get; set; }
		/// <summary>
		/// 판매마감_여행플래너
		/// </summary>
		[Column("판매마감_여행플래너")]
		public string SalesEnd_TravelPlanner { get; set; }
		/// <summary>
		/// 가족요금프로모션사용여부
		/// </summary>
		[Column("가족요금프로모션사용여부")]
		public string FamilyFarePromotionUseOrNot { get; set; }
		/// <summary>
		/// 어른유료인원
		/// </summary>
		[Column("어른유료인원")]
		public int AdultFeeChargedNumberOfPeople { get; set; }
		/// <summary>
		/// 소아N유료인원
		/// </summary>
		[Column("소아N유료인원")]
		public int Kid_N_FeeChargedNumberOfPeople { get; set; }
		/// <summary>
		/// 소아E유료인원
		/// </summary>
		[Column("소아E유료인원")]
		public int Kid_E_FeeChargedNumberOfPeople { get; set; }
		/// <summary>
		/// 유아유료인원
		/// </summary>
		[Column("유아유료인원")]
		public int ToddlerFeeChargedNumberOfPeople { get; set; }
		/// <summary>
		/// 어른무료인원
		/// </summary>
		[Column("어른무료인원")]
		public int AdultFreeNumberOfPeople { get; set; }
		/// <summary>
		/// 소아N무료인원
		/// </summary>
		[Column("소아N무료인원")]
		public int Kid_N_FreeNumberOfPeople { get; set; }
		/// <summary>
		/// 소아E무료인원
		/// </summary>
		[Column("소아E무료인원")]
		public int Kid_E_FreeNumberOfPeople { get; set; }
		/// <summary>
		/// 유아무료인원
		/// </summary>
		[Column("유아무료인원")]
		public int ToddlerFreeNumberOfPeople { get; set; }
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
		/// 정산상태
		/// </summary>
		[Column("정산상태")]
		public string SettlementState { get; set; }
		/// <summary>
		/// 정산마감일
		/// </summary>
		[Column("정산마감일")]
		public string SettlementEndDate { get; set; }
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
		/// 가이드확정
		/// </summary>
		[Column("가이드확정")]
		public string GuideConfirmed { get; set; }
		/// <summary>
		/// 조인여부
		/// </summary>
		[Column("조인여부")]
		public string JoinOrNot { get; set; }
		/// <summary>
		/// 메인여부
		/// </summary>
		[Column("메인여부")]
		public string MainOrNot { get; set; }
		/// <summary>
		/// 행사인원
		/// </summary>
		[Column("행사인원")]
		public int EventNumberOfPeople { get; set; }
		/// <summary>
		/// 랜드조인
		/// </summary>
		[Column("랜드조인")]
		public int LandJoin { get; set; }
		/// <summary>
		/// 여행기간
		/// </summary>
		[Column("여행기간")]
		public string TravelPeriod { get; set; }
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
		/// 미팅장소코드
		/// </summary>
		[Column("미팅장소코드")]
		public string MeetingPlaceCode { get; set; }
		/// <summary>
		/// 미팅장소
		/// </summary>
		[Column("미팅장소")]
		public string MeetingPlace { get; set; }
		/// <summary>
		/// 미팅장소2
		/// </summary>
		[Column("미팅장소2")]
		public string MeetingPlace2 { get; set; }
		/// <summary>
		/// 미팅장소비고
		/// </summary>
		[Column("미팅장소비고")]
		public string MeetingPlaceNote { get; set; }
		/// <summary>
		/// 미팅시간
		/// </summary>
		[Column("미팅시간")]
		public string MeetingTime { get; set; }
		/// <summary>
		/// 실미팅시간
		/// </summary>
		[Column("실미팅시간")]
		public string RealMeetingTime { get; set; }
		/// <summary>
		/// 간략일정
		/// </summary>
		[Column("간략일정")]
		public string BriefSchedule { get; set; }
		/// <summary>
		/// 결재TL
		/// </summary>
		[Column("결재TL")]
		public string Approval_TL { get; set; }
		/// <summary>
		/// 여행자보험
		/// </summary>
		[Column("여행자보험")]
		public string TravelerInsurance { get; set; }
		/// <summary>
		/// 여행자보험담당
		/// </summary>
		[Column("여행자보험담당")]
		public string TravelerInsuranceResponsibility { get; set; }
		/// <summary>
		/// 비자피
		/// </summary>
		[Column("비자피")]
		public string VisaFee { get; set; }
		/// <summary>
		/// 여권발급비
		/// </summary>
		[Column("여권발급비")]
		public string PassportIssuanceFee { get; set; }
		/// <summary>
		/// 현지안내원
		/// </summary>
		[Column("현지안내원")]
		public string LocalGuide { get; set; }
		/// <summary>
		/// 인천공항세
		/// </summary>
		[Column("인천공항세")]
		public string IncheonAirpotTax { get; set; }
		/// <summary>
		/// 관진금
		/// </summary>
		[Column("관진금")]
		public string GovernmentDeposit { get; set; }
		/// <summary>
		/// 전쟁보험료
		/// </summary>
		[Column("전쟁보험료")]
		public string WarInsuranceFee { get; set; }
		/// <summary>
		/// 유류할증료
		/// </summary>
		[Column("유류할증료")]
		public string FuelSurchargeFee { get; set; }
		/// <summary>
		/// 현지공항세
		/// </summary>
		[Column("현지공항세")]
		public string LocalAirportTax { get; set; }
		/// <summary>
		/// 공동경비
		/// </summary>
		[Column("공동경비")]
		public string JointExpense { get; set; }
		/// <summary>
		/// 관광지입장료
		/// </summary>
		[Column("관광지입장료")]
		public string SightseeingSpotEntranceFee { get; set; }
		/// <summary>
		/// 선택관광수
		/// </summary>
		[Column("선택관광수")]
		public int SelectSightseeingNumber { get; set; }
		/// <summary>
		/// 쇼핑여부
		/// </summary>
		[Column("쇼핑여부")]
		public string ShoppingOrNot { get; set; }
		/// <summary>
		/// 쇼핑횟수
		/// </summary>
		[Column("쇼핑횟수")]
		public int ShoppingTimes { get; set; }
		/// <summary>
		/// 물놀이안전노출여부
		/// </summary>
		[Column("물놀이안전노출여부")]
		public string WaterPlaySafetyDisplayOrNot { get; set; }
		/// <summary>
		/// 현장안전지침서노출여부
		/// </summary>
		[Column("현장안전지침서노출여부")]
		public string ActualPlaceSafetyGuidelineDisplayOrNot { get; set; }
		/// <summary>
		/// 안전정보1
		/// </summary>
		[Column("안전정보1")]
		public string SafetyInfo1 { get; set; }
		/// <summary>
		/// 안전정보1내용
		/// </summary>
		[Column("안전정보1내용")]
		public string SafetyInfo1Content { get; set; }
		/// <summary>
		/// 안전정보2
		/// </summary>
		[Column("안전정보2")]
		public string SafetyInfo2 { get; set; }
		/// <summary>
		/// 안전정보2내용
		/// </summary>
		[Column("안전정보2내용")]
		public string SafetyInfo2Content { get; set; }
		/// <summary>
		/// 안전정보3
		/// </summary>
		[Column("안전정보3")]
		public string SafetyInfo3 { get; set; }
		/// <summary>
		/// 안전정보3내용
		/// </summary>
		[Column("안전정보3내용")]
		public string SafetyInfo3Content { get; set; }
		/// <summary>
		/// 안전정보국가별
		/// </summary>
		[Column("안전정보국가별")]
		public string SafetyInfoEachCountry { get; set; }
		/// <summary>
		/// 인솔자동행
		/// </summary>
		[Column("인솔자동행")]
		public string LeaderAccompany { get; set; }
		/// <summary>
		/// 인솔자동행2
		/// </summary>
		[Column("인솔자동행2")]
		public string LeaderAccompany2 { get; set; }
		/// <summary>
		/// 이인일실
		/// </summary>
		[Column("이인일실")]
		public string TwoPersonOneRoom { get; set; }
		/// <summary>
		/// 포함비고1
		/// </summary>
		[Column("포함비고1")]
		public string IncludedNote1 { get; set; }
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
		/// 유의사항비고2
		/// </summary>
		[Column("유의사항비고2")]
		public string NoticeNote2 { get; set; }
		/// <summary>
		/// 유의사항비고
		/// </summary>
		[Column("유의사항비고")]
		public string NoticeNote { get; set; }
		/// <summary>
		/// 특전비고
		/// </summary>
		[Column("특전비고")]
		public string SpecialEventNote { get; set; }
		/// <summary>
		/// 쇼핑비고
		/// </summary>
		[Column("쇼핑비고")]
		public string ShoppingNote { get; set; }
		/// <summary>
		/// 추가경비비고
		/// </summary>
		[Column("추가경비비고")]
		public string AddExpenseNote { get; set; }
		/// <summary>
		/// 특이사항비고
		/// </summary>
		[Column("특이사항비고")]
		public string SpecificNote { get; set; }
		/// <summary>
		/// 고객별특이사항
		/// </summary>
		[Column("고객별특이사항")]
		public string EachCustomerSpecific { get; set; }
		/// <summary>
		/// 요금비고
		/// </summary>
		[Column("요금비고")]
		public string FareNote { get; set; }
		/// <summary>
		/// 여행추천비고
		/// </summary>
		[Column("여행추천비고")]
		public string TravelRecommendNote { get; set; }
		/// <summary>
		/// 여권비자비고
		/// </summary>
		[Column("여권비자비고")]
		public string PassportVisaNote { get; set; }
		/// <summary>
		/// 취소료규정
		/// </summary>
		[Column("취소료규정")]
		public string CancelFeeRegulations { get; set; }
		/// <summary>
		/// 환급규정
		/// </summary>
		[Column("환급규정")]
		public string RefundRegulations { get; set; }
		/// <summary>
		/// 수신자부담전화
		/// </summary>
		[Column("수신자부담전화")]
		public string ReceiverDebitPhone { get; set; }
		/// <summary>
		/// 현지연락처
		/// </summary>
		[Column("현지연락처")]
		public string LocalContact { get; set; }
		/// <summary>
		/// 현지연락처2
		/// </summary>
		[Column("현지연락처2")]
		public string LocalContact2 { get; set; }
		/// <summary>
		/// 현지연락처3
		/// </summary>
		[Column("현지연락처3")]
		public string LocalContact3 { get; set; }
		/// <summary>
		/// 항공정보
		/// </summary>
		[Column("항공정보")]
		public string FlightInfo { get; set; }
		/// <summary>
		/// 싱글추가요금
		/// </summary>
		[Column("싱글추가요금")]
		public string SingleAddFare { get; set; }
		/// <summary>
		/// 방사용조건비고
		/// </summary>
		[Column("방사용조건비고")]
		public string RoomUseConditionNote { get; set; }
		/// <summary>
		/// 긴급연락처
		/// </summary>
		[Column("긴급연락처")]
		public string EmergencyContact { get; set; }
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
		/// 최소출발인원
		/// </summary>
		[Column("최소출발인원")]
		public int MinimumDepartureNumberOfPeople { get; set; }
		/// <summary>
		/// 안내원동행인원
		/// </summary>
		[Column("안내원동행인원")]
		public int GuideAccompanyNumberOfPeople { get; set; }
		/// <summary>
		/// 항공비고
		/// </summary>
		[Column("항공비고")]
		public string FlightNote { get; set; }
		/// <summary>
		/// 비자
		/// </summary>
		[Column("비자")]
		public string Visa { get; set; }
		/// <summary>
		/// 유류할증료비고
		/// </summary>
		[Column("유류할증료비고")]
		public string FuelSurchargeFeeNote { get; set; }
		/// <summary>
		/// NameTL
		/// </summary>
		[Column("NameTL")]
		public string NameTL { get; set; }
		/// <summary>
		/// 발권TL
		/// </summary>
		[Column("발권TL")]
		public string TicketIssuance_TL { get; set; }
		/// <summary>
		/// 보유좌석수
		/// </summary>
		[Column("보유좌석수")]
		public int HoldingSeatNumber { get; set; }
		/// <summary>
		/// 재고보유좌석수
		/// </summary>
		[Column("재고보유좌석수")]
		public int StockHoldingSeatNumber { get; set; }
		/// <summary>
		/// 공유
		/// </summary>
		[Column("공유")]
		public string Sharing { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
		/// <summary>
		/// LND
		/// </summary>
		[Column("LND")]
		public int LND { get; set; }
		/// <summary>
		/// 예약좌석수
		/// </summary>
		[Column("예약좌석수")]
		public string BookingSeatNumber { get; set; }
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
		/// 재고타입
		/// </summary>
		[Column("재고타입")]
		public string StockType { get; set; }
		/// <summary>
		/// 예약좌석
		/// </summary>
		[Column("예약좌석")]
		public string BookingSeat { get; set; }
		/// <summary>
		/// 인솔자예약인원
		/// </summary>
		[Column("인솔자예약인원")]
		public int LeaderBookingNumberOfPeople { get; set; }
		/// <summary>
		/// 잔여좌석수
		/// </summary>
		[Column("잔여좌석수")]
		public string AvailableSeatNumber { get; set; }
		/// <summary>
		/// OK기준코드
		/// </summary>
		[Column("OK기준코드")]
		public string OK_StandardCode { get; set; }
		/// <summary>
		/// OK기준명
		/// </summary>
		[Column("OK기준명")]
		public string OK_StandardName { get; set; }
		/// <summary>
		/// 상품분류
		/// </summary>
		[Column("상품분류")]
		public string ProductClassification { get; set; }
		/// <summary>
		/// 상품분류2
		/// </summary>
		[Column("상품분류2")]
		public string ProductClassification2 { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// OK기준변경예정일
		/// </summary>
		[Column("OK기준변경예정일")]
		public string OK_StandardChangeExpectationDate { get; set; }
		/// <summary>
		/// 타사비교
		/// </summary>
		[Column("타사비교")]
		public string CompareWithOtherCompanies { get; set; }
		/// <summary>
		/// 카드결제가능여부
		/// </summary>
		[Column("카드결제가능여부")]
		public string CardPaymentPossibleOrNot { get; set; }
		/// <summary>
		/// 수배비고
		/// </summary>
		[Column("수배비고")]
		public string WantedNote { get; set; }
		/// <summary>
		/// 지급방식코드
		/// </summary>
		[Column("지급방식코드")]
		public string PaymentMethodCode { get; set; }
		/// <summary>
		/// 지급방식
		/// </summary>
		[Column("지급방식")]
		public string PaymentMethod { get; set; }
		/// <summary>
		/// 단체예약좌석수
		/// </summary>
		[Column("단체예약좌석수")]
		public string GroupBookingSeatNumber { get; set; }
		/// <summary>
		/// 인솔자
		/// </summary>
		[Column("인솔자")]
		public string Leader { get; set; }
		/// <summary>
		/// 대표이미지종류
		/// </summary>
		[Column("대표이미지종류")]
		public string RepresentativeImageType { get; set; }
		/// <summary>
		/// 단체이미지경로
		/// </summary>
		[Column("단체이미지경로")]
		public string GroupImageRoute { get; set; }
		/// <summary>
		/// 예약가능일
		/// </summary>
		[Column("예약가능일")]
		public string BookingPossibleDate { get; set; }
		/// <summary>
		/// 유류할증료불포함비고
		/// </summary>
		[Column("유류할증료불포함비고")]
		public string FuelSurchargeFeeUnincludedNote { get; set; }
		/// <summary>
		/// 상품등급
		/// </summary>
		[Column("상품등급")]
		public string ProductClass { get; set; }
		/// <summary>
		/// 상품등급명
		/// </summary>
		[Column("상품등급명")]
		public string ProductClassName { get; set; }
		/// <summary>
		/// 질문과답변
		/// </summary>
		[Column("질문과답변")]
		public string QuestionAndAnswer { get; set; }
		/// <summary>
		/// 인센티브여부
		/// </summary>
		[Column("인센티브여부")]
		public string IncentiveOrNot { get; set; }
		/// <summary>
		/// 커미션
		/// </summary>
		[Column("커미션")]
		public int Commission { get; set; }
		/// <summary>
		/// 인솔자PTID
		/// </summary>
		[Column("인솔자PTID")]
		public int Leader_PTID { get; set; }
		/// <summary>
		/// 투어마일리지
		/// </summary>
		[Column("투어마일리지")]
		public int TourMileage { get; set; }
		/// <summary>
		/// 투어마일리지비고
		/// </summary>
		[Column("투어마일리지비고")]
		public string TourMileageNote { get; set; }
		/// <summary>
		/// 적립예상투어마일리지
		/// </summary>
		[Column("적립예상투어마일리지")]
		public int AccumulationExpectedTourMileage { get; set; }
		/// <summary>
		/// 제휴업체단체번호1
		/// </summary>
		[Column("제휴업체단체번호1")]
		public string AffiliateCompanyGroupNumber1 { get; set; }
		/// <summary>
		/// 평균비행시간
		/// </summary>
		[Column("평균비행시간")]
		public string AverageFlightDuration { get; set; }
		/// <summary>
		/// 출발비행시간
		/// </summary>
		[Column("출발비행시간")]
		public string DepartureFlightDuration { get; set; }
		/// <summary>
		/// 도착비행시간
		/// </summary>
		[Column("도착비행시간")]
		public string ArrivalFlightDuration { get; set; }
		/// <summary>
		/// 출발편_경유도시명
		/// </summary>
		[Column("출발편_경유도시명")]
		public string DepartureFlight_TransitCityName { get; set; }
		/// <summary>
		/// 출발편_경유도시_도착일
		/// </summary>
		[Column("출발편_경유도시_도착일")]
		public DateTime DepartureFlight_TransitCity_ArrivalDate { get; set; }
		/// <summary>
		/// 출발편_경유도시_도착시간
		/// </summary>
		[Column("출발편_경유도시_도착시간")]
		public string DepartureFlight_TransitCity_ArrivalTime { get; set; }
		/// <summary>
		/// 출발편_경유도시_출발일자
		/// </summary>
		[Column("출발편_경유도시_출발일자")]
		public DateTime DepartureFlight_TransitCity_DepartureDate { get; set; }
		/// <summary>
		/// 출발편_경유도시_출발시간
		/// </summary>
		[Column("출발편_경유도시_출발시간")]
		public string DepartureFlight_TransitCity_DepartureTime { get; set; }
		/// <summary>
		/// 출발편경유비행시간
		/// </summary>
		[Column("출발편경유비행시간")]
		public string DepartureFlightTransitFlightDuration { get; set; }
		/// <summary>
		/// 귀국편_경유도시명
		/// </summary>
		[Column("귀국편_경유도시명")]
		public string ReturnToHomelandFlight_TransitCityName { get; set; }
		/// <summary>
		/// 귀국편_경유도착도시명
		/// </summary>
		[Column("귀국편_경유도착도시명")]
		public string ReturnToHomelandFlight_TransitArrivalCityName { get; set; }
		/// <summary>
		/// 귀국편_경유도시_도착일
		/// </summary>
		[Column("귀국편_경유도시_도착일")]
		public DateTime ReturnToHomelandFlight_TransitCity_ArrivalDate { get; set; }
		/// <summary>
		/// 귀국편_경유도시_도착시간
		/// </summary>
		[Column("귀국편_경유도시_도착시간")]
		public string ReturnToHomelandFlight_TransitCity_ArrivalTime { get; set; }
		/// <summary>
		/// 귀국편경유비행시간
		/// </summary>
		[Column("귀국편경유비행시간")]
		public string ReturnToHomelandFlightTransitFlightDuration { get; set; }
		/// <summary>
		/// 귀국편경유출발일자
		/// </summary>
		[Column("귀국편경유출발일자")]
		public DateTime ReturnToHomelandFlightTransitDepartureDate { get; set; }
		/// <summary>
		/// 귀국편경유출발시간
		/// </summary>
		[Column("귀국편경유출발시간")]
		public string ReturnToHomelandFlightTransitDepartureTime { get; set; }
		/// <summary>
		/// 출발편_경유도시_편명
		/// </summary>
		[Column("출발편_경유도시_편명")]
		public string DepartureFlight_TransitCity_FlightName { get; set; }
		/// <summary>
		/// 귀국편_경유도시_편명
		/// </summary>
		[Column("귀국편_경유도시_편명")]
		public string ReturnToHomelandFlight_TransitCity_FlightName { get; set; }
		/// <summary>
		/// 경유출발일정표시
		/// </summary>
		[Column("경유출발일정표시")]
		public string TransitDepartureScheduleDisplay { get; set; }
		/// <summary>
		/// 경유도착일정표시
		/// </summary>
		[Column("경유도착일정표시")]
		public string TransitArrivalScheduleDisplay { get; set; }
		/// <summary>
		/// 조기예약할인
		/// </summary>
		[Column("조기예약할인")]
		public string EarlyBookingDiscount { get; set; }
		/// <summary>
		/// 현지행사정보
		/// </summary>
		[Column("현지행사정보")]
		public string LocalEventInfo { get; set; }
		/// <summary>
		/// 특별약관여부
		/// </summary>
		[Column("특별약관여부")]
		public string SpecialTermsOrNot { get; set; }
		/// <summary>
		/// 예상적립마일리지
		/// </summary>
		[Column("예상적립마일리지")]
		public string ExpectedAccumulationMileage { get; set; }
		/// <summary>
		/// 여행자보험비고
		/// </summary>
		[Column("여행자보험비고")]
		public string TravelerInsuranceNote { get; set; }
		/// <summary>
		/// 교통수단
		/// </summary>
		[Column("교통수단")]
		public string TransportationMethod { get; set; }
		/// <summary>
		/// 담당부서
		/// </summary>
		[Column("담당부서")]
		public int ResponsibilityDepartment { get; set; }
		/// <summary>
		/// 여행경보
		/// </summary>
		[Column("여행경보")]
		public string TravelWarning { get; set; }
		/// <summary>
		/// 여행경보긴급연락처
		/// </summary>
		[Column("여행경보긴급연락처")]
		public string TravelWarningEmergencyContact { get; set; }
		/// <summary>
		/// 여행경보사건사고
		/// </summary>
		[Column("여행경보사건사고")]
		public string TravelWarningIncidentAccident { get; set; }
		/// <summary>
		/// 해외여행안전정보_하단공통
		/// </summary>
		[Column("해외여행안전정보_하단공통")]
		public string OverseaTravelSafetyInfo_BottomGeneral { get; set; }
		/// <summary>
		/// 가이드정보
		/// </summary>
		[Column("가이드정보")]
		public string GuideInfo { get; set; }
		/// <summary>
		/// 단체분류
		/// </summary>
		[Column("단체분류")]
		public string GroupClassification2 { get; set; }
		/// <summary>
		/// 단체간략키워드
		/// </summary>
		[Column("단체간략키워드")]
		public string GroupBriefKeyword { get; set; }
		/// <summary>
		/// P단체번호
		/// </summary>
		[Column("P단체번호")]
		public int P_GroupNumber { get; set; }
		/// <summary>
		/// B2C인센티브분류
		/// </summary>
		[Column("B2C인센티브분류")]
		public string B2C_IncentiveClassification { get; set; }
		/// <summary>
		/// 출발공동운항코드
		/// </summary>
		[Column("출발공동운항코드")]
		public string DepartureCodeshareCode { get; set; }
		/// <summary>
		/// 도착공동운항코드
		/// </summary>
		[Column("도착공동운항코드")]
		public string ArrivalCodeshareCode { get; set; }
		/// <summary>
		/// 출발공동운항명
		/// </summary>
		[Column("출발공동운항명")]
		public string DepartureCodeshareName { get; set; }
		/// <summary>
		/// 도착공동운항명
		/// </summary>
		[Column("도착공동운항명")]
		public string ArrivalCodeshareName { get; set; }
		/// <summary>
		/// 공동운항_출발편명
		/// </summary>
		[Column("공동운항_출발편명")]
		public string Codeshare_DepartureFlightName { get; set; }
		/// <summary>
		/// 공동운항_도착편명
		/// </summary>
		[Column("공동운항_도착편명")]
		public string Codeshare_ArrivalFlightName { get; set; }
		/// <summary>
		/// 현장안전고지문구
		/// </summary>
		[Column("현장안전고지문구")]
		public string ActualPlaceSafetyNoticeWords { get; set; }
		/// <summary>
		/// 이동경로이미지주소
		/// </summary>
		[Column("이동경로이미지주소")]
		public string NavigationRouteImageAddress { get; set; }
		/// <summary>
		/// 상품분류1
		/// </summary>
		[Column("상품분류1")]
		public string ProductClassification1 { get; set; }
		/// <summary>
		/// 단체지역
		/// </summary>
		[Column("단체지역")]
		public string GroupRegion { get; set; }
		/// <summary>
		/// 내부판매AD여부
		/// </summary>
		[Column("내부판매AD여부")]
		public string InternalSales_AD_OrNot { get; set; }
		/// <summary>
		/// 출발도시
		/// </summary>
		[Column("출발도시")]
		public string DepartureCity { get; set; }
		/// <summary>
		/// 최종도착지
		/// </summary>
		[Column("최종도착지")]
		public string FinalArrivals { get; set; }
		/// <summary>
		/// 선박여부
		/// </summary>
		[Column("선박여부")]
		public string ShippingOrNot { get; set; }
		/// <summary>
		/// 시리즈연동
		/// </summary>
		[Column("시리즈연동")]
		public string SeriesConnected { get; set; }
		/// <summary>
		/// 단체종류
		/// </summary>
		[Column("단체종류")]
		public string GroupType { get; set; }
		/// <summary>
		/// 일정버전
		/// </summary>
		[Column("일정버전")]
		public double ScheduleVersion { get; set; }
		/// <summary>
		/// 다른버전보기가능여부
		/// </summary>
		[Column("다른버전보기가능여부")]
		public int OtherVersionSeeingPossibleOrNot { get; set; }
		/// <summary>
		/// 담당부서명
		/// </summary>
		[Column("담당부서명")]
		public string ResponsibilityDepartmentName { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 공제
		/// </summary>
		[Column("공제")]
		public string Deduction { get; set; }
		/// <summary>
		/// 영업보증
		/// </summary>
		[Column("영업보증")]
		public string BusinessGuarantee { get; set; }
		/// <summary>
		/// 예치금
		/// </summary>
		[Column("예치금")]
		public string DepositMoney { get; set; }
		/// <summary>
		/// 보험가입계약금액
		/// </summary>
		[Column("보험가입계약금액")]
		public string InsuranceSignUpContractAmount { get; set; }
		/// <summary>
		/// 여행자보험가입여부
		/// </summary>
		[Column("여행자보험가입여부")]
		public string TravelerInsuranceSignUpOrNot { get; set; }
		/// <summary>
		/// 여행자보험회사
		/// </summary>
		[Column("여행자보험회사")]
		public string TravelerInsuranceCompany { get; set; }
		/// <summary>
		/// 여행자보험계약금액
		/// </summary>
		[Column("여행자보험계약금액")]
		public string TravelerInsuranceContractAmount { get; set; }
		/// <summary>
		/// 항공기
		/// </summary>
		[Column("항공기")]
		public string Airplane { get; set; }
		/// <summary>
		/// 항공기등급
		/// </summary>
		[Column("항공기등급")]
		public string AirplaneClass { get; set; }
		/// <summary>
		/// 기차
		/// </summary>
		[Column("기차")]
		public string Train { get; set; }
		/// <summary>
		/// 기차등급
		/// </summary>
		[Column("기차등급")]
		public string TrainClass { get; set; }
		/// <summary>
		/// 선박
		/// </summary>
		[Column("선박")]
		public string Shipping { get; set; }
		/// <summary>
		/// 선박등급
		/// </summary>
		[Column("선박등급")]
		public string ShippingClass { get; set; }
		/// <summary>
		/// 기타교통
		/// </summary>
		[Column("기타교통")]
		public string OtherTransportation { get; set; }
		/// <summary>
		/// 기타교통등급
		/// </summary>
		[Column("기타교통등급")]
		public string OtherTransportationClass { get; set; }
		/// <summary>
		/// 숙박시설
		/// </summary>
		[Column("숙박시설")]
		public string LogmentFacilities { get; set; }
		/// <summary>
		/// 숙박시설등급
		/// </summary>
		[Column("숙박시설등급")]
		public string LogmentFacilitiesClass { get; set; }
		/// <summary>
		/// 투숙인원
		/// </summary>
		[Column("투숙인원")]
		public byte NumberOfStayingPeople { get; set; }
		/// <summary>
		/// 인솔자
		/// </summary>
		[Column("인솔자")]
		public string Leader { get; set; }
		/// <summary>
		/// 안내원
		/// </summary>
		[Column("안내원")]
		public string Guide { get; set; }
		/// <summary>
		/// 현지여행사
		/// </summary>
		[Column("현지여행사")]
		public string LocalTravelCompany { get; set; }
		/// <summary>
		/// 현지교통1
		/// </summary>
		[Column("현지교통1")]
		public string LocalTransportation1 { get; set; }
		/// <summary>
		/// 현지교통승차인원
		/// </summary>
		[Column("현지교통승차인원")]
		public byte LocalTransportationNumberOfPassengers { get; set; }
		/// <summary>
		/// 현지교통2
		/// </summary>
		[Column("현지교통2")]
		public string LocalTransportation2 { get; set; }
		/// <summary>
		/// 현지교통3
		/// </summary>
		[Column("현지교통3")]
		public string LocalTransportation3 { get; set; }
		/// <summary>
		/// 교통운임
		/// </summary>
		[Column("교통운임")]
		public string TransportationFare { get; set; }
		/// <summary>
		/// 숙박식사료
		/// </summary>
		[Column("숙박식사료")]
		public string LogmentMealCost { get; set; }
		/// <summary>
		/// 안내자경비
		/// </summary>
		[Column("안내자경비")]
		public string GuideExpense { get; set; }
		/// <summary>
		/// 공항항만세
		/// </summary>
		[Column("공항항만세")]
		public string AirportDutyFree { get; set; }
		/// <summary>
		/// 관광기금
		/// </summary>
		[Column("관광기금")]
		public string SightseeingFund { get; set; }
		/// <summary>
		/// 제세금
		/// </summary>
		[Column("제세금")]
		public string Tax { get; set; }
		/// <summary>
		/// 입장료
		/// </summary>
		[Column("입장료")]
		public string EntranceFee { get; set; }
		/// <summary>
		/// 여권발급비
		/// </summary>
		[Column("여권발급비")]
		public string PassportIssuanceFee { get; set; }
		/// <summary>
		/// 비자발급비
		/// </summary>
		[Column("비자발급비")]
		public string VisaIssuanceFee { get; set; }
		/// <summary>
		/// 봉사료
		/// </summary>
		[Column("봉사료")]
		public string CharityFee { get; set; }
		/// <summary>
		/// 포터비
		/// </summary>
		[Column("포터비")]
		public string PorterFee { get; set; }
		/// <summary>
		/// 쇼핑
		/// </summary>
		[Column("쇼핑")]
		public string Shopping { get; set; }
		/// <summary>
		/// 선택관광
		/// </summary>
		[Column("선택관광")]
		public string SelectSightseeing { get; set; }
		/// <summary>
		/// 기타
		/// </summary>
		[Column("기타")]
		public string Other { get; set; }
		/// <summary>
		/// 기타내용
		/// </summary>
		[Column("기타내용")]
		public string OtherContent { get; set; }
		/// <summary>
		/// 여권발급료
		/// </summary>
		[Column("여권발급료")]
		public long PassportIssuanceFee2 { get; set; }
		/// <summary>
		/// 비자발급료
		/// </summary>
		[Column("비자발급료")]
		public long VisaIssuanceFee2 { get; set; }
		/// <summary>
		/// 일반규정숙지
		/// </summary>
		[Column("일반규정숙지")]
		public string NormalRegulationsFullKnowledge { get; set; }
		/// <summary>
		/// 특별규정숙지
		/// </summary>
		[Column("특별규정숙지")]
		public string SpecialRegulationsFullKnowledge { get; set; }
		/// <summary>
		/// 보험기간
		/// </summary>
		[Column("보험기간")]
		public string InsurancePeriod { get; set; }
		/// <summary>
		/// 보험사
		/// </summary>
		[Column("보험사")]
		public string InsuranceCompany { get; set; }
		/// <summary>
		/// 항공기등급코드
		/// </summary>
		[Column("항공기등급코드")]
		public string AirplaneClassCode { get; set; }
		/// <summary>
		/// 기내식포함여부
		/// </summary>
		[Column("기내식포함여부")]
		public string InFlightIncludedFoodOrNot { get; set; }
		/// <summary>
		/// 식사료
		/// </summary>
		[Column("식사료")]
		public string MealCost { get; set; }
	}
}