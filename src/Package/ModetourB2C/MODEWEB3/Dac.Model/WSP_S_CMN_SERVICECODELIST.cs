namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_SERVICECODELIST
/// </summary>
public class WSP_S_CMN_SERVICECODELIST
{
	public const string SP_NAME = "WSP_S_CMN_SERVICECODELIST";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Gubun
		/// </summary>
		[Description("Gubun")]
		public int Gubun { get; set; }
		/// <summary>
		/// Code
		/// </summary>
		[Description("Code")]
		public string Code { get; set; }
		/// <summary>
		/// UseStatus
		/// </summary>
		[Description("UseStatus")]
		public string UseStatus { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Service_Serial_Number
		/// </summary>
		[Column("Service_Serial_Number")]
		public int Service_Serial_Number { get; set; }
		/// <summary>
		/// Service_Class_Code
		/// </summary>
		[Column("Service_Class_Code")]
		public string Service_Class_Code { get; set; }
		/// <summary>
		/// Service_Group_Code
		/// </summary>
		[Column("Service_Group_Code")]
		public string Service_Group_Code { get; set; }
		/// <summary>
		/// Service_Code
		/// </summary>
		[Column("Service_Code")]
		public string Service_Code { get; set; }
		/// <summary>
		/// Service_Code_Constant
		/// </summary>
		[Column("Service_Code_Constant")]
		public string Service_Code_Constant { get; set; }
		/// <summary>
		/// Service_Code_Name
		/// </summary>
		[Column("Service_Code_Name")]
		public string Service_Code_Name { get; set; }
		/// <summary>
		/// Service_Code_Value
		/// </summary>
		[Column("Service_Code_Value")]
		public string Service_Code_Value { get; set; }
		/// <summary>
		/// Depth
		/// </summary>
		[Column("Depth")]
		public int Depth { get; set; }
		/// <summary>
		/// UseStatus
		/// </summary>
		[Column("UseStatus")]
		public string UseStatus { get; set; }
		/// <summary>
		/// Sort
		/// </summary>
		[Column("Sort")]
		public int Sort { get; set; }
		/// <summary>
		/// Etc
		/// </summary>
		[Column("Etc")]
		public int Etc { get; set; }
		/// <summary>
		/// EtcData
		/// </summary>
		[Column("EtcData")]
		public string EtcData { get; set; }
	}
}