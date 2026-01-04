namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_ADMIN_기획전리스트
/// </summary>
public class WSP_S_CMN_ADMIN_SpecialEventList
{
	public const string SP_NAME = "WSP_S_CMN_ADMIN_기획전리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 현재페이지
		/// </summary>
		[Description("현재페이지")]
		public int CurrentPage { get; set; }
		/// <summary>
		/// 페이지당글개수
		/// </summary>
		[Description("페이지당글개수")]
		public int EachPageCharactersNumber { get; set; }
		/// <summary>
		/// 검색필드
		/// </summary>
		[Description("검색필드")]
		public string SearchingField { get; set; }
		/// <summary>
		/// 검색어
		/// </summary>
		[Description("검색어")]
		public string SearchingKeyword { get; set; }
		/// <summary>
		/// 전체게시글수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체게시글수")]
		public int EntirePostCharactersNumber { get; set; }
		/// <summary>
		/// 전체페이지수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체페이지수")]
		public int EntirePageNumber { get; set; }
	}

	public class Result : IDbResult
	{
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
		/// 키워드
		/// </summary>
		[Column("키워드")]
		public string Keyword { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// 이미지1
		/// </summary>
		[Column("이미지1")]
		public string Image1 { get; set; }
		/// <summary>
		/// 이미지2
		/// </summary>
		[Column("이미지2")]
		public string Image2 { get; set; }
		/// <summary>
		/// 이미지3
		/// </summary>
		[Column("이미지3")]
		public string Image3 { get; set; }
		/// <summary>
		/// 이미지4
		/// </summary>
		[Column("이미지4")]
		public string Image4 { get; set; }
		/// <summary>
		/// 이미지5
		/// </summary>
		[Column("이미지5")]
		public string Image5 { get; set; }
		/// <summary>
		/// 이미지7
		/// </summary>
		[Column("이미지7")]
		public string Image7 { get; set; }
		/// <summary>
		/// 이미지8
		/// </summary>
		[Column("이미지8")]
		public string Image8 { get; set; }
		/// <summary>
		/// 이미지9
		/// </summary>
		[Column("이미지9")]
		public string Image9 { get; set; }
		/// <summary>
		/// 이미지10
		/// </summary>
		[Column("이미지10")]
		public string Image10 { get; set; }
		/// <summary>
		/// 이미지F
		/// </summary>
		[Column("이미지F")]
		public string Image_F { get; set; }
		/// <summary>
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
		/// <summary>
		/// 요청자명
		/// </summary>
		[Column("요청자명")]
		public string RequesterName { get; set; }
		/// <summary>
		/// 요청일
		/// </summary>
		[Column("요청일")]
		public DateTime RequestDate { get; set; }
		/// <summary>
		/// 제휴여부
		/// </summary>
		[Column("제휴여부")]
		public string AffiliateOrNot { get; set; }
		/// <summary>
		/// 게시
		/// </summary>
		[Column("게시")]
		public string Post { get; set; }
		/// <summary>
		/// 게시시작일
		/// </summary>
		[Column("게시시작일")]
		public DateTime PostStartDate { get; set; }
		/// <summary>
		/// 게시만료일
		/// </summary>
		[Column("게시만료일")]
		public DateTime PostExpirationDate { get; set; }
		/// <summary>
		/// 작업자
		/// </summary>
		[Column("작업자")]
		public string Worker { get; set; }
	}
}