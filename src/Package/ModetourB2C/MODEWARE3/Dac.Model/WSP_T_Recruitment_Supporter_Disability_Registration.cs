namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_장애_등록
/// </summary>
public class WSP_T_Recruitment_Supporter_Disability_Registration
{
	public const string SP_NAME = "WSP_T_채용_지원자_장애_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 장애인등록일자
		/// </summary>
		[Description("장애인등록일자")]
		public DateTime DisabledPersonRegisterDate { get; set; }
		/// <summary>
		/// 장애인등록번호
		/// </summary>
		[Description("장애인등록번호")]
		public string DisabledPersonRegisterNumber { get; set; }
		/// <summary>
		/// 장애구분코드번호
		/// </summary>
		[Description("장애구분코드번호")]
		public int DisabilityClassificationCodeNumber { get; set; }
		/// <summary>
		/// 장애구분코드명
		/// </summary>
		[Description("장애구분코드명")]
		public string DisabilityClassificationCodeName { get; set; }
		/// <summary>
		/// 장애유형코드번호
		/// </summary>
		[Description("장애유형코드번호")]
		public int DisabilityTypeCodeNumber { get; set; }
		/// <summary>
		/// 장애유형코드명
		/// </summary>
		[Description("장애유형코드명")]
		public string DisabilityTypeCodeName { get; set; }
		/// <summary>
		/// 장애등급코드번호
		/// </summary>
		[Description("장애등급코드번호")]
		public int DisabilityClassCodeNumber { get; set; }
		/// <summary>
		/// 장애등급코드명
		/// </summary>
		[Description("장애등급코드명")]
		public string DisabilityClassCodeName { get; set; }
		/// <summary>
		/// 중증여부
		/// </summary>
		[Description("중증여부")]
		public string SeriousOrNot { get; set; }
	}

}