namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSV_S_아이템_해외항공_발권게시판_개별리스트
/// </summary>
public class WSV_S_Item_OverseaFlight_TicketIssuanceNoticeboard_IndividualList
{
	public const string SP_NAME = "WSV_S_아이템_해외항공_발권게시판_개별리스트";

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

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 스텝1
		/// </summary>
		[Column("스텝1")]
		public int Step1 { get; set; }
		/// <summary>
		/// 스텝2
		/// </summary>
		[Column("스텝2")]
		public byte Step2 { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 작성자번호
		/// </summary>
		[Column("작성자번호")]
		public int WritterNumber { get; set; }
		/// <summary>
		/// 요청구분
		/// </summary>
		[Column("요청구분")]
		public string RequestClassification { get; set; }
		/// <summary>
		/// PNR
		/// </summary>
		[Column("PNR")]
		public string PNR { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 아이피
		/// </summary>
		[Column("아이피")]
		public string IP { get; set; }
		/// <summary>
		/// 진행상태
		/// </summary>
		[Column("진행상태")]
		public string ProgressState { get; set; }
		/// <summary>
		/// 삭제여부
		/// </summary>
		[Column("삭제여부")]
		public string DeleteOrNot { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}
}