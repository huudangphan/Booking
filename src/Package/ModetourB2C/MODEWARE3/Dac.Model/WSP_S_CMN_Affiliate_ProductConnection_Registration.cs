namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_제휴_상품연결_등록
/// </summary>
public class WSP_S_CMN_Affiliate_ProductConnection_Registration
{
	public const string SP_NAME = "WSP_S_CMN_제휴_상품연결_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상품코드2
		/// </summary>
		[Description("상품코드2")]
		public string ProductCode2 { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 항공코드
		/// </summary>
		[Description("항공코드")]
		public string FlightCode { get; set; }
		/// <summary>
		/// 제휴상품번호
		/// </summary>
		[Description("제휴상품번호")]
		public string AffiliateProductNumber { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 작업구분
		/// </summary>
		[Description("작업구분")]
		public string WorkingClassification { get; set; }
		/// <summary>
		/// 메소드
		/// </summary>
		[Description("메소드")]
		public string Method { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Description("비고")]
		public string Note { get; set; }
	}

}