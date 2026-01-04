namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_평가하기노출여부
/// </summary>
public class WSP_S_UnmannedSendingLeader_EvaluationDisplayOrNot
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_평가하기노출여부";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 평가하기노출여부
		/// </summary>
		[Column("평가하기노출여부")]
		public string EvaluationDisplayOrNot { get; set; }
	}
}