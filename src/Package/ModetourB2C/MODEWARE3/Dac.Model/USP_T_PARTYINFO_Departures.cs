namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_PARTYINFO_출발지
/// </summary>
public class USP_T_PARTYINFO_Departures
{
	public const string SP_NAME = "USP_T_PARTYINFO_출발지";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 출발지코드
		/// </summary>
		[Description("출발지코드")]
		public string DeparturesCode { get; set; }
	}

}