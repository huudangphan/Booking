namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_T_쪽지_삭제
/// </summary>
public class WSP_T_Note_Delete
{
	public const string SP_NAME = "WSP_T_쪽지_삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 발신자
		/// </summary>
		[Description("발신자")]
		public int MailSender { get; set; }
		/// <summary>
		/// 수신자
		/// </summary>
		[Description("수신자")]
		public int Receiver { get; set; }
		/// <summary>
		/// 쪽지번호
		/// </summary>
		[Description("쪽지번호")]
		public string NoteNumber { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
	}

}