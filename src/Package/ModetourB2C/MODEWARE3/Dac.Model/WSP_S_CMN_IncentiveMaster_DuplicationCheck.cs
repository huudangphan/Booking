namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_인센티브마스터_중복체크
/// </summary>
public class WSP_S_CMN_IncentiveMaster_DuplicationCheck
{
	public const string SP_NAME = "WSP_S_CMN_인센티브마스터_중복체크";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 요청자명
		/// </summary>
		[Description("요청자명")]
		public string RequesterName { get; set; }
		/// <summary>
		/// 요청자_연락처
		/// </summary>
		[Description("요청자_연락처")]
		public string Requester_Contact { get; set; }
		/// <summary>
		/// 요청자_이메일
		/// </summary>
		[Description("요청자_이메일")]
		public string Requester_Email { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Column("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
	}
}