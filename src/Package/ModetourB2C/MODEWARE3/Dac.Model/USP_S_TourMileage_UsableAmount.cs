namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_투어마일리지_사용가능액
/// </summary>
public class USP_S_TourMileage_UsableAmount
{
	public const string SP_NAME = "USP_S_투어마일리지_사용가능액";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 회원번호
		/// </summary>
		[Column("회원번호")]
		public string MemberNumber { get; set; }
		/// <summary>
		/// 입금미수
		/// </summary>
		[Column("입금미수")]
		public long DepositUnpayed { get; set; }
		/// <summary>
		/// 총수납액
		/// </summary>
		[Column("총수납액")]
		public long TotalReceiptAmount { get; set; }
		/// <summary>
		/// 최소사용가능
		/// </summary>
		[Column("최소사용가능")]
		public long MinimumUsePossible { get; set; }
		/// <summary>
		/// 손님결제예정금액
		/// </summary>
		[Column("손님결제예정금액")]
		public long GuessPaymentExpectationAmount { get; set; }
		/// <summary>
		/// 판매액
		/// </summary>
		[Column("판매액")]
		public long SalesAmount { get; set; }
		/// <summary>
		/// 나의마일리지
		/// </summary>
		[Column("나의마일리지")]
		public long MyMileage { get; set; }
		/// <summary>
		/// 가족합산마일리지
		/// </summary>
		[Column("가족합산마일리지")]
		public long FamilySumMilege { get; set; }
		/// <summary>
		/// 잔여마일리지
		/// </summary>
		[Column("잔여마일리지")]
		public long BalanceMileage { get; set; }
		/// <summary>
		/// 기사용액
		/// </summary>
		[Column("기사용액")]
		public long ArticleUsageAmount { get; set; }
		/// <summary>
		/// 사용가능액
		/// </summary>
		[Column("사용가능액")]
		public long UsePossibleAmount { get; set; }
	}
}