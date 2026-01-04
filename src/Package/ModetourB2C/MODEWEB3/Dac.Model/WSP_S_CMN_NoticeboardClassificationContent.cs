namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_게시판구분내용
/// </summary>
public class WSP_S_CMN_NoticeboardClassificationContent
{
	public const string SP_NAME = "WSP_S_CMN_게시판구분내용";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public int Classification { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 게시판명
		/// </summary>
		[Column("게시판명")]
		public string NoticeboardName { get; set; }
		/// <summary>
		/// 테이블명
		/// </summary>
		[Column("테이블명")]
		public string TableName { get; set; }
		/// <summary>
		/// 스킨명1
		/// </summary>
		[Column("스킨명1")]
		public string SkinName1 { get; set; }
		/// <summary>
		/// 스킨명2
		/// </summary>
		[Column("스킨명2")]
		public string SkinName2 { get; set; }
		/// <summary>
		/// 스킨명3
		/// </summary>
		[Column("스킨명3")]
		public string SkinName3 { get; set; }
		/// <summary>
		/// 스킨명4
		/// </summary>
		[Column("스킨명4")]
		public string SkinName4 { get; set; }
		/// <summary>
		/// 스킨명5
		/// </summary>
		[Column("스킨명5")]
		public string SkinName5 { get; set; }
		/// <summary>
		/// 타이틀1
		/// </summary>
		[Column("타이틀1")]
		public string Title1 { get; set; }
		/// <summary>
		/// 타이틀2
		/// </summary>
		[Column("타이틀2")]
		public string Title2 { get; set; }
		/// <summary>
		/// 타이틀3
		/// </summary>
		[Column("타이틀3")]
		public string Title3 { get; set; }
		/// <summary>
		/// 타이틀4
		/// </summary>
		[Column("타이틀4")]
		public string Title4 { get; set; }
		/// <summary>
		/// 타이틀5
		/// </summary>
		[Column("타이틀5")]
		public string Title5 { get; set; }
		/// <summary>
		/// 게시판폭1
		/// </summary>
		[Column("게시판폭1")]
		public string NoticeboardWidth1 { get; set; }
		/// <summary>
		/// 게시판폭2
		/// </summary>
		[Column("게시판폭2")]
		public string NoticeboardWidth2 { get; set; }
		/// <summary>
		/// 게시판폭3
		/// </summary>
		[Column("게시판폭3")]
		public string NoticeboardWidth3 { get; set; }
		/// <summary>
		/// 게시판폭4
		/// </summary>
		[Column("게시판폭4")]
		public string NoticeboardWidth4 { get; set; }
		/// <summary>
		/// 게시판폭5
		/// </summary>
		[Column("게시판폭5")]
		public string NoticeboardWidth5 { get; set; }
		/// <summary>
		/// 스타일1
		/// </summary>
		[Column("스타일1")]
		public string Style1 { get; set; }
		/// <summary>
		/// 스타일2
		/// </summary>
		[Column("스타일2")]
		public string Style2 { get; set; }
		/// <summary>
		/// 스타일3
		/// </summary>
		[Column("스타일3")]
		public string Style3 { get; set; }
		/// <summary>
		/// 스타일4
		/// </summary>
		[Column("스타일4")]
		public string Style4 { get; set; }
		/// <summary>
		/// 스타일5
		/// </summary>
		[Column("스타일5")]
		public string Style5 { get; set; }
		/// <summary>
		/// 이메일1
		/// </summary>
		[Column("이메일1")]
		public bool Email1 { get; set; }
		/// <summary>
		/// 이메일2
		/// </summary>
		[Column("이메일2")]
		public bool Email2 { get; set; }
		/// <summary>
		/// 이메일3
		/// </summary>
		[Column("이메일3")]
		public bool Email3 { get; set; }
		/// <summary>
		/// 이메일4
		/// </summary>
		[Column("이메일4")]
		public bool Email4 { get; set; }
		/// <summary>
		/// 이메일5
		/// </summary>
		[Column("이메일5")]
		public bool Email5 { get; set; }
		/// <summary>
		/// 하단부1
		/// </summary>
		[Column("하단부1")]
		public string BottomPart1 { get; set; }
		/// <summary>
		/// 하단부2
		/// </summary>
		[Column("하단부2")]
		public string BottomPart2 { get; set; }
		/// <summary>
		/// 하단부3
		/// </summary>
		[Column("하단부3")]
		public string BottomPart3 { get; set; }
		/// <summary>
		/// 하단부4
		/// </summary>
		[Column("하단부4")]
		public string BottomPart4 { get; set; }
		/// <summary>
		/// 하단부5
		/// </summary>
		[Column("하단부5")]
		public string BottomPart5 { get; set; }
		/// <summary>
		/// 로그인1
		/// </summary>
		[Column("로그인1")]
		public bool Login1 { get; set; }
		/// <summary>
		/// 로그인2
		/// </summary>
		[Column("로그인2")]
		public bool Login2 { get; set; }
		/// <summary>
		/// 로그인3
		/// </summary>
		[Column("로그인3")]
		public bool Login3 { get; set; }
		/// <summary>
		/// 로그인4
		/// </summary>
		[Column("로그인4")]
		public bool Login4 { get; set; }
		/// <summary>
		/// 로그인5
		/// </summary>
		[Column("로그인5")]
		public bool Login5 { get; set; }
		/// <summary>
		/// 말머리1
		/// </summary>
		[Column("말머리1")]
		public string HeadOfStory1 { get; set; }
		/// <summary>
		/// 말머리2
		/// </summary>
		[Column("말머리2")]
		public string HeadOfStory2 { get; set; }
		/// <summary>
		/// 말머리3
		/// </summary>
		[Column("말머리3")]
		public string HeadOfStory3 { get; set; }
		/// <summary>
		/// 말머리4
		/// </summary>
		[Column("말머리4")]
		public string HeadOfStory4 { get; set; }
		/// <summary>
		/// 말머리5
		/// </summary>
		[Column("말머리5")]
		public string HeadOfStory5 { get; set; }
	}
}