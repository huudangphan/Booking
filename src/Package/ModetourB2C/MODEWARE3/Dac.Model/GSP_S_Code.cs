namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_S_코드
/// </summary>
public class GSP_S_Code
{
	public const string SP_NAME = "GSP_S_코드";

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
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
	}
}