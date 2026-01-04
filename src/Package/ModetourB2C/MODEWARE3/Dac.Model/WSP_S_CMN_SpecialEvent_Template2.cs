namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_기획전_템플릿2
/// </summary>
public class WSP_S_CMN_SpecialEvent_Template2
{
	public const string SP_NAME = "WSP_S_CMN_기획전_템플릿2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 기획전번호
		/// </summary>
		[Description("기획전번호")]
		public int SpecialEventNumber { get; set; }
		/// <summary>
		/// 기기타입
		/// </summary>
		[Description("기기타입")]
		public byte EquipmentType { get; set; }
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
		/// 이미지_자유여행
		/// </summary>
		[Column("이미지_자유여행")]
		public string Image_FreeTravel { get; set; }
		/// <summary>
		/// 이미지_국가대륙
		/// </summary>
		[Column("이미지_국가대륙")]
		public string Image_CountryContinent { get; set; }
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
		/// 아이템노출수
		/// </summary>
		[Column("아이템노출수")]
		public int ItemDisplayNumber { get; set; }
		/// <summary>
		/// 템플릿_태그
		/// </summary>
		[Column("템플릿_태그")]
		public string Template_Tag { get; set; }
		/// <summary>
		/// 템플릿_메뉴
		/// </summary>
		[Column("템플릿_메뉴")]
		public string Template_Menu { get; set; }
		/// <summary>
		/// 템플릿_아이템
		/// </summary>
		[Column("템플릿_아이템")]
		public string Template_Item { get; set; }
		/// <summary>
		/// 풀사이즈여부
		/// </summary>
		[Column("풀사이즈여부")]
		public string FullsizeOrNot { get; set; }
		/// <summary>
		/// 항목구분
		/// </summary>
		[Column("항목구분")]
		public string ItemClassification { get; set; }
		/// <summary>
		/// 이미지_모바일
		/// </summary>
		[Column("이미지_모바일")]
		public string Image_Mobile { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 구역번호
		/// </summary>
		[Column("구역번호")]
		public int AreaNumber { get; set; }
		/// <summary>
		/// 위치
		/// </summary>
		[Column("위치")]
		public string Position { get; set; }
		/// <summary>
		/// 이미지URL
		/// </summary>
		[Column("이미지URL")]
		public string Image_URL { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 출발지
		/// </summary>
		[Column("출발지")]
		public string Departures { get; set; }
	}

	public class Result4 : IDbResult
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
}