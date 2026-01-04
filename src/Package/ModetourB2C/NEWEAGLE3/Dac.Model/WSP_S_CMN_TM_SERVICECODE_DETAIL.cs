namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_TM_SERVICECODE_DETAIL
/// </summary>
public class WSP_S_CMN_TM_SERVICECODE_DETAIL
{
	public const string SP_NAME = "WSP_S_CMN_TM_SERVICECODE_DETAIL";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Code
		/// </summary>
		[Description("Code")]
		public string Code { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Code
		/// </summary>
		[Column("Code")]
		public string Code { get; set; }
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
		/// Depth
		/// </summary>
		[Column("Depth")]
		public int Depth { get; set; }
	}
}