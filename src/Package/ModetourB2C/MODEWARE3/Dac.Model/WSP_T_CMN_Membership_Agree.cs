namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_멤버쉽_동의
/// </summary>
public class WSP_T_CMN_Membership_Agree
{
	public const string SP_NAME = "WSP_T_CMN_멤버쉽_동의";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 멤버쉽약관동의여부
		/// </summary>
		[Description("멤버쉽약관동의여부")]
		public string MembershipTermsAgreeOrNot { get; set; }
		/// <summary>
		/// 멤버쉽이용약관
		/// </summary>
		[Description("멤버쉽이용약관")]
		public string MembershipTermsAndConditions { get; set; }
		/// <summary>
		/// 개인정보수집
		/// </summary>
		[Description("개인정보수집")]
		public string PersonalInfoCollection { get; set; }
		/// <summary>
		/// 고유식별정보수집
		/// </summary>
		[Description("고유식별정보수집")]
		public string UniqueInfoCollection { get; set; }
		/// <summary>
		/// 개인정보3자제공
		/// </summary>
		[Description("개인정보3자제공")]
		public string PersonalInfo3rdPartyProvision { get; set; }
		/// <summary>
		/// 개인정보위탁
		/// </summary>
		[Description("개인정보위탁")]
		public string PersonalInfoConsign { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 20)]
		[Description("결과")]
		public string Result { get; set; }
	}

}