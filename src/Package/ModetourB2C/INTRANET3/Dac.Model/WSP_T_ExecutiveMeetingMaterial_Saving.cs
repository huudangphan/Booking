namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_T_임원회의자료_저장
/// </summary>
public class WSP_T_ExecutiveMeetingMaterial_Saving
{
	public const string SP_NAME = "WSP_T_임원회의자료_저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 게시판번호
		/// </summary>
		[Description("게시판번호")]
		public int NoticeboardNumber { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 스텝1
		/// </summary>
		[Description("스텝1")]
		public int Step1 { get; set; }
		/// <summary>
		/// 스텝2
		/// </summary>
		[Description("스텝2")]
		public int Step2 { get; set; }
		/// <summary>
		/// 스텝3
		/// </summary>
		[Description("스텝3")]
		public int Step3 { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Description("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 부서번호
		/// </summary>
		[Description("부서번호")]
		public int DepartmentNumber { get; set; }
		/// <summary>
		/// 작성자정보
		/// </summary>
		[Description("작성자정보")]
		public string WritterInfo { get; set; }
		/// <summary>
		/// 말머리
		/// </summary>
		[Description("말머리")]
		public string HeadOfStory { get; set; }
		/// <summary>
		/// 제목태그
		/// </summary>
		[Description("제목태그")]
		public string TitleTag { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Description("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Description("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 공지날짜
		/// </summary>
		[Description("공지날짜")]
		public string NotificationDate { get; set; }
		/// <summary>
		/// 파일폴더
		/// </summary>
		[Description("파일폴더")]
		public string FileFolder { get; set; }
		/// <summary>
		/// 파일
		/// </summary>
		[Description("파일")]
		public string File { get; set; }
		/// <summary>
		/// 기타토의
		/// </summary>
		[Description("기타토의")]
		public string OtherDiscusion { get; set; }
		/// <summary>
		/// 열람권한
		/// </summary>
		[Description("열람권한")]
		public string ReadingAuthority { get; set; }
	}

}