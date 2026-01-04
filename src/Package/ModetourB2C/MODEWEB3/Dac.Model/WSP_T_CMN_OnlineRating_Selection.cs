namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_온라인등급_선택
/// </summary>
public class WSP_T_CMN_OnlineRating_Selection
{
	public const string SP_NAME = "WSP_T_CMN_온라인등급_선택";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 사이트일련번호
		/// </summary>
		[Description("사이트일련번호")]
		public int SiteSerialNumber { get; set; }
		/// <summary>
		/// 상품_상품분류코드
		/// </summary>
		[Description("상품_상품분류코드")]
		public string Product_ProductClassificationCode { get; set; }
		/// <summary>
		/// 상품_상품번호
		/// </summary>
		[Description("상품_상품번호")]
		public string Product_ProductNumber { get; set; }
		/// <summary>
		/// 정렬여부
		/// </summary>
		[Description("정렬여부")]
		public string SortingOrNot { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Description("순서")]
		public int Order { get; set; }
		/// <summary>
		/// 거래처
		/// </summary>
		[Description("거래처")]
		public int Customer { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Description("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
	}

}