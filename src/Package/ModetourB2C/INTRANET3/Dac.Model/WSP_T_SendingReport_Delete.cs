namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_T_센딩보고_삭제
/// </summary>
public class WSP_T_SendingReport_Delete
{
	public const string SP_NAME = "WSP_T_센딩보고_삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

}