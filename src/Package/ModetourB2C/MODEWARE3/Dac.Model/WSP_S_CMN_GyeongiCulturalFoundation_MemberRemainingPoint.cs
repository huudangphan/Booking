namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_경기문화재단_회원잔여포인트
/// </summary>
public class WSP_S_CMN_GyeongiCulturalFoundation_MemberRemainingPoint
{
	public const string SP_NAME = "WSP_S_CMN_경기문화재단_회원잔여포인트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 멤버마스터번호
		/// </summary>
		[Description("멤버마스터번호")]
		public int MemberMasterNumber { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Description("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Description("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
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