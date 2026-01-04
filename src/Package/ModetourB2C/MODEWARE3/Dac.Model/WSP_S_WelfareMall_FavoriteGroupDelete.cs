namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_복지몰_찜단체삭제
/// </summary>
public class WSP_S_WelfareMall_FavoriteGroupDelete
{
	public const string SP_NAME = "WSP_S_복지몰_찜단체삭제";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

}