namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_특선상품_특선번호_항목
/// </summary>
public class WSP_S_CMN_SpecialSelectionProduct_SpecialSelectionNumber_Item
{
	public const string SP_NAME = "WSP_S_CMN_특선상품_특선번호_항목";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// IDX
		/// </summary>
		[Description("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// SITENO
		/// </summary>
		[Description("SITENO")]
		public int SITENO { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 특선상품번호
		/// </summary>
		[Column("특선상품번호")]
		public int SpecialSelectionProductNumber { get; set; }
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
		/// 단체명
		/// </summary>
		[Column("단체명")]
		public string GroupName { get; set; }
		/// <summary>
		/// 부제목
		/// </summary>
		[Column("부제목")]
		public string SubTitle { get; set; }
		/// <summary>
		/// MDPICK
		/// </summary>
		[Column("MDPICK")]
		public string MDPICK { get; set; }
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
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// 할인율
		/// </summary>
		[Column("할인율")]
		public int DiscountRate { get; set; }
		/// <summary>
		/// 특전
		/// </summary>
		[Column("특전")]
		public string SpecialEvent { get; set; }
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
		/// 추천글
		/// </summary>
		[Column("추천글")]
		public string Blurb { get; set; }
		/// <summary>
		/// 등록기한
		/// </summary>
		[Column("등록기한")]
		public DateTime RegisterDeadline { get; set; }
		/// <summary>
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public string GroupNumber { get; set; }
		/// <summary>
		/// 항공코드
		/// </summary>
		[Column("항공코드")]
		public string FlightCode { get; set; }
		/// <summary>
		/// 최초출발일
		/// </summary>
		[Column("최초출발일")]
		public string FirstDepartureDate { get; set; }
		/// <summary>
		/// 마지막출발일
		/// </summary>
		[Column("마지막출발일")]
		public string LastDepartureDate { get; set; }
		/// <summary>
		/// 상품분류
		/// </summary>
		[Column("상품분류")]
		public string ProductClassification { get; set; }
		/// <summary>
		/// 최소단체번호
		/// </summary>
		[Column("최소단체번호")]
		public int MinimumGroupNumber { get; set; }
		/// <summary>
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
		/// <summary>
		/// 대표이미지종류
		/// </summary>
		[Column("대표이미지종류")]
		public string RepresentativeImageType { get; set; }
		/// <summary>
		/// 대표국가
		/// </summary>
		[Column("대표국가")]
		public int RepresentativeCountry { get; set; }
		/// <summary>
		/// 대표도시
		/// </summary>
		[Column("대표도시")]
		public int RepresentativeCity { get; set; }
		/// <summary>
		/// 대표국가명
		/// </summary>
		[Column("대표국가명")]
		public string RepresentativeCountryName { get; set; }
		/// <summary>
		/// 대표도시명
		/// </summary>
		[Column("대표도시명")]
		public string RepresentativeCityName { get; set; }
		/// <summary>
		/// 지역번호
		/// </summary>
		[Column("지역번호")]
		public int RegionNumber { get; set; }
		/// <summary>
		/// 기준일
		/// </summary>
		[Column("기준일")]
		public DateTime StandardDate { get; set; }
		/// <summary>
		/// 마감일
		/// </summary>
		[Column("마감일")]
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 최소가격
		/// </summary>
		[Column("최소가격")]
		public long MinimumPrice { get; set; }
		/// <summary>
		/// 노출시작일
		/// </summary>
		[Column("노출시작일")]
		public int DisplayStartDate { get; set; }
		/// <summary>
		/// 출발공항코드
		/// </summary>
		[Column("출발공항코드")]
		public string DepartureAirportCode { get; set; }
		/// <summary>
		/// 상품마감여부
		/// </summary>
		[Column("상품마감여부")]
		public string ProductEndOrNot { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 객체번호
		/// </summary>
		[Column("객체번호")]
		public int ObjectNumber { get; set; }
	}
}