namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// USP_S_기초코드
/// </summary>
public class USP_S_BasicCode
{
	public const string SP_NAME = "USP_S_기초코드";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 종류
		/// </summary>
		[Description("종류")]
		public string Type { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
	}
}