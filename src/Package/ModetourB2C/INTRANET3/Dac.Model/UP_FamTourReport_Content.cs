namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// UP_팸투어보고_내용
/// </summary>
public class UP_FamTourReport_Content
{
	public const string SP_NAME = "UP_팸투어보고_내용";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 주관
		/// </summary>
		[Column("주관")]
		public string Supervision { get; set; }
		/// <summary>
		/// 기간
		/// </summary>
		[Column("기간")]
		public string Period { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 보고제목
		/// </summary>
		[Column("보고제목")]
		public string ReportTitle { get; set; }
		/// <summary>
		/// 참가업체
		/// </summary>
		[Column("참가업체")]
		public string ParticipateCompany { get; set; }
		/// <summary>
		/// 보고내용
		/// </summary>
		[Column("보고내용")]
		public string ReportContent { get; set; }
		/// <summary>
		/// 조회
		/// </summary>
		[Column("조회")]
		public int Search { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public DateTime WrittingDate { get; set; }
	}
}