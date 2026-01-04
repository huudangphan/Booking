namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_채용_참조2
/// </summary>
public class WSP_S_Recruitment_Reference2
{
	public const string SP_NAME = "WSP_S_채용_참조2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 어학함수구분
		/// </summary>
		[Description("어학함수구분")]
		public string LanguageFunctionClassification { get; set; }
		/// <summary>
		/// 코드번호
		/// </summary>
		[Description("코드번호")]
		public int CodeNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 코드번호
		/// </summary>
		[Column("코드번호")]
		public int CodeNumber { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
	}
}