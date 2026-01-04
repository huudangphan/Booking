namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_단체리스트_상품일자_출발확정
/// </summary>
public class WSP_S_CMN_GroupList_ProductDate_DepartureConfirm
{
	public const string SP_NAME = "WSP_S_CMN_단체리스트_상품일자_출발확정";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지역번호
		/// </summary>
		[Description("지역번호")]
		public int RegionNumber { get; set; }
		/// <summary>
		/// 테마번호
		/// </summary>
		[Description("테마번호")]
		public int ThemeNumber { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Description("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 검색개월수
		/// </summary>
		[Description("검색개월수")]
		public int SearchingMonthsNumber { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
	}
}