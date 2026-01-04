namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_패키지따라가기_상세내용
/// </summary>
public class WSP_S_CMN_PackageFollow_DetailContent
{
	public const string SP_NAME = "WSP_S_CMN_패키지따라가기_상세내용";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 순번
		/// </summary>
		[Description("순번")]
		public int Order { get; set; }
		/// <summary>
		/// 소제목_순번
		/// </summary>
		[Description("소제목_순번")]
		public int SubTitle_Order { get; set; }
		/// <summary>
		/// KIND
		/// </summary>
		[Description("KIND")]
		public string KIND { get; set; }
	}

	public class Result1 : IDbResult
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

	public class Result2 : IDbResult
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
		/// 주
		/// </summary>
		[Column("주")]
		public int Week { get; set; }
		/// <summary>
		/// 도시
		/// </summary>
		[Column("도시")]
		public int City { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 부제목
		/// </summary>
		[Column("부제목")]
		public string SubTitle { get; set; }
		/// <summary>
		/// 메인BG이미지
		/// </summary>
		[Column("메인BG이미지")]
		public string Main_BG_Image { get; set; }
		/// <summary>
		/// 리스트사진
		/// </summary>
		[Column("리스트사진")]
		public string ListPicture { get; set; }
		/// <summary>
		/// 소개
		/// </summary>
		[Column("소개")]
		public string Introduction { get; set; }
		/// <summary>
		/// BG이미지
		/// </summary>
		[Column("BG이미지")]
		public string BG_Image { get; set; }
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
		/// <summary>
		/// 소제목수
		/// </summary>
		[Column("소제목수")]
		public int SubTitleNumber { get; set; }
		/// <summary>
		/// 관련상품수
		/// </summary>
		[Column("관련상품수")]
		public int RelatedProductNumber { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 순번
		/// </summary>
		[Column("순번")]
		public short Order { get; set; }
		/// <summary>
		/// 소제목
		/// </summary>
		[Column("소제목")]
		public string SubTitle { get; set; }
		/// <summary>
		/// 소제목_카피
		/// </summary>
		[Column("소제목_카피")]
		public string SubTitle_Copy { get; set; }
		/// <summary>
		/// 소제목_설명
		/// </summary>
		[Column("소제목_설명")]
		public string SubTitle_Explaination { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 소제목_순번
		/// </summary>
		[Column("소제목_순번")]
		public short SubTitle_Order { get; set; }
		/// <summary>
		/// 순번
		/// </summary>
		[Column("순번")]
		public short Order { get; set; }
		/// <summary>
		/// s_소제목
		/// </summary>
		[Column("s_소제목")]
		public string S_SubTitle { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// 사진
		/// </summary>
		[Column("사진")]
		public string Picture { get; set; }
		/// <summary>
		/// 사진설명
		/// </summary>
		[Column("사진설명")]
		public string PictureExplaination { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 항공
		/// </summary>
		[Column("항공")]
		public string Flight { get; set; }
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
		/// <summary>
		/// 표출상품명
		/// </summary>
		[Column("표출상품명")]
		public string DisplayProductName { get; set; }
	}
}