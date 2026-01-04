namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_골프존_골프장부킹_예약조회
/// </summary>
public class WSP_S_GolfZone_GolfCourseBooking_ReservationFind
{
	public const string SP_NAME = "WSP_S_골프존_골프장부킹_예약조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상품번호
		/// </summary>
		[Description("상품번호")]
		public int ProductNumber { get; set; }
		/// <summary>
		/// IP
		/// </summary>
		[Description("IP")]
		public string IP { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 골프장예약번호
		/// </summary>
		[Column("골프장예약번호")]
		public string GolfCourseBookingNumber { get; set; }
		/// <summary>
		/// 골프장코드
		/// </summary>
		[Column("골프장코드")]
		public string GolfCourseCode { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 예약자이름
		/// </summary>
		[Column("예약자이름")]
		public string BookerName { get; set; }
		/// <summary>
		/// 라운드날짜
		/// </summary>
		[Column("라운드날짜")]
		public string RoundDate { get; set; }
		/// <summary>
		/// 티오프시간
		/// </summary>
		[Column("티오프시간")]
		public string TeeoffTime { get; set; }
		/// <summary>
		/// 코스명
		/// </summary>
		[Column("코스명")]
		public string CourseName { get; set; }
		/// <summary>
		/// 결재구분
		/// </summary>
		[Column("결재구분")]
		public string ApprovalClassification { get; set; }
		/// <summary>
		/// 결제금액
		/// </summary>
		[Column("결제금액")]
		public int PaymentAmount { get; set; }
		/// <summary>
		/// 골프장이름
		/// </summary>
		[Column("골프장이름")]
		public string GolfCourseName { get; set; }
		/// <summary>
		/// 골프장위치
		/// </summary>
		[Column("골프장위치")]
		public string GolfCoursePosition { get; set; }
		/// <summary>
		/// 결제마감일
		/// </summary>
		[Column("결제마감일")]
		public string PaymentEndDate { get; set; }
		/// <summary>
		/// 인원수
		/// </summary>
		[Column("인원수")]
		public int NumberOfPeopleNumber { get; set; }
		/// <summary>
		/// 취소여부
		/// </summary>
		[Column("취소여부")]
		public string CancelOrNot { get; set; }
		/// <summary>
		/// 입금상태
		/// </summary>
		[Column("입금상태")]
		public string DepositState { get; set; }
		/// <summary>
		/// 예약자PTID
		/// </summary>
		[Column("예약자PTID")]
		public int Booker_PTID { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 연락처
		/// </summary>
		[Column("연락처")]
		public string Contact { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// HP
		/// </summary>
		[Column("HP")]
		public string HP { get; set; }
	}
}