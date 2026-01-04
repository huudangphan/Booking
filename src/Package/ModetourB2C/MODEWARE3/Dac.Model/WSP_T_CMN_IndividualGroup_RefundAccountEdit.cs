namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_개별단체_환불계좌수정
/// </summary>
public class WSP_T_CMN_IndividualGroup_RefundAccountEdit
{
	public const string SP_NAME = "WSP_T_CMN_개별단체_환불계좌수정";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 환불계좌은행
		/// </summary>
		[Description("환불계좌은행")]
		public string RefundAccountBank { get; set; }
		/// <summary>
		/// 환불계좌번호
		/// </summary>
		[Description("환불계좌번호")]
		public string RefundAccountNumber { get; set; }
		/// <summary>
		/// 환불계좌예금주
		/// </summary>
		[Description("환불계좌예금주")]
		public string RefundAccountBankAccountOwner { get; set; }
	}

}