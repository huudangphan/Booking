namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_상품권스크래치_인증
/// </summary>
public class WSP_S_CMN_VoucherScratch_Verification
{
	public const string SP_NAME = "WSP_S_CMN_상품권스크래치_인증";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상품권번호
		/// </summary>
		[Description("상품권번호")]
		public string VoucherNumber { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 인증결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("인증결과")]
		public string VerificationResult { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 비밀번호오류횟수
		/// </summary>
		[Column("비밀번호오류횟수")]
		public int PasswordErrorTimes { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 액면가
		/// </summary>
		[Column("액면가")]
		public long ParValue { get; set; }
		/// <summary>
		/// 출고일자
		/// </summary>
		[Column("출고일자")]
		public DateTime ExportDate { get; set; }
	}
}