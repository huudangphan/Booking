namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_여행플래너_여행자문자발송_TUNE_V2
/// </summary>
public class WSP_T_CMN_TravelPlanner_TravelerMessageSending_TUNE_V2
{
	public const string SP_NAME = "WSP_T_CMN_여행플래너_여행자문자발송_TUNE_V2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Description("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// SERVER_NAME
		/// </summary>
		[Description("SERVER_NAME")]
		public string SERVER_NAME { get; set; }
		/// <summary>
		/// RIP
		/// </summary>
		[Description("RIP")]
		public string RIP { get; set; }
		/// <summary>
		/// CRM_NUM
		/// </summary>
		[Description("CRM_NUM")]
		public int CRM_NUM { get; set; }
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
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// PTPYE
		/// </summary>
		[Description("PTPYE")]
		public string PTPYE { get; set; }
		/// <summary>
		/// SEND_RESERVE_DATE
		/// </summary>
		[Description("SEND_RESERVE_DATE")]
		public string SEND_RESERVE_DATE { get; set; }
		/// <summary>
		/// TID
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("TID")]
		public List<SaleDetailNumber_TYPE> TID { get; set; }
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