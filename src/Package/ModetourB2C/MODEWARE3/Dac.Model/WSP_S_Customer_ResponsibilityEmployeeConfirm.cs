namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_거래처_담당직원확인
/// </summary>
public class WSP_S_Customer_ResponsibilityEmployeeConfirm
{
	public const string SP_NAME = "WSP_S_거래처_담당직원확인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 여행사명
		/// </summary>
		[Description("여행사명")]
		public string TravelCompanyName { get; set; }
		/// <summary>
		/// 담당직원명
		/// </summary>
		[Description("담당직원명")]
		public string ResponsibilityEmployeeName { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public int Column1 { get; set; }
	}
}