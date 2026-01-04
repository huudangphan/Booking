namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// UP_출장보고_내용
/// </summary>
public class UP_BusinessTripReport_Content
{
	public const string SP_NAME = "UP_출장보고_내용";

	public class Parameters : BaseDbParameters
	{
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
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 구분번호
		/// </summary>
		[Column("구분번호")]
		public string ClassificationNumber { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public string GroupNumber { get; set; }
		/// <summary>
		/// 단체명
		/// </summary>
		[Column("단체명")]
		public string GroupName { get; set; }
		/// <summary>
		/// 행사인원
		/// </summary>
		[Column("행사인원")]
		public string EventNumberOfPeople { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Column("도착일")]
		public string ArrivalDate { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Column("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 내용2
		/// </summary>
		[Column("내용2")]
		public string Content2 { get; set; }
		/// <summary>
		/// 내용3
		/// </summary>
		[Column("내용3")]
		public string Content3 { get; set; }
		/// <summary>
		/// 내용4
		/// </summary>
		[Column("내용4")]
		public string Content4 { get; set; }
		/// <summary>
		/// 내용5
		/// </summary>
		[Column("내용5")]
		public string Content5 { get; set; }
		/// <summary>
		/// 내용6
		/// </summary>
		[Column("내용6")]
		public string Content6 { get; set; }
		/// <summary>
		/// 내용7
		/// </summary>
		[Column("내용7")]
		public string Content7 { get; set; }
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
		/// <summary>
		/// 파일
		/// </summary>
		[Column("파일")]
		public string File { get; set; }
		/// <summary>
		/// 비고1
		/// </summary>
		[Column("비고1")]
		public string Note1 { get; set; }
		/// <summary>
		/// 비고2
		/// </summary>
		[Column("비고2")]
		public string Note2 { get; set; }
		/// <summary>
		/// 비고3
		/// </summary>
		[Column("비고3")]
		public string Note3 { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public DateTime WrittingDate { get; set; }
	}
}