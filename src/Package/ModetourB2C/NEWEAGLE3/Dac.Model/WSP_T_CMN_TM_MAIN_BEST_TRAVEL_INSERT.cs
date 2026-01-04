namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_TM_MAIN_BEST_TRAVEL_INSERT
/// </summary>
public class WSP_T_CMN_TM_MAIN_BEST_TRAVEL_INSERT
{
	public const string SP_NAME = "WSP_T_CMN_TM_MAIN_BEST_TRAVEL_INSERT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// T_BestTravel
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("T_BestTravel")]
		public List<TYPE_TM_Main_Best_Travel> T_BestTravel { get; set; }
	}

}