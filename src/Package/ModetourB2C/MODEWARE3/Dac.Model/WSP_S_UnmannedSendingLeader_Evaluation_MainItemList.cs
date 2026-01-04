namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_평가_메인항목리스트
/// </summary>
public class WSP_S_UnmannedSendingLeader_Evaluation_MainItemList
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_평가_메인항목리스트";

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
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 평가항목
		/// </summary>
		[Column("평가항목")]
		public string EvaluationItem { get; set; }
		/// <summary>
		/// 평가코드
		/// </summary>
		[Column("평가코드")]
		public string EvaluationCode { get; set; }
	}
}