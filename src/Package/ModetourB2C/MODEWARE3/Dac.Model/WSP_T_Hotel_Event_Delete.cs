namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_호텔_이벤트_삭제
/// </summary>
public class WSP_T_Hotel_Event_Delete
{
	public const string SP_NAME = "WSP_T_호텔_이벤트_삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Idx
		/// </summary>
		[Description("Idx")]
		public string Idx { get; set; }
	}

}