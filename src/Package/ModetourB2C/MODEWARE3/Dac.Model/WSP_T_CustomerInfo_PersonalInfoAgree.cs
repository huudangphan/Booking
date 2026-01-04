namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_고객정보_개인정보동의
/// </summary>
public class WSP_T_CustomerInfo_PersonalInfoAgree
{
	public const string SP_NAME = "WSP_T_고객정보_개인정보동의";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 동의경로
		/// </summary>
		[Description("동의경로")]
		public string AgreeRoute { get; set; }
	}

}