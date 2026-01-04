namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_선택관광삭제
/// </summary>
public class WSP_S_UnmannedSendingLeader_SelectSightseeingDelete
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_선택관광삭제";

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
		/// <summary>
		/// 평가자
		/// </summary>
		[Description("평가자")]
		public int EvaluationPerson { get; set; }
		/// <summary>
		/// PLID
		/// </summary>
		[Description("PLID")]
		public int PLID { get; set; }
	}

}