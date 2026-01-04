namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_인보이스_이메일
/// </summary>
public class USP_S_Invoice_Email
{
	public const string SP_NAME = "USP_S_인보이스_이메일";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 번호
		/// </summary>
		[Description("번호")]
		public int Number { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 수신
		/// </summary>
		[Column("수신")]
		public string Reception { get; set; }
		/// <summary>
		/// 발신
		/// </summary>
		[Column("발신")]
		public string MailSending { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 고객
		/// </summary>
		[Column("고객")]
		public string Customer { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 요금
		/// </summary>
		[Column("요금")]
		public string Fare { get; set; }
		/// <summary>
		/// 계산식
		/// </summary>
		[Column("계산식")]
		public string Calculus { get; set; }
		/// <summary>
		/// 사업자
		/// </summary>
		[Column("사업자")]
		public string Licensee { get; set; }
		/// <summary>
		/// 은행
		/// </summary>
		[Column("은행")]
		public string Bank { get; set; }
		/// <summary>
		/// 항공
		/// </summary>
		[Column("항공")]
		public string Flight { get; set; }
		/// <summary>
		/// 고객여부
		/// </summary>
		[Column("고객여부")]
		public string CustomerOrNot { get; set; }
		/// <summary>
		/// 취소료규정
		/// </summary>
		[Column("취소료규정")]
		public string CancelFeeRegulations { get; set; }
		/// <summary>
		/// 입금내역
		/// </summary>
		[Column("입금내역")]
		public string DepositHistory { get; set; }
		/// <summary>
		/// 입금여부
		/// </summary>
		[Column("입금여부")]
		public string DepositOrNot { get; set; }
		/// <summary>
		/// 시한
		/// </summary>
		[Column("시한")]
		public string TimeLimit { get; set; }
		/// <summary>
		/// 커미션여부
		/// </summary>
		[Column("커미션여부")]
		public string CommissionOrNot { get; set; }
		/// <summary>
		/// 직인여부
		/// </summary>
		[Column("직인여부")]
		public string OfficialSealOrNot { get; set; }
		/// <summary>
		/// 보낸사람메일
		/// </summary>
		[Column("보낸사람메일")]
		public string SenderMail { get; set; }
		/// <summary>
		/// 받는사람메일
		/// </summary>
		[Column("받는사람메일")]
		public string ReceiverMail { get; set; }
		/// <summary>
		/// 상품정보표시여부
		/// </summary>
		[Column("상품정보표시여부")]
		public string ProductInfoDisplayOrNot { get; set; }
		/// <summary>
		/// 상세내역노출여부
		/// </summary>
		[Column("상세내역노출여부")]
		public string DetailHistoryDisplayOrNot { get; set; }
		/// <summary>
		/// 상세내역
		/// </summary>
		[Column("상세내역")]
		public string DetailHistory { get; set; }
		/// <summary>
		/// 가상계좌번호
		/// </summary>
		[Column("가상계좌번호")]
		public string VirtualAccountNumber { get; set; }
	}
}