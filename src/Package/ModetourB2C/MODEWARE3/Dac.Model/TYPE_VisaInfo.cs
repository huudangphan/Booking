namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// TYPE_비자정보
/// </summary>
public class TYPE_VisaInfo
{
	/// <summary>
	/// 일반비자번호
	/// </summary>
	[Description("일반비자번호")]
	public int NormalVisaNumber { get; set; }
	/// <summary>
	/// 일련번호
	/// </summary>
	[Description("일련번호")]
	public int SerialNumber { get; set; }
	/// <summary>
	/// 발급국가
	/// </summary>
	[Description("발급국가")]
	public string IssuanceCountry { get; set; }
	/// <summary>
	/// 유효기간
	/// </summary>
	[Description("유효기간")]
	public DateTime ValidPeriod { get; set; }
	/// <summary>
	/// 비자파일번호
	/// </summary>
	[Description("비자파일번호")]
	public int VisaFileNumber { get; set; }
	/// <summary>
	/// 비자번호
	/// </summary>
	[Description("비자번호")]
	public string VisaNumber { get; set; }
}