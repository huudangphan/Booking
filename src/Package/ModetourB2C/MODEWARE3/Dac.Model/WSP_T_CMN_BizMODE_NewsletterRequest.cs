namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_비즈모두_뉴스레터신청
/// </summary>
public class WSP_T_CMN_BizMODE_NewsletterRequest
{
	public const string SP_NAME = "WSP_T_CMN_비즈모두_뉴스레터신청";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 법인명
		/// </summary>
		[Description("법인명")]
		public string CorporationName { get; set; }
		/// <summary>
		/// 담당자
		/// </summary>
		[Description("담당자")]
		public string Manager { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Description("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 직급
		/// </summary>
		[Description("직급")]
		public string JobPosition { get; set; }
		/// <summary>
		/// 직장우편번호
		/// </summary>
		[Description("직장우편번호")]
		public string WorkingPlaceZipCode { get; set; }
		/// <summary>
		/// 직장주소1
		/// </summary>
		[Description("직장주소1")]
		public string WorkingPlaceAddress1 { get; set; }
		/// <summary>
		/// 직장주소2
		/// </summary>
		[Description("직장주소2")]
		public string WorkingPlaceAddress2 { get; set; }
		/// <summary>
		/// 개인정보동의
		/// </summary>
		[Description("개인정보동의")]
		public string PersonalInfoAgree { get; set; }
		/// <summary>
		/// 이메일수신동의
		/// </summary>
		[Description("이메일수신동의")]
		public string EmailReceptionAgree { get; set; }
		/// <summary>
		/// 마케팅제공동의
		/// </summary>
		[Description("마케팅제공동의")]
		public string MarketingProvisionAgree { get; set; }
		/// <summary>
		/// 분야
		/// </summary>
		[Description("분야")]
		public string Area { get; set; }
		/// <summary>
		/// 직종
		/// </summary>
		[Description("직종")]
		public string JobType { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Description("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 유입경로
		/// </summary>
		[Description("유입경로")]
		public string InflowRoute { get; set; }
		/// <summary>
		/// 신청구분
		/// </summary>
		[Description("신청구분")]
		public string RequestClassification { get; set; }
	}

}