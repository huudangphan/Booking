namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_나의여행스크랩삭제
/// </summary>
public class WSP_T_CMN_MyTravelScrapDelete
{
	public const string SP_NAME = "WSP_T_CMN_나의여행스크랩삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

}