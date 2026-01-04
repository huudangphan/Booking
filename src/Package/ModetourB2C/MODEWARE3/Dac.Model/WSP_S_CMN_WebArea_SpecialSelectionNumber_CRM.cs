namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_웹구역_특선번호_CRM
/// </summary>
public class WSP_S_CMN_WebArea_SpecialSelectionNumber_CRM
{
	public const string SP_NAME = "WSP_S_CMN_웹구역_특선번호_CRM";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 웹구역번호리스트
		/// </summary>
		[Description("웹구역번호리스트")]
		public string WebAreaNumberList { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 구역번호
		/// </summary>
		[Column("구역번호")]
		public int AreaNumber { get; set; }
		/// <summary>
		/// IDX
		/// </summary>
		[Column("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 특가명
		/// </summary>
		[Column("특가명")]
		public string SpecialPriceName { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 부제목
		/// </summary>
		[Column("부제목")]
		public string SubTitle { get; set; }
		/// <summary>
		/// 이미지경로
		/// </summary>
		[Column("이미지경로")]
		public string ImageRoute { get; set; }
		/// <summary>
		/// 추천아이콘
		/// </summary>
		[Column("추천아이콘")]
		public string RecommendIcon { get; set; }
		/// <summary>
		/// 간략설명
		/// </summary>
		[Column("간략설명")]
		public string BriefDescription { get; set; }
		/// <summary>
		/// 할인율
		/// </summary>
		[Column("할인율")]
		public int DiscountRate { get; set; }
		/// <summary>
		/// SORT1
		/// </summary>
		[Column("SORT1")]
		public byte SORT1 { get; set; }
		/// <summary>
		/// SORT2
		/// </summary>
		[Column("SORT2")]
		public int SORT2 { get; set; }
		/// <summary>
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
		/// <summary>
		/// 최소가격
		/// </summary>
		[Column("최소가격")]
		public long MinimumPrice { get; set; }
		/// <summary>
		/// 최대가격
		/// </summary>
		[Column("최대가격")]
		public long MaximumPrice { get; set; }
		/// <summary>
		/// 시작날짜
		/// </summary>
		[Column("시작날짜")]
		public string StartDate { get; set; }
		/// <summary>
		/// 끝날짜
		/// </summary>
		[Column("끝날짜")]
		public string EndDate { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 상품분류
		/// </summary>
		[Column("상품분류")]
		public string ProductClassification { get; set; }
		/// <summary>
		/// 특전
		/// </summary>
		[Column("특전")]
		public string SpecialEvent { get; set; }
		/// <summary>
		/// 기준일
		/// </summary>
		[Column("기준일")]
		public DateTime StandardDate { get; set; }
		/// <summary>
		/// MDPICK
		/// </summary>
		[Column("MDPICK")]
		public string MDPICK { get; set; }
		/// <summary>
		/// 상품마감여부
		/// </summary>
		[Column("상품마감여부")]
		public string ProductEndOrNot { get; set; }
		/// <summary>
		/// 마감일
		/// </summary>
		[Column("마감일")]
		public DateTime EndDate2 { get; set; }
		/// <summary>
		/// 상품정상가
		/// </summary>
		[Column("상품정상가")]
		public long ProductNormalPrice { get; set; }
		/// <summary>
		/// 카테고리명
		/// </summary>
		[Column("카테고리명")]
		public string CategoryName { get; set; }
		/// <summary>
		/// 동영상URL
		/// </summary>
		[Column("동영상URL")]
		public string VideoURL { get; set; }
		/// <summary>
		/// M타임딜
		/// </summary>
		[Column("M타임딜")]
		public string M_TimeDeal { get; set; }
		/// <summary>
		/// 출발지
		/// </summary>
		[Column("출발지")]
		public string Departures { get; set; }
		/// <summary>
		/// 공동구매노출여부
		/// </summary>
		[Column("공동구매노출여부")]
		public string GroupBookingDisplayOrNot { get; set; }
		/// <summary>
		/// 공동구매_상품마감여부
		/// </summary>
		[Column("공동구매_상품마감여부")]
		public string GroupBooking_ProductEndOrNot { get; set; }
		/// <summary>
		/// 공동구매_목표모객
		/// </summary>
		[Column("공동구매_목표모객")]
		public int GroupBooking_GoalAudience { get; set; }
		/// <summary>
		/// 공동구매_할인액
		/// </summary>
		[Column("공동구매_할인액")]
		public int GroupBooking_DiscountAmount { get; set; }
		/// <summary>
		/// 공동구매_여행설명
		/// </summary>
		[Column("공동구매_여행설명")]
		public string GroupBooking_TravelExplaination { get; set; }
	}
}