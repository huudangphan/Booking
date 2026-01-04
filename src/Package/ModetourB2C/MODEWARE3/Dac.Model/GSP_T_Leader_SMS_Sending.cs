namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_T_인솔자_SMS발송
/// </summary>
public class GSP_T_Leader_SMS_Sending
{
	public const string SP_NAME = "GSP_T_인솔자_SMS발송";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 발송자
		/// </summary>
		[Description("발송자")]
		public int Sender { get; set; }
		/// <summary>
		/// 수신자
		/// </summary>
		[Description("수신자")]
		public string Receiver { get; set; }
		/// <summary>
		/// 메시지
		/// </summary>
		[Description("메시지")]
		public string Message { get; set; }
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