namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_S_APPLICATIONHOST
/// </summary>
public class WSV_S_APPLICATIONHOST
{
	public const string SP_NAME = "WSV_S_APPLICATIONHOST";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// ServiceName
		/// </summary>
		[Description("ServiceName")]
		public string ServiceName { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 에러메시지
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 1000)]
		[Description("에러메시지")]
		public string ErrorMessage { get; set; }
	}

}