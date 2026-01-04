namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_SERVICECODE_INSERT
/// </summary>
public class WSP_T_CMN_SERVICECODE_INSERT
{
	public const string SP_NAME = "WSP_T_CMN_SERVICECODE_INSERT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// Service_Serial_Number
		/// </summary>
		[Description("Service_Serial_Number")]
		public int Service_Serial_Number { get; set; }
		/// <summary>
		/// Service_Class_Code
		/// </summary>
		[Description("Service_Class_Code")]
		public string Service_Class_Code { get; set; }
		/// <summary>
		/// Service_Group_Code
		/// </summary>
		[Description("Service_Group_Code")]
		public string Service_Group_Code { get; set; }
		/// <summary>
		/// Service_Code
		/// </summary>
		[Description("Service_Code")]
		public string Service_Code { get; set; }
		/// <summary>
		/// Service_Code_Constant
		/// </summary>
		[Description("Service_Code_Constant")]
		public string Service_Code_Constant { get; set; }
		/// <summary>
		/// Service_Code_Name
		/// </summary>
		[Description("Service_Code_Name")]
		public string Service_Code_Name { get; set; }
		/// <summary>
		/// Service_Code_Value
		/// </summary>
		[Description("Service_Code_Value")]
		public string Service_Code_Value { get; set; }
		/// <summary>
		/// Depth
		/// </summary>
		[Description("Depth")]
		public int Depth { get; set; }
		/// <summary>
		/// UseStatus
		/// </summary>
		[Description("UseStatus")]
		public string UseStatus { get; set; }
		/// <summary>
		/// Sort
		/// </summary>
		[Description("Sort")]
		public int Sort { get; set; }
		/// <summary>
		/// Etc
		/// </summary>
		[Description("Etc")]
		public int Etc { get; set; }
		/// <summary>
		/// EtcData
		/// </summary>
		[Description("EtcData")]
		public string EtcData { get; set; }
	}

}