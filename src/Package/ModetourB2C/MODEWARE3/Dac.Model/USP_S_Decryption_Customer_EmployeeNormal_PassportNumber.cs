namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_복호화_거래처_직원일반_여권번호
/// </summary>
public class USP_S_Decryption_Customer_EmployeeNormal_PassportNumber
{
	public const string SP_NAME = "USP_S_복호화_거래처_직원일반_여권번호";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// IP
		/// </summary>
		[Description("IP")]
		public string IP { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// APP
		/// </summary>
		[Description("APP")]
		public string APP { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// DEC_여권번호
		/// </summary>
		[Column("DEC_여권번호")]
		public string DEC_PassportNumber { get; set; }
	}
}