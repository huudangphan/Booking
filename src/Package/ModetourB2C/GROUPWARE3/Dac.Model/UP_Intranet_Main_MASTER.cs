namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// UP_인트라넷_메인_MASTER
/// </summary>
public class UP_Intranet_Main_MASTER
{
	public const string SP_NAME = "UP_인트라넷_메인_MASTER";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 부서번호
		/// </summary>
		[Description("부서번호")]
		public int DepartmentNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 양식번호
		/// </summary>
		[Column("양식번호")]
		public short FormNumber { get; set; }
		/// <summary>
		/// 중요도
		/// </summary>
		[Column("중요도")]
		public string ImportanceLevel { get; set; }
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public int Column1 { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 양식번호
		/// </summary>
		[Column("양식번호")]
		public short FormNumber { get; set; }
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public int Column1 { get; set; }
	}
}