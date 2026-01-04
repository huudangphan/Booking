namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_TM_MAINVISUAL_INSERT
/// </summary>
public class WSP_T_CMN_TM_MAINVISUAL_INSERT
{
	public const string SP_NAME = "WSP_T_CMN_TM_MAINVISUAL_INSERT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// T_Main_Visual
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("T_Main_Visual")]
		public List<TYPE_TM_Main_Visual> T_Main_Visual { get; set; }
	}

}