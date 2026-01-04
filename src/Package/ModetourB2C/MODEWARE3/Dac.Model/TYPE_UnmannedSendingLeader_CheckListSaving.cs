namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// TYPE_무인센딩인솔자_체크리스트저장
/// </summary>
public class TYPE_UnmannedSendingLeader_CheckListSaving
{
	/// <summary>
	/// DDAY
	/// </summary>
	[Description("DDAY")]
	public int DDAY { get; set; }
	/// <summary>
	/// 순서
	/// </summary>
	[Description("순서")]
	public int Order { get; set; }
	/// <summary>
	/// 체크여부
	/// </summary>
	[Description("체크여부")]
	public string CheckOrNot { get; set; }
}