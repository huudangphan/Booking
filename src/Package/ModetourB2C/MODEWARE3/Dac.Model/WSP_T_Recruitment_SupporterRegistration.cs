namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_채용_지원자등록
/// </summary>
public class WSP_T_Recruitment_SupporterRegistration
{
	public const string SP_NAME = "WSP_T_채용_지원자등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 공고일련번호
		/// </summary>
		[Description("공고일련번호")]
		public int AnnounceSerialNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 지원자일련번호
		/// </summary>
		[Column("지원자일련번호")]
		public int SupporterSerialNumber { get; set; }
	}
}