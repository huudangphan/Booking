namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_영업일찾기
/// </summary>
public class WSP_S_CMN_BusinessDateFinding
{
	public const string SP_NAME = "WSP_S_CMN_영업일찾기";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 기간1
		/// </summary>
		[Description("기간1")]
		public string Period1 { get; set; }
		/// <summary>
		/// 몇일후
		/// </summary>
		[Description("몇일후")]
		public int SomeDaysAfter { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 년월일
		/// </summary>
		[Column("년월일")]
		public DateTime YearMonthDate { get; set; }
	}
}