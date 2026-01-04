namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// TYPE_항공_결제정보_카드
/// </summary>
public class TYPE_Flight_PaymentInfo_Card
{
	/// <summary>
	/// 판매명세번호
	/// </summary>
	[Description("판매명세번호")]
	public int SalesSpecificationNumber { get; set; }
	/// <summary>
	/// 마일리지사용여부
	/// </summary>
	[Description("마일리지사용여부")]
	public string MileageUseOrNot { get; set; }
	/// <summary>
	/// 카드종류
	/// </summary>
	[Description("카드종류")]
	public string CardType { get; set; }
	/// <summary>
	/// 카드번호
	/// </summary>
	[Description("카드번호")]
	public string CardNumber { get; set; }
	/// <summary>
	/// 소유자명
	/// </summary>
	[Description("소유자명")]
	public string OwnerName { get; set; }
	/// <summary>
	/// 유효기간
	/// </summary>
	[Description("유효기간")]
	public string ValidPeriod { get; set; }
	/// <summary>
	/// 비밀번호
	/// </summary>
	[Description("비밀번호")]
	public string Password { get; set; }
	/// <summary>
	/// 할부기간
	/// </summary>
	[Description("할부기간")]
	public string InstallmentPeriod { get; set; }
	/// <summary>
	/// 주민번호
	/// </summary>
	[Description("주민번호")]
	public string CitizenIDNumber { get; set; }
	/// <summary>
	/// 카드금액
	/// </summary>
	[Description("카드금액")]
	public int CardAmount { get; set; }
	/// <summary>
	/// 3자카드여부
	/// </summary>
	[Description("3자카드여부")]
	public string ThirdCardOrNot { get; set; }
}