namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_무인센딩인솔자_MPLE평가
/// </summary>
public class WSP_T_UnmannedSendingLeader_MPLE_Evaluation
{
	public const string SP_NAME = "WSP_T_무인센딩인솔자_MPLE평가";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 평가자
		/// </summary>
		[Description("평가자")]
		public int EvaluationPerson { get; set; }
		/// <summary>
		/// 평가점수
		/// </summary>
		[Description("평가점수")]
		public int EvaluationScore { get; set; }
		/// <summary>
		/// 다음에평가하기
		/// </summary>
		[Description("다음에평가하기")]
		public string LaterEvaluation { get; set; }
	}

}