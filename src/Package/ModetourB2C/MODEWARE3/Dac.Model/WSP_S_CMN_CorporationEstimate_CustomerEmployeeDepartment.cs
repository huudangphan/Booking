namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_법인견적_거래처사원부서
/// </summary>
public class WSP_S_CMN_CorporationEstimate_CustomerEmployeeDepartment
{
	public const string SP_NAME = "WSP_S_CMN_법인견적_거래처사원부서";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 부서
		/// </summary>
		[Column("부서")]
		public int Department { get; set; }
		/// <summary>
		/// 사원
		/// </summary>
		[Column("사원")]
		public int Staff { get; set; }
	}
}