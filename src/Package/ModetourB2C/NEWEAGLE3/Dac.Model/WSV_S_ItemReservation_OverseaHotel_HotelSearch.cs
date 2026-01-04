namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSV_S_아이템예약_해외호텔_호텔검색
/// </summary>
public class WSV_S_ItemReservation_OverseaHotel_HotelSearch
{
	public const string SP_NAME = "WSV_S_아이템예약_해외호텔_호텔검색";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 검색어
		/// </summary>
		[Description("검색어")]
		public string SearchingKeyword { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Description("도시번호")]
		public int CityNumber { get; set; }
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
		/// 인기도순서
		/// </summary>
		[Column("인기도순서")]
		public int FamousLevelOrder { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// 아이템번호
		/// </summary>
		[Column("아이템번호")]
		public int ItemNumber { get; set; }
		/// <summary>
		/// 아이템명
		/// </summary>
		[Column("아이템명")]
		public string ItemName { get; set; }
		/// <summary>
		/// 아이템명K
		/// </summary>
		[Column("아이템명K")]
		public string ItemNameK { get; set; }
		/// <summary>
		/// 아이템코드
		/// </summary>
		[Column("아이템코드")]
		public string ItemCode { get; set; }
		/// <summary>
		/// 키워드
		/// </summary>
		[Column("키워드")]
		public string Keyword { get; set; }
	}
}