namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_인센티브_상태
/// </summary>
public class WSP_S_Incentive_State
{
	public const string SP_NAME = "WSP_S_인센티브_상태";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 부서번호
		/// </summary>
		[Description("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 영업상태
		/// </summary>
		[Column("영업상태")]
		public string BusinessState { get; set; }
		/// <summary>
		/// 건수
		/// </summary>
		[Column("건수")]
		public int Numberofcases { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 상품상태
		/// </summary>
		[Column("상품상태")]
		public string ProductState { get; set; }
		/// <summary>
		/// 건수
		/// </summary>
		[Column("건수")]
		public int Numberofcases { get; set; }
	}
}