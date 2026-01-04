namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_SNS회원_ID생성2
/// </summary>
public class WSP_S_CMN_SNS_Member_IDGenerate2
{
	public const string SP_NAME = "WSP_S_CMN_SNS회원_ID생성2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// MODE
		/// </summary>
		[Description("MODE")]
		public string MODE { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// RETURN_CODE
		/// </summary>
		[Column("RETURN_CODE")]
		public int RETURN_CODE { get; set; }
		/// <summary>
		/// RETURN_MSG
		/// </summary>
		[Column("RETURN_MSG")]
		public string RETURN_MSG { get; set; }
		/// <summary>
		/// RETURN_DATA
		/// </summary>
		[Column("RETURN_DATA")]
		public string RETURN_DATA { get; set; }
	}
}