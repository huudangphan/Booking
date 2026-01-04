namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_여권비자_내용
/// </summary>
public class WSP_S_PassportVisa_Content
{
	public const string SP_NAME = "WSP_S_여권비자_내용";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 카테고리
		/// </summary>
		[Description("카테고리")]
		public string Category { get; set; }
		/// <summary>
		/// 국가
		/// </summary>
		[Description("국가")]
		public string Country { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public int Region { get; set; }
		/// <summary>
		/// 국가
		/// </summary>
		[Column("국가")]
		public int Country { get; set; }
		/// <summary>
		/// 지역명
		/// </summary>
		[Column("지역명")]
		public string RegionName { get; set; }
		/// <summary>
		/// 국가명
		/// </summary>
		[Column("국가명")]
		public string CountryName { get; set; }
		/// <summary>
		/// 대사관주소
		/// </summary>
		[Column("대사관주소")]
		public string EmbassyAddress { get; set; }
		/// <summary>
		/// 대사관전화번호
		/// </summary>
		[Column("대사관전화번호")]
		public string EmbassyPhoneNumber { get; set; }
		/// <summary>
		/// 대사관업무시간
		/// </summary>
		[Column("대사관업무시간")]
		public string EmbassyTaskTime { get; set; }
		/// <summary>
		/// 순번
		/// </summary>
		[Column("순번")]
		public byte Order { get; set; }
		/// <summary>
		/// 소제목
		/// </summary>
		[Column("소제목")]
		public string SubTitle { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
	}
}