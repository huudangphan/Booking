namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_SO_거래처
/// </summary>
public class WSP_SO_Customer
{
	public const string SP_NAME = "WSP_SO_거래처";

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
		/// AgentName
		/// </summary>
		[Column("AgentName")]
		public string AgentName { get; set; }
		/// <summary>
		/// AgentID
		/// </summary>
		[Column("AgentID")]
		public int AgentID { get; set; }
		/// <summary>
		/// AgentEmpName
		/// </summary>
		[Column("AgentEmpName")]
		public string AgentEmpName { get; set; }
		/// <summary>
		/// AgentEmpID
		/// </summary>
		[Column("AgentEmpID")]
		public int AgentEmpID { get; set; }
	}
}