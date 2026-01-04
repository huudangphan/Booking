namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_루밍리스트
/// </summary>
public class WSP_S_UnmannedSendingLeader_RoomingList
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_루밍리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 주문일
		/// </summary>
		[Column("주문일")]
		public DateTime OrderDate { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 방번호
		/// </summary>
		[Column("방번호")]
		public int RoomNumber { get; set; }
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
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 기타정보
		/// </summary>
		[Column("기타정보")]
		public string OtherInfo { get; set; }
		/// <summary>
		/// 순번
		/// </summary>
		[Column("순번")]
		public int Order { get; set; }
		/// <summary>
		/// 객실타입
		/// </summary>
		[Column("객실타입")]
		public string GuestRoomType { get; set; }
		/// <summary>
		/// 나이
		/// </summary>
		[Column("나이")]
		public int Age { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 인원
		/// </summary>
		[Column("인원")]
		public int NumberOfPeople { get; set; }
	}
}