namespace Modetour.B2C.Entity.Package
{
    public class TourProductModel
    {
        /// <summary>
        /// 단체번호
        /// </summary>
        public int PNum { get; set; }
        /// <summary>
        /// 단체구분코드
        /// </summary>
        public string ClassCode { get; set; }
        /// <summary>
        /// 단체구분
        /// </summary>
        public string ClassCodeName { get; set; }
        /// <summary>
        /// 단체종류
        /// </summary>
        public string ClassCategory { get; set; }
        /// <summary>
        /// 단체지역번호
        /// </summary>
        public int ProductPlaceNo { get; set; }
        /// <summary>
        /// 출발일
        /// </summary>
        public DateTime DepartureDate { get; set; }
        /// <summary>
        /// 도착일
        /// </summary>
        public DateTime ArrivalDate { get; set; }
        /// <summary>
        /// 항공코드
        /// </summary>
        public string AirCode { get; set; }
        /// <summary>
        /// 항공사명
        /// </summary>
        public string AirName { get; set; }
        /// <summary>
        /// 상품코드
        /// </summary>
        public string ProductCode { get; set; }
        /// <summary>
        /// 상품명
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 접두어
        /// </summary>
        public string Prefix { get; set; }
        /// <summary>
        /// 접두어명
        /// </summary>
        public string PrefixName { get; set; }
        /// <summary>
        /// 접미어
        /// </summary>
        public string Suffix { get; set; }
        /// <summary>
        /// 판매가_어른
        /// </summary>
        public int sPrice_Adult { get; set; }
        /// <summary>
        /// 판매가_소아N
        /// </summary>
        public int sPrice_InfantN { get; set; }
        /// <summary>
        /// 판매가_소아E
        /// </summary>
        public int sPrice_InfantE { get; set; }
        /// <summary>
        /// 판매가_유아
        /// </summary>
        public int sPrice_Child { get; set; }
        /// <summary>
        /// 판매가_어른_총액
        /// </summary>
        public int sPrice_Adult_Total { get; set; }
        /// <summary>
        /// 판매가_소아N_총액
        /// </summary>
        public int sPrice_InfantN_Total { get; set; }
        /// <summary>
        /// 판매가_소아E_총액
        /// </summary>
        public int sPrice_InfantE_Total { get; set; }
        /// <summary>
        /// 판매가_유아_총액
        /// </summary>
        public int sPrice_Child_Total { get; set; }
        /// <summary>
        /// 판매가_랜드
        /// </summary>
        public int sPrice_Land { get; set; }
        /// <summary>
        /// 상품가_어른
        /// </summary>
        public int pPrice_Adult { get; set; }
        /// <summary>
        /// 상품가_소아N
        /// </summary>
        public int pPrice_InfantN { get; set; }
        /// <summary>
        /// 상품가_소아E
        /// </summary>
        public int pPrice_infantE { get; set; }
        /// <summary>
        /// 상품가_유아
        /// </summary>
        public int pPrice_Child { get; set; }
        /// <summary>
        /// 상품가_랜드
        /// </summary>
        public int pPrice_Land { get; set; }
        /// <summary>
        /// 상품가_어른_총액
        /// </summary>
        public int pPrice_Adult_Total { get; set; }
        /// <summary>
        /// 상품가_소아N_총액
        /// </summary>
        public int pPrice_InfantN_Total { get; set; }
        /// <summary>
        /// 상품가_소아E_총액
        /// </summary>
        public int pPrice_infantE_Total { get; set; }
        /// <summary>
        /// 상품가_유아_초액
        /// </summary>
        public int pPrice_Child_Total { get; set; }
        /// <summary>
        /// 유류할증료_어른
        /// </summary>
        public int FuelCharge_Adult { get; set; }
        /// <summary>
        /// 유류할증료_소아N
        /// </summary>
        public int FuelCharge_InfantN { get; set; }
        /// <summary>
        /// 유류할증료_소아E
        /// </summary>
        public int FuelCharge_InfantE { get; set; }
        /// <summary>
        /// 유류할증료_유아
        /// </summary>
        public int FuelCharge_Child { get; set; }
        /// <summary>
        /// 제세공과금_어른
        /// </summary>
        public int TaxCharge_Adult { get; set; }
        /// <summary>
        /// 제세공과금_소아N
        /// </summary>
        public int TaxCharge_InfantN { get; set; }
        /// <summary>
        /// 제세공과금_소아E
        /// </summary>
        public int TaxCharge_InFantE { get; set; }
        /// <summary>
        /// 제세공과금_유아
        /// </summary>
        public int TaxCharge_Child { get; set; }
        /// <summary>
        /// 추가요금_싱글룸
        /// </summary>
        public int AddCharge_SingleRoom { get; set; }
        /// <summary>
        /// 현지필수경비여부
        /// </summary>
        public string LocalCharge_Flag { get; set; }
        /// <summary>
        /// 현지필수경비_통화
        /// </summary>
        public string LocalCharge_Monetary { get; set; }
        /// <summary>
        /// 현지필수경비
        /// </summary>
        public int LocalCharge_Price { get; set; }
        /// <summary>
        /// 현지필수경비_소아
        /// </summary>
        public int LocalCharge_Infant { get; set; }
        /// <summary>
        /// 현지필수경비_유아
        /// </summary>
        public int LocalCharge_Child { get; set; }
        /// <summary>
        /// 비지니스추가요금
        /// </summary>
        public int BizCharge_Price { get; set; }
        /// <summary>
        /// 가족요금프로모션사용여부
        /// </summary>
        public string FamilyPromotionFlag { get; set; }
        /// <summary>
        /// 어른유료인원
        /// </summary>
        public int Paid_AdultCount { get; set; }
        /// <summary>
        /// 소아N유료인원
        /// </summary>
        public int Paid_InfantNCount { get; set; }
        /// <summary>
        /// 소아E유료인원
        /// </summary>
        public int Paid_InfantECount { get; set; }
        /// <summary>
        /// 유아유료인원
        /// </summary>
        public int Paid_ChildCount { get; set; }
        /// <summary>
        /// 어른무료인원
        /// </summary>
        public int Free_AdultCount { get; set; }
        /// <summary>
        /// 소아N무료인원
        /// </summary>
        public int Free_InfantNCount { get; set; }
        /// <summary>
        /// 소아E무료인원
        /// </summary>
        public int Free_InfantECount { get; set; }
        /// <summary>
        /// 유아무료인원
        /// </summary>
        public int Free_ChildCount { get; set; }
        /// <summary>
        /// 추가원가수속
        /// </summary>
        public int VisaCharge { get; set; }
        /// <summary>
        /// 취소
        /// </summary>
        public string CancleFlag { get; set; }
        /// <summary>
        /// 제휴여부
        /// </summary>
        public string AllianceFlag { get; set; }
        /// <summary>
        /// 판매마감
        /// </summary>
        public string DeadConfirm { get; set; }
        /// <summary>
        /// 판매마감_여행플래너
        /// </summary>
        public string DeadConfirm_TourPlanner { get; set; }
        /// <summary>
        /// 출발확정
        /// </summary>
        public string DepartureConfirm { get; set; }
        /// <summary>
        /// 가격확정
        /// </summary>
        public string PriceConfirm { get; set; }
        /// <summary>
        /// 일정확정
        /// </summary>
        public string ScheduleConfirm { get; set; }
        /// <summary>
        /// 호텔확정
        /// </summary>
        public string HotelConfirm { get; set; }
        /// <summary>
        /// 항공확정
        /// </summary>
        public string AirConfirm { get; set; }
        /// <summary>
        /// 조인여부
        /// </summary>
        public string JoinFlag { get; set; }
        /// <summary>
        /// 메인여부
        /// </summary>
        public string MainFlag { get; set; }
        /// <summary>
        /// 행사인원
        /// </summary>
        public int EventPerson { get; set; }
        /// <summary>
        /// 랜드조인
        /// </summary>
        public int LandPerson { get; set; }
        /// <summary>
        /// LND
        /// </summary>
        public int LocalPerson { get; set; }
        /// <summary>
        /// 예약좌석수
        /// </summary>
        public int BookingSeat { get; set; }
        /// <summary>
        /// NameTL
        /// </summary>
        public DateTime NameTL { get; set; }
        /// <summary>
        /// 안내원동행인원
        /// </summary>
        public int MinPerson_Leader { get; set; }
        /// <summary>
        /// 상품코드2
        /// </summary>
        public string ProductCode2 { get; set; }
        /// <summary>
        /// 상품등급
        /// </summary>
        public string ProductGrade { get; set; }
        /// <summary>
        /// 조기예약할인
        /// </summary>
        public string EarlyBookingFlag { get; set; }
        /// <summary>
        /// 시리즈연동
        /// </summary>
        public string SeriesFlag { get; set; }
        /// <summary>
        /// 단체좌석사용여부
        /// </summary>
        public string GroupSeatFlag { get; set; }
        /// <summary>
        /// 내부판매AD여부
        /// </summary>
        public string InsideADFlag { get; set; }
        /// <summary>
        /// 단체간략키워드
        /// </summary>
        public string SummaryKeyword { get; set; }
        /// <summary>
        /// P단체번호
        /// </summary>
        public int PPNum { get; set; }
        /// <summary>
        /// 행사번호
        /// </summary>
        public int EventGroupNo { get; set; }
        /// <summary>
        /// 박수
        /// </summary>
        public int Night { get; set; }
        /// <summary>
        /// 일수
        /// </summary>
        public int Days { get; set; }
        /// <summary>
        /// 여행기간
        /// </summary>
        public string TourPeriod { get; set; }
        /// <summary>
        /// 출발항공편
        /// </summary>
        public string DepartureAirFlight { get; set; }
        /// <summary>
        /// 출발시간
        /// </summary>
        public string DepartureTime { get; set; }
        /// <summary>
        /// 도착항공편
        /// </summary>
        public string ArrivalAirFlight { get; set; }
        /// <summary>
        /// 도착시간
        /// </summary>
        public string ArrivalTime { get; set; }
        /// <summary>
        /// 기내숙박
        /// </summary>
        public int AirNight { get; set; }
        /// <summary>
        /// 직항여부
        /// </summary>
        public string DirectAirFlag { get; set; }
        /// <summary>
        /// 미팅장소코드
        /// </summary>
        public string MeetingPlaceCode { get; set; }
        /// <summary>
        /// 미팅장소2
        /// </summary>
        public string MeetingPlace2 { get; set; }
        /// <summary>
        /// 미팅시간
        /// </summary>
        public string MeetingTime { get; set; }
        /// <summary>
        /// 여행자보험
        /// </summary>
        public string InsuranceFlag { get; set; }
        /// <summary>
        /// 여행자보험담당
        /// </summary>
        public string InsuranceManage { get; set; }
        /// <summary>
        /// 포함비고
        /// </summary>
        public string IncludeRemarks { get; set; }
        /// <summary>
        /// 불포함비고
        /// </summary>
        public string NotIncludeRemarks { get; set; }
        /// <summary>
        /// 유의사항비고
        /// </summary>
        public string CautionRemarks { get; set; }
        /// <summary>
        /// 특전비고
        /// </summary>
        public string BenefitRemarks { get; set; }
        /// <summary>
        /// 공통특전비고
        /// </summary>
        public string CommonBenefitRemarks { get; set; }
        /// <summary>
        /// 쇼핑비고
        /// </summary>
        public string ShoppingRemarks { get; set; }
        /// <summary>
        /// 쇼핑시유의사항
        /// </summary>
        public string ShoppingCautionRemarks { get; set; }
        /// <summary>
        /// 추가경비비고
        /// </summary>
        public string AddChargeRemarks { get; set; }
        /// <summary>
        /// 특이사항비고
        /// </summary>
        public string SpecialRemarks { get; set; }
        /// <summary>
        /// 요금비고
        /// </summary>
        public string PriceRemarks { get; set; }
        /// <summary>
        /// 여행추천비고
        /// </summary>
        public string RecommendRemarks { get; set; }
        /// <summary>
        /// 여권비자비고
        /// </summary>
        public string PassportRemarks { get; set; }
        /// <summary>
        /// 취소료규정
        /// </summary>
        public string CancleRemarks { get; set; }
        /// <summary>
        /// 수신자부담전화
        /// </summary>
        public string FreeContactTel { get; set; }
        /// <summary>
        /// 현지연락처
        /// </summary>
        public string LocalContactTel { get; set; }
        /// <summary>
        /// 싱글추가요금
        /// </summary>
        public string SingleRoomRemarks { get; set; }
        /// <summary>
        /// 동영상정보
        /// </summary>
        public string VideoUrl { get; set; }
        /// <summary>
        /// 방사용조건비고
        /// </summary>
        public string RoomRemarks { get; set; }
        /// <summary>
        /// 긴급연락처
        /// </summary>
        public string EmergencyRemarks { get; set; }
        /// <summary>
        /// 현지도착시간
        /// </summary>
        public string LocalArrivalTime { get; set; }
        /// <summary>
        /// 현지출발시간
        /// </summary>
        public string LocalDepartureTime { get; set; }
        /// <summary>
        /// 최소출발인원
        /// </summary>
        public int MinPerson_Departure { get; set; }
        /// <summary>
        /// 비자
        /// </summary>
        public string VisaFlag { get; set; }
        /// <summary>
        /// 유류할증료비고
        /// </summary>
        public string FuelRemarks { get; set; }
        /// <summary>
        /// 특별약관
        /// </summary>
        public string SpecialClauseFlag { get; set; }
        /// <summary>
        /// 질문과답변
        /// </summary>
        public string FAQ { get; set; }
        /// <summary>
        /// 고객별특이사항
        /// </summary>
        public string CustomerRemarks { get; set; }
        /// <summary>
        /// 현지행사정보
        /// </summary>
        public string LocalEvent { get; set; }
        /// <summary>
        /// 가이드확정
        /// </summary>
        public string GuideConfirm { get; set; }
        /// <summary>
        /// 쇼핑횟수
        /// </summary>
        public int ShoppingCount { get; set; }
        /// <summary>
        /// 물놀이안전노출여부
        /// </summary>
        public string SwimmingFlag { get; set; }
        /// <summary>
        /// 현장안전지침서노출여부
        /// </summary>
        public string LocalSafetyFlag { get; set; }
        /// <summary>
        /// 이인일실
        /// </summary>
        public string Room21Flag { get; set; }
        /// <summary>
        /// B2C인센티브분류
        /// </summary>
        public string B2C { get; set; }
        /// <summary>
        /// 이동경로이미지주소
        /// </summary>
        public string RouteImgPath { get; set; }
        /// <summary>
        /// 잔여좌석수
        /// </summary>
        public int RemainSeat { get; set; }
        /// <summary>
        /// 지급방식코드
        /// </summary>
        public string PaymentCode { get; set; }
        /// <summary>
        /// 연합
        /// </summary>
        public string UnionFlag { get; set; }
        /// <summary>
        /// 출발도시
        /// </summary>
        public string DepartureCity { get; set; }
        /// <summary>
        /// 출발도시명
        /// </summary>
        public string DepartureCityName { get; set; }
        /// <summary>
        /// 출발공항명
        /// </summary>
        public string DepartureAirPort { get; set; }
        /// <summary>
        /// 도착도시
        /// </summary>
        public string ArrivalCity { get; set; }
        /// <summary>
        /// 도착도시명
        /// </summary>
        public string ArrivalCityName { get; set; }
        /// <summary>
        /// 한국출발도시
        /// </summary>
        public string KorDepartureCity { get; set; }
        /// <summary>
        /// 한국출발도시명
        /// </summary>
        public string KorDepartureCityName { get; set; }
        /// <summary>
        /// 한국도착도시
        /// </summary>
        public string KorArrivalCity { get; set; }
        /// <summary>
        /// 한국도착도시명
        /// </summary>
        public string KorArrivalCityName { get; set; }
        /// <summary>
        /// 출발비행시간
        /// </summary>
        public string DepartureFlightTime { get; set; }
        /// <summary>
        /// 도착비행시간
        /// </summary>
        public string ArrivalFlightTime { get; set; }
        /// <summary>
        /// 선박여부
        /// </summary>
        public string ShipFlag { get; set; }
        /// <summary>
        /// 교통수단코드
        /// </summary>
        public string TransportWayCode { get; set; }
        /// <summary>
        /// 교통수단
        /// </summary>
        public string TransportWay { get; set; }
        /// <summary>
        /// 최종도착지
        /// </summary>
        public string FinalArrivalCity { get; set; }
        /// <summary>
        /// 출발편_도착일자
        /// </summary>
        public DateTime D_ArrivalDate { get; set; }
        /// <summary>
        /// 귀국편_출발일자
        /// </summary>
        public DateTime A_DepartureDate { get; set; }
        /// <summary>
        /// 출발편_경유도시_도착일
        /// </summary>
        public DateTime D_T_ArrivalDate { get; set; }
        /// <summary>
        /// 출발편_경유도시_도착시간
        /// </summary>
        public string D_T_ArrivalTime { get; set; }
        /// <summary>
        /// 출발편_경유도시_출발시간
        /// </summary>
        public string D_T_DepartureTime { get; set; }
        /// <summary>
        /// 출발편_경유도시_경유편_비행시간
        /// </summary>
        public string D_T_DepartureFlightTime { get; set; }
        /// <summary>
        /// 귀국편_경유도시_도착일
        /// </summary>
        public DateTime A_T_ArrivalDate { get; set; }
        /// <summary>
        /// 귀국편_경유도시_도착시간
        /// </summary>
        public string A_T_ArrivalTime { get; set; }
        /// <summary>
        /// 귀국편_경유도시_출발시간
        /// </summary>
        public string A_T_DepartureTime { get; set; }
        /// <summary>
        /// 귀국편_경유도시_경유편_비행시간
        /// </summary>
        public string A_T_DepartureFlightTime { get; set; }
        /// <summary>
        /// 출발편_경유도시_편명
        /// </summary>
        public string D_T_AirFlight { get; set; }
        /// <summary>
        /// 귀국편_경유도시_편명
        /// </summary>
        public string A_T_AirFlight { get; set; }
        /// <summary>
        /// 출발편_경유도시_출발일자
        /// </summary>
        public DateTime D_T_DepartureDate { get; set; }
        /// <summary>
        /// 귀국편_경유도시_출발일자
        /// </summary>
        public DateTime A_T_DepartureDate { get; set; }
        /// <summary>
        /// 출발편_경유도시코드
        /// </summary>
        public string D_ThroughCity { get; set; }
        /// <summary>
        /// 출발편_경유도시명
        /// </summary>
        public string D_ThroughCityName { get; set; }
        /// <summary>
        /// 귀국편_경유도시코드
        /// </summary>
        public string A_ThroughCity { get; set; }
        /// <summary>
        /// 귀국편_경유도시명
        /// </summary>
        public string A_ThroughCityName { get; set; }
        /// <summary>
        /// 귀국편_경유도착도시코드
        /// </summary>
        public string A_ThroughCity2 { get; set; }
        /// <summary>
        /// 귀국편_경유도착도시명
        /// </summary>
        public string A_ThroughCityName2 { get; set; }
        /// <summary>
        /// 공동운항_출발편명
        /// </summary>
        public string Join_DepartureAirFlight { get; set; }
        /// <summary>
        /// 공동운항_도착편명
        /// </summary>
        public string Join_ArrivalAirFlight { get; set; }
        /// <summary>
        /// 경유출발일정표시
        /// </summary>
        public string ThroughDepartureFlag { get; set; }
        /// <summary>
        /// 경유도착일정표시
        /// </summary>
        public string ThroughArrivalFlag { get; set; }
        /// <summary>
        /// 출발공동운항코드
        /// </summary>
        public string Join_DepartureCode { get; set; }
        /// <summary>
        /// 도착공동운항코드
        /// </summary>
        public string Join_ArrivalCode { get; set; }
        /// <summary>
        /// 출발공동운항명
        /// </summary>
        public string Join_DepartureAirName { get; set; }
        /// <summary>
        /// 도착공동운항명
        /// </summary>
        public string Join_ArrivalAirName { get; set; }
        /// <summary>
        /// 지역
        /// </summary>
        public string DnO { get; set; }
        /// <summary>
        /// 상품분류
        /// </summary>
        public string ProductCategory_S { get; set; }
        /// <summary>
        /// 상품분류2
        /// </summary>
        public string ProductCategory { get; set; }
        /// <summary>
        /// 대표이미지
        /// </summary>
        public string FaceImg { get; set; }
        /// <summary>
        /// 대표이미지묶음
        /// </summary>
        public List<string> arrFaceImg { get; set; }
        /// <summary>
        /// 대표이미지종류
        /// </summary>
        public string FaceImgCategory { get; set; }
        /// <summary>
        /// 마스터번호
        /// </summary>
        public int PromotionNum { get; set; }
        /// <summary>
        /// 프로모션명
        /// </summary>
        public string PromotionName { get; set; }
        /// <summary>
        /// 로고파일
        /// </summary>
        public string PromotionLogo { get; set; }
        /// <summary>
        /// 대표국가명
        /// </summary>
        public string FaceCountryName { get; set; }
        /// <summary>
        /// 여행경보사건사고
        /// </summary>
        public string AccidentRemarks { get; set; }
        /// <summary>
        /// 인솔자PTID
        /// </summary>
        public int LeaderNum { get; set; }
        /// <summary>
        /// 인솔자동행
        /// </summary>
        public string LeaderFlag { get; set; }
        /// <summary>
        /// 인솔자확정
        /// </summary>
        public string LeaderConfirm { get; set; }
        /// <summary>
        /// 인센티브여부
        /// </summary>
        public string IncentiveFlag { get; set; }
        /// <summary>
        /// 안전정보국가별
        /// </summary>
        public string SafetyRemarks { get; set; }
        /// <summary>
        /// 현장안전고지문구
        /// </summary>
        public string LocalSafetyRemarks { get; set; }
        /// <summary>
        /// 적립예상투어마일리지
        /// </summary>
        public int Mileage { get; set; }
        /// <summary>
        /// 예약가능일
        /// </summary>
        public DateTime ReservableDate { get; set; }
        /// <summary>
        /// 영업보증
        /// </summary>
        public string SalesWarrantFlag { get; set; }
        /// <summary>
        /// 여행자보험가입여부
        /// </summary>
        public string InsuranceSignFlag { get; set; }
        /// <summary>
        /// 여행자보험계약금액
        /// </summary>
        public string InsuranceSignPrice { get; set; }
        /// <summary>
        /// 인솔자사번
        /// </summary>
        public string LeaderEmployeeNum { get; set; }
        /// <summary>
        /// 인솔자성명
        /// </summary>
        public string LeaderName { get; set; }
        /// <summary>
        /// 인솔자성별
        /// </summary>
        public string LeaderSex { get; set; }
        /// <summary>
        /// 인솔자경력
        /// </summary>
        public int LeaderCareer { get; set; }
        /// <summary>
        /// 인솔자출장경력
        /// </summary>
        public string LeaderTourCareer { get; set; }
        /// <summary>
        /// 인솔자자격사항
        /// </summary>
        public string LeaderCapacity { get; set; }
        /// <summary>
        /// 인솔자본인소개
        /// </summary>
        public string LeaderAbout { get; set; }
        /// <summary>
        /// 인솔자사진노출여부
        /// </summary>
        public string LeaderImgFlag { get; set; }
        /// <summary>
        /// 인솔자개인정보공개동의
        /// </summary>
        public string LeaderInfoAgreeFlag { get; set; }
        /// <summary>
        /// arr_안전정보
        /// </summary>
        public List<SafetyInfoModel> arrSafetyInfo { get; set; }
        /// <summary>
        /// QRCODE BASE64 string
        /// </summary>
        public string QRCODE { get; set; }
        /// <summary>
        /// 일정버전
        /// </summary>
        public double ItineraryVer { get; set; }
        /// <summary>
        /// 다른버전보기가능여부
        /// </summary>
        public int ItineraryOtherVerFlag { get; set; }
        /// <summary>
        /// 상품상태
        /// </summary>
        public string ProductStatus { get; set; }
        /// <summary>
        /// 담당부서명
        /// </summary>
        public string DeptName { get; set; }
        /// <summary>
        /// 키워드
        /// </summary>
        public string ProductKeyword { get; set; }
        /// <summary>
        /// 센딩여부
        /// </summary>
        public string SendingFlag { get; set; }
    }
}
