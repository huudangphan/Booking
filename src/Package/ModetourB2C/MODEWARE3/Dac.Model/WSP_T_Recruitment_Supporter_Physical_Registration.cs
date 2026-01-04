namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_신체_등록
/// </summary>
public class WSP_T_Recruitment_Supporter_Physical_Registration
{
	public const string SP_NAME = "WSP_T_채용_지원자_신체_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 신장
		/// </summary>
		[Description("신장")]
		public string Height { get; set; }
		/// <summary>
		/// 체중
		/// </summary>
		[Description("체중")]
		public string Weight { get; set; }
		/// <summary>
		/// 시력좌
		/// </summary>
		[Description("시력좌")]
		public string EyesightLeft { get; set; }
		/// <summary>
		/// 시력우
		/// </summary>
		[Description("시력우")]
		public string EyesightRight { get; set; }
		/// <summary>
		/// 혈액형
		/// </summary>
		[Description("혈액형")]
		public string BloodType { get; set; }
		/// <summary>
		/// 특이사항
		/// </summary>
		[Description("특이사항")]
		public string Specific { get; set; }
	}

}