namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// GSP_S_중메뉴_코드조회_MOBILE
/// </summary>
public class GSP_S_MiddleMenu_FindCode_MOBILE
{
	public const string SP_NAME = "GSP_S_중메뉴_코드조회_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 게시판번호
		/// </summary>
		[Description("게시판번호")]
		public int NoticeboardNumber { get; set; }
		/// <summary>
		/// 메뉴명
		/// </summary>
		[Description("메뉴명")]
		public string MenuName { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 대메뉴코드
		/// </summary>
		[Column("대메뉴코드")]
		public string MainMenuCode { get; set; }
		/// <summary>
		/// 중메뉴코드
		/// </summary>
		[Column("중메뉴코드")]
		public string MiddleMenuCode { get; set; }
	}
}