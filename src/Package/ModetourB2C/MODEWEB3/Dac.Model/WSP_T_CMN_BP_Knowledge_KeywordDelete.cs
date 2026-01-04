namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_BP지식_키워드삭제
/// </summary>
public class WSP_T_CMN_BP_Knowledge_KeywordDelete
{
	public const string SP_NAME = "WSP_T_CMN_BP지식_키워드삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처
		/// </summary>
		[Description("거래처")]
		public int Customer { get; set; }
		/// <summary>
		/// 상품_항공코드
		/// </summary>
		[Description("상품_항공코드")]
		public string Product_FlightCode { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
	}

}