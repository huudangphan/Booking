namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// WSP_S_업무요청게시판_첨부_검색
/// </summary>
public class WSP_S_DutyRequestNoticeboard_Attached_Search
{
	public const string SP_NAME = "WSP_S_업무요청게시판_첨부_검색";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
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
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 파일
		/// </summary>
		[Column("파일")]
		public string File { get; set; }
	}
}