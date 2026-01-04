namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// GSP_S_중메뉴_소메뉴_리스트_MOBILE
/// </summary>
public class GSP_S_MiddleMenu_SubMenu_List_MOBILE
{
	public const string SP_NAME = "GSP_S_중메뉴_소메뉴_리스트_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 대메뉴
		/// </summary>
		[Description("대메뉴")]
		public string MainMenu { get; set; }
		/// <summary>
		/// 부서번호
		/// </summary>
		[Description("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 중메뉴
		/// </summary>
		[Column("중메뉴")]
		public string MiddleMenu { get; set; }
		/// <summary>
		/// 소메뉴
		/// </summary>
		[Column("소메뉴")]
		public string SubMenu { get; set; }
		/// <summary>
		/// 중메뉴명
		/// </summary>
		[Column("중메뉴명")]
		public string MiddleMenuName { get; set; }
		/// <summary>
		/// 소메뉴명
		/// </summary>
		[Column("소메뉴명")]
		public string SubMenuName { get; set; }
		/// <summary>
		/// 중메뉴경로
		/// </summary>
		[Column("중메뉴경로")]
		public string MiddleMenuRoute { get; set; }
		/// <summary>
		/// 소메뉴경로
		/// </summary>
		[Column("소메뉴경로")]
		public string SubMenuRoute { get; set; }
		/// <summary>
		/// 중메뉴아이콘경로
		/// </summary>
		[Column("중메뉴아이콘경로")]
		public string MiddleMenuIconRoute { get; set; }
		/// <summary>
		/// 소메뉴아이콘경로
		/// </summary>
		[Column("소메뉴아이콘경로")]
		public string SubMenuIconRoute { get; set; }
		/// <summary>
		/// 중메뉴색상
		/// </summary>
		[Column("중메뉴색상")]
		public string MiddleMenuColor { get; set; }
		/// <summary>
		/// 소메뉴색상
		/// </summary>
		[Column("소메뉴색상")]
		public string SubMenuColor { get; set; }
		/// <summary>
		/// 중메뉴클래스
		/// </summary>
		[Column("중메뉴클래스")]
		public string MiddleMenuClass { get; set; }
		/// <summary>
		/// 중메뉴순서
		/// </summary>
		[Column("중메뉴순서")]
		public byte MiddleMenuOrder { get; set; }
		/// <summary>
		/// 소메뉴순서
		/// </summary>
		[Column("소메뉴순서")]
		public byte SubMenuOrder { get; set; }
		/// <summary>
		/// 중메뉴게시판번호
		/// </summary>
		[Column("중메뉴게시판번호")]
		public string MiddleMenuBoardNumber { get; set; }
	}
}