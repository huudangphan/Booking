namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// GSP_S_푸쉬_MOBILE
/// </summary>
public class GSP_S_Push_MOBILE
{
	public const string SP_NAME = "GSP_S_푸쉬_MOBILE";

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
		/// 직원번호
		/// </summary>
		[Column("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 대메뉴
		/// </summary>
		[Column("대메뉴")]
		public string MainMenu { get; set; }
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
		/// 대메뉴메뉴명
		/// </summary>
		[Column("대메뉴메뉴명")]
		public string MainMenuMenuName { get; set; }
		/// <summary>
		/// 중메뉴메뉴명
		/// </summary>
		[Column("중메뉴메뉴명")]
		public string MiddleMenuMenuName { get; set; }
		/// <summary>
		/// 소메뉴메뉴명
		/// </summary>
		[Column("소메뉴메뉴명")]
		public string SubMenuMenuName { get; set; }
		/// <summary>
		/// 대메뉴경로
		/// </summary>
		[Column("대메뉴경로")]
		public string MainMenuRoute { get; set; }
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
	}
}