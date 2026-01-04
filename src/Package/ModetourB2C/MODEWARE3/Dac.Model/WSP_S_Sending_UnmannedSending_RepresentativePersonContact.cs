namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_센딩_무인센딩_대표자연락처
/// </summary>
public class WSP_S_Sending_UnmannedSending_RepresentativePersonContact
{
	public const string SP_NAME = "WSP_S_센딩_무인센딩_대표자연락처";

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
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// DEC_HP
		/// </summary>
		[Column("DEC_HP")]
		public string DEC_HP { get; set; }
	}
}