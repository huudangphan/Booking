namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// GSP_S_대메뉴_리스트_MOBILE
/// </summary>
public class GSP_S_MainMenu_List_MOBILE
{
	public const string SP_NAME = "GSP_S_대메뉴_리스트_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 대메뉴
		/// </summary>
		[Column("대메뉴")]
		public string MainMenu { get; set; }
		/// <summary>
		/// 메뉴명
		/// </summary>
		[Column("메뉴명")]
		public string MenuName { get; set; }
		/// <summary>
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
		/// <summary>
		/// 아이콘경로
		/// </summary>
		[Column("아이콘경로")]
		public string IconRoute { get; set; }
		/// <summary>
		/// 메뉴색상
		/// </summary>
		[Column("메뉴색상")]
		public string MenuColor { get; set; }
		/// <summary>
		/// 메뉴클래스
		/// </summary>
		[Column("메뉴클래스")]
		public string MenuClass { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public byte Order { get; set; }
	}
}