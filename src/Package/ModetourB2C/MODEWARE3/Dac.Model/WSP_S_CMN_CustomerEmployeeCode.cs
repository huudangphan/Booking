namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_거래처직원코드
/// </summary>
public class WSP_S_CMN_CustomerEmployeeCode
{
	public const string SP_NAME = "WSP_S_CMN_거래처직원코드";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Column("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 거래처직원명
		/// </summary>
		[Column("거래처직원명")]
		public string CustomerEmployeeName { get; set; }
	}
}