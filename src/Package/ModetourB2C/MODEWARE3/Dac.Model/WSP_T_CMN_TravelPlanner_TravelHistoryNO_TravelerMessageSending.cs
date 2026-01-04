namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_여행플래너_여행이력무_여행자문자발송
/// </summary>
public class WSP_T_CMN_TravelPlanner_TravelHistoryNO_TravelerMessageSending
{
	public const string SP_NAME = "WSP_T_CMN_여행플래너_여행이력무_여행자문자발송";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("이름")]
		public List<TYPE_MODETalkReceiver> Name { get; set; }
		/// <summary>
		/// TITLE
		/// </summary>
		[Description("TITLE")]
		public string TITLE { get; set; }
		/// <summary>
		/// CONTENTS
		/// </summary>
		[Description("CONTENTS")]
		public string CONTENTS { get; set; }
		/// <summary>
		/// MTYPE
		/// </summary>
		[Description("MTYPE")]
		public string MTYPE { get; set; }
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
		/// <summary>
		/// CRM_NUM
		/// </summary>
		[Description("CRM_NUM")]
		public int CRM_NUM { get; set; }
	}

}