namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_전문가_패키지_통합_저장
/// </summary>
public class WSP_T_CMN_Expert_Package_Integrated_Saving
{
	public const string SP_NAME = "WSP_T_CMN_전문가_패키지_통합_저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Description("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 메뉴구분
		/// </summary>
		[Description("메뉴구분")]
		public string MenuClassification { get; set; }
		/// <summary>
		/// 대륙
		/// </summary>
		[Description("대륙")]
		public int Continent { get; set; }
		/// <summary>
		/// 국가
		/// </summary>
		[Description("국가")]
		public int Country { get; set; }
		/// <summary>
		/// 도시
		/// </summary>
		[Description("도시")]
		public int City { get; set; }
		/// <summary>
		/// 테마
		/// </summary>
		[Description("테마")]
		public string Theme { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Description("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 간략설명
		/// </summary>
		[Description("간략설명")]
		public string BriefDescription { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Description("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 내용2
		/// </summary>
		[Description("내용2")]
		public string Content2 { get; set; }
		/// <summary>
		/// 리스트이미지
		/// </summary>
		[Description("리스트이미지")]
		public string ListImage { get; set; }
		/// <summary>
		/// 메인BG이미지
		/// </summary>
		[Description("메인BG이미지")]
		public string Main_BG_Image { get; set; }
		/// <summary>
		/// 관련상품
		/// </summary>
		[Description("관련상품")]
		public string RelatedProduct { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 결과2
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 10)]
		[Description("결과2")]
		public string Result2 { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 주
		/// </summary>
		[Description("주")]
		public int Week { get; set; }
		/// <summary>
		/// 내용3
		/// </summary>
		[Description("내용3")]
		public string Content3 { get; set; }
	}

}