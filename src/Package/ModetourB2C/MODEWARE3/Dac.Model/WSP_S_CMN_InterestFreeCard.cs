namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_무이자카드
/// </summary>
public class WSP_S_CMN_InterestFreeCard
{
	public const string SP_NAME = "WSP_S_CMN_무이자카드";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 종료일최소
		/// </summary>
		[Description("종료일최소")]
		public DateTime? EndDateMinimum { get; set; }
		/// <summary>
		/// 종료일최대
		/// </summary>
		[Description("종료일최대")]
		public DateTime? EndDateMaximum { get; set; }
		/// <summary>
		/// FLAG
		/// </summary>
		[Description("FLAG")]
		public int FLAG { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
		/// <summary>
		/// 카드사
		/// </summary>
		[Column("카드사")]
		public string CardCompany { get; set; }
		/// <summary>
		/// 개월수
		/// </summary>
		[Column("개월수")]
		public string MonthNumber { get; set; }
		/// <summary>
		/// 종료일
		/// </summary>
		[Column("종료일")]
		public string EndDate { get; set; }
		/// <summary>
		/// 상세내용
		/// </summary>
		[Column("상세내용")]
		public string DetailContent { get; set; }
	}
}