namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_여권자동등록서비스_알림확인
/// </summary>
public class WSP_T_PassportAutoRegistrationService_AlarmConfirm
{
	public const string SP_NAME = "WSP_T_여권자동등록서비스_알림확인";

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

}