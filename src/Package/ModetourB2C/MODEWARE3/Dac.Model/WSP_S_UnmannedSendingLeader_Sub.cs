namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_서브
/// </summary>
public class WSP_S_UnmannedSendingLeader_Sub
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_서브";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 행사번호
		/// </summary>
		[Description("행사번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
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
		/// 여정기간
		/// </summary>
		[Column("여정기간")]
		public string JourneyPeriod { get; set; }
		/// <summary>
		/// 미팅시간
		/// </summary>
		[Column("미팅시간")]
		public string MeetingTime { get; set; }
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
		/// 출발편
		/// </summary>
		[Column("출발편")]
		public string DepartureFlight { get; set; }
		/// <summary>
		/// 도착편
		/// </summary>
		[Column("도착편")]
		public string ReturnFlight { get; set; }
		/// <summary>
		/// 출발도시
		/// </summary>
		[Column("출발도시")]
		public string DepartureCity { get; set; }
		/// <summary>
		/// 도착도시
		/// </summary>
		[Column("도착도시")]
		public string ArrivalCity { get; set; }
		/// <summary>
		/// 성인
		/// </summary>
		[Column("성인")]
		public int Adult { get; set; }
		/// <summary>
		/// 아동
		/// </summary>
		[Column("아동")]
		public int Children { get; set; }
		/// <summary>
		/// 유아
		/// </summary>
		[Column("유아")]
		public int Toddler { get; set; }
		/// <summary>
		/// 총여행객
		/// </summary>
		[Column("총여행객")]
		public int TotalTravelCustomer { get; set; }
		/// <summary>
		/// 상품OP
		/// </summary>
		[Column("상품OP")]
		public string Product_OP { get; set; }
		/// <summary>
		/// 항공담당
		/// </summary>
		[Column("항공담당")]
		public string FlightResponsibility { get; set; }
		/// <summary>
		/// 미팅장소
		/// </summary>
		[Column("미팅장소")]
		public string MeetingPlace { get; set; }
		/// <summary>
		/// 마감상태
		/// </summary>
		[Column("마감상태")]
		public string EndStatus { get; set; }
		/// <summary>
		/// 상품OP휴대폰
		/// </summary>
		[Column("상품OP휴대폰")]
		public string ProductOPPhoneNumber { get; set; }
		/// <summary>
		/// 항공담당휴대폰
		/// </summary>
		[Column("항공담당휴대폰")]
		public string FlightManagePhoneNumber { get; set; }
		/// <summary>
		/// 팀수
		/// </summary>
		[Column("팀수")]
		public int NumberOfTeams { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 분류
		/// </summary>
		[Column("분류")]
		public string Classification { get; set; }
		/// <summary>
		/// 메인
		/// </summary>
		[Column("메인")]
		public string Main { get; set; }
		/// <summary>
		/// 분류1
		/// </summary>
		[Column("분류1")]
		public byte Classification1 { get; set; }
		/// <summary>
		/// 분류2
		/// </summary>
		[Column("분류2")]
		public byte Classification2 { get; set; }
		/// <summary>
		/// 예약번호
		/// </summary>
		[Column("예약번호")]
		public int BookingNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 대표
		/// </summary>
		[Column("대표")]
		public string Representative { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 나이
		/// </summary>
		[Column("나이")]
		public int Age { get; set; }
		/// <summary>
		/// 방번호
		/// </summary>
		[Column("방번호")]
		public int RoomNumber { get; set; }
		/// <summary>
		/// 랜드
		/// </summary>
		[Column("랜드")]
		public string Land { get; set; }
		/// <summary>
		/// DEC_HP
		/// </summary>
		[Column("DEC_HP")]
		public string DEC_HP { get; set; }
		/// <summary>
		/// 계약동의
		/// </summary>
		[Column("계약동의")]
		public string ContractAgreement { get; set; }
		/// <summary>
		/// 센딩팩전송여부
		/// </summary>
		[Column("센딩팩전송여부")]
		public string SendingBackTransmissionOrNot { get; set; }
		/// <summary>
		/// 아이콘비활성화
		/// </summary>
		[Column("아이콘비활성화")]
		public string IconFeeActivate { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 랜드사명
		/// </summary>
		[Column("랜드사명")]
		public string LandCompanyName { get; set; }
		/// <summary>
		/// 연락처1
		/// </summary>
		[Column("연락처1")]
		public string Contact1 { get; set; }
		/// <summary>
		/// 연락처2
		/// </summary>
		[Column("연락처2")]
		public string Contact2 { get; set; }
		/// <summary>
		/// 연락처3
		/// </summary>
		[Column("연락처3")]
		public string Contact3 { get; set; }
	}
}