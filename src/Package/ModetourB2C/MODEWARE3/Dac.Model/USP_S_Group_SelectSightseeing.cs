namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_단체_선택관광
/// </summary>
public class USP_S_Group_SelectSightseeing
{
	public const string SP_NAME = "USP_S_단체_선택관광";

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
		/// 선택관광명
		/// </summary>
		[Column("선택관광명")]
		public string SelectSightseeingName { get; set; }
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
		/// 선택관광비용아동
		/// </summary>
		[Column("선택관광비용아동")]
		public int SelectSightseeingExpenseKid { get; set; }
		/// <summary>
		/// 선택관광진행최소인원
		/// </summary>
		[Column("선택관광진행최소인원")]
		public string SelectSightseeingProgressMinimumNumberOfPeople { get; set; }
		/// <summary>
		/// 동행여부2
		/// </summary>
		[Column("동행여부2")]
		public string AccompanyOrNot2 { get; set; }
		/// <summary>
		/// PLACE번호
		/// </summary>
		[Column("PLACE번호")]
		public int PLACE_Number { get; set; }
		/// <summary>
		/// PLACE
		/// </summary>
		[Column("PLACE")]
		public string PLACE { get; set; }
		/// <summary>
		/// 포함여부
		/// </summary>
		[Column("포함여부")]
		public string IncludedOrNot { get; set; }
		/// <summary>
		/// 사전판매여부
		/// </summary>
		[Column("사전판매여부")]
		public string PreSalesOrNot { get; set; }
	}
}