namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_T_외부기관중재사례_삭제
/// </summary>
public class WSP_T_ExternalAgencyArbitrationCase_Delete
{
	public const string SP_NAME = "WSP_T_외부기관중재사례_삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 작성자번호
		/// </summary>
		[Description("작성자번호")]
		public int WritterNumber { get; set; }
		/// <summary>
		/// 첨부
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 200)]
		[Description("첨부")]
		public string Attach { get; set; }
	}

}