namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_복지몰_최근본상품_NEW
/// </summary>
public class WSP_S_WelfareMall_RecentViewedProduct_NEW
{
	public const string SP_NAME = "WSP_S_복지몰_최근본상품_NEW";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 유저ID
		/// </summary>
		[Description("유저ID")]
		public string User_ID { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }
		/// <summary>
		/// 회원유형
		/// </summary>
		[Description("회원유형")]
		public string MemberType { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
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
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 판매마감
		/// </summary>
		[Column("판매마감")]
		public string SalesEnd { get; set; }
		/// <summary>
		/// 성인_판매가격
		/// </summary>
		[Column("성인_판매가격")]
		public long Adult_SalesPrice { get; set; }
		/// <summary>
		/// 성인_추가금액
		/// </summary>
		[Column("성인_추가금액")]
		public long Adult_AdditionalAmount { get; set; }
		/// <summary>
		/// 성인_할인가격_OK
		/// </summary>
		[Column("성인_할인가격_OK")]
		public long Adult_DiscountPrice_OK { get; set; }
		/// <summary>
		/// 성인_할인가격_WT
		/// </summary>
		[Column("성인_할인가격_WT")]
		public long Adult_DiscountPrice_WT { get; set; }
		/// <summary>
		/// 성인_최종가격_OK
		/// </summary>
		[Column("성인_최종가격_OK")]
		public long Adult_FinalPrice_OK { get; set; }
		/// <summary>
		/// 성인_최종가격_OK_추가금액제외
		/// </summary>
		[Column("성인_최종가격_OK_추가금액제외")]
		public long Adult_FinalPrice_OK_AdditionalAmountException { get; set; }
		/// <summary>
		/// 성인_최종가격_WT
		/// </summary>
		[Column("성인_최종가격_WT")]
		public long Adult_FinalPrice_WT { get; set; }
		/// <summary>
		/// 성인_최종가격_WT_추가금액제외
		/// </summary>
		[Column("성인_최종가격_WT_추가금액제외")]
		public long Adult_FinalPrice_WT_AdditionalAmountException { get; set; }
		/// <summary>
		/// 소아N_판매가격
		/// </summary>
		[Column("소아N_판매가격")]
		public long Kid_N_SalesPrice { get; set; }
		/// <summary>
		/// 소아N_추가금액
		/// </summary>
		[Column("소아N_추가금액")]
		public long Kid_N_AdditionalAmount { get; set; }
		/// <summary>
		/// 소아N_할인금액_OK
		/// </summary>
		[Column("소아N_할인금액_OK")]
		public long Kid_N_DiscountAmount_OK { get; set; }
		/// <summary>
		/// 소아N_할인금액_WT
		/// </summary>
		[Column("소아N_할인금액_WT")]
		public long Kid_N_DiscountAmount_WT { get; set; }
		/// <summary>
		/// 소아N_최종가격_OK
		/// </summary>
		[Column("소아N_최종가격_OK")]
		public long Kid_N_FinalPrice_OK { get; set; }
		/// <summary>
		/// 소아N_최종가격_WT
		/// </summary>
		[Column("소아N_최종가격_WT")]
		public long Kid_N_FinalPrice_WT { get; set; }
		/// <summary>
		/// 소아E_판매가격
		/// </summary>
		[Column("소아E_판매가격")]
		public long Kid_E_SalesPrice { get; set; }
		/// <summary>
		/// 소아E_추가금액
		/// </summary>
		[Column("소아E_추가금액")]
		public long Kid_E_AdditionalAmount { get; set; }
		/// <summary>
		/// 소아E_할인금액_OK
		/// </summary>
		[Column("소아E_할인금액_OK")]
		public long Kid_E_DiscountAmount_OK { get; set; }
		/// <summary>
		/// 소아E_할인금액_WT
		/// </summary>
		[Column("소아E_할인금액_WT")]
		public long Kid_E_DiscountAmount_WT { get; set; }
		/// <summary>
		/// 소아E_최종가격_OK
		/// </summary>
		[Column("소아E_최종가격_OK")]
		public long Kid_E_FinalPrice_OK { get; set; }
		/// <summary>
		/// 소아E_최종가격_WT
		/// </summary>
		[Column("소아E_최종가격_WT")]
		public long Kid_E_FinalPrice_WT { get; set; }
		/// <summary>
		/// 유아_판매가격
		/// </summary>
		[Column("유아_판매가격")]
		public long Toddler_SalesPrice { get; set; }
		/// <summary>
		/// 유아_추가금액
		/// </summary>
		[Column("유아_추가금액")]
		public long Toddler_AdditionalAmount { get; set; }
		/// <summary>
		/// 유아_할인금액_OK
		/// </summary>
		[Column("유아_할인금액_OK")]
		public long Toddler_DiscountAmount_OK { get; set; }
		/// <summary>
		/// 유아_할인금액_WT
		/// </summary>
		[Column("유아_할인금액_WT")]
		public long Toddler_DiscountAmount_WT { get; set; }
		/// <summary>
		/// 유아_최종가격_OK
		/// </summary>
		[Column("유아_최종가격_OK")]
		public long Toddler_FinalPrice_OK { get; set; }
		/// <summary>
		/// 유아_최종가격_WT
		/// </summary>
		[Column("유아_최종가격_WT")]
		public long Toddler_FinalPrice_WT { get; set; }
		/// <summary>
		/// 즉시예약
		/// </summary>
		[Column("즉시예약")]
		public string ImmediateReservation { get; set; }
		/// <summary>
		/// 대기예약
		/// </summary>
		[Column("대기예약")]
		public string WaitingBooking { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 기획전번호
		/// </summary>
		[Column("기획전번호")]
		public int SpecialEventNumber { get; set; }
		/// <summary>
		/// 기획전명
		/// </summary>
		[Column("기획전명")]
		public string SpecialEventName { get; set; }
		/// <summary>
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
		/// <summary>
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 카테고리
		/// </summary>
		[Column("카테고리")]
		public string Category { get; set; }
		/// <summary>
		/// 카테고리링크
		/// </summary>
		[Column("카테고리링크")]
		public string CategoryLink { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 키워드
		/// </summary>
		[Column("키워드")]
		public string Keyword { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}
}