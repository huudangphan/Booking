namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_제휴사이트_주문외부키
/// </summary>
public class WSP_T_CMN_AffiliateSite_OrderExternalKey
{
	public const string SP_NAME = "WSP_T_CMN_제휴사이트_주문외부키";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Description("종류")]
		public string Type2 { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Description("상태1")]
		public string State1 { get; set; }
		/// <summary>
		/// 상태2
		/// </summary>
		[Description("상태2")]
		public string State2 { get; set; }
		/// <summary>
		/// 상태3
		/// </summary>
		[Description("상태3")]
		public string State3 { get; set; }
		/// <summary>
		/// 상태4
		/// </summary>
		[Description("상태4")]
		public string State4 { get; set; }
		/// <summary>
		/// 상태5
		/// </summary>
		[Description("상태5")]
		public string State5 { get; set; }
		/// <summary>
		/// 상태6
		/// </summary>
		[Description("상태6")]
		public string State6 { get; set; }
		/// <summary>
		/// 상태7
		/// </summary>
		[Description("상태7")]
		public string State7 { get; set; }
		/// <summary>
		/// 금액1
		/// </summary>
		[Description("금액1")]
		public int Amount1 { get; set; }
		/// <summary>
		/// 금액2
		/// </summary>
		[Description("금액2")]
		public int Amount2 { get; set; }
		/// <summary>
		/// 금액3
		/// </summary>
		[Description("금액3")]
		public int Amount3 { get; set; }
		/// <summary>
		/// RCODE
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 4)]
		[Description("RCODE")]
		public string RCODE { get; set; }
		/// <summary>
		/// RMSG
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 200)]
		[Description("RMSG")]
		public string RMSG { get; set; }
	}

}