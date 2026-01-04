namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_프로모션_거래처배분
/// </summary>
public class WSP_S_Promotion_CustomerDistribution
{
	public const string SP_NAME = "WSP_S_프로모션_거래처배분";

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 마스터번호
		/// </summary>
		[Column("마스터번호")]
		public int MasterNumber { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Column("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 시작일
		/// </summary>
		[Column("시작일")]
		public DateTime StartDate { get; set; }
		/// <summary>
		/// 종료일
		/// </summary>
		[Column("종료일")]
		public DateTime EndDate { get; set; }
		/// <summary>
		/// PC사용여부
		/// </summary>
		[Column("PC사용여부")]
		public string PC_UseOrNot { get; set; }
		/// <summary>
		/// MO사용여부
		/// </summary>
		[Column("MO사용여부")]
		public string MO_UseOrNot { get; set; }
		/// <summary>
		/// PC우선순위
		/// </summary>
		[Column("PC우선순위")]
		public int PC_PriorityRanking { get; set; }
		/// <summary>
		/// MO우선순위
		/// </summary>
		[Column("MO우선순위")]
		public int MO_PriorityRanking { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Column("사용여부")]
		public string UseOrNot { get; set; }
	}
}