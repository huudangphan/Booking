namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_BTMS_법인명
/// </summary>
public class WSP_S_CMN_BTMS_CorporationName
{
	public const string SP_NAME = "WSP_S_CMN_BTMS_법인명";

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
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 회사명
		/// </summary>
		[Column("회사명")]
		public string CompanyName { get; set; }
	}
}