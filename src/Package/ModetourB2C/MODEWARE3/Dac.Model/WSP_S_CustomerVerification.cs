namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_거래처인증
/// </summary>
public class WSP_S_CustomerVerification
{
	public const string SP_NAME = "WSP_S_거래처인증";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 거래처직원코드
		/// </summary>
		[Description("거래처직원코드")]
		public int CustomerEmployeeCode { get; set; }
		/// <summary>
		/// New_ID
		/// </summary>
		[Description("New_ID")]
		public string New_ID { get; set; }
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
		/// 회사명
		/// </summary>
		[Column("회사명")]
		public string CompanyName { get; set; }
		/// <summary>
		/// Server_IP
		/// </summary>
		[Column("Server_IP")]
		public string Server_IP { get; set; }
		/// <summary>
		/// New_ID
		/// </summary>
		[Column("New_ID")]
		public string New_ID { get; set; }
	}
}