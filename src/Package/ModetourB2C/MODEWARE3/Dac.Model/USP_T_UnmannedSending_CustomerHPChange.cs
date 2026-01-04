namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_무인센딩_고객HP변경
/// </summary>
public class USP_T_UnmannedSending_CustomerHPChange
{
	public const string SP_NAME = "USP_T_무인센딩_고객HP변경";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// HP
		/// </summary>
		[Description("HP")]
		public string HP { get; set; }
	}

}