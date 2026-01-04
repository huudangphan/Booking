namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_알림서비스_삭제
/// </summary>
public class WSP_T_AlarmService_Delete
{
	public const string SP_NAME = "WSP_T_알림서비스_삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 알림예약번호
		/// </summary>
		[Description("알림예약번호")]
		public int AlarmBookingNumber { get; set; }
	}

}