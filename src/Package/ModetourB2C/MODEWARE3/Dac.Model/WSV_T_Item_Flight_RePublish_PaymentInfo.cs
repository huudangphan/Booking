namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_T_아이템_항공_재발행_결제정보
/// </summary>
public class WSV_T_Item_Flight_RePublish_PaymentInfo
{
	public const string SP_NAME = "WSV_T_아이템_항공_재발행_결제정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// TBL카드결제
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("TBL카드결제")]
		public List<TYPE_Flight_PaymentInfo_Card> TBL_CardPayment { get; set; }
		/// <summary>
		/// 요청자
		/// </summary>
		[Description("요청자")]
		public int Requester { get; set; }
		/// <summary>
		/// 요청자IP
		/// </summary>
		[Description("요청자IP")]
		public string Requester_IP { get; set; }
		/// <summary>
		/// 요청단말기
		/// </summary>
		[Description("요청단말기")]
		public string RequestTerminal { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 에러메시지
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 4000)]
		[Description("에러메시지")]
		public string ErrorMessage { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[Column("결과")]
		public string RESULT { get; set; }
		/// <summary>
		/// 에러메시지
		/// </summary>
		[Column("에러메시지")]
		public string ErrorMessage { get; set; }
	}
}