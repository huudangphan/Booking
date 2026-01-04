namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_APP_인트로정보
/// </summary>
public class WSP_S_APP_IntroInfo
{
	public const string SP_NAME = "WSP_S_APP_인트로정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// RETURN_CODE
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("RETURN_CODE")]
		public int RETURN_CODE { get; set; }
		/// <summary>
		/// RETURN_MSG
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 1000)]
		[Description("RETURN_MSG")]
		public string RETURN_MSG { get; set; }
		/// <summary>
		/// RETURN_DATA
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 1000)]
		[Description("RETURN_DATA")]
		public string RETURN_DATA { get; set; }
	}

}