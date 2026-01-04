namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_메시지_확인
/// </summary>
public class WSP_T_Message_Confirm
{
	public const string SP_NAME = "WSP_T_메시지_확인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 메세지발송번호
		/// </summary>
		[Description("메세지발송번호")]
		public int MessageSendingNumber { get; set; }
		/// <summary>
		/// 수신여부
		/// </summary>
		[Description("수신여부")]
		public string ReceptionOrNot { get; set; }
		/// <summary>
		/// 수신비고
		/// </summary>
		[Description("수신비고")]
		public string ReceptionNote { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
	}
}