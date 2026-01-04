namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_여권자동등록서비스_처리불가명단
/// </summary>
public class WSP_S_PassportAutoRegistrationService_CannotHandleNameList
{
	public const string SP_NAME = "WSP_S_여권자동등록서비스_처리불가명단";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 대표여부
		/// </summary>
		[Description("대표여부")]
		public string RepresentativeOrNot { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 신청번호
		/// </summary>
		[Column("신청번호")]
		public int RequestNumber { get; set; }
		/// <summary>
		/// 신청일
		/// </summary>
		[Column("신청일")]
		public string RequestDate { get; set; }
		/// <summary>
		/// 신청시분
		/// </summary>
		[Column("신청시분")]
		public string RequestHourMinute { get; set; }
		/// <summary>
		/// 한글성명
		/// </summary>
		[Column("한글성명")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 성별2
		/// </summary>
		[Column("성별2")]
		public string Gender2 { get; set; }
	}
}