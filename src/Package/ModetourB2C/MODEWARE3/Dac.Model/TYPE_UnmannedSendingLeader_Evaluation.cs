namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// TYPE_무인센딩인솔자_평가
/// </summary>
public class TYPE_UnmannedSendingLeader_Evaluation
{
	/// <summary>
	/// 여행일
	/// </summary>
	[Description("여행일")]
	public DateTime TravelDate { get; set; }
	/// <summary>
	/// 평가항목
	/// </summary>
	[Description("평가항목")]
	public string EvaluationItem { get; set; }
	/// <summary>
	/// 세부항목
	/// </summary>
	[Description("세부항목")]
	public string DetailItem { get; set; }
	/// <summary>
	/// PLID
	/// </summary>
	[Description("PLID")]
	public int PLID { get; set; }
	/// <summary>
	/// 평가자
	/// </summary>
	[Description("평가자")]
	public int EvaluationPerson { get; set; }
	/// <summary>
	/// 평점
	/// </summary>
	[Description("평점")]
	public int Rating { get; set; }
}