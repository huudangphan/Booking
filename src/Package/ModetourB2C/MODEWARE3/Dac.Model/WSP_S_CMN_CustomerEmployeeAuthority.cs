namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_거래처직원권한
/// </summary>
public class WSP_S_CMN_CustomerEmployeeAuthority
{
	public const string SP_NAME = "WSP_S_CMN_거래처직원권한";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 권한
		/// </summary>
		[Description("권한")]
		public int Authority { get; set; }
		/// <summary>
		/// 거래처직원코드
		/// </summary>
		[Description("거래처직원코드")]
		public int CustomerEmployeeCode { get; set; }
		/// <summary>
		/// XMLID
		/// </summary>
		[Description("XMLID")]
		public string XMLID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Column("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 거래처직원코드
		/// </summary>
		[Column("거래처직원코드")]
		public int CustomerEmployeeCode { get; set; }
		/// <summary>
		/// XMLID
		/// </summary>
		[Column("XMLID")]
		public string XMLID { get; set; }
		/// <summary>
		/// 회사명
		/// </summary>
		[Column("회사명")]
		public string CompanyName { get; set; }
		/// <summary>
		/// IP
		/// </summary>
		[Column("IP")]
		public string IP { get; set; }
	}
}