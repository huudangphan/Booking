namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_MPLE_평가리포트
/// </summary>
public class WSP_S_MPLE_EvaluationReport
{
	public const string SP_NAME = "WSP_S_MPLE_평가리포트";

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

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 평가율
		/// </summary>
		[Column("평가율")]
		public decimal EvaluationRate { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 평가항목
		/// </summary>
		[Column("평가항목")]
		public string EvaluationItem { get; set; }
		/// <summary>
		/// 평가건수
		/// </summary>
		[Column("평가건수")]
		public int EvaluationNumber { get; set; }
		/// <summary>
		/// 전체건수
		/// </summary>
		[Column("전체건수")]
		public int EntireNumber { get; set; }
	}
}