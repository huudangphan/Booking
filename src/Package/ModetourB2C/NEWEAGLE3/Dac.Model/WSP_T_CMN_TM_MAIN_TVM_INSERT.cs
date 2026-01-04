namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_TM_MAIN_TVM_INSERT
/// </summary>
public class WSP_T_CMN_TM_MAIN_TVM_INSERT
{
	public const string SP_NAME = "WSP_T_CMN_TM_MAIN_TVM_INSERT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// T_TvM
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("T_TvM")]
		public List<TYPE_TM_Main_TvM> T_TvM { get; set; }
	}

}