namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_MPLE_의견작성
/// </summary>
public class WSP_T_MPLE_OpinionWrite
{
	public const string SP_NAME = "WSP_T_MPLE_의견작성";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 작성자
		/// </summary>
		[Description("작성자")]
		public int Writter { get; set; }
		/// <summary>
		/// 의견작성내용
		/// </summary>
		[Description("의견작성내용")]
		public string OpinionWrittingContent { get; set; }
	}

}