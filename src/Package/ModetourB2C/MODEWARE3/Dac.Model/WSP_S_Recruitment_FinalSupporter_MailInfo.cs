namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_채용_최종지원자_메일정보
/// </summary>
public class WSP_S_Recruitment_FinalSupporter_MailInfo
{
	public const string SP_NAME = "WSP_S_채용_최종지원자_메일정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Description("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 전자우편주소
		/// </summary>
		[Column("전자우편주소")]
		public string DigitalPostalAddress { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 핸드폰번호
		/// </summary>
		[Column("핸드폰번호")]
		public string PhoneNumber { get; set; }
	}
}