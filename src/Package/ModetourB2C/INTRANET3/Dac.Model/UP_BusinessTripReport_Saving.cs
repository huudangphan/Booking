namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// UP_출장보고_저장
/// </summary>
public class UP_BusinessTripReport_Saving
{
	public const string SP_NAME = "UP_출장보고_저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 구분번호
		/// </summary>
		[Description("구분번호")]
		public string ClassificationNumber { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Description("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public string GroupNumber { get; set; }
		/// <summary>
		/// 단체명
		/// </summary>
		[Description("단체명")]
		public string GroupName { get; set; }
		/// <summary>
		/// 행사인원
		/// </summary>
		[Description("행사인원")]
		public string EventNumberOfPeople { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Description("도착일")]
		public string ArrivalDate { get; set; }
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
		/// 파일
		/// </summary>
		[Description("파일")]
		public string File { get; set; }
		/// <summary>
		/// 보고내용
		/// </summary>
		[Description("보고내용")]
		public string ReportContent { get; set; }
		/// <summary>
		/// 내용2
		/// </summary>
		[Description("내용2")]
		public string Content2 { get; set; }
		/// <summary>
		/// 내용3
		/// </summary>
		[Description("내용3")]
		public string Content3 { get; set; }
		/// <summary>
		/// 내용4
		/// </summary>
		[Description("내용4")]
		public string Content4 { get; set; }
		/// <summary>
		/// 내용5
		/// </summary>
		[Description("내용5")]
		public string Content5 { get; set; }
		/// <summary>
		/// 내용6
		/// </summary>
		[Description("내용6")]
		public string Content6 { get; set; }
		/// <summary>
		/// 내용7
		/// </summary>
		[Description("내용7")]
		public string Content7 { get; set; }
		/// <summary>
		/// 비고1
		/// </summary>
		[Description("비고1")]
		public string Note1 { get; set; }
		/// <summary>
		/// 비고2
		/// </summary>
		[Description("비고2")]
		public string Note2 { get; set; }
		/// <summary>
		/// 비고3
		/// </summary>
		[Description("비고3")]
		public string Note3 { get; set; }
		/// <summary>
		/// 메모번호
		/// </summary>
		[Description("메모번호")]
		public int MemoNumber { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Description("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 메모
		/// </summary>
		[Description("메모")]
		public string Memo { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
	}

}