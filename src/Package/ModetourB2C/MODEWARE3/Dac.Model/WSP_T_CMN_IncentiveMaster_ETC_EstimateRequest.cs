namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_인센티브마스터_ETC_견적신청
/// </summary>
public class WSP_T_CMN_IncentiveMaster_ETC_EstimateRequest
{
	public const string SP_NAME = "WSP_T_CMN_인센티브마스터_ETC_견적신청";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 문의종류
		/// </summary>
		[Description("문의종류")]
		public string InquiryType { get; set; }
		/// <summary>
		/// 요청자
		/// </summary>
		[Description("요청자")]
		public string Requester { get; set; }
		/// <summary>
		/// 핸드폰
		/// </summary>
		[Description("핸드폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 문의내용
		/// </summary>
		[Description("문의내용")]
		public string InquiryContent { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Description("제목")]
		public string Title { get; set; }
		/// <summary>
		/// Etcno
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("Etcno")]
		public int Etcno { get; set; }
		/// <summary>
		/// 마케팅동의여부
		/// </summary>
		[Description("마케팅동의여부")]
		public string MarketingAgreeOrNot { get; set; }
	}

}