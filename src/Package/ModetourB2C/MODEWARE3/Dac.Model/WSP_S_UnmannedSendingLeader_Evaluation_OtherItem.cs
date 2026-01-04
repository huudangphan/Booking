namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_평가_기타항목
/// </summary>
public class WSP_S_UnmannedSendingLeader_Evaluation_OtherItem
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_평가_기타항목";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 평가항목코드
		/// </summary>
		[Description("평가항목코드")]
		public string EvaluationItemCode { get; set; }
		/// <summary>
		/// 평가자
		/// </summary>
		[Description("평가자")]
		public int EvaluationPerson { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 날짜
		/// </summary>
		[Column("날짜")]
		public string Date { get; set; }
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
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
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
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 저장여부
		/// </summary>
		[Column("저장여부")]
		public string SavingOrNot { get; set; }
		/// <summary>
		/// 세부항목
		/// </summary>
		[Column("세부항목")]
		public string DetailItem { get; set; }
	}
}