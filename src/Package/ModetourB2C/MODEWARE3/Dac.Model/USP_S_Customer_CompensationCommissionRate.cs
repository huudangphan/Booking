namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_거래처_보상커미션율
/// </summary>
public class USP_S_Customer_CompensationCommissionRate
{
	public const string SP_NAME = "USP_S_거래처_보상커미션율";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 보상커미션율
		/// </summary>
		[DapperParameter(DbType.Decimal, ParameterDirection.InputOutput, 5)]
		[Description("보상커미션율")]
		public decimal CompensationCommisionRate { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 보상커미션율
		/// </summary>
		[Column("보상커미션율")]
		public decimal CompensationCommisionRate { get; set; }
	}
}