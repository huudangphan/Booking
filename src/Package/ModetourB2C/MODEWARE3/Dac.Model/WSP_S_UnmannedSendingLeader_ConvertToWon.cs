namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_원화환산
/// </summary>
public class WSP_S_UnmannedSendingLeader_ConvertToWon
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_원화환산";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 통화코드
		/// </summary>
		[Description("통화코드")]
		public string CallCode { get; set; }
		/// <summary>
		/// 외화금액
		/// </summary>
		[Description("외화금액")]
		public decimal ForeignCurrencyAmount { get; set; }
		/// <summary>
		/// 원화금액
		/// </summary>
		[Description("원화금액")]
		public decimal AmountInWon { get; set; }
		/// <summary>
		/// 환율
		/// </summary>
		[Description("환율")]
		public decimal ExchangeRate { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 입금액
		/// </summary>
		[Column("입금액")]
		public decimal DepositAmount { get; set; }
		/// <summary>
		/// 인솔자커미션
		/// </summary>
		[Column("인솔자커미션")]
		public decimal LeaderCommission { get; set; }
	}
}