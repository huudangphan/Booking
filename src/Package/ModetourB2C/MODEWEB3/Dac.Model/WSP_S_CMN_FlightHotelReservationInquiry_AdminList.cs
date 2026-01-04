namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_항공호텔예약문의_관리자리스트
/// </summary>
public class WSP_S_CMN_FlightHotelReservationInquiry_AdminList
{
	public const string SP_NAME = "WSP_S_CMN_항공호텔예약문의_관리자리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 예약구분
		/// </summary>
		[Description("예약구분")]
		public string BookingClassification { get; set; }
		/// <summary>
		/// 예약구분1
		/// </summary>
		[Description("예약구분1")]
		public string BookingClassification1 { get; set; }
		/// <summary>
		/// 현재페이지
		/// </summary>
		[Description("현재페이지")]
		public int CurrentPage { get; set; }
		/// <summary>
		/// 페이지당글개수
		/// </summary>
		[Description("페이지당글개수")]
		public int EachPageCharactersNumber { get; set; }
		/// <summary>
		/// 전체게시글수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체게시글수")]
		public int EntirePostCharactersNumber { get; set; }
		/// <summary>
		/// 전체페이지수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체페이지수")]
		public int EntirePageNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 순번
		/// </summary>
		[Column("순번")]
		public long Order { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 예약구분
		/// </summary>
		[Column("예약구분")]
		public string BookingClassification { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public DateTime WrittingDate { get; set; }
		/// <summary>
		/// 답변상태
		/// </summary>
		[Column("답변상태")]
		public string AnswerState { get; set; }
		/// <summary>
		/// 문의구분
		/// </summary>
		[Column("문의구분")]
		public string InquiryClassification { get; set; }
		/// <summary>
		/// 예약담당자
		/// </summary>
		[Column("예약담당자")]
		public string BookingManager { get; set; }
		/// <summary>
		/// 예약담당자명
		/// </summary>
		[Column("예약담당자명")]
		public string BookingManagerName { get; set; }
	}
}