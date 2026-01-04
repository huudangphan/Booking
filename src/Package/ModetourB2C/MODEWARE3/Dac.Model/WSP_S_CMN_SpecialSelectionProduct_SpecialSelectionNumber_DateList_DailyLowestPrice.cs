namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_특선상품_특선번호_날짜리스트_일별최저가
/// </summary>
public class WSP_S_CMN_SpecialSelectionProduct_SpecialSelectionNumber_DateList_DailyLowestPrice
{
	public const string SP_NAME = "WSP_S_CMN_특선상품_특선번호_날짜리스트_일별최저가";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// IDX
		/// </summary>
		[Description("IDX")]
		public int IDX { get; set; }
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
		/// 출발일1
		/// </summary>
		[Description("출발일1")]
		public DateTime DepartureDate1 { get; set; }
		/// <summary>
		/// 출발일2
		/// </summary>
		[Description("출발일2")]
		public DateTime DepartureDate2 { get; set; }
		/// <summary>
		/// 제휴여부
		/// </summary>
		[Description("제휴여부")]
		public string AffiliateOrNot { get; set; }
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