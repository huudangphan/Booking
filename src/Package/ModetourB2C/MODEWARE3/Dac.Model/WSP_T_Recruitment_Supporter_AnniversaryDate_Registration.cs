namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_기념일_등록
/// </summary>
public class WSP_T_Recruitment_Supporter_AnniversaryDate_Registration
{
	public const string SP_NAME = "WSP_T_채용_지원자_기념일_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 기념일구분코드번호
		/// </summary>
		[Description("기념일구분코드번호")]
		public int AnniversaryClassificationCodeNumber { get; set; }
		/// <summary>
		/// 기념일구분코드명
		/// </summary>
		[Description("기념일구분코드명")]
		public string AnniversaryClassificationCodeName { get; set; }
		/// <summary>
		/// 기념일자
		/// </summary>
		[Description("기념일자")]
		public DateTime AnniversaryDate { get; set; }
		/// <summary>
		/// 음양구분
		/// </summary>
		[Description("음양구분")]
		public string NegativePositiveClassification { get; set; }
	}

}