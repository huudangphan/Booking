namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_무인센딩_개인정보동의
/// </summary>
public class WSP_T_UnmannedSending_PersonalInfoAgree
{
	public const string SP_NAME = "WSP_T_무인센딩_개인정보동의";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
	}

}