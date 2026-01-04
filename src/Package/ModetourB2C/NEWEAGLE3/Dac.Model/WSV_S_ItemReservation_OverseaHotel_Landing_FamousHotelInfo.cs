namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSV_S_아이템예약_해외호텔_랜딩_인기호텔정보
/// </summary>
public class WSV_S_ItemReservation_OverseaHotel_Landing_FamousHotelInfo
{
	public const string SP_NAME = "WSV_S_아이템예약_해외호텔_랜딩_인기호텔정보";

	public class Parameters : BaseDbParameters
	{
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
		/// 호텔영문명
		/// </summary>
		[Column("호텔영문명")]
		public string HotelEnglishName { get; set; }
		/// <summary>
		/// 호텔한글명
		/// </summary>
		[Column("호텔한글명")]
		public string HotelKoreanName { get; set; }
		/// <summary>
		/// 호텔코드
		/// </summary>
		[Column("호텔코드")]
		public string HotelCode { get; set; }
		/// <summary>
		/// 호텔이미지
		/// </summary>
		[Column("호텔이미지")]
		public string HotelImage { get; set; }
		/// <summary>
		/// 판매
		/// </summary>
		[Column("판매")]
		public short Sales { get; set; }
	}
}