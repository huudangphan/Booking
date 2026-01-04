namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_여행플래너_여행이력무_회원정보
/// </summary>
public class WSP_S_CMN_TravelPlanner_TravelHistoryNO_MemberInfo
{
	public const string SP_NAME = "WSP_S_CMN_여행플래너_여행이력무_회원정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Description("이름")]
		public string Name { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 핸드폰번호
		/// </summary>
		[Column("핸드폰번호")]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
	}
}