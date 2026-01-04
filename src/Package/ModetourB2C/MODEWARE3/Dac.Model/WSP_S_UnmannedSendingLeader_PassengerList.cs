namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_무인센딩인솔자_패신저리스트
/// </summary>
public class WSP_S_UnmannedSendingLeader_PassengerList
{
	public const string SP_NAME = "WSP_S_무인센딩인솔자_패신저리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// USERIP
		/// </summary>
		[Description("USERIP")]
		public string USERIP { get; set; }
		/// <summary>
		/// USEID
		/// </summary>
		[Description("USEID")]
		public int USEID { get; set; }
		/// <summary>
		/// APPNAME
		/// </summary>
		[Description("APPNAME")]
		public string APPNAME { get; set; }
		/// <summary>
		/// 복호화
		/// </summary>
		[Description("복호화")]
		public string Decryption { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Column("비고")]
		public string Note { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Column("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 여권번호
		/// </summary>
		[Column("여권번호")]
		public string PassportNumber { get; set; }
		/// <summary>
		/// 여권만료일
		/// </summary>
		[Column("여권만료일")]
		public string PassportExpirationDate { get; set; }
		/// <summary>
		/// 연락처
		/// </summary>
		[Column("연락처")]
		public string Contact { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 노베드
		/// </summary>
		[Column("노베드")]
		public string NoBed { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 계약서동의
		/// </summary>
		[Column("계약서동의")]
		public string ContractAgreement { get; set; }
		/// <summary>
		/// 개인정보동의
		/// </summary>
		[Column("개인정보동의")]
		public string PersonalInfoAgree { get; set; }
		/// <summary>
		/// 나이
		/// </summary>
		[Column("나이")]
		public int Age { get; set; }
		/// <summary>
		/// 입금상태
		/// </summary>
		[Column("입금상태")]
		public string DepositState { get; set; }
		/// <summary>
		/// 판매일
		/// </summary>
		[Column("판매일")]
		public DateTime SalesDate { get; set; }
		/// <summary>
		/// 티켓번호
		/// </summary>
		[Column("티켓번호")]
		public string TicketNumber { get; set; }
	}
}