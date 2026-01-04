namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_TM_SERVICECODE_INSERT
/// </summary>
public class WSP_T_CMN_TM_SERVICECODE_INSERT
{
	public const string SP_NAME = "WSP_T_CMN_TM_SERVICECODE_INSERT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Code
		/// </summary>
		[Description("Code")]
		public string Code { get; set; }
		/// <summary>
		/// Depth
		/// </summary>
		[Description("Depth")]
		public int Depth { get; set; }
		/// <summary>
		/// KorName
		/// </summary>
		[Description("KorName")]
		public string KorName { get; set; }
		/// <summary>
		/// EngName
		/// </summary>
		[Description("EngName")]
		public string EngName { get; set; }
		/// <summary>
		/// Value1
		/// </summary>
		[Description("Value1")]
		public string Value1 { get; set; }
		/// <summary>
		/// Value2
		/// </summary>
		[Description("Value2")]
		public string Value2 { get; set; }
		/// <summary>
		/// UseFlag
		/// </summary>
		[Description("UseFlag")]
		public string UseFlag { get; set; }
		/// <summary>
		/// DelFlag
		/// </summary>
		[Description("DelFlag")]
		public string DelFlag { get; set; }
		/// <summary>
		/// Order
		/// </summary>
		[Description("Order")]
		public int Order { get; set; }
	}

}