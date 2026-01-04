namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_인도네시아_QNA패스워드확인
/// </summary>
public class WSP_S_Indonesia_QNA_PasswordConfirm
{
	public const string SP_NAME = "WSP_S_인도네시아_QNA패스워드확인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 언어구분
		/// </summary>
		[Description("언어구분")]
		public string LanguageClassification { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 비밀번호일치
		/// </summary>
		[Column("비밀번호일치")]
		public int PasswordMatched { get; set; }
	}
}