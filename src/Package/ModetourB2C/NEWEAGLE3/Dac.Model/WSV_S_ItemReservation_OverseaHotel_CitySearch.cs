namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSV_S_아이템예약_해외호텔_도시검색
/// </summary>
public class WSV_S_ItemReservation_OverseaHotel_CitySearch
{
	public const string SP_NAME = "WSV_S_아이템예약_해외호텔_도시검색";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 검색어
		/// </summary>
		[Description("검색어")]
		public string SearchingKeyword { get; set; }
		/// <summary>
		/// 품목코드
		/// </summary>
		[Description("품목코드")]
		public string ProductListCode { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 에러메시지
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 1000)]
		[Description("에러메시지")]
		public string ErrorMessage { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 국가코드
		/// </summary>
		[Column("국가코드")]
		public string CountryCode { get; set; }
		/// <summary>
		/// 도시코드
		/// </summary>
		[Column("도시코드")]
		public int CityCode { get; set; }
		/// <summary>
		/// 도시명K
		/// </summary>
		[Column("도시명K")]
		public string CityName_K { get; set; }
		/// <summary>
		/// 도시명
		/// </summary>
		[Column("도시명")]
		public string CityName { get; set; }
		/// <summary>
		/// 국가명K
		/// </summary>
		[Column("국가명K")]
		public string CountryName_K { get; set; }
		/// <summary>
		/// 도시검색
		/// </summary>
		[Column("도시검색")]
		public string CitySearch { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 위도
		/// </summary>
		[Column("위도")]
		public decimal Latitude { get; set; }
		/// <summary>
		/// 경도
		/// </summary>
		[Column("경도")]
		public decimal Longtitude { get; set; }
	}
}