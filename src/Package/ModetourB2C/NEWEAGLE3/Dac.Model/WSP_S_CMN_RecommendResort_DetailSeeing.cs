namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_추천리조트_상세보기
/// </summary>
public class WSP_S_CMN_RecommendResort_DetailSeeing
{
	public const string SP_NAME = "WSP_S_CMN_추천리조트_상세보기";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// ID
		/// </summary>
		[Description("ID")]
		public int ID { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 추천지
		/// </summary>
		[Column("추천지")]
		public string RecommendArea { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
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
		/// 사진
		/// </summary>
		[Column("사진")]
		public string Picture { get; set; }
		/// <summary>
		/// 주소
		/// </summary>
		[Column("주소")]
		public string Address { get; set; }
		/// <summary>
		/// 전화
		/// </summary>
		[Column("전화")]
		public string Phone { get; set; }
		/// <summary>
		/// 팩스
		/// </summary>
		[Column("팩스")]
		public string Fax { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 홈페이지
		/// </summary>
		[Column("홈페이지")]
		public string HomePage { get; set; }
		/// <summary>
		/// 사진1
		/// </summary>
		[Column("사진1")]
		public string Picture1 { get; set; }
		/// <summary>
		/// 사진2
		/// </summary>
		[Column("사진2")]
		public string Picture2 { get; set; }
		/// <summary>
		/// 사진3
		/// </summary>
		[Column("사진3")]
		public string Picture3 { get; set; }
		/// <summary>
		/// 사진4
		/// </summary>
		[Column("사진4")]
		public string Picture4 { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 대륙
		/// </summary>
		[Column("대륙")]
		public int Continent { get; set; }
		/// <summary>
		/// 나라
		/// </summary>
		[Column("나라")]
		public int Country { get; set; }
		/// <summary>
		/// 도시
		/// </summary>
		[Column("도시")]
		public int City { get; set; }
		/// <summary>
		/// 나라명
		/// </summary>
		[Column("나라명")]
		public string CountryName { get; set; }
		/// <summary>
		/// 도시명
		/// </summary>
		[Column("도시명")]
		public string CityName { get; set; }
	}

	public class Result2 : IDbResult
	{
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
		/// 사진
		/// </summary>
		[Column("사진")]
		public string Picture { get; set; }
	}

	public class Result3 : IDbResult
	{
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
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
	}
}