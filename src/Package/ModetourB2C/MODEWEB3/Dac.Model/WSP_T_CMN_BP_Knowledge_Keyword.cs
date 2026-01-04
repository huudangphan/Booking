namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_BP지식_키워드
/// </summary>
public class WSP_T_CMN_BP_Knowledge_Keyword
{
	public const string SP_NAME = "WSP_T_CMN_BP지식_키워드";

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
		/// 키워드
		/// </summary>
		[Description("키워드")]
		public string Keyword { get; set; }
		/// <summary>
		/// 이미지URL
		/// </summary>
		[Description("이미지URL")]
		public string Image_URL { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
	}

}