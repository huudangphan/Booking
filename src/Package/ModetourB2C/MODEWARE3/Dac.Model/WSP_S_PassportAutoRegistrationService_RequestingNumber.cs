namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_여권자동등록서비스_신청중인건수
/// </summary>
public class WSP_S_PassportAutoRegistrationService_RequestingNumber
{
	public const string SP_NAME = "WSP_S_여권자동등록서비스_신청중인건수";

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
		/// 신청중인건수
		/// </summary>
		[Column("신청중인건수")]
		public int RequestingStateNumber { get; set; }
		/// <summary>
		/// 처리불가건수
		/// </summary>
		[Column("처리불가건수")]
		public int HandleImpossibleNumber { get; set; }
	}
}