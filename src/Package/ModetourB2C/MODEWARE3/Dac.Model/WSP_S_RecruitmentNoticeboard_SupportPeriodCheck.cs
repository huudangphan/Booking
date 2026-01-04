namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_채용게시판_지원기간체크
/// </summary>
public class WSP_S_RecruitmentNoticeboard_SupportPeriodCheck
{
	public const string SP_NAME = "WSP_S_채용게시판_지원기간체크";

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
		/// 결과
		/// </summary>
		[Column("결과")]
		public string RESULT { get; set; }
	}
}