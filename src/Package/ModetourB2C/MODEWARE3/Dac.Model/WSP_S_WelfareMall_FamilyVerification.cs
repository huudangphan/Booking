namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_복지몰_가족인증
/// </summary>
public class WSP_S_WelfareMall_FamilyVerification
{
	public const string SP_NAME = "WSP_S_복지몰_가족인증";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Column("생년월일")]
		public string BirthYearMonthDay { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 회원유형
		/// </summary>
		[Column("회원유형")]
		public string MemberType { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public DateTime ArrivalDate { get; set; }
		/// <summary>
		/// 항공코드
		/// </summary>
		[Column("항공코드")]
		public string FlightCode { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
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
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 성인_판매가격
		/// </summary>
		[Column("성인_판매가격")]
		public long Adult_SalesPrice { get; set; }
		/// <summary>
		/// 성인_판매가격_예약판매가단체
		/// </summary>
		[Column("성인_판매가격_예약판매가단체")]
		public long Adult_SalesPrice_ReservationSellingPriceGroup { get; set; }
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
		/// 성인_영업팀할인
		/// </summary>
		[Column("성인_영업팀할인")]
		public long Adult_BusinessTeamDiscount { get; set; }
		/// <summary>
		/// 성인_상품팀웨이버_OK
		/// </summary>
		[Column("성인_상품팀웨이버_OK")]
		public long Adult_ProductTeamWaiver_OK { get; set; }
		/// <summary>
		/// 성인_상품팀웨이버_WT
		/// </summary>
		[Column("성인_상품팀웨이버_WT")]
		public long Adult_ProductTeamWaiver_WT { get; set; }
		/// <summary>
		/// 소아N_판매가격
		/// </summary>
		[Column("소아N_판매가격")]
		public long Kid_N_SalesPrice { get; set; }
		/// <summary>
		/// 소아N_판매가격_예약판매가단체
		/// </summary>
		[Column("소아N_판매가격_예약판매가단체")]
		public long Kid_N_SalesPrice_ReservationSellingPriceGroup { get; set; }
		/// <summary>
		/// 소아N_추가금액
		/// </summary>
		[Column("소아N_추가금액")]
		public long Kid_N_AdditionalAmount { get; set; }
		/// <summary>
		/// 소아N_할인금액_OK
		/// </summary>
		[Column("소아N_할인금액_OK")]
		public int Kid_N_DiscountAmount_OK { get; set; }
		/// <summary>
		/// 소아N_할인금액_WT
		/// </summary>
		[Column("소아N_할인금액_WT")]
		public int Kid_N_DiscountAmount_WT { get; set; }
		/// <summary>
		/// 소아N_최종가격_OK
		/// </summary>
		[Column("소아N_최종가격_OK")]
		public long Kid_N_FinalPrice_OK { get; set; }
		/// <summary>
		/// 소아N_최종가격_OK_추가금액제외
		/// </summary>
		[Column("소아N_최종가격_OK_추가금액제외")]
		public long Kid_N_FinalPrice_OK_AdditionalAmountException { get; set; }
		/// <summary>
		/// 소아N_최종가격_WT
		/// </summary>
		[Column("소아N_최종가격_WT")]
		public long Kid_N_FinalPrice_WT { get; set; }
		/// <summary>
		/// 소아N_최종가격_WT_추가금액제외
		/// </summary>
		[Column("소아N_최종가격_WT_추가금액제외")]
		public long Kid_N_FinalPrice_WT_AdditionalAmountException { get; set; }
		/// <summary>
		/// 소아N_영업팀할인
		/// </summary>
		[Column("소아N_영업팀할인")]
		public int Kid_N_BusinessTeamDiscount { get; set; }
		/// <summary>
		/// 소아N_상품팀웨이버_OK
		/// </summary>
		[Column("소아N_상품팀웨이버_OK")]
		public int Kid_N_ProductTeamWaiver_OK { get; set; }
		/// <summary>
		/// 소아N_상품팀웨이버_WT
		/// </summary>
		[Column("소아N_상품팀웨이버_WT")]
		public int Kid_N_ProductTeamWaiver_WT { get; set; }
		/// <summary>
		/// 소아E_판매가격
		/// </summary>
		[Column("소아E_판매가격")]
		public long Kid_E_SalesPrice { get; set; }
		/// <summary>
		/// 소아E_판매가격_예약판매가단체
		/// </summary>
		[Column("소아E_판매가격_예약판매가단체")]
		public long Kid_E_SalesPrice_ReservationSellingPriceGroup { get; set; }
		/// <summary>
		/// 소아E_추가금액
		/// </summary>
		[Column("소아E_추가금액")]
		public long Kid_E_AdditionalAmount { get; set; }
		/// <summary>
		/// 소아E_할인금액_OK
		/// </summary>
		[Column("소아E_할인금액_OK")]
		public int Kid_E_DiscountAmount_OK { get; set; }
		/// <summary>
		/// 소아E_할인금액_WT
		/// </summary>
		[Column("소아E_할인금액_WT")]
		public int Kid_E_DiscountAmount_WT { get; set; }
		/// <summary>
		/// 소아E_최종가격_OK
		/// </summary>
		[Column("소아E_최종가격_OK")]
		public long Kid_E_FinalPrice_OK { get; set; }
		/// <summary>
		/// 소아E_최종가격_OK_추가금액제외
		/// </summary>
		[Column("소아E_최종가격_OK_추가금액제외")]
		public long Kid_E_FinalPrice_OK_AdditionalAmountException { get; set; }
		/// <summary>
		/// 소아E_최종가격_WT
		/// </summary>
		[Column("소아E_최종가격_WT")]
		public long Kid_E_FinalPrice_WT { get; set; }
		/// <summary>
		/// 소아E_최종가격_WT_추가금액제외
		/// </summary>
		[Column("소아E_최종가격_WT_추가금액제외")]
		public long Kid_E_FinalPrice_WT_AdditionalAmountException { get; set; }
		/// <summary>
		/// 소아E_영업팀할인
		/// </summary>
		[Column("소아E_영업팀할인")]
		public int Kid_E_BusinessTeamDiscount { get; set; }
		/// <summary>
		/// 소아E_상품팀웨이버_OK
		/// </summary>
		[Column("소아E_상품팀웨이버_OK")]
		public int Kid_E_ProductTeamWaiver_OK { get; set; }
		/// <summary>
		/// 소아E_상품팀웨이버_WT
		/// </summary>
		[Column("소아E_상품팀웨이버_WT")]
		public int Kid_E_ProductTeamWaiver_WT { get; set; }
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
		public int Toddler_DiscountAmount_OK { get; set; }
		/// <summary>
		/// 유아_할인금액_WT
		/// </summary>
		[Column("유아_할인금액_WT")]
		public int Toddler_DiscountAmount_WT { get; set; }
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
		/// 유아_최종가격_OK_추가금액제외
		/// </summary>
		[Column("유아_최종가격_OK_추가금액제외")]
		public long Toddler_FinalPrice_OK_AdditionalAmountException { get; set; }
		/// <summary>
		/// 유아_최종가격_WT_추가금액제외
		/// </summary>
		[Column("유아_최종가격_WT_추가금액제외")]
		public long Toddler_FinalPrice_WT_AdditionalAmountException { get; set; }
	}
}