namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_센딩_무인센딩
/// </summary>
public class WSP_S_Sending_UnmannedSending
{
	public const string SP_NAME = "WSP_S_센딩_무인센딩";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 출발일
		/// </summary>
		[Description("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 장소
		/// </summary>
		[Description("장소")]
		public string Place { get; set; }
		/// <summary>
		/// 장소2
		/// </summary>
		[Description("장소2")]
		public string Place2 { get; set; }
		/// <summary>
		/// 공항
		/// </summary>
		[Description("공항")]
		public string Airport { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 내항기여부
		/// </summary>
		[Column("내항기여부")]
		public string TransitFlightOrNot { get; set; }
		/// <summary>
		/// 선택
		/// </summary>
		[Column("선택")]
		public string Select { get; set; }
		/// <summary>
		/// 여행자계약서
		/// </summary>
		[Column("여행자계약서")]
		public string TravelerContract { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
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
		/// 출발항공편
		/// </summary>
		[Column("출발항공편")]
		public string DepartureFlight { get; set; }
		/// <summary>
		/// 미팅시간
		/// </summary>
		[Column("미팅시간")]
		public string MeetingTime { get; set; }
		/// <summary>
		/// 출발시간
		/// </summary>
		[Column("출발시간")]
		public string DepartureTime { get; set; }
		/// <summary>
		/// 인원
		/// </summary>
		[Column("인원")]
		public int NumberOfPeople { get; set; }
		/// <summary>
		/// 인솔자
		/// </summary>
		[Column("인솔자")]
		public string Leader { get; set; }
		/// <summary>
		/// 센딩자
		/// </summary>
		[Column("센딩자")]
		public string Sender { get; set; }
		/// <summary>
		/// 인솔자비고
		/// </summary>
		[Column("인솔자비고")]
		public string LeaderNote { get; set; }
		/// <summary>
		/// 센딩비고
		/// </summary>
		[Column("센딩비고")]
		public string SendingNote { get; set; }
		/// <summary>
		/// 외국이디
		/// </summary>
		[Column("외국이디")]
		public string ForeignID { get; set; }
		/// <summary>
		/// 센딩배정
		/// </summary>
		[Column("센딩배정")]
		public string SendingAssign { get; set; }
		/// <summary>
		/// 허브라운지
		/// </summary>
		[Column("허브라운지")]
		public string HubLounge { get; set; }
		/// <summary>
		/// 수배담당
		/// </summary>
		[Column("수배담당")]
		public string WantedResponsibility { get; set; }
		/// <summary>
		/// 항공담당
		/// </summary>
		[Column("항공담당")]
		public string FlightResponsibility { get; set; }
		/// <summary>
		/// 팀예약건수
		/// </summary>
		[Column("팀예약건수")]
		public int TeamReservationNumberOfCase { get; set; }
		/// <summary>
		/// 공항간략
		/// </summary>
		[Column("공항간략")]
		public string AirportBrief { get; set; }
		/// <summary>
		/// 카운터
		/// </summary>
		[Column("카운터")]
		public string Counter { get; set; }
		/// <summary>
		/// 센딩방법_기기_총인원
		/// </summary>
		[Column("센딩방법_기기_총인원")]
		public int SendingWay_Equipment_TotalNumberOfPeople { get; set; }
		/// <summary>
		/// 센딩방법_직원_총인원
		/// </summary>
		[Column("센딩방법_직원_총인원")]
		public int SendingWay_Employee_TotalNumberOfPeople { get; set; }
		/// <summary>
		/// 센딩방법_기기_팀예약건수
		/// </summary>
		[Column("센딩방법_기기_팀예약건수")]
		public int SendingWay_Equipment_TeamReservationNumberOfCase { get; set; }
		/// <summary>
		/// 센딩방법_직원_팀예약건수
		/// </summary>
		[Column("센딩방법_직원_팀예약건수")]
		public int SendingWay_Employee_TeamReservationNumberOfCase { get; set; }
	}
}