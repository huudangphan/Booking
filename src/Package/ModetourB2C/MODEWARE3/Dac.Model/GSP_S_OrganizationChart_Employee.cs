namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_S_조직도_직원
/// </summary>
public class GSP_S_OrganizationChart_Employee
{
	public const string SP_NAME = "GSP_S_조직도_직원";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 부서번호
		/// </summary>
		[Description("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 자신포함
		/// </summary>
		[Description("자신포함")]
		public string OneselfIncluded { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 스텝1
		/// </summary>
		[Column("스텝1")]
		public string Step1 { get; set; }
		/// <summary>
		/// 상위부서코드
		/// </summary>
		[Column("상위부서코드")]
		public int HighRankDepartmentCode { get; set; }
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
		/// 소트
		/// </summary>
		[Column("소트")]
		public string Sort { get; set; }
		/// <summary>
		/// 직원
		/// </summary>
		[Column("직원")]
		public string Employee { get; set; }
	}
}