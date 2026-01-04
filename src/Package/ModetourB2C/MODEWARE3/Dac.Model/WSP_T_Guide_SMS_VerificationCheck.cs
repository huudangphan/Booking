namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_가이드_SMS인증체크
/// </summary>
public class WSP_T_Guide_SMS_VerificationCheck
{
	public const string SP_NAME = "WSP_T_가이드_SMS인증체크";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Description("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 승인인증번호
		/// </summary>
		[Description("승인인증번호")]
		public int ApprovalVerificationNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public string Column1 { get; set; }
	}
}