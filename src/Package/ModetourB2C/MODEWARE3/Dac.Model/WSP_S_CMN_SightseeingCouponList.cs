namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_관광쿠폰리스트
/// </summary>
public class WSP_S_CMN_SightseeingCouponList
{
	public const string SP_NAME = "WSP_S_CMN_관광쿠폰리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 테마코드
		/// </summary>
		[Description("테마코드")]
		public string ThemeCode { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Description("정렬")]
		public string Sorting { get; set; }
		/// <summary>
		/// 현재페이지
		/// </summary>
		[Description("현재페이지")]
		public int CurrentPage { get; set; }
		/// <summary>
		/// 페이지당글개수
		/// </summary>
		[Description("페이지당글개수")]
		public int EachPageCharactersNumber { get; set; }
		/// <summary>
		/// 전체게시글수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체게시글수")]
		public int EntirePostCharactersNumber { get; set; }
		/// <summary>
		/// 전체페이지수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체페이지수")]
		public int EntirePageNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 성인요금
		/// </summary>
		[Column("성인요금")]
		public int AdultFare { get; set; }
		/// <summary>
		/// 성인판매가
		/// </summary>
		[Column("성인판매가")]
		public int AdultSellingPrice { get; set; }
		/// <summary>
		/// 대표이미지경로
		/// </summary>
		[Column("대표이미지경로")]
		public string RepresentativeImageRoute { get; set; }
	}
}