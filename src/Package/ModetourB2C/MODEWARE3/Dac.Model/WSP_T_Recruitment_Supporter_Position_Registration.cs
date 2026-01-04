namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자_지위_등록
/// </summary>
public class WSP_T_Recruitment_Supporter_Position_Registration
{
	public const string SP_NAME = "WSP_T_채용_지원자_지위_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
		/// <summary>
		/// 현재직위
		/// </summary>
		[Description("현재직위")]
		public string CurrentPosition { get; set; }
		/// <summary>
		/// 현재입사일
		/// </summary>
		[Description("현재입사일")]
		public DateTime CurrentCompanyJoiningDate { get; set; }
		/// <summary>
		/// 현재승진일
		/// </summary>
		[Description("현재승진일")]
		public DateTime CurrentPromotedDate { get; set; }
		/// <summary>
		/// 현재연봉
		/// </summary>
		[Description("현재연봉")]
		public string CurrentAnnualSalary { get; set; }
		/// <summary>
		/// 희망직위
		/// </summary>
		[Description("희망직위")]
		public string DesiredPosition { get; set; }
		/// <summary>
		/// 희망연봉
		/// </summary>
		[Description("희망연봉")]
		public string DesiredAnnualSalary { get; set; }
		/// <summary>
		/// 기타희망사항
		/// </summary>
		[Description("기타희망사항")]
		public string OtherWishList { get; set; }
	}

}