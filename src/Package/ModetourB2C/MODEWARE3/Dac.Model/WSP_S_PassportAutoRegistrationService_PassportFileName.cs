namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_여권자동등록서비스_여권파일명
/// </summary>
public class WSP_S_PassportAutoRegistrationService_PassportFileName
{
	public const string SP_NAME = "WSP_S_여권자동등록서비스_여권파일명";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 여권파일명
		/// </summary>
		[Column("여권파일명")]
		public string PassportFileName { get; set; }
	}
}