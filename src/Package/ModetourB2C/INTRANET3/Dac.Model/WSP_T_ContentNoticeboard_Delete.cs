namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_T_컨텐츠게시판_삭제
/// </summary>
public class WSP_T_ContentNoticeboard_Delete
{
	public const string SP_NAME = "WSP_T_컨텐츠게시판_삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 첨부
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 200)]
		[Description("첨부")]
		public string Attach { get; set; }
	}

}