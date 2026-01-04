namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// UP_고객의소리_삭제
/// </summary>
public class UP_CustomerVoice_Delete
{
	public const string SP_NAME = "UP_고객의소리_삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

}