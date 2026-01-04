namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_여권자동등록서비스_유효성체크
/// </summary>
public class WSP_S_PassportAutoRegistrationService_ValidityCheck
{
	public const string SP_NAME = "WSP_S_여권자동등록서비스_유효성체크";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Description("생년월일")]
		public string BirthYearMonthDay { get; set; }
		/// <summary>
		/// 여권만료일
		/// </summary>
		[Description("여권만료일")]
		public DateTime PassportExpirationDate { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 에러여부
		/// </summary>
		[Column("에러여부")]
		public string ErrorOrNot { get; set; }
		/// <summary>
		/// MSG
		/// </summary>
		[Column("MSG")]
		public string MSG { get; set; }
	}
}