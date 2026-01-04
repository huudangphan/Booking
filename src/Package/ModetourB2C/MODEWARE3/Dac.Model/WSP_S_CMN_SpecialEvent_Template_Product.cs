namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_기획전_템플릿_상품
/// </summary>
public class WSP_S_CMN_SpecialEvent_Template_Product
{
	public const string SP_NAME = "WSP_S_CMN_기획전_템플릿_상품";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구역번호
		/// </summary>
		[Description("구역번호")]
		public int AreaNumber { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 위치
		/// </summary>
		[Column("위치")]
		public string Position { get; set; }
		/// <summary>
		/// 대표도시명
		/// </summary>
		[Column("대표도시명")]
		public string RepresentativeCityName { get; set; }
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
		public int MinimumPrice { get; set; }
		/// <summary>
		/// 최대가격
		/// </summary>
		[Column("최대가격")]
		public int MaximumPrice { get; set; }
		/// <summary>
		/// MLOC
		/// </summary>
		[Column("MLOC")]
		public string MLOC { get; set; }
		/// <summary>
		/// 특전
		/// </summary>
		[Column("특전")]
		public string SpecialEvent { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
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
		/// 입찰시작가격
		/// </summary>
		[Column("입찰시작가격")]
		public long TenderStartPrice { get; set; }
		/// <summary>
		/// 프로모션
		/// </summary>
		[Column("프로모션")]
		public string Promotion { get; set; }
	}
}