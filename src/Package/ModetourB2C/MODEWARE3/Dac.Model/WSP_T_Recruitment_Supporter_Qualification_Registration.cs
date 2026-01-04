namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_자격_등록
/// </summary>
public class WSP_T_Recruitment_Supporter_Qualification_Registration
{
	public const string SP_NAME = "WSP_T_채용_지원자_자격_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 자격코드번호
		/// </summary>
		[Description("자격코드번호")]
		public int QualificationCodeNumber { get; set; }
		/// <summary>
		/// 자격코드명
		/// </summary>
		[Description("자격코드명")]
		public string QualificationCodeName { get; set; }
		/// <summary>
		/// 자격증번호
		/// </summary>
		[Description("자격증번호")]
		public string CertificateNumber { get; set; }
		/// <summary>
		/// 발급일
		/// </summary>
		[Description("발급일")]
		public DateTime IssuanceDate { get; set; }
		/// <summary>
		/// 발급기관
		/// </summary>
		[Description("발급기관")]
		public string IssuanceOffice { get; set; }
	}

}