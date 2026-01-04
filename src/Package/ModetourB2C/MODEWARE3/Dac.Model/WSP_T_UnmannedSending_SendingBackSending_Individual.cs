namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_무인센딩_센딩팩보내기_개별
/// </summary>
public class WSP_T_UnmannedSending_SendingBackSending_Individual
{
	public const string SP_NAME = "WSP_T_무인센딩_센딩팩보내기_개별";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
	}

}