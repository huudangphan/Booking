namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_여권비자_상세보기
/// </summary>
public class WSP_S_PassportVisa_DetailSeeing
{
	public const string SP_NAME = "WSP_S_여권비자_상세보기";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 카테고리
		/// </summary>
		[Column("카테고리")]
		public string Category { get; set; }
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
	}

	public class Result2 : IDbResult
	{
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