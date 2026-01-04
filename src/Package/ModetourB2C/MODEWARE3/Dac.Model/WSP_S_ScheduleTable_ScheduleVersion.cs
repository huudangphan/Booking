namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_일정표_일정버전
/// </summary>
public class WSP_S_ScheduleTable_ScheduleVersion
{
	public const string SP_NAME = "WSP_S_일정표_일정버전";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 일정버전
		/// </summary>
		[Column("일정버전")]
		public double ScheduleVersion { get; set; }
		/// <summary>
		/// 다른버전보기가능여부
		/// </summary>
		[Column("다른버전보기가능여부")]
		public int OtherVersionSeeingPossibleOrNot { get; set; }
	}
}