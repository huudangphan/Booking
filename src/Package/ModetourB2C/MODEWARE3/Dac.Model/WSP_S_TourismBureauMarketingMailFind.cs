namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_관광청마케팅메일조회
/// </summary>
public class WSP_S_TourismBureauMarketingMailFind
{
	public const string SP_NAME = "WSP_S_관광청마케팅메일조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// IDX
		/// </summary>
		[Description("IDX")]
		public int IDX { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
	}
}