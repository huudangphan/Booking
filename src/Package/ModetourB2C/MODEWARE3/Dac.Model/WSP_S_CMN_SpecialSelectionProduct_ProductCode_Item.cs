namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_특선상품_상품코드_항목
/// </summary>
public class WSP_S_CMN_SpecialSelectionProduct_ProductCode_Item
{
	public const string SP_NAME = "WSP_S_CMN_특선상품_상품코드_항목";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
	}

	public class Result1 : IDbResult
	{
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
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
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
		/// 최소단체번호
		/// </summary>
		[Column("최소단체번호")]
		public int MinimumGroupNumber { get; set; }
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
		/// 대표국가코드
		/// </summary>
		[Column("대표국가코드")]
		public string RepresentativeCountryCode { get; set; }
		/// <summary>
		/// 대표도시코드
		/// </summary>
		[Column("대표도시코드")]
		public string RepresentativeCityCode { get; set; }
		/// <summary>
		/// 기준일
		/// </summary>
		[Column("기준일")]
		public string StandardDate { get; set; }
		/// <summary>
		/// 마감일
		/// </summary>
		[Column("마감일")]
		public string EndDate { get; set; }
		/// <summary>
		/// 기준커미션율
		/// </summary>
		[Column("기준커미션율")]
		public decimal StandardCommisionRate { get; set; }
		/// <summary>
		/// 단체분류
		/// </summary>
		[Column("단체분류")]
		public string GroupClassification { get; set; }
		/// <summary>
		/// 출발공항코드
		/// </summary>
		[Column("출발공항코드")]
		public string DepartureAirportCode { get; set; }
		/// <summary>
		/// 일정버전
		/// </summary>
		[Column("일정버전")]
		public double ScheduleVersion { get; set; }
		/// <summary>
		/// 최소가격
		/// </summary>
		[Column("최소가격")]
		public long MinimumPrice { get; set; }
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