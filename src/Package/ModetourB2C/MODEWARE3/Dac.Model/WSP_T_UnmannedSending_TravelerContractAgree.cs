namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_무인센딩_여행자계약동의
/// </summary>
public class WSP_T_UnmannedSending_TravelerContractAgree
{
	public const string SP_NAME = "WSP_T_무인센딩_여행자계약동의";

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
		/// 여행계약서전자서명
		/// </summary>
		[Description("여행계약서전자서명")]
		public string TravelContractDigitalSignature { get; set; }
	}

}