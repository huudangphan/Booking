namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// UP_평가여부_검색_MOBILE
/// </summary>
public class UP_EvaluateOrNot_Search_MOBILE
{
	public const string SP_NAME = "UP_평가여부_검색_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 평가자
		/// </summary>
		[Description("평가자")]
		public int EvaluationPerson { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 평가자
		/// </summary>
		[Column("평가자")]
		public int EvaluationPerson { get; set; }
		/// <summary>
		/// 평가점수
		/// </summary>
		[Column("평가점수")]
		public int EvaluationScore { get; set; }
		/// <summary>
		/// 평가일
		/// </summary>
		[Column("평가일")]
		public DateTime EvaluationDate { get; set; }
		/// <summary>
		/// 지금안함_설정일
		/// </summary>
		[Column("지금안함_설정일")]
		public DateTime Disable_SettingDate { get; set; }
		/// <summary>
		/// 평가기준년월
		/// </summary>
		[Column("평가기준년월")]
		public string EvaluationStandardYearMonth { get; set; }
	}
}