namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_주문외부키_저장
/// </summary>
public class WSP_T_OrderExternalKey_Saving
{
	public const string SP_NAME = "WSP_T_주문외부키_저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Description("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Description("상태1")]
		public string State1 { get; set; }
		/// <summary>
		/// 상태2
		/// </summary>
		[Description("상태2")]
		public string State2 { get; set; }
		/// <summary>
		/// 상태3
		/// </summary>
		[Description("상태3")]
		public string State3 { get; set; }
		/// <summary>
		/// 상태4
		/// </summary>
		[Description("상태4")]
		public string State4 { get; set; }
		/// <summary>
		/// 상태5
		/// </summary>
		[Description("상태5")]
		public string State5 { get; set; }
		/// <summary>
		/// 상태6
		/// </summary>
		[Description("상태6")]
		public string State6 { get; set; }
		/// <summary>
		/// 상태7
		/// </summary>
		[Description("상태7")]
		public string State7 { get; set; }
		/// <summary>
		/// 금액1
		/// </summary>
		[Description("금액1")]
		public int Amount1 { get; set; }
		/// <summary>
		/// 금액2
		/// </summary>
		[Description("금액2")]
		public int Amount2 { get; set; }
		/// <summary>
		/// 금액3
		/// </summary>
		[Description("금액3")]
		public int Amount3 { get; set; }
		/// <summary>
		/// 외부주문번호
		/// </summary>
		[Description("외부주문번호")]
		public string ExternalOrderNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 멤버마스터번호
		/// </summary>
		[Column("멤버마스터번호")]
		public int MemberMasterNumber { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 지급포인트
		/// </summary>
		[Column("지급포인트")]
		public decimal PaymentPoint { get; set; }
		/// <summary>
		/// 사용포인트
		/// </summary>
		[Column("사용포인트")]
		public decimal UsePoint { get; set; }
		/// <summary>
		/// 잔여포인트
		/// </summary>
		[Column("잔여포인트")]
		public decimal BalancePoint { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 사용포인트
		/// </summary>
		[Column("사용포인트")]
		public decimal UsePoint { get; set; }
	}
}