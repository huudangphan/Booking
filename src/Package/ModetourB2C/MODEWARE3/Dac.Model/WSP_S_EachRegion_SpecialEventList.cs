namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_지역별_기획전리스트
/// </summary>
public class WSP_S_EachRegion_SpecialEventList
{
	public const string SP_NAME = "WSP_S_지역별_기획전리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 출발지
		/// </summary>
		[Description("출발지")]
		public string Departures { get; set; }
		/// <summary>
		/// 지역명
		/// </summary>
		[Description("지역명")]
		public string RegionName { get; set; }
		/// <summary>
		/// 테마명
		/// </summary>
		[Description("테마명")]
		public string ThemeName { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 기획전번호
		/// </summary>
		[Column("기획전번호")]
		public int SpecialEventNumber { get; set; }
		/// <summary>
		/// 지역리스트
		/// </summary>
		[Column("지역리스트")]
		public string RegionList { get; set; }
		/// <summary>
		/// 테마리스트
		/// </summary>
		[Column("테마리스트")]
		public string ThemeList { get; set; }
		/// <summary>
		/// 기획전명
		/// </summary>
		[Column("기획전명")]
		public string SpecialEventName { get; set; }
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
		/// 모바일이미지
		/// </summary>
		[Column("모바일이미지")]
		public string MobileImage { get; set; }
		/// <summary>
		/// 이미지_국가대륙
		/// </summary>
		[Column("이미지_국가대륙")]
		public string Image_CountryContinent { get; set; }
		/// <summary>
		/// 이미지_자유여행
		/// </summary>
		[Column("이미지_자유여행")]
		public string Image_FreeTravel { get; set; }
		/// <summary>
		/// 서브하단고정배너
		/// </summary>
		[Column("서브하단고정배너")]
		public string SubBottomFixedBanner { get; set; }
		/// <summary>
		/// 경로
		/// </summary>
		[Column("경로")]
		public string Route { get; set; }
		/// <summary>
		/// 게시만료일
		/// </summary>
		[Column("게시만료일")]
		public DateTime PostExpirationDate { get; set; }
		/// <summary>
		/// 게시시작일
		/// </summary>
		[Column("게시시작일")]
		public DateTime PostStartDate { get; set; }
		/// <summary>
		/// 타입명
		/// </summary>
		[Column("타입명")]
		public string TypeName { get; set; }
	}
}