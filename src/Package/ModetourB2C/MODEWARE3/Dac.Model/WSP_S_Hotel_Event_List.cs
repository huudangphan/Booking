namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_호텔_이벤트_리스트
/// </summary>
public class WSP_S_Hotel_Event_List
{
	public const string SP_NAME = "WSP_S_호텔_이벤트_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Type
		/// </summary>
		[Description("Type")]
		public string Type { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 클래스
		/// </summary>
		[Column("클래스")]
		public string Class { get; set; }
		/// <summary>
		/// 예약시작일
		/// </summary>
		[Column("예약시작일")]
		public DateTime BookingStartDate { get; set; }
		/// <summary>
		/// 예약종료일
		/// </summary>
		[Column("예약종료일")]
		public DateTime BookingEndDate { get; set; }
		/// <summary>
		/// 체크인시작일
		/// </summary>
		[Column("체크인시작일")]
		public DateTime CheckInStartDate { get; set; }
		/// <summary>
		/// 체크인종료일
		/// </summary>
		[Column("체크인종료일")]
		public DateTime CheckInEndDate { get; set; }
		/// <summary>
		/// 숙박일
		/// </summary>
		[Column("숙박일")]
		public byte LogmentDate { get; set; }
		/// <summary>
		/// GDS
		/// </summary>
		[Column("GDS")]
		public string GDS { get; set; }
		/// <summary>
		/// 개시여부
		/// </summary>
		[Column("개시여부")]
		public string ReleaseOrNot { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}
}