namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_여권자동등록서비스_국적발행국가리스트_검색
/// </summary>
public class WSP_S_PassportAutoRegistrationService_NationalityPublishCountryList_Search
{
	public const string SP_NAME = "WSP_S_여권자동등록서비스_국적발행국가리스트_검색";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 코드
		/// </summary>
		[Description("코드")]
		public string Code { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
	}
}