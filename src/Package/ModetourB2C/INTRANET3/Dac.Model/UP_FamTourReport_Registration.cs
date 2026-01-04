namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// UP_팸투어보고_등록
/// </summary>
public class UP_FamTourReport_Registration
{
	public const string SP_NAME = "UP_팸투어보고_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 작업구분
		/// </summary>
		[Description("작업구분")]
		public string WorkingClassification { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Description("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 주관
		/// </summary>
		[Description("주관")]
		public string Supervision { get; set; }
		/// <summary>
		/// 기간
		/// </summary>
		[Description("기간")]
		public string Period { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Description("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 보고제목
		/// </summary>
		[Description("보고제목")]
		public string ReportTitle { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 참가업체
		/// </summary>
		[Description("참가업체")]
		public string ParticipateCompany { get; set; }
		/// <summary>
		/// 보고내용
		/// </summary>
		[Description("보고내용")]
		public string ReportContent { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
	}

}