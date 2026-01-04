namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// USP_S_철도패스_이벤트
/// </summary>
public class USP_S_RailwayPASS_Event
{
	public const string SP_NAME = "USP_S_철도패스_이벤트";

	public class Result : IDbResult
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
		/// 진행시작일
		/// </summary>
		[Column("진행시작일")]
		public string ProgressStartDate { get; set; }
		/// <summary>
		/// 진행종료일
		/// </summary>
		[Column("진행종료일")]
		public string ProgressEndDate { get; set; }
		/// <summary>
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
		/// <summary>
		/// 상세이미지
		/// </summary>
		[Column("상세이미지")]
		public string DetailImage { get; set; }
		/// <summary>
		/// 특전사함
		/// </summary>
		[Column("특전사함")]
		public string SpecialEventItem { get; set; }
		/// <summary>
		/// 구매조건
		/// </summary>
		[Column("구매조건")]
		public string BuyCondition { get; set; }
		/// <summary>
		/// 이용조건
		/// </summary>
		[Column("이용조건")]
		public string UseCondition { get; set; }
		/// <summary>
		/// 환불규정
		/// </summary>
		[Column("환불규정")]
		public string RefundRegulations { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 게시여부
		/// </summary>
		[Column("게시여부")]
		public string PostOrNot { get; set; }
		/// <summary>
		/// 게시순서
		/// </summary>
		[Column("게시순서")]
		public int PostOrder { get; set; }
		/// <summary>
		/// 등록자
		/// </summary>
		[Column("등록자")]
		public string Registerer { get; set; }
		/// <summary>
		/// 수정자
		/// </summary>
		[Column("수정자")]
		public string Editor { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public string RegisterDate { get; set; }
		/// <summary>
		/// 수정일
		/// </summary>
		[Column("수정일")]
		public string EditionDate { get; set; }
	}
}