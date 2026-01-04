namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_상품QA_내용
/// </summary>
public class WSP_S_CMN_Product_QA_Content
{
	public const string SP_NAME = "WSP_S_CMN_상품QA_내용";

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
		/// 지역
		/// </summary>
		[Description("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 검색필드
		/// </summary>
		[Description("검색필드")]
		public string SearchingField { get; set; }
		/// <summary>
		/// 검색어
		/// </summary>
		[Description("검색어")]
		public string SearchingKeyword { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 글쓴이
		/// </summary>
		[Column("글쓴이")]
		public string Writer { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 일정타입
		/// </summary>
		[Column("일정타입")]
		public string ScheduleType { get; set; }
		/// <summary>
		/// 단체명
		/// </summary>
		[Column("단체명")]
		public string GroupName { get; set; }
		/// <summary>
		/// MLoc
		/// </summary>
		[Column("MLoc")]
		public string MLoc { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 답변
		/// </summary>
		[Column("답변")]
		public string Answer { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 오픈
		/// </summary>
		[Column("오픈")]
		public string Open { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
		/// <summary>
		/// 사이트
		/// </summary>
		[Column("사이트")]
		public string Site { get; set; }
		/// <summary>
		/// 사용자오픈
		/// </summary>
		[Column("사용자오픈")]
		public string UserOpen { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 관련상품QA수
		/// </summary>
		[Column("관련상품QA수")]
		public int RelatedProduct_QA_Number { get; set; }
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
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 사용자오픈
		/// </summary>
		[Column("사용자오픈")]
		public string UserOpen { get; set; }
	}
}