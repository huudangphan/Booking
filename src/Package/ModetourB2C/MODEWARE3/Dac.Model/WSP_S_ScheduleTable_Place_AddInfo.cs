namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_일정표_장소_추가정보
/// </summary>
public class WSP_S_ScheduleTable_Place_AddInfo
{
	public const string SP_NAME = "WSP_S_일정표_장소_추가정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 선택일련번호
		/// </summary>
		[Column("선택일련번호")]
		public int SelectSerialNumber { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 선택관광통화
		/// </summary>
		[Column("선택관광통화")]
		public string SelectSightseeingCurrency { get; set; }
		/// <summary>
		/// 선택관광비용
		/// </summary>
		[Column("선택관광비용")]
		public long SelectSightseeingExpense { get; set; }
		/// <summary>
		/// 소요시간
		/// </summary>
		[Column("소요시간")]
		public string RequiredTime { get; set; }
		/// <summary>
		/// 대기장소
		/// </summary>
		[Column("대기장소")]
		public string WaitingPlace { get; set; }
		/// <summary>
		/// 동행여부
		/// </summary>
		[Column("동행여부")]
		public string AccompanyOrNot { get; set; }
		/// <summary>
		/// 선택관광비용_아동
		/// </summary>
		[Column("선택관광비용_아동")]
		public int SelectSightseeingExpense_Kid { get; set; }
		/// <summary>
		/// 진행최소인원
		/// </summary>
		[Column("진행최소인원")]
		public string ProgressMinimumNumberOfPeople { get; set; }
		/// <summary>
		/// 선택관광명
		/// </summary>
		[Column("선택관광명")]
		public string SelectSightseeingName { get; set; }
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// 포함여부
		/// </summary>
		[Column("포함여부")]
		public string IncludedOrNot { get; set; }
		/// <summary>
		/// PLACE종류
		/// </summary>
		[Column("PLACE종류")]
		public string PLACE_Type { get; set; }
		/// <summary>
		/// 사전판매여부
		/// </summary>
		[Column("사전판매여부")]
		public string PreSalesOrNot { get; set; }
	}
}