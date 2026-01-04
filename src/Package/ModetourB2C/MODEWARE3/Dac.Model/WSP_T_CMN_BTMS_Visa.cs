namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_BTMS_비자
/// </summary>
public class WSP_T_CMN_BTMS_Visa
{
	public const string SP_NAME = "WSP_T_CMN_BTMS_비자";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 저장구분
		/// </summary>
		[Description("저장구분")]
		public string SavingClassification { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 요청자
		/// </summary>
		[Description("요청자")]
		public string Requester { get; set; }
		/// <summary>
		/// 비자번호
		/// </summary>
		[Description("비자번호")]
		public string VisaNumber { get; set; }
		/// <summary>
		/// 발급국가
		/// </summary>
		[Description("발급국가")]
		public string IssuanceCountry { get; set; }
		/// <summary>
		/// 유효기간
		/// </summary>
		[Description("유효기간")]
		public string ValidPeriod { get; set; }
		/// <summary>
		/// 비자파일번호
		/// </summary>
		[Description("비자파일번호")]
		public string VisaFileNumber { get; set; }
		/// <summary>
		/// 일반비자번호
		/// </summary>
		[Description("일반비자번호")]
		public int NormalVisaNumber { get; set; }
	}

}