namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_단체버전조회
/// </summary>
public class WSP_S_GroupVersionFind
{
	public const string SP_NAME = "WSP_S_단체버전조회";

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
		/// 일정버전
		/// </summary>
		[Column("일정버전")]
		public double ScheduleVersion { get; set; }
	}
}