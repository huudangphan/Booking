namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_DBHELPER_UPDATE
/// </summary>
public class WSP_T_CMN_DBHELPER_UPDATE
{
	public const string SP_NAME = "WSP_T_CMN_DBHELPER_UPDATE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Idx
		/// </summary>
		[Description("Idx")]
		public int Idx { get; set; }
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
		/// Value
		/// </summary>
		[Description("Value")]
		public string Value { get; set; }
		/// <summary>
		/// GroupNum
		/// </summary>
		[Description("GroupNum")]
		public string GroupNum { get; set; }
	}

}