namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_주문아이템_판매명세_취소신청
/// </summary>
public class WSP_T_CMN_OrderItem_SaleDetail_CancelRequest
{
	public const string SP_NAME = "WSP_T_CMN_주문아이템_판매명세_취소신청";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public string SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 취소코드
		/// </summary>
		[Description("취소코드")]
		public string CancelCode { get; set; }
		/// <summary>
		/// 기타사유
		/// </summary>
		[Description("기타사유")]
		public string OtherReason { get; set; }
		/// <summary>
		/// 진행상태코드
		/// </summary>
		[Description("진행상태코드")]
		public string ProgressStateCode { get; set; }
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
		/// <summary>
		/// 요청자
		/// </summary>
		[Description("요청자")]
		public int Requester { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// ID
		/// </summary>
		[Column("ID")]
		public int ID { get; set; }
	}
}