namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_나의여행스크랩리스트_메인
/// </summary>
public class WSP_S_CMN_MyTravelScrapList_Main
{
	public const string SP_NAME = "WSP_S_CMN_나의여행스크랩리스트_메인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 리스트갯수
		/// </summary>
		[Description("리스트갯수")]
		public int ListNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Column("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 관련경로
		/// </summary>
		[Column("관련경로")]
		public string RelatedRoute { get; set; }
	}
}