namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_회원검색_검색어
/// </summary>
public class WSP_S_CMN_MemberSearch_SearchKeyword
{
	public const string SP_NAME = "WSP_S_CMN_회원검색_검색어";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 검색어
		/// </summary>
		[Description("검색어")]
		public string SearchingKeyword { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 회원명
		/// </summary>
		[Column("회원명")]
		public string MemberName { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Column("사원번호")]
		public int StaffNumber { get; set; }
	}
}