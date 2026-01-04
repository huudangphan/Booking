namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// UP_고객의소리_등록
/// </summary>
public class UP_CustomerVoice_Registration
{
	public const string SP_NAME = "UP_고객의소리_등록";

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
		/// 작성자구분
		/// </summary>
		[Description("작성자구분")]
		public string WritterClassification { get; set; }
		/// <summary>
		/// 여행사명
		/// </summary>
		[Description("여행사명")]
		public string TravelCompanyName { get; set; }
		/// <summary>
		/// 담당직원
		/// </summary>
		[Description("담당직원")]
		public string ResponsibilityEmployee { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Description("종류")]
		public string Type { get; set; }
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
		/// 주민등록번호
		/// </summary>
		[Description("주민등록번호")]
		public string CitizenRegisterNumber { get; set; }
		/// <summary>
		/// 연락처
		/// </summary>
		[Description("연락처")]
		public string Contact { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Description("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Description("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 여행자
		/// </summary>
		[Description("여행자")]
		public string Traveler { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 여행지역
		/// </summary>
		[Description("여행지역")]
		public string TravelRegion { get; set; }
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
		/// 불편항목
		/// </summary>
		[Description("불편항목")]
		public string InconvenienceItem { get; set; }
		/// <summary>
		/// 칭찬항목
		/// </summary>
		[Description("칭찬항목")]
		public string Compliment { get; set; }
		/// <summary>
		/// 항목
		/// </summary>
		[Description("항목")]
		public string Item { get; set; }
		/// <summary>
		/// 상품담당자
		/// </summary>
		[Description("상품담당자")]
		public int ProductManager { get; set; }
		/// <summary>
		/// 상품담당자정보
		/// </summary>
		[Description("상품담당자정보")]
		public string ProductManagerInfo { get; set; }
		/// <summary>
		/// 상품참조자
		/// </summary>
		[Description("상품참조자")]
		public string ProductReferrer { get; set; }
		/// <summary>
		/// 상품참조자정보
		/// </summary>
		[Description("상품참조자정보")]
		public string ProductReferrerInfo { get; set; }
		/// <summary>
		/// 영업담당자
		/// </summary>
		[Description("영업담당자")]
		public int BusinessManager { get; set; }
		/// <summary>
		/// 영업담당자정보
		/// </summary>
		[Description("영업담당자정보")]
		public string BusinessManagerInfo { get; set; }
		/// <summary>
		/// 영업참조자
		/// </summary>
		[Description("영업참조자")]
		public string BusinessReferrer { get; set; }
		/// <summary>
		/// 영업참조자정보
		/// </summary>
		[Description("영업참조자정보")]
		public string BusinessReferrerInfo { get; set; }
		/// <summary>
		/// 진행현황
		/// </summary>
		[Description("진행현황")]
		public string ProgressCurrentState { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("번호")]
		public int Number { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 결과
		/// </summary>
		[Column("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 발생라인
		/// </summary>
		[Column("발생라인")]
		public string OccurLine { get; set; }
		/// <summary>
		/// 에러메세지
		/// </summary>
		[Column("에러메세지")]
		public string ErrorMessage { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public string Column1 { get; set; }
		/// <summary>
		/// Column2
		/// </summary>
		[Column("Column2")]
		public string Column2 { get; set; }
		/// <summary>
		/// Column3
		/// </summary>
		[Column("Column3")]
		public string Column3 { get; set; }
		/// <summary>
		/// Column4
		/// </summary>
		[Column("Column4")]
		public string Column4 { get; set; }
		/// <summary>
		/// Column5
		/// </summary>
		[Column("Column5")]
		public int Column5 { get; set; }
		/// <summary>
		/// Column6
		/// </summary>
		[Column("Column6")]
		public int Column6 { get; set; }
		/// <summary>
		/// Column7
		/// </summary>
		[Column("Column7")]
		public string Column7 { get; set; }
	}
}