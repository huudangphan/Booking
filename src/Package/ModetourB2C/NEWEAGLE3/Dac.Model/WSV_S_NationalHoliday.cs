namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSV_S_공휴일
/// </summary>
public class WSV_S_NationalHoliday
{
	public const string SP_NAME = "WSV_S_공휴일";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 공휴일
		/// </summary>
		[Description("공휴일")]
		public string NationalHoliday { get; set; }
		/// <summary>
		/// 시작일
		/// </summary>
		[Description("시작일")]
		public string StartDate { get; set; }
		/// <summary>
		/// 마침일
		/// </summary>
		[Description("마침일")]
		public string FinishDate { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 날짜
		/// </summary>
		[Column("날짜")]
		public string Date { get; set; }
		/// <summary>
		/// 년
		/// </summary>
		[Column("년")]
		public string Year { get; set; }
		/// <summary>
		/// 월
		/// </summary>
		[Column("월")]
		public string Month { get; set; }
		/// <summary>
		/// 일
		/// </summary>
		[Column("일")]
		public string Date2 { get; set; }
		/// <summary>
		/// 음력
		/// </summary>
		[Column("음력")]
		public string LunarCalendar { get; set; }
		/// <summary>
		/// 요일1
		/// </summary>
		[Column("요일1")]
		public string DayOfWeek1 { get; set; }
		/// <summary>
		/// 요일2
		/// </summary>
		[Column("요일2")]
		public string DayOfWeek2 { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 휴일
		/// </summary>
		[Column("휴일")]
		public string Holiday { get; set; }
		/// <summary>
		/// 업무일
		/// </summary>
		[Column("업무일")]
		public string BusinessDate { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
	}
}