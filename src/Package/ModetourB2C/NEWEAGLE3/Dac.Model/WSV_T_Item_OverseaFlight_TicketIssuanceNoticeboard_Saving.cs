namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSV_T_아이템_해외항공_발권게시판_저장
/// </summary>
public class WSV_T_Item_OverseaFlight_TicketIssuanceNoticeboard_Saving
{
	public const string SP_NAME = "WSV_T_아이템_해외항공_발권게시판_저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
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
		/// 요청구분
		/// </summary>
		[Description("요청구분")]
		public string RequestClassification { get; set; }
		/// <summary>
		/// PNR
		/// </summary>
		[Description("PNR")]
		public string PNR { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Description("제목")]
		public string Title { get; set; }
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
		/// 일련번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("일련번호")]
		public int SerialNumber { get; set; }
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