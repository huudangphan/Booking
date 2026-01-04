namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_MD강력추천_상세보기
/// </summary>
public class WSP_S_MDStrongRecommendation_DetailSeeing
{
	public const string SP_NAME = "WSP_S_MD강력추천_상세보기";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 출력
		/// </summary>
		[Description("출력")]
		public string PrintOut { get; set; }
	}

	public class Result1 : IDbResult
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
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
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
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 태그
		/// </summary>
		[Column("태그")]
		public byte Tag { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 아이피
		/// </summary>
		[Column("아이피")]
		public string IP { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 순번
		/// </summary>
		[Column("순번")]
		public short Order { get; set; }
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
		/// 나열순서
		/// </summary>
		[Column("나열순서")]
		public short ListingOrder { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
	}
}