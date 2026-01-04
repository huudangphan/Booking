namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_상품노하우_상세보기
/// </summary>
public class WSP_S_CMN_ProductKnowHow_DetailSeeing
{
	public const string SP_NAME = "WSP_S_CMN_상품노하우_상세보기";

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
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 카테고리
		/// </summary>
		[Column("카테고리")]
		public string Category { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 분류
		/// </summary>
		[Column("분류")]
		public int Classification { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 조회
		/// </summary>
		[Column("조회")]
		public int Search { get; set; }
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