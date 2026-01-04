namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_평가_메인
/// </summary>
public class WSP_S_UnmannedSendingLeader_Evaluation_Main
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_평가_메인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
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
		/// 일
		/// </summary>
		[Column("일")]
		public string Date2 { get; set; }
		/// <summary>
		/// 요일
		/// </summary>
		[Column("요일")]
		public string Day { get; set; }
		/// <summary>
		/// 일차
		/// </summary>
		[Column("일차")]
		public int First { get; set; }
	}
}