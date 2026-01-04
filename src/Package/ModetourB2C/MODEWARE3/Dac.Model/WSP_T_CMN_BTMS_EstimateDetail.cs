namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_BTMS_견적세부
/// </summary>
public class WSP_T_CMN_BTMS_EstimateDetail
{
	public const string SP_NAME = "WSP_T_CMN_BTMS_견적세부";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 세부번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("세부번호")]
		public int DetailNumber { get; set; }
		/// <summary>
		/// 요청분류
		/// </summary>
		[Description("요청분류")]
		public string RequestClassification { get; set; }
		/// <summary>
		/// 요청구분
		/// </summary>
		[Description("요청구분")]
		public string RequestClassification2 { get; set; }
		/// <summary>
		/// 견적번호
		/// </summary>
		[Description("견적번호")]
		public int EstimateNumber { get; set; }
		/// <summary>
		/// 견적상태
		/// </summary>
		[Description("견적상태")]
		public string EstimateState { get; set; }
		/// <summary>
		/// 접수자
		/// </summary>
		[Description("접수자")]
		public int Receiver { get; set; }
		/// <summary>
		/// 요청사항
		/// </summary>
		[Description("요청사항")]
		public string Request { get; set; }
		/// <summary>
		/// 체류기간
		/// </summary>
		[Description("체류기간")]
		public string SojournPeriod { get; set; }
		/// <summary>
		/// 성인인원
		/// </summary>
		[Description("성인인원")]
		public int AdultNumberOfPeople { get; set; }
		/// <summary>
		/// 소아인원
		/// </summary>
		[Description("소아인원")]
		public int KidNumberOfPeople { get; set; }
		/// <summary>
		/// 선호항공
		/// </summary>
		[Description("선호항공")]
		public string PreferenceFlight { get; set; }
		/// <summary>
		/// 좌석등급
		/// </summary>
		[Description("좌석등급")]
		public string SeatClass { get; set; }
		/// <summary>
		/// 체크인
		/// </summary>
		[Description("체크인")]
		public DateTime CheckIn { get; set; }
		/// <summary>
		/// 체크아웃
		/// </summary>
		[Description("체크아웃")]
		public DateTime CheckOut { get; set; }
		/// <summary>
		/// 객실수
		/// </summary>
		[Description("객실수")]
		public int GuestRoomCount { get; set; }
		/// <summary>
		/// 호텔등급
		/// </summary>
		[Description("호텔등급")]
		public string HotelClass { get; set; }
		/// <summary>
		/// 식사
		/// </summary>
		[Description("식사")]
		public string Meal { get; set; }
		/// <summary>
		/// 항공구분
		/// </summary>
		[Description("항공구분")]
		public string FlightClassification { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Description("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Description("도착일")]
		public DateTime ArrivalDate { get; set; }
		/// <summary>
		/// 출발일2
		/// </summary>
		[Description("출발일2")]
		public DateTime DepartureDate2 { get; set; }
		/// <summary>
		/// 도착일2
		/// </summary>
		[Description("도착일2")]
		public DateTime ArrivalDate2 { get; set; }
		/// <summary>
		/// 출발일3
		/// </summary>
		[Description("출발일3")]
		public DateTime DepartureDate3 { get; set; }
		/// <summary>
		/// 도착일3
		/// </summary>
		[Description("도착일3")]
		public DateTime ArrivalDate3 { get; set; }
		/// <summary>
		/// 출발시간
		/// </summary>
		[Description("출발시간")]
		public string DepartureTime { get; set; }
		/// <summary>
		/// 도착시간
		/// </summary>
		[Description("도착시간")]
		public string ArrivalTime { get; set; }
		/// <summary>
		/// 출발시간2
		/// </summary>
		[Description("출발시간2")]
		public string DepartureTime2 { get; set; }
		/// <summary>
		/// 도착시간2
		/// </summary>
		[Description("도착시간2")]
		public string ArrivalTime2 { get; set; }
		/// <summary>
		/// 출발시간3
		/// </summary>
		[Description("출발시간3")]
		public string DepartureTime3 { get; set; }
		/// <summary>
		/// 도착시간3
		/// </summary>
		[Description("도착시간3")]
		public string ArrivalTime3 { get; set; }
		/// <summary>
		/// 출발국가
		/// </summary>
		[Description("출발국가")]
		public string DepartureCountry { get; set; }
		/// <summary>
		/// 도착국가
		/// </summary>
		[Description("도착국가")]
		public string ArrivalCountry { get; set; }
		/// <summary>
		/// 출발국가2
		/// </summary>
		[Description("출발국가2")]
		public string DepartureCountry2 { get; set; }
		/// <summary>
		/// 도착국가2
		/// </summary>
		[Description("도착국가2")]
		public string ArrivalCountry2 { get; set; }
		/// <summary>
		/// 출발국가3
		/// </summary>
		[Description("출발국가3")]
		public string DepartureCountry3 { get; set; }
		/// <summary>
		/// 도착국가3
		/// </summary>
		[Description("도착국가3")]
		public string ArrivalCountry3 { get; set; }
		/// <summary>
		/// 출발도시
		/// </summary>
		[Description("출발도시")]
		public string DepartureCity { get; set; }
		/// <summary>
		/// 도착도시
		/// </summary>
		[Description("도착도시")]
		public string ArrivalCity { get; set; }
		/// <summary>
		/// 출발도시2
		/// </summary>
		[Description("출발도시2")]
		public string DepartureCity2 { get; set; }
		/// <summary>
		/// 도착도시2
		/// </summary>
		[Description("도착도시2")]
		public string ArrivalCity2 { get; set; }
		/// <summary>
		/// 출발도시3
		/// </summary>
		[Description("출발도시3")]
		public string DepartureCity3 { get; set; }
		/// <summary>
		/// 도착도시3
		/// </summary>
		[Description("도착도시3")]
		public string ArrivalCity3 { get; set; }
	}

}