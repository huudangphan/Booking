namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// UP_전자결재_메뉴
/// </summary>
public class UP_DigitalApproval_Menu
{
	public const string SP_NAME = "UP_전자결재_메뉴";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
		/// <summary>
		/// 결재함명
		/// </summary>
		[Column("결재함명")]
		public string ApprovalName { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 부서코드
		/// </summary>
		[Column("부서코드")]
		public int DepartmentCode { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 본부명
		/// </summary>
		[Column("본부명")]
		public string HeadofficeName { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 부서명
		/// </summary>
		[Column("부서명")]
		public int DepartmentName { get; set; }
		/// <summary>
		/// 메뉴명
		/// </summary>
		[Column("메뉴명")]
		public string MenuName { get; set; }
	}
}