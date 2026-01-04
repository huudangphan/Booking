namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_LOG_ERRORDATA
/// </summary>
public class WSP_S_CMN_LOG_ERRORDATA
{
	public const string SP_NAME = "WSP_S_CMN_LOG_ERRORDATA";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Idx
		/// </summary>
		[Description("Idx")]
		public int Idx { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 도메인
		/// </summary>
		[Column("도메인")]
		public string Domain { get; set; }
		/// <summary>
		/// 페이지경로
		/// </summary>
		[Column("페이지경로")]
		public string PageRoute { get; set; }
		/// <summary>
		/// 파라미터
		/// </summary>
		[Column("파라미터")]
		public string Parameter { get; set; }
		/// <summary>
		/// 클라이언트IP
		/// </summary>
		[Column("클라이언트IP")]
		public string Client_IP { get; set; }
		/// <summary>
		/// 서버
		/// </summary>
		[Column("서버")]
		public string Server { get; set; }
		/// <summary>
		/// 브라우저
		/// </summary>
		[Column("브라우저")]
		public string Browser { get; set; }
		/// <summary>
		/// 정보1
		/// </summary>
		[Column("정보1")]
		public string Info1 { get; set; }
		/// <summary>
		/// 정보2
		/// </summary>
		[Column("정보2")]
		public string Info2 { get; set; }
		/// <summary>
		/// 정보3
		/// </summary>
		[Column("정보3")]
		public string Info3 { get; set; }
		/// <summary>
		/// 정보4
		/// </summary>
		[Column("정보4")]
		public string Info4 { get; set; }
		/// <summary>
		/// 정보5
		/// </summary>
		[Column("정보5")]
		public string Info5 { get; set; }
		/// <summary>
		/// 메시지1
		/// </summary>
		[Column("메시지1")]
		public string Message1 { get; set; }
		/// <summary>
		/// 대분류
		/// </summary>
		[Column("대분류")]
		public string MajorClassification { get; set; }
	}
}