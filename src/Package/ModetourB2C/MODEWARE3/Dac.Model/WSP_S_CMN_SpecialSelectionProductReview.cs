namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_특선상품리뷰
/// </summary>
public class WSP_S_CMN_SpecialSelectionProductReview
{
	public const string SP_NAME = "WSP_S_CMN_특선상품리뷰";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// IDX
		/// </summary>
		[Description("IDX")]
		public int IDX { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 특선리뷰번호
		/// </summary>
		[Column("특선리뷰번호")]
		public int SpecialSelectionReviewNumber { get; set; }
		/// <summary>
		/// 특선상품번호
		/// </summary>
		[Column("특선상품번호")]
		public int SpecialSelectionProductNumber { get; set; }
		/// <summary>
		/// 노출순서
		/// </summary>
		[Column("노출순서")]
		public int DisplayOrder { get; set; }
		/// <summary>
		/// 상품평점
		/// </summary>
		[Column("상품평점")]
		public int ProductRating { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 여행후기일련번호
		/// </summary>
		[Column("여행후기일련번호")]
		public int TravelReviewSerialNumber { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public DateTime WrittingDate { get; set; }
	}
}