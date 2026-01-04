namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_여권자동등록서비스_약관동의여부
/// </summary>
public class WSP_S_PassportAutoRegistrationService_TermsAgreeOrNot
{
	public const string SP_NAME = "WSP_S_여권자동등록서비스_약관동의여부";

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
		/// 고유식별정보수집동의여부
		/// </summary>
		[Column("고유식별정보수집동의여부")]
		public string UniqueInfoCollectionAgreeOrNot { get; set; }
		/// <summary>
		/// 여권정보촬영동의여부
		/// </summary>
		[Column("여권정보촬영동의여부")]
		public string PassportInfoTakingPhotoAgreeOrNot { get; set; }
	}
}