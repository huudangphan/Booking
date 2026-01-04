namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_BP지식_키워드
/// </summary>
public class WSP_S_CMN_BP_Knowledge_Keyword
{
	public const string SP_NAME = "WSP_S_CMN_BP지식_키워드";

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
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Column("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 상품_항공코드
		/// </summary>
		[Column("상품_항공코드")]
		public string Product_FlightCode { get; set; }
		/// <summary>
		/// 키워드
		/// </summary>
		[Column("키워드")]
		public string Keyword { get; set; }
		/// <summary>
		/// 이미지URL
		/// </summary>
		[Column("이미지URL")]
		public string Image_URL { get; set; }
	}
}