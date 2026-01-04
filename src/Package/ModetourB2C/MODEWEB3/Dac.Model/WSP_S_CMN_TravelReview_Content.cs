namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_여행후기_내용
/// </summary>
public class WSP_S_CMN_TravelReview_Content
{
	public const string SP_NAME = "WSP_S_CMN_여행후기_내용";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Description("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 상품코드2
		/// </summary>
		[Description("상품코드2")]
		public string ProductCode2 { get; set; }
		/// <summary>
		/// 거래처
		/// </summary>
		[Description("거래처")]
		public int Customer { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 글쓴이
		/// </summary>
		[Column("글쓴이")]
		public string Writer { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 일정타입
		/// </summary>
		[Column("일정타입")]
		public string ScheduleType { get; set; }
		/// <summary>
		/// 단체명
		/// </summary>
		[Column("단체명")]
		public string GroupName { get; set; }
		/// <summary>
		/// MLoc
		/// </summary>
		[Column("MLoc")]
		public string MLoc { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 만족도
		/// </summary>
		[Column("만족도")]
		public string SatisfactionRate { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 오픈
		/// </summary>
		[Column("오픈")]
		public string Open { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 추천
		/// </summary>
		[Column("추천")]
		public int Recommend { get; set; }
		/// <summary>
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
		/// <summary>
		/// 사이트
		/// </summary>
		[Column("사이트")]
		public string Site { get; set; }
		/// <summary>
		/// 핸드폰
		/// </summary>
		[Column("핸드폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 이벤트
		/// </summary>
		[Column("이벤트")]
		public string Event { get; set; }
		/// <summary>
		/// 사진
		/// </summary>
		[Column("사진")]
		public string Picture { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Column("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 위치
		/// </summary>
		[Column("위치")]
		public int Position { get; set; }
		/// <summary>
		/// 객실
		/// </summary>
		[Column("객실")]
		public int GuestRoom { get; set; }
		/// <summary>
		/// 서비스
		/// </summary>
		[Column("서비스")]
		public int Service { get; set; }
		/// <summary>
		/// 가격
		/// </summary>
		[Column("가격")]
		public int Price { get; set; }
		/// <summary>
		/// 아이템구분
		/// </summary>
		[Column("아이템구분")]
		public string ItemClassification { get; set; }
		/// <summary>
		/// 항공코드
		/// </summary>
		[Column("항공코드")]
		public string FlightCode { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 댓글번호
		/// </summary>
		[Column("댓글번호")]
		public int CommentNumber { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 별칭
		/// </summary>
		[Column("별칭")]
		public string Nickname { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public DateTime WrittingDate { get; set; }
		/// <summary>
		/// 사이트
		/// </summary>
		[Column("사이트")]
		public string Site { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Column("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public int Column1 { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}
}