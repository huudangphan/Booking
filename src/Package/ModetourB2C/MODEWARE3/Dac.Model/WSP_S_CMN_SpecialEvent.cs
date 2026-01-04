namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_기획전
/// </summary>
public class WSP_S_CMN_SpecialEvent
{
	public const string SP_NAME = "WSP_S_CMN_기획전";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 기획전번호
		/// </summary>
		[Description("기획전번호")]
		public int SpecialEventNumber { get; set; }
		/// <summary>
		/// 태그구분
		/// </summary>
		[Description("태그구분")]
		public byte TagClassification { get; set; }
	}

	public class Result1 : IDbResult
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
		/// 이미지6
		/// </summary>
		[Column("이미지6")]
		public string Image6 { get; set; }
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
		/// 이미지11
		/// </summary>
		[Column("이미지11")]
		public string Image11 { get; set; }
		/// <summary>
		/// 이미지F
		/// </summary>
		[Column("이미지F")]
		public string Image_F { get; set; }
		/// <summary>
		/// 이미지F1
		/// </summary>
		[Column("이미지F1")]
		public string Image_F1 { get; set; }
		/// <summary>
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
		/// <summary>
		/// 요청자
		/// </summary>
		[Column("요청자")]
		public int Requester { get; set; }
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
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 타입
		/// </summary>
		[Column("타입")]
		public string Type { get; set; }
		/// <summary>
		/// 작업자
		/// </summary>
		[Column("작업자")]
		public string Worker { get; set; }
		/// <summary>
		/// 간략타이틀
		/// </summary>
		[Column("간략타이틀")]
		public string BriefTitle { get; set; }
		/// <summary>
		/// 웹_탭구분
		/// </summary>
		[Column("웹_탭구분")]
		public string Web_TabClassification { get; set; }
		/// <summary>
		/// 웹_상품템플릿
		/// </summary>
		[Column("웹_상품템플릿")]
		public string Web_ProductTemplate { get; set; }
		/// <summary>
		/// 모바일_탭구분
		/// </summary>
		[Column("모바일_탭구분")]
		public string Mobile_TabClassification { get; set; }
		/// <summary>
		/// 태그PC
		/// </summary>
		[Column("태그PC")]
		public string Tag_PC { get; set; }
		/// <summary>
		/// 태그Mobile
		/// </summary>
		[Column("태그Mobile")]
		public string Tag_MOBILE { get; set; }
		/// <summary>
		/// 닷컴태그
		/// </summary>
		[Column("닷컴태그")]
		public string DotComTag { get; set; }
		/// <summary>
		/// 모바일태그
		/// </summary>
		[Column("모바일태그")]
		public string MobileTag { get; set; }
		/// <summary>
		/// 제휴사태그1
		/// </summary>
		[Column("제휴사태그1")]
		public string AffiliateCompanyTag1 { get; set; }
		/// <summary>
		/// 제휴사태그2
		/// </summary>
		[Column("제휴사태그2")]
		public string AffiliateCompanyTag2 { get; set; }
		/// <summary>
		/// 제휴사태그3
		/// </summary>
		[Column("제휴사태그3")]
		public string AffiliateCompanyTag3 { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 지역번호
		/// </summary>
		[Column("지역번호")]
		public int RegionNumber { get; set; }
		/// <summary>
		/// 테마번호
		/// </summary>
		[Column("테마번호")]
		public int ThemeNumber { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 제휴그룹코드
		/// </summary>
		[Column("제휴그룹코드")]
		public string AffiliateGroupCode { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public string Column1 { get; set; }
		/// <summary>
		/// Column2
		/// </summary>
		[Column("Column2")]
		public string Column2 { get; set; }
	}
}