namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_TM_SERVICECODE_LIST
/// </summary>
public class WSP_S_CMN_TM_SERVICECODE_LIST
{
	public const string SP_NAME = "WSP_S_CMN_TM_SERVICECODE_LIST";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Code
		/// </summary>
		[Description("Code")]
		public string Code { get; set; }
		/// <summary>
		/// KorName
		/// </summary>
		[Description("KorName")]
		public string KorName { get; set; }
		/// <summary>
		/// Depth
		/// </summary>
		[Description("Depth")]
		public int Depth { get; set; }
		/// <summary>
		/// UseFlag
		/// </summary>
		[Description("UseFlag")]
		public string UseFlag { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Code
		/// </summary>
		[Column("Code")]
		public string Code { get; set; }
		/// <summary>
		/// Depth
		/// </summary>
		[Column("Depth")]
		public int Depth { get; set; }
		/// <summary>
		/// KorName
		/// </summary>
		[Column("KorName")]
		public string KorName { get; set; }
		/// <summary>
		/// EngName
		/// </summary>
		[Column("EngName")]
		public string EngName { get; set; }
		/// <summary>
		/// Value1
		/// </summary>
		[Column("Value1")]
		public string Value1 { get; set; }
		/// <summary>
		/// Value2
		/// </summary>
		[Column("Value2")]
		public string Value2 { get; set; }
		/// <summary>
		/// UseFlag
		/// </summary>
		[Column("UseFlag")]
		public string UseFlag { get; set; }
		/// <summary>
		/// DelFlag
		/// </summary>
		[Column("DelFlag")]
		public string DelFlag { get; set; }
		/// <summary>
		/// Order
		/// </summary>
		[Column("Order")]
		public long Order { get; set; }
		/// <summary>
		/// RegDate
		/// </summary>
		[Column("RegDate")]
		public DateTime RegDate { get; set; }
	}
}