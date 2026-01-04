namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_제휴회원포인트
/// </summary>
public class WSP_S_CMN_AffiliateMemberPoint
{
	public const string SP_NAME = "WSP_S_CMN_제휴회원포인트";

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
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 고객ID
		/// </summary>
		[Description("고객ID")]
		public string Customer_ID { get; set; }
		/// <summary>
		/// 상품권ID
		/// </summary>
		[Description("상품권ID")]
		public string Voucher_ID { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 제휴포인트번호
		/// </summary>
		[Column("제휴포인트번호")]
		public int AffiliatePointNumber { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 계열사
		/// </summary>
		[Column("계열사")]
		public string Affiliate { get; set; }
		/// <summary>
		/// 계열사코드
		/// </summary>
		[Column("계열사코드")]
		public string AffiliateCode { get; set; }
		/// <summary>
		/// 근무부서
		/// </summary>
		[Column("근무부서")]
		public string WorkDepartment { get; set; }
		/// <summary>
		/// 고객명
		/// </summary>
		[Column("고객명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 상품권만료일
		/// </summary>
		[Column("상품권만료일")]
		public DateTime VoucherExpirationDate { get; set; }
		/// <summary>
		/// 대상년도
		/// </summary>
		[Column("대상년도")]
		public string CandidateYear { get; set; }
		/// <summary>
		/// 비고사항
		/// </summary>
		[Column("비고사항")]
		public string NoteItem { get; set; }
	}
}