namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// WSP_S_업무요청게시판_평가_검색
/// </summary>
public class WSP_S_DutyRequestNoticeboard_Evaluate_Search
{
	public const string SP_NAME = "WSP_S_업무요청게시판_평가_검색";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 작업구분
		/// </summary>
		[Description("작업구분")]
		public string WorkingClassification { get; set; }
		/// <summary>
		/// 게시판구분
		/// </summary>
		[Description("게시판구분")]
		public int NoticeboardClassification { get; set; }
		/// <summary>
		/// 작성자PTID
		/// </summary>
		[Description("작성자PTID")]
		public int WritterPTID { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// MSG
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 100)]
		[Description("MSG")]
		public string MSG { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 검색건수
		/// </summary>
		[Column("검색건수")]
		public int SearchingNumberofcases { get; set; }
	}
}