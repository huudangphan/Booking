namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_회사소개_견학신청_확인
/// </summary>
public class WSP_S_CompanyIntroduction_FieldTripRequest_Confirm
{
	public const string SP_NAME = "WSP_S_회사소개_견학신청_확인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 신청자성명
		/// </summary>
		[Description("신청자성명")]
		public string RequesterName { get; set; }
		/// <summary>
		/// 신청자전화번호
		/// </summary>
		[Description("신청자전화번호")]
		public string RequesterPhoneNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 신청수
		/// </summary>
		[Column("신청수")]
		public int RequestNumber { get; set; }
	}
}