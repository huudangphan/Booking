namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_단체명리스트
/// </summary>
public class USP_S_GroupNameList
{
	public const string SP_NAME = "USP_S_단체명리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 출발시작일
		/// </summary>
		[Description("출발시작일")]
		public DateTime DepartureStartDate { get; set; }
		/// <summary>
		/// 출발종료일
		/// </summary>
		[Description("출발종료일")]
		public DateTime DepartureEndDate { get; set; }
		/// <summary>
		/// 키워드
		/// </summary>
		[Description("키워드")]
		public string Keyword { get; set; }
		/// <summary>
		/// 상태
		/// </summary>
		[Description("상태")]
		public string State { get; set; }
		/// <summary>
		/// 일요일
		/// </summary>
		[Description("일요일")]
		public string DateDay { get; set; }
		/// <summary>
		/// 월요일
		/// </summary>
		[Description("월요일")]
		public string MonthDay { get; set; }
		/// <summary>
		/// 화요일
		/// </summary>
		[Description("화요일")]
		public string Tuesday { get; set; }
		/// <summary>
		/// 수요일
		/// </summary>
		[Description("수요일")]
		public string NumberDay { get; set; }
		/// <summary>
		/// 목요일
		/// </summary>
		[Description("목요일")]
		public string Thursday { get; set; }
		/// <summary>
		/// 금요일
		/// </summary>
		[Description("금요일")]
		public string ThisDate { get; set; }
		/// <summary>
		/// 토요일
		/// </summary>
		[Description("토요일")]
		public string Saturday { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
	}
}