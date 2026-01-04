namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_마일리지샵_조회목록
/// </summary>
public class WSP_S_CMN_MileageShop_FindList
{
	public const string SP_NAME = "WSP_S_CMN_마일리지샵_조회목록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 신청목록NO
		/// </summary>
		[Description("신청목록NO")]
		public int RequestList_NO { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 조회목록no
		/// </summary>
		[Column("조회목록no")]
		public int SearchList_NO { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 조회날짜
		/// </summary>
		[Column("조회날짜")]
		public DateTime SearchDate { get; set; }
		/// <summary>
		/// 신청목록no
		/// </summary>
		[Column("신청목록no")]
		public int RequestList_NO { get; set; }
	}
}