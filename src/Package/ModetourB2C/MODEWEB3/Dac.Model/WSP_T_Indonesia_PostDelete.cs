namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_인도네시아_게시글삭제
/// </summary>
public class WSP_T_Indonesia_PostDelete
{
	public const string SP_NAME = "WSP_T_인도네시아_게시글삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

}