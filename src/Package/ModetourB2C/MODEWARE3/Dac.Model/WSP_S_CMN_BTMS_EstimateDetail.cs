namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_BTMS_견적세부
/// </summary>
public class WSP_S_CMN_BTMS_EstimateDetail
{
	public const string SP_NAME = "WSP_S_CMN_BTMS_견적세부";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 견적번호
		/// </summary>
		[Description("견적번호")]
		public int EstimateNumber { get; set; }
		/// <summary>
		/// 세부번호
		/// </summary>
		[Description("세부번호")]
		public int DetailNumber { get; set; }
	}

	public class Result1 : IDbResult
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
		/// 요청분류
		/// </summary>
		[Column("요청분류")]
		public string RequestClassification { get; set; }
		/// <summary>
		/// 요청구분
		/// </summary>
		[Column("요청구분")]
		public string RequestClassification2 { get; set; }
		/// <summary>
		/// 견적상태
		/// </summary>
		[Column("견적상태")]
		public string EstimateState { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// GDS주문번호
		/// </summary>
		[Column("GDS주문번호")]
		public string GDS_OrderNumber { get; set; }
		/// <summary>
		/// GDSTL
		/// </summary>
		[Column("GDSTL")]
		public DateTime GDSTL { get; set; }
		/// <summary>
		/// 비즈니스TL
		/// </summary>
		[Column("비즈니스TL")]
		public DateTime BusinessTL { get; set; }
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
		/// 총액
		/// </summary>
		[Column("총액")]
		public long TotalAmount { get; set; }
		/// <summary>
		/// 클래스
		/// </summary>
		[Column("클래스")]
		public string Class { get; set; }
		/// <summary>
		/// 요청사항
		/// </summary>
		[Column("요청사항")]
		public string Request { get; set; }
		/// <summary>
		/// 비고사항
		/// </summary>
		[Column("비고사항")]
		public string NoteItem { get; set; }
		/// <summary>
		/// 비자종류
		/// </summary>
		[Column("비자종류")]
		public string VisaType { get; set; }
		/// <summary>
		/// 유효기간
		/// </summary>
		[Column("유효기간")]
		public DateTime ValidPeriod { get; set; }
		/// <summary>
		/// 예상발급일
		/// </summary>
		[Column("예상발급일")]
		public DateTime ExpectedIssuanceDate { get; set; }
		/// <summary>
		/// 접수자
		/// </summary>
		[Column("접수자")]
		public int Receiver { get; set; }
		/// <summary>
		/// 접수일
		/// </summary>
		[Column("접수일")]
		public DateTime ReceiptDate { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public DateTime ArrivalDate { get; set; }
		/// <summary>
		/// 체류기간
		/// </summary>
		[Column("체류기간")]
		public string SojournPeriod { get; set; }
		/// <summary>
		/// 성인인원
		/// </summary>
		[Column("성인인원")]
		public int AdultNumberOfPeople { get; set; }
		/// <summary>
		/// 소아인원
		/// </summary>
		[Column("소아인원")]
		public int KidNumberOfPeople { get; set; }
		/// <summary>
		/// 선호항공
		/// </summary>
		[Column("선호항공")]
		public string PreferenceFlight { get; set; }
		/// <summary>
		/// 좌석등급
		/// </summary>
		[Column("좌석등급")]
		public string SeatClass { get; set; }
		/// <summary>
		/// 체크인
		/// </summary>
		[Column("체크인")]
		public DateTime CheckIn { get; set; }
		/// <summary>
		/// 체크아웃
		/// </summary>
		[Column("체크아웃")]
		public DateTime CheckOut { get; set; }
		/// <summary>
		/// 객실수
		/// </summary>
		[Column("객실수")]
		public int GuestRoomCount { get; set; }
		/// <summary>
		/// 호텔등급
		/// </summary>
		[Column("호텔등급")]
		public string HotelClass { get; set; }
		/// <summary>
		/// 식사
		/// </summary>
		[Column("식사")]
		public string Meal { get; set; }
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
		/// 출발일2
		/// </summary>
		[Column("출발일2")]
		public DateTime DepartureDate2 { get; set; }
		/// <summary>
		/// 도착일2
		/// </summary>
		[Column("도착일2")]
		public DateTime ArrivalDate2 { get; set; }
		/// <summary>
		/// 출발시간2
		/// </summary>
		[Column("출발시간2")]
		public string DepartureTime2 { get; set; }
		/// <summary>
		/// 도착시간2
		/// </summary>
		[Column("도착시간2")]
		public string ArrivalTime2 { get; set; }
		/// <summary>
		/// 출발일3
		/// </summary>
		[Column("출발일3")]
		public DateTime DepartureDate3 { get; set; }
		/// <summary>
		/// 도착일3
		/// </summary>
		[Column("도착일3")]
		public DateTime ArrivalDate3 { get; set; }
		/// <summary>
		/// 출발시간3
		/// </summary>
		[Column("출발시간3")]
		public string DepartureTime3 { get; set; }
		/// <summary>
		/// 도착시간3
		/// </summary>
		[Column("도착시간3")]
		public string ArrivalTime3 { get; set; }
		/// <summary>
		/// 출발국가
		/// </summary>
		[Column("출발국가")]
		public string DepartureCountry { get; set; }
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
		/// 출발국가2
		/// </summary>
		[Column("출발국가2")]
		public string DepartureCountry2 { get; set; }
		/// <summary>
		/// 출발도시2
		/// </summary>
		[Column("출발도시2")]
		public string DepartureCity2 { get; set; }
		/// <summary>
		/// 도착국가2
		/// </summary>
		[Column("도착국가2")]
		public string ArrivalCountry2 { get; set; }
		/// <summary>
		/// 도착도시2
		/// </summary>
		[Column("도착도시2")]
		public string ArrivalCity2 { get; set; }
		/// <summary>
		/// 출발국가3
		/// </summary>
		[Column("출발국가3")]
		public string DepartureCountry3 { get; set; }
		/// <summary>
		/// 출발도시3
		/// </summary>
		[Column("출발도시3")]
		public string DepartureCity3 { get; set; }
		/// <summary>
		/// 도착국가3
		/// </summary>
		[Column("도착국가3")]
		public string ArrivalCountry3 { get; set; }
		/// <summary>
		/// 도착도시3
		/// </summary>
		[Column("도착도시3")]
		public string ArrivalCity3 { get; set; }
		/// <summary>
		/// 항공구분
		/// </summary>
		[Column("항공구분")]
		public string FlightClassification { get; set; }
		/// <summary>
		/// 신청일
		/// </summary>
		[Column("신청일")]
		public DateTime RequestDate { get; set; }
		/// <summary>
		/// 수정불가여부
		/// </summary>
		[Column("수정불가여부")]
		public string EditionImpossibleOrNot { get; set; }
		/// <summary>
		/// 확정객실수
		/// </summary>
		[Column("확정객실수")]
		public int ConfirmGuestRoomNumber { get; set; }
		/// <summary>
		/// 확정박수
		/// </summary>
		[Column("확정박수")]
		public int ConfirmNightsNumber { get; set; }
		/// <summary>
		/// 비자진행상태
		/// </summary>
		[Column("비자진행상태")]
		public string VisaProgressState { get; set; }
		/// <summary>
		/// 확정인원
		/// </summary>
		[Column("확정인원")]
		public int ConfirmNumberOfPeople { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 명단번호
		/// </summary>
		[Column("명단번호")]
		public int NameListNumber { get; set; }
		/// <summary>
		/// 세부번호
		/// </summary>
		[Column("세부번호")]
		public int DetailNumber { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문성
		/// </summary>
		[Column("영문성")]
		public string EnglishLastName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Column("생년월일")]
		public DateTime BirthYearMonthDay { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 탑승객정보
		/// </summary>
		[Column("탑승객정보")]
		public string PassengerInfo { get; set; }
		/// <summary>
		/// 수령주소
		/// </summary>
		[Column("수령주소")]
		public string ReceiptAddress { get; set; }
		/// <summary>
		/// 객실번호
		/// </summary>
		[Column("객실번호")]
		public int GuestRoomNumber { get; set; }
		/// <summary>
		/// 휴대전화
		/// </summary>
		[Column("휴대전화")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 직급
		/// </summary>
		[Column("직급")]
		public string JobPosition { get; set; }
		/// <summary>
		/// 우편번호
		/// </summary>
		[Column("우편번호")]
		public string ZipCode { get; set; }
		/// <summary>
		/// 회원번호
		/// </summary>
		[Column("회원번호")]
		public int MemberNumber { get; set; }
	}
}