namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_상품코드
/// </summary>
public class USP_S_ProductCode
{
	public const string SP_NAME = "USP_S_상품코드";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Description("상품명")]
		public string ProductName { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 대표국가
		/// </summary>
		[Column("대표국가")]
		public string RepresentativeCountry { get; set; }
		/// <summary>
		/// 대표도시
		/// </summary>
		[Column("대표도시")]
		public string RepresentativeCity { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 상품분류
		/// </summary>
		[Column("상품분류")]
		public string ProductClassification { get; set; }
		/// <summary>
		/// 담당부서
		/// </summary>
		[Column("담당부서")]
		public string ResponsibilityDepartment { get; set; }
		/// <summary>
		/// 상품분류2
		/// </summary>
		[Column("상품분류2")]
		public string ProductClassification2 { get; set; }
		/// <summary>
		/// 간략설명
		/// </summary>
		[Column("간략설명")]
		public string BriefDescription { get; set; }
		/// <summary>
		/// 상품설명
		/// </summary>
		[Column("상품설명")]
		public string ProductExplaination { get; set; }
		/// <summary>
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// 대표이미지종류
		/// </summary>
		[Column("대표이미지종류")]
		public string RepresentativeImageType { get; set; }
		/// <summary>
		/// 상품분류코드
		/// </summary>
		[Column("상품분류코드")]
		public string ProductClassificationCode { get; set; }
		/// <summary>
		/// 지역코드
		/// </summary>
		[Column("지역코드")]
		public string RegionCode { get; set; }
		/// <summary>
		/// 출발공항코드
		/// </summary>
		[Column("출발공항코드")]
		public string DepartureAirportCode { get; set; }
		/// <summary>
		/// 도착공항코드
		/// </summary>
		[Column("도착공항코드")]
		public string ArrivalAirportCode { get; set; }
	}
}