namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// UP_고객의소리_상세_MOBILE
/// </summary>
public class UP_CustomerVoice_Detail_MOBILE
{
	public const string SP_NAME = "UP_고객의소리_상세_MOBILE";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 작성자구분
		/// </summary>
		[Column("작성자구분")]
		public string WritterClassification { get; set; }
		/// <summary>
		/// 여행사명
		/// </summary>
		[Column("여행사명")]
		public string TravelCompanyName { get; set; }
		/// <summary>
		/// 담당직원
		/// </summary>
		[Column("담당직원")]
		public string ResponsibilityEmployee { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Column("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Column("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 출발일1
		/// </summary>
		[Column("출발일1")]
		public string DepartureDate1 { get; set; }
		/// <summary>
		/// 상품명
		/// </summary>
		[Column("상품명")]
		public string ProductName { get; set; }
		/// <summary>
		/// 여행자
		/// </summary>
		[Column("여행자")]
		public string Traveler { get; set; }
		/// <summary>
		/// 여행지역
		/// </summary>
		[Column("여행지역")]
		public string TravelRegion { get; set; }
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
		/// 불편항목
		/// </summary>
		[Column("불편항목")]
		public string InconvenienceItem { get; set; }
		/// <summary>
		/// 칭찬항목
		/// </summary>
		[Column("칭찬항목")]
		public string Compliment { get; set; }
		/// <summary>
		/// 상품담당자
		/// </summary>
		[Column("상품담당자")]
		public int ProductManager { get; set; }
		/// <summary>
		/// 상품담당자정보
		/// </summary>
		[Column("상품담당자정보")]
		public string ProductManagerInfo { get; set; }
		/// <summary>
		/// 상품담당자지정일
		/// </summary>
		[Column("상품담당자지정일")]
		public DateTime ProductManagerAssignmentDate { get; set; }
		/// <summary>
		/// 상품참조자
		/// </summary>
		[Column("상품참조자")]
		public string ProductReferrer { get; set; }
		/// <summary>
		/// 상품참조자정보
		/// </summary>
		[Column("상품참조자정보")]
		public string ProductReferrerInfo { get; set; }
		/// <summary>
		/// 영업담당자
		/// </summary>
		[Column("영업담당자")]
		public int BusinessManager { get; set; }
		/// <summary>
		/// 영업담당자정보
		/// </summary>
		[Column("영업담당자정보")]
		public string BusinessManagerInfo { get; set; }
		/// <summary>
		/// 영업담당자지정일
		/// </summary>
		[Column("영업담당자지정일")]
		public DateTime BusinessManagerAssignmentDate { get; set; }
		/// <summary>
		/// 영업참조자
		/// </summary>
		[Column("영업참조자")]
		public string BusinessReferrer { get; set; }
		/// <summary>
		/// 영업참조자정보
		/// </summary>
		[Column("영업참조자정보")]
		public string BusinessReferrerInfo { get; set; }
		/// <summary>
		/// 상품진행현황
		/// </summary>
		[Column("상품진행현황")]
		public string ProductProgressCurrentState { get; set; }
		/// <summary>
		/// 영업진행현황
		/// </summary>
		[Column("영업진행현황")]
		public string BusinessProgressCurrentState { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 회원PTID
		/// </summary>
		[Column("회원PTID")]
		public int Member_PTID { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Column("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 만족지수
		/// </summary>
		[Column("만족지수")]
		public int SatisfationIndex { get; set; }
		/// <summary>
		/// 진행현황
		/// </summary>
		[Column("진행현황")]
		public string ProgressCurrentState { get; set; }
		/// <summary>
		/// 대표이미지
		/// </summary>
		[Column("대표이미지")]
		public string RepresentativeImage { get; set; }
		/// <summary>
		/// 단체간략키워드
		/// </summary>
		[Column("단체간략키워드")]
		public string GroupBriefKeyword { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 순서
		/// </summary>
		[Column("순서")]
		public int Order { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public int Writter { get; set; }
		/// <summary>
		/// 작성자정보
		/// </summary>
		[Column("작성자정보")]
		public string WritterInfo { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 진행현황
		/// </summary>
		[Column("진행현황")]
		public string ProgressCurrentState { get; set; }
		/// <summary>
		/// 메일발송여부
		/// </summary>
		[Column("메일발송여부")]
		public bool MailSendingOrNot { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 만족지수
		/// </summary>
		[Column("만족지수")]
		public int SatisfationIndex { get; set; }
	}
}