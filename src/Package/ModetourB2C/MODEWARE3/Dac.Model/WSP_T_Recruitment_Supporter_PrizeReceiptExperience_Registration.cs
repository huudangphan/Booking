namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_수상경력_등록
/// </summary>
public class WSP_T_Recruitment_Supporter_PrizeReceiptExperience_Registration
{
	public const string SP_NAME = "WSP_T_채용_지원자_수상경력_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 수상일
		/// </summary>
		[Description("수상일")]
		public DateTime PrizeReceiptDate { get; set; }
		/// <summary>
		/// 수상명
		/// </summary>
		[Description("수상명")]
		public string PrizeReceiptName { get; set; }
		/// <summary>
		/// 수상기관
		/// </summary>
		[Description("수상기관")]
		public string PrizeReceiptOffice { get; set; }
		/// <summary>
		/// 수상내역
		/// </summary>
		[Description("수상내역")]
		public string PrizeReceiptHistory { get; set; }
	}

}