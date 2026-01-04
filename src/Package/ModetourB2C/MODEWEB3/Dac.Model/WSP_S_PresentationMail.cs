namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_설명회메일
/// </summary>
public class WSP_S_PresentationMail
{
	public const string SP_NAME = "WSP_S_설명회메일";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

}