namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_단체리스트_상품일자_출발날짜
/// </summary>
public class WSP_S_CMN_GroupList_ProductDate_DepartureDate
{
	public const string SP_NAME = "WSP_S_CMN_단체리스트_상품일자_출발날짜";

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