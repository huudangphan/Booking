namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_게시판리스트_항공
/// </summary>
public class WSP_S_CMN_NoticeboardList_Flight
{
	public const string SP_NAME = "WSP_S_CMN_게시판리스트_항공";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public int Classification { get; set; }
		/// <summary>
		/// 갯수
		/// </summary>
		[Description("갯수")]
		public int Number { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 스텝1
		/// </summary>
		[Column("스텝1")]
		public int Step1 { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 공지
		/// </summary>
		[Column("공지")]
		public bool Notification { get; set; }
	}
}