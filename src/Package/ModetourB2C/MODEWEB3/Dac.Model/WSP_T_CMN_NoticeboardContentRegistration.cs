namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_게시판내용등록
/// </summary>
public class WSP_T_CMN_NoticeboardContentRegistration
{
	public const string SP_NAME = "WSP_T_CMN_게시판내용등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 작업구분
		/// </summary>
		[Description("작업구분")]
		public string WorkingClassification { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public int Classification { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
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
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
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
		/// 태그
		/// </summary>
		[Description("태그")]
		public byte Tag { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 아이피
		/// </summary>
		[Description("아이피")]
		public string IP { get; set; }
		/// <summary>
		/// 공지
		/// </summary>
		[Description("공지")]
		public bool Notification { get; set; }
		/// <summary>
		/// 파일1
		/// </summary>
		[Description("파일1")]
		public string File1 { get; set; }
		/// <summary>
		/// 파일2
		/// </summary>
		[Description("파일2")]
		public string File2 { get; set; }
		/// <summary>
		/// 말머리
		/// </summary>
		[Description("말머리")]
		public string HeadOfStory { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 권한
		/// </summary>
		[Description("권한")]
		public string Authority { get; set; }
		/// <summary>
		/// 권한리스트
		/// </summary>
		[Description("권한리스트")]
		public string AuthorityList { get; set; }
		/// <summary>
		/// 담당사원번호
		/// </summary>
		[Description("담당사원번호")]
		public int ResponsibilityStaffNumber { get; set; }
		/// <summary>
		/// 담당사원명
		/// </summary>
		[Description("담당사원명")]
		public string ResponsibilityStaffName { get; set; }
	}

}