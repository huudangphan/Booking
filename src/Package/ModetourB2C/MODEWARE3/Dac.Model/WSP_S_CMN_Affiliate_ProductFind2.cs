namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_제휴_상품조회2
/// </summary>
public class WSP_S_CMN_Affiliate_ProductFind2
{
	public const string SP_NAME = "WSP_S_CMN_제휴_상품조회2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 항공코드
		/// </summary>
		[Description("항공코드")]
		public string FlightCode { get; set; }
		/// <summary>
		/// 상품분류
		/// </summary>
		[Description("상품분류")]
		public short ProductClassification { get; set; }
		/// <summary>
		/// 상품분류2
		/// </summary>
		[Description("상품분류2")]
		public short ProductClassification2 { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 상품코드2
		/// </summary>
		[Column("상품코드2")]
		public string ProductCode2 { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 항공코드
		/// </summary>
		[Column("항공코드")]
		public string FlightCode { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 등록단체번호
		/// </summary>
		[Column("등록단체번호")]
		public int RegisterGroupNumber { get; set; }
		/// <summary>
		/// 제휴상품번호
		/// </summary>
		[Column("제휴상품번호")]
		public string AffiliateProductNumber { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 추가요금_TAX
		/// </summary>
		[Column("추가요금_TAX")]
		public long AddFare_TAX { get; set; }
		/// <summary>
		/// 잔여좌석
		/// </summary>
		[Column("잔여좌석")]
		public int AvailableSeat { get; set; }
		/// <summary>
		/// 판매가_어른
		/// </summary>
		[Column("판매가_어른")]
		public long SellingPrice_Adult { get; set; }
		/// <summary>
		/// 판매가_소아N
		/// </summary>
		[Column("판매가_소아N")]
		public long SellingPrice_Kid_N { get; set; }
		/// <summary>
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// 상세내용
		/// </summary>
		[Column("상세내용")]
		public string DetailContent { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 수정일
		/// </summary>
		[Column("수정일")]
		public DateTime EditionDate { get; set; }
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
		/// 연결날짜
		/// </summary>
		[Column("연결날짜")]
		public int ConnectionDate { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public long Sorting { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 상품코드2
		/// </summary>
		[Column("상품코드2")]
		public string ProductCode2 { get; set; }
		/// <summary>
		/// 옵션일련번호
		/// </summary>
		[Column("옵션일련번호")]
		public int OptionSerialNumber { get; set; }
		/// <summary>
		/// 설정값
		/// </summary>
		[Column("설정값")]
		public string SettingValue { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 그룹명
		/// </summary>
		[Column("그룹명")]
		public string GroupName { get; set; }
		/// <summary>
		/// 속성
		/// </summary>
		[Column("속성")]
		public string Attribute { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public long Sorting { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 그룹명
		/// </summary>
		[Column("그룹명")]
		public string GroupName { get; set; }
		/// <summary>
		/// 기본값
		/// </summary>
		[Column("기본값")]
		public string DefaultValue { get; set; }
		/// <summary>
		/// 속성
		/// </summary>
		[Column("속성")]
		public string Attribute { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public long Sorting { get; set; }
	}
}