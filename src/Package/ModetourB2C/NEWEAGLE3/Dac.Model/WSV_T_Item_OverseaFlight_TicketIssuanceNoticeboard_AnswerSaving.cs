namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSV_T_아이템_해외항공_발권게시판_답변저장
/// </summary>
public class WSV_T_Item_OverseaFlight_TicketIssuanceNoticeboard_AnswerSaving
{
	public const string SP_NAME = "WSV_T_아이템_해외항공_발권게시판_답변저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 스텝1
		/// </summary>
		[Description("스텝1")]
		public int Step1 { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Description("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 작성자번호
		/// </summary>
		[Description("작성자번호")]
		public int WritterNumber { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Description("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 아이피
		/// </summary>
		[Description("아이피")]
		public string IP { get; set; }
		/// <summary>
		/// 진행상태
		/// </summary>
		[Description("진행상태")]
		public string ProgressState { get; set; }
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