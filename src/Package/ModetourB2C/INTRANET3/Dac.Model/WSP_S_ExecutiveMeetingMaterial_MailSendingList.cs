namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_임원회의자료_메일발송리스트
/// </summary>
public class WSP_S_ExecutiveMeetingMaterial_MailSendingList
{
	public const string SP_NAME = "WSP_S_임원회의자료_메일발송리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 게시판번호
		/// </summary>
		[Description("게시판번호")]
		public int NoticeboardNumber { get; set; }
		/// <summary>
		/// 열람권한
		/// </summary>
		[Description("열람권한")]
		public int ReadingAuthority { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 직원명
		/// </summary>
		[Column("직원명")]
		public string EmployeeName { get; set; }
		/// <summary>
		/// 사번
		/// </summary>
		[Column("사번")]
		public string EmployeeIdentifiedNumber { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
	}
}