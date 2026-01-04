namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// TYPE_앙케이트신청
/// </summary>
public class TYPE_EnqueteRequest
{
	/// <summary>
	/// 앙케이트_질문_일련번호
	/// </summary>
	[Description("앙케이트_질문_일련번호")]
	public int Enquete_Question_SerialNumber { get; set; }
	/// <summary>
	/// 선택항목
	/// </summary>
	[Description("선택항목")]
	public string SelectItem { get; set; }
	/// <summary>
	/// 등록일
	/// </summary>
	[Description("등록일")]
	public DateTime RegisterDate { get; set; }
}