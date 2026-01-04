namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_특선상품_상품코드_날짜리스트_출발일조건_일별최저가
/// </summary>
public class WSP_S_CMN_SpecialSelectionProduct_ProductCode_DateList_DepartureDateConditions_DailyLowestPrice
{
	public const string SP_NAME = "WSP_S_CMN_특선상품_상품코드_날짜리스트_출발일조건_일별최저가";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// SITENO
		/// </summary>
		[Description("SITENO")]
		public int SITENO { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 출발일1
		/// </summary>
		[Description("출발일1")]
		public string DepartureDate1 { get; set; }
		/// <summary>
		/// 출발일2
		/// </summary>
		[Description("출발일2")]
		public string DepartureDate2 { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 가격
		/// </summary>
		[Column("가격")]
		public long Price { get; set; }
	}
}