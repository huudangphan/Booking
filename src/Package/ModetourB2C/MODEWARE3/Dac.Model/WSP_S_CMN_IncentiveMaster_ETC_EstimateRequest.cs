namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_인센티브마스터_ETC_견적신청
/// </summary>
public class WSP_S_CMN_IncentiveMaster_ETC_EstimateRequest
{
	public const string SP_NAME = "WSP_S_CMN_인센티브마스터_ETC_견적신청";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// EtcNo
		/// </summary>
		[Description("EtcNo")]
		public int EtcNo { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 요청일
		/// </summary>
		[Column("요청일")]
		public string RequestDate { get; set; }
		/// <summary>
		/// Etcno
		/// </summary>
		[Column("Etcno")]
		public int Etcno { get; set; }
		/// <summary>
		/// 문의종류
		/// </summary>
		[Column("문의종류")]
		public string InquiryType { get; set; }
		/// <summary>
		/// 요청자
		/// </summary>
		[Column("요청자")]
		public string Requester { get; set; }
		/// <summary>
		/// 핸드폰
		/// </summary>
		[Column("핸드폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Column("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 요청일1
		/// </summary>
		[Column("요청일1")]
		public DateTime RequestDate1 { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Column("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 문의내용
		/// </summary>
		[Column("문의내용")]
		public string InquiryContent { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 견적상태
		/// </summary>
		[Column("견적상태")]
		public string EstimateState { get; set; }
		/// <summary>
		/// 마케팅동의여부
		/// </summary>
		[Column("마케팅동의여부")]
		public string MarketingAgreeOrNot { get; set; }
	}
}