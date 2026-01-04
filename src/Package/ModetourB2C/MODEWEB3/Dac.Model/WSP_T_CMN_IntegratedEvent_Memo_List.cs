namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_통합이벤트_메모_리스트
/// </summary>
public class WSP_T_CMN_IntegratedEvent_Memo_List
{
	public const string SP_NAME = "WSP_T_CMN_통합이벤트_메모_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Description("이벤트번호")]
		public int EventNumber { get; set; }
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
		/// <summary>
		/// 날짜1
		/// </summary>
		[Description("날짜1")]
		public DateTime Date1 { get; set; }
		/// <summary>
		/// 날짜2
		/// </summary>
		[Description("날짜2")]
		public DateTime Date2 { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Column("이벤트번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// ptid
		/// </summary>
		[Column("ptid")]
		public int ptid { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Column("상태1")]
		public string State1 { get; set; }
		/// <summary>
		/// 상태2
		/// </summary>
		[Column("상태2")]
		public string State2 { get; set; }
		/// <summary>
		/// 상태3
		/// </summary>
		[Column("상태3")]
		public string State3 { get; set; }
		/// <summary>
		/// 번호1
		/// </summary>
		[Column("번호1")]
		public int Number1 { get; set; }
		/// <summary>
		/// 번호2
		/// </summary>
		[Column("번호2")]
		public int Number2 { get; set; }
		/// <summary>
		/// 번호3
		/// </summary>
		[Column("번호3")]
		public int Number3 { get; set; }
		/// <summary>
		/// 평점
		/// </summary>
		[Column("평점")]
		public short Rating { get; set; }
		/// <summary>
		/// 아이피
		/// </summary>
		[Column("아이피")]
		public string IP { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 삭제
		/// </summary>
		[Column("삭제")]
		public string Delete { get; set; }
		/// <summary>
		/// 전체게시글수
		/// </summary>
		[Column("전체게시글수")]
		public int EntirePostCharactersNumber { get; set; }
		/// <summary>
		/// 제거게시물수
		/// </summary>
		[Column("제거게시물수")]
		public int RemovedPostNumber { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 참여자수중복제거
		/// </summary>
		[Column("참여자수중복제거")]
		public int JoinerNumberDuplicatedRemoved { get; set; }
		/// <summary>
		/// 참여자수중복미제거
		/// </summary>
		[Column("참여자수중복미제거")]
		public int JoinerNumberDuplicated미Removed { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Column("이벤트번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// ptid
		/// </summary>
		[Column("ptid")]
		public int ptid { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Column("상태1")]
		public string State1 { get; set; }
		/// <summary>
		/// 상태2
		/// </summary>
		[Column("상태2")]
		public string State2 { get; set; }
		/// <summary>
		/// 상태3
		/// </summary>
		[Column("상태3")]
		public string State3 { get; set; }
		/// <summary>
		/// 번호1
		/// </summary>
		[Column("번호1")]
		public int Number1 { get; set; }
		/// <summary>
		/// 번호2
		/// </summary>
		[Column("번호2")]
		public int Number2 { get; set; }
		/// <summary>
		/// 번호3
		/// </summary>
		[Column("번호3")]
		public int Number3 { get; set; }
		/// <summary>
		/// 평점
		/// </summary>
		[Column("평점")]
		public short Rating { get; set; }
		/// <summary>
		/// 아이피
		/// </summary>
		[Column("아이피")]
		public string IP { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 삭제
		/// </summary>
		[Column("삭제")]
		public string Delete { get; set; }
		/// <summary>
		/// 전체게시글수
		/// </summary>
		[Column("전체게시글수")]
		public int EntirePostCharactersNumber { get; set; }
		/// <summary>
		/// 제거게시물수
		/// </summary>
		[Column("제거게시물수")]
		public int RemovedPostNumber { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 추천수
		/// </summary>
		[Column("추천수")]
		public int RecommendNumber { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Column("이벤트번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// ptid
		/// </summary>
		[Column("ptid")]
		public int ptid { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Column("상태1")]
		public string State1 { get; set; }
		/// <summary>
		/// 상태2
		/// </summary>
		[Column("상태2")]
		public string State2 { get; set; }
		/// <summary>
		/// 상태3
		/// </summary>
		[Column("상태3")]
		public string State3 { get; set; }
		/// <summary>
		/// 번호1
		/// </summary>
		[Column("번호1")]
		public int Number1 { get; set; }
		/// <summary>
		/// 번호2
		/// </summary>
		[Column("번호2")]
		public int Number2 { get; set; }
		/// <summary>
		/// 번호3
		/// </summary>
		[Column("번호3")]
		public int Number3 { get; set; }
		/// <summary>
		/// 평점
		/// </summary>
		[Column("평점")]
		public short Rating { get; set; }
		/// <summary>
		/// 아이피
		/// </summary>
		[Column("아이피")]
		public string IP { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 삭제
		/// </summary>
		[Column("삭제")]
		public string Delete { get; set; }
		/// <summary>
		/// 전체게시글수
		/// </summary>
		[Column("전체게시글수")]
		public int EntirePostCharactersNumber { get; set; }
		/// <summary>
		/// 제거게시물수
		/// </summary>
		[Column("제거게시물수")]
		public int RemovedPostNumber { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 당첨여부
		/// </summary>
		[Column("당첨여부")]
		public string WinnerOrNot { get; set; }
		/// <summary>
		/// 추천수
		/// </summary>
		[Column("추천수")]
		public int RecommendNumber { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Column("이벤트번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// ptid
		/// </summary>
		[Column("ptid")]
		public int ptid { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Column("상태1")]
		public string State1 { get; set; }
		/// <summary>
		/// 상태2
		/// </summary>
		[Column("상태2")]
		public string State2 { get; set; }
		/// <summary>
		/// 상태3
		/// </summary>
		[Column("상태3")]
		public string State3 { get; set; }
		/// <summary>
		/// 번호1
		/// </summary>
		[Column("번호1")]
		public int Number1 { get; set; }
		/// <summary>
		/// 번호2
		/// </summary>
		[Column("번호2")]
		public int Number2 { get; set; }
		/// <summary>
		/// 번호3
		/// </summary>
		[Column("번호3")]
		public int Number3 { get; set; }
		/// <summary>
		/// 평점
		/// </summary>
		[Column("평점")]
		public short Rating { get; set; }
		/// <summary>
		/// 아이피
		/// </summary>
		[Column("아이피")]
		public string IP { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 삭제
		/// </summary>
		[Column("삭제")]
		public string Delete { get; set; }
		/// <summary>
		/// 전체게시글수
		/// </summary>
		[Column("전체게시글수")]
		public int EntirePostCharactersNumber { get; set; }
		/// <summary>
		/// 제거게시물수
		/// </summary>
		[Column("제거게시물수")]
		public int RemovedPostNumber { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 추천수
		/// </summary>
		[Column("추천수")]
		public int RecommendNumber { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// 입찰가
		/// </summary>
		[Column("입찰가")]
		public int Tenderer { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// 경품1
		/// </summary>
		[Column("경품1")]
		public int Giveaway1 { get; set; }
		/// <summary>
		/// 경품2
		/// </summary>
		[Column("경품2")]
		public int Giveaway2 { get; set; }
	}

	public class Result8 : IDbResult
	{
		/// <summary>
		/// 경품1
		/// </summary>
		[Column("경품1")]
		public int Giveaway1 { get; set; }
		/// <summary>
		/// 경품2
		/// </summary>
		[Column("경품2")]
		public int Giveaway2 { get; set; }
		/// <summary>
		/// 경품3
		/// </summary>
		[Column("경품3")]
		public int Giveaway3 { get; set; }
		/// <summary>
		/// 경품4
		/// </summary>
		[Column("경품4")]
		public int Giveaway4 { get; set; }
		/// <summary>
		/// 경품5
		/// </summary>
		[Column("경품5")]
		public int Giveaway5 { get; set; }
	}

	public class Result9 : IDbResult
	{
		/// <summary>
		/// 경품1
		/// </summary>
		[Column("경품1")]
		public int Giveaway1 { get; set; }
		/// <summary>
		/// 경품2
		/// </summary>
		[Column("경품2")]
		public int Giveaway2 { get; set; }
		/// <summary>
		/// 경품3
		/// </summary>
		[Column("경품3")]
		public int Giveaway3 { get; set; }
		/// <summary>
		/// 경품4
		/// </summary>
		[Column("경품4")]
		public int Giveaway4 { get; set; }
	}

	public class Result10 : IDbResult
	{
		/// <summary>
		/// 경품1
		/// </summary>
		[Column("경품1")]
		public int Giveaway1 { get; set; }
		/// <summary>
		/// 경품2
		/// </summary>
		[Column("경품2")]
		public int Giveaway2 { get; set; }
		/// <summary>
		/// 경품3
		/// </summary>
		[Column("경품3")]
		public int Giveaway3 { get; set; }
	}

	public class Result11 : IDbResult
	{
		/// <summary>
		/// 토탈
		/// </summary>
		[Column("토탈")]
		public int Total { get; set; }
	}
}