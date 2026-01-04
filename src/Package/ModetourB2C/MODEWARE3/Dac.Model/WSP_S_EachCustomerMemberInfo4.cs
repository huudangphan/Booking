namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_거래처별회원정보4
/// </summary>
public class WSP_S_EachCustomerMemberInfo4
{
	public const string SP_NAME = "WSP_S_거래처별회원정보4";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Column("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 수정자
		/// </summary>
		[Column("수정자")]
		public int Editor { get; set; }
		/// <summary>
		/// SMS수신동의
		/// </summary>
		[Column("SMS수신동의")]
		public string SMS_ReceptionAgree { get; set; }
		/// <summary>
		/// 무료SMS
		/// </summary>
		[Column("무료SMS")]
		public int Free_SMS { get; set; }
		/// <summary>
		/// 센드빌가입여부
		/// </summary>
		[Column("센드빌가입여부")]
		public string SendbillSignUpOrNot { get; set; }
		/// <summary>
		/// 센드빌가입일
		/// </summary>
		[Column("센드빌가입일")]
		public DateTime SendbillSignUpDate { get; set; }
		/// <summary>
		/// CRS인보이스DISPLAY
		/// </summary>
		[Column("CRS인보이스DISPLAY")]
		public string CRS_Invoice_DISPLAY { get; set; }
		/// <summary>
		/// CRS5권한여부
		/// </summary>
		[Column("CRS5권한여부")]
		public string CRS5_AuthorityOrNot { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Column("사용여부")]
		public string UseOrNot { get; set; }
		/// <summary>
		/// 온라인교육_정보제공동의여부
		/// </summary>
		[Column("온라인교육_정보제공동의여부")]
		public string OnlineEducation_InfoProvisionAgreeOrNot { get; set; }
		/// <summary>
		/// 온라인교육_대상거래처번호
		/// </summary>
		[Column("온라인교육_대상거래처번호")]
		public int OnlineEducation_CandidateCustomerNumber { get; set; }
	}
}