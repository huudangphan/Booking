namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_포토팡팡_내용
/// </summary>
public class WSP_S_CMN_Photopangpang_Content
{
	public const string SP_NAME = "WSP_S_CMN_포토팡팡_내용";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지역
		/// </summary>
		[Description("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 사이트
		/// </summary>
		[Description("사이트")]
		public string Site { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 여행지
		/// </summary>
		[Column("여행지")]
		public string TravelSpot { get; set; }
		/// <summary>
		/// 여행지2
		/// </summary>
		[Column("여행지2")]
		public string TravelSpot2 { get; set; }
		/// <summary>
		/// 사진
		/// </summary>
		[Column("사진")]
		public string Picture { get; set; }
		/// <summary>
		/// 형식
		/// </summary>
		[Column("형식")]
		public bool Format { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Column("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 정보반영
		/// </summary>
		[Column("정보반영")]
		public bool InfoReflect { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public string WrittingDate { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public int Region { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
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
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 여행구분
		/// </summary>
		[Column("여행구분")]
		public string TravelClassification { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 테마
		/// </summary>
		[Column("테마")]
		public string Theme { get; set; }
		/// <summary>
		/// 사진크기
		/// </summary>
		[Column("사진크기")]
		public string PictureSize { get; set; }
		/// <summary>
		/// 추천
		/// </summary>
		[Column("추천")]
		public int Recommend { get; set; }
	}

	public class Result2 : IDbResult
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
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public DateTime WrittingDate { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public int Region { get; set; }
	}

	public class Result3 : IDbResult
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
}