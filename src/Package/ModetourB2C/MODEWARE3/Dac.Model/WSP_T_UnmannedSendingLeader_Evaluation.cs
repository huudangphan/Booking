namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_무인센딩인솔자_평가
/// </summary>
public class WSP_T_UnmannedSendingLeader_Evaluation
{
	public const string SP_NAME = "WSP_T_무인센딩인솔자_평가";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// T_평가집합
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("T_평가집합")]
		public List<TYPE_UnmannedSendingLeader_Evaluation> T_EvaluationGathering { get; set; }
	}

}