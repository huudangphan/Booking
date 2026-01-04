namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_앱생체인식_가능기기
/// </summary>
public class WSP_T_CMN_AppBiometrics_PossibleEquipment
{
	public const string SP_NAME = "WSP_T_CMN_앱생체인식_가능기기";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// MODE
		/// </summary>
		[Description("MODE")]
		public string MODE { get; set; }
		/// <summary>
		/// AgentID
		/// </summary>
		[Description("AgentID")]
		public int AgentID { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// APPKEY
		/// </summary>
		[Description("APPKEY")]
		public string APPKEY { get; set; }
		/// <summary>
		/// UUID
		/// </summary>
		[Description("UUID")]
		public string UUID { get; set; }
		/// <summary>
		/// TYPE
		/// </summary>
		[Description("TYPE")]
		public string TYPE { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("결과")]
		public int Result { get; set; }
		/// <summary>
		/// 에러메시지
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 1000)]
		[Description("에러메시지")]
		public string ErrorMessage { get; set; }
	}

}