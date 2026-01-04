namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_여행플래너_여행자문자발송_TUNE
/// </summary>
public class WSP_T_CMN_TravelPlanner_TravelerMessageSending_TUNE
{
	public const string SP_NAME = "WSP_T_CMN_여행플래너_여행자문자발송_TUNE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 여행자정보XML
		/// </summary>
		[Description("여행자정보XML")]
		public string TravelerInfo_XML { get; set; }
		/// <summary>
		/// RESULT
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("RESULT")]
		public int RESULT { get; set; }
		/// <summary>
		/// ERRORMSG
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 4000)]
		[Description("ERRORMSG")]
		public string ERRORMSG { get; set; }
	}

}