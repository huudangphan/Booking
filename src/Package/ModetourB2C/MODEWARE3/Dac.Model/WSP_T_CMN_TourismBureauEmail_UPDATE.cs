namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_관광청이메일_UPDATE
/// </summary>
public class WSP_T_CMN_TourismBureauEmail_UPDATE
{
	public const string SP_NAME = "WSP_T_CMN_관광청이메일_UPDATE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// MasterNo
		/// </summary>
		[Description("MasterNo")]
		public int MasterNo { get; set; }
		/// <summary>
		/// EMAIL
		/// </summary>
		[Description("EMAIL")]
		public string EMAIL { get; set; }
	}

}