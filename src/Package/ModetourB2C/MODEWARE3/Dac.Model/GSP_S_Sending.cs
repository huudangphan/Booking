namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_S_센딩
/// </summary>
public class GSP_S_Sending
{
	public const string SP_NAME = "GSP_S_센딩";

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

	public class Result1 : IDbResult
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
		/// 센딩자2
		/// </summary>
		[Column("센딩자2")]
		public string Sender2 { get; set; }
		/// <summary>
		/// 센딩자2번호
		/// </summary>
		[Column("센딩자2번호")]
		public string Sender2Number { get; set; }
		/// <summary>
		/// 허브라운지
		/// </summary>
		[Column("허브라운지")]
		public string HubLounge { get; set; }
		/// <summary>
		/// 상품담당자
		/// </summary>
		[Column("상품담당자")]
		public string ProductManager { get; set; }
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
		/// E센딩
		/// </summary>
		[Column("E센딩")]
		public int E_Sending { get; set; }
		/// <summary>
		/// 공항직원센딩
		/// </summary>
		[Column("공항직원센딩")]
		public int AirportEmployeeSending { get; set; }
		/// <summary>
		/// 책임인원
		/// </summary>
		[Column("책임인원")]
		public decimal NumberOfPeopleInCharge { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 전달사항
		/// </summary>
		[Column("전달사항")]
		public string SendingMatter { get; set; }
		/// <summary>
		/// 당직자
		/// </summary>
		[Column("당직자")]
		public string NightShiftWorker { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 당직자
		/// </summary>
		[Column("당직자")]
		public string NightShiftWorker { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 전달사항
		/// </summary>
		[Column("전달사항")]
		public string SendingMatter { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 직급
		/// </summary>
		[Column("직급")]
		public string JobPosition { get; set; }
		/// <summary>
		/// 부서
		/// </summary>
		[Column("부서")]
		public string Department { get; set; }
	}
}