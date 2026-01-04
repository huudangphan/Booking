namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_회원_CI_DI
/// </summary>
public class USP_S_Member_CI_DI
{
	public const string SP_NAME = "USP_S_회원_CI_DI";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// CI
		/// </summary>
		[Description("CI")]
		public string CI { get; set; }
		/// <summary>
		/// DI
		/// </summary>
		[Description("DI")]
		public string DI { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public int Column1 { get; set; }
	}
}