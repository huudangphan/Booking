namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_ENQUETE_INSERT
/// </summary>
public class WSP_T_CMN_ENQUETE_INSERT
{
	public const string SP_NAME = "WSP_T_CMN_ENQUETE_INSERT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// EventNo
		/// </summary>
		[Description("EventNo")]
		public int EventNo { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// T_앙케이트_등록
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("T_앙케이트_등록")]
		public List<TYPE_EnqueteRequest> T_Enquete_Registration { get; set; }
	}

}