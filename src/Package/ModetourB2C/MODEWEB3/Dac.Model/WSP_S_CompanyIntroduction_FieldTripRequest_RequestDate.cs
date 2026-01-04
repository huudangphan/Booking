namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_회사소개_견학신청_신청일자
/// </summary>
public class WSP_S_CompanyIntroduction_FieldTripRequest_RequestDate
{
	public const string SP_NAME = "WSP_S_회사소개_견학신청_신청일자";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 신청년도
		/// </summary>
		[Description("신청년도")]
		public string RequestYear { get; set; }
		/// <summary>
		/// 신청월
		/// </summary>
		[Description("신청월")]
		public string RequestMonth { get; set; }
	}

}