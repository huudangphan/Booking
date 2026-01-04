namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_인센티브마스터_WEMODE_견적조회수
/// </summary>
public class WSP_T_CMN_IncentiveMaster_WEMODE_EstimateFindNumber
{
	public const string SP_NAME = "WSP_T_CMN_인센티브마스터_WEMODE_견적조회수";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 메인번호
		/// </summary>
		[Description("메인번호")]
		public int MainNumber { get; set; }
	}

}