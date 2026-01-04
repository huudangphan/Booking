namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// ASP_TIMEDEAL_SELECT
/// </summary>
public class ASP_TIMEDEAL_SELECT
{
	public const string SP_NAME = "ASP_TIMEDEAL_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Description("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// TEMPLATE
		/// </summary>
		[Column("TEMPLATE")]
		public string TEMPLATE { get; set; }
		/// <summary>
		/// GR_IDX
		/// </summary>
		[Column("GR_IDX")]
		public int GR_IDX { get; set; }
		/// <summary>
		/// GR_TITLE
		/// </summary>
		[Column("GR_TITLE")]
		public string GR_TITLE { get; set; }
		/// <summary>
		/// TITLE_IMG
		/// </summary>
		[Column("TITLE_IMG")]
		public string TITLE_IMG { get; set; }
		/// <summary>
		/// BG_COLOR
		/// </summary>
		[Column("BG_COLOR")]
		public string BG_COLOR { get; set; }
		/// <summary>
		/// FONT_COLOR
		/// </summary>
		[Column("FONT_COLOR")]
		public string FONT_COLOR { get; set; }
		/// <summary>
		/// MAIN_TITLE
		/// </summary>
		[Column("MAIN_TITLE")]
		public string MAIN_TITLE { get; set; }
		/// <summary>
		/// SUB_TITLE
		/// </summary>
		[Column("SUB_TITLE")]
		public string SUB_TITLE { get; set; }
		/// <summary>
		/// CAT_START
		/// </summary>
		[Column("CAT_START")]
		public string CAT_START { get; set; }
		/// <summary>
		/// CAT_PROD
		/// </summary>
		[Column("CAT_PROD")]
		public string CAT_PROD { get; set; }
		/// <summary>
		/// START_DATE
		/// </summary>
		[Column("START_DATE")]
		public DateTime START_DATE { get; set; }
		/// <summary>
		/// END_DATE
		/// </summary>
		[Column("END_DATE")]
		public DateTime END_DATE { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 특선상품번호
		/// </summary>
		[Column("특선상품번호")]
		public int SpecialSelectionProductNumber { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 간략설명
		/// </summary>
		[Column("간략설명")]
		public string BriefDescription { get; set; }
		/// <summary>
		/// 포함
		/// </summary>
		[Column("포함")]
		public string Included { get; set; }
		/// <summary>
		/// 불포함
		/// </summary>
		[Column("불포함")]
		public string Unincluded { get; set; }
		/// <summary>
		/// 특전
		/// </summary>
		[Column("특전")]
		public string SpecialEvent { get; set; }
		/// <summary>
		/// 할인율
		/// </summary>
		[Column("할인율")]
		public int DiscountRate { get; set; }
		/// <summary>
		/// 상품정상가
		/// </summary>
		[Column("상품정상가")]
		public long ProductNormalPrice { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 특선상품번호
		/// </summary>
		[Column("특선상품번호")]
		public int SpecialSelectionProductNumber { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 항공코드
		/// </summary>
		[Column("항공코드")]
		public string FlightCode { get; set; }
		/// <summary>
		/// 항공사명
		/// </summary>
		[Column("항공사명")]
		public string AirlineName { get; set; }
		/// <summary>
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// TOTAL
		/// </summary>
		[Column("TOTAL")]
		public long TOTAL { get; set; }
		/// <summary>
		/// 보유좌석
		/// </summary>
		[Column("보유좌석")]
		public int HoldingSeat { get; set; }
		/// <summary>
		/// 예약좌석
		/// </summary>
		[Column("예약좌석")]
		public int BookingSeat { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 출발시간
		/// </summary>
		[Column("출발시간")]
		public string DepartureTime { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public string ArrivalDate { get; set; }
		/// <summary>
		/// 박수
		/// </summary>
		[Column("박수")]
		public byte NightNumber { get; set; }
		/// <summary>
		/// 일수
		/// </summary>
		[Column("일수")]
		public byte DaysNumber { get; set; }
		/// <summary>
		/// 판매마감
		/// </summary>
		[Column("판매마감")]
		public string SalesEnd { get; set; }
		/// <summary>
		/// 내부판매AD여부
		/// </summary>
		[Column("내부판매AD여부")]
		public string InternalSales_AD_OrNot { get; set; }
		/// <summary>
		/// 출발확정
		/// </summary>
		[Column("출발확정")]
		public string DepartureConfirm { get; set; }
		/// <summary>
		/// NameTL
		/// </summary>
		[Column("NameTL")]
		public string NameTL { get; set; }
		/// <summary>
		/// 잔여좌석
		/// </summary>
		[Column("잔여좌석")]
		public string AvailableSeat { get; set; }
		/// <summary>
		/// 취소
		/// </summary>
		[Column("취소")]
		public string Cancel { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 특선상품번호
		/// </summary>
		[Column("특선상품번호")]
		public int SpecialSelectionProductNumber { get; set; }
		/// <summary>
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// MIN_DATE
		/// </summary>
		[Column("MIN_DATE")]
		public DateTime MIN_DATE { get; set; }
		/// <summary>
		/// MAX_DATE
		/// </summary>
		[Column("MAX_DATE")]
		public DateTime MAX_DATE { get; set; }
		/// <summary>
		/// START_DATE
		/// </summary>
		[Column("START_DATE")]
		public DateTime START_DATE { get; set; }
	}
}