namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_평가_식사
/// </summary>
public class WSP_S_UnmannedSendingLeader_Evaluation_Meal
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_평가_식사";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 날짜
		/// </summary>
		[Description("날짜")]
		public DateTime Date { get; set; }
		/// <summary>
		/// 평가자
		/// </summary>
		[Description("평가자")]
		public int EvaluationPerson { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 날짜
		/// </summary>
		[Column("날짜")]
		public DateTime Date { get; set; }
		/// <summary>
		/// 일차
		/// </summary>
		[Column("일차")]
		public int First { get; set; }
		/// <summary>
		/// 도시
		/// </summary>
		[Column("도시")]
		public string City { get; set; }
		/// <summary>
		/// PLACE명
		/// </summary>
		[Column("PLACE명")]
		public string PLACE_Name { get; set; }
		/// <summary>
		/// 평점
		/// </summary>
		[Column("평점")]
		public int Rating { get; set; }
		/// <summary>
		/// 리뷰작성여부
		/// </summary>
		[Column("리뷰작성여부")]
		public string ReviewWrittingOrNot { get; set; }
		/// <summary>
		/// 평가항목
		/// </summary>
		[Column("평가항목")]
		public string EvaluationItem { get; set; }
		/// <summary>
		/// 세부항목
		/// </summary>
		[Column("세부항목")]
		public string DetailItem { get; set; }
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
	}
}