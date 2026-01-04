namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_설명회메일
/// </summary>
public class WSP_T_PresentationMail
{
	public const string SP_NAME = "WSP_T_설명회메일";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 파라미터
		/// </summary>
		[Description("파라미터")]
		public string Parameter { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

}