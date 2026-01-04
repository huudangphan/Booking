namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_여권자동등록서비스_ALARM
/// </summary>
public class WSP_S_PassportAutoRegistrationService_ALARM
{
	public const string SP_NAME = "WSP_S_여권자동등록서비스_ALARM";

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
		/// 진행상태코드
		/// </summary>
		[Column("진행상태코드")]
		public string ProgressStateCode { get; set; }
		/// <summary>
		/// 진행상태변경일
		/// </summary>
		[Column("진행상태변경일")]
		public string ProgressStateChangeDate { get; set; }
		/// <summary>
		/// 알림내용
		/// </summary>
		[Column("알림내용")]
		public string AlarmContent { get; set; }
	}
}