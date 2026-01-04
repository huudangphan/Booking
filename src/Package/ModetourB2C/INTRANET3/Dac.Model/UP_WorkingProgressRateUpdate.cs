namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// UP_작업진행률업데이트
/// </summary>
public class UP_WorkingProgressRateUpdate
{
	public const string SP_NAME = "UP_작업진행률업데이트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 평가리스트
		/// </summary>
		[Description("평가리스트")]
		public string EvaluationList { get; set; }
		/// <summary>
		/// 관리자비고내용
		/// </summary>
		[Description("관리자비고내용")]
		public string AdminNoteContent { get; set; }
	}

}