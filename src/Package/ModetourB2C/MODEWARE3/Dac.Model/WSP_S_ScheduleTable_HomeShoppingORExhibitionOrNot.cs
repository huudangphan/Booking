namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_일정표_홈쇼핑OR박람회여부
/// </summary>
public class WSP_S_ScheduleTable_HomeShoppingORExhibitionOrNot
{
	public const string SP_NAME = "WSP_S_일정표_홈쇼핑OR박람회여부";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 행사번호
		/// </summary>
		[Description("행사번호")]
		public int EventNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 매칭기준
		/// </summary>
		[Column("매칭기준")]
		public string MatchingStandard { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 행사번호
		/// </summary>
		[Column("행사번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 매칭일련번호
		/// </summary>
		[Column("매칭일련번호")]
		public int MatchingSerialNumber { get; set; }
		/// <summary>
		/// 매칭단체번호
		/// </summary>
		[Column("매칭단체번호")]
		public int MatchingGroupNumber { get; set; }
		/// <summary>
		/// 매칭이름
		/// </summary>
		[Column("매칭이름")]
		public string MatchingName { get; set; }
		/// <summary>
		/// 매칭기간
		/// </summary>
		[Column("매칭기간")]
		public DateTime MatchingPeriod { get; set; }
	}
}