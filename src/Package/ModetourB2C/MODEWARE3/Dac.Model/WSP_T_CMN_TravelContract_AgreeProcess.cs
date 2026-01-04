namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_여행계약서_동의절차
/// </summary>
public class WSP_T_CMN_TravelContract_AgreeProcess
{
	public const string SP_NAME = "WSP_T_CMN_여행계약서_동의절차";

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
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 동의상태
		/// </summary>
		[Description("동의상태")]
		public string AgreeState { get; set; }
		/// <summary>
		/// 본인인증여부
		/// </summary>
		[Description("본인인증여부")]
		public string SelfVerificationOrNot { get; set; }
		/// <summary>
		/// 주민번호
		/// </summary>
		[Description("주민번호")]
		public string CitizenIDNumber { get; set; }
		/// <summary>
		/// 대리인관계
		/// </summary>
		[Description("대리인관계")]
		public string AgencyRelationship { get; set; }
	}

}