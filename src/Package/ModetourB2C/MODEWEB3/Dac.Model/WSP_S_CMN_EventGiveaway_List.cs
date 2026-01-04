namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_이벤트경품_리스트
/// </summary>
public class WSP_S_CMN_EventGiveaway_List
{
	public const string SP_NAME = "WSP_S_CMN_이벤트경품_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Description("이벤트번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// 경품번호
		/// </summary>
		[Description("경품번호")]
		public int GiveawayNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 중복체크
		/// </summary>
		[Description("중복체크")]
		public string DuplicatedCheck { get; set; }
		/// <summary>
		/// 중복체크정보
		/// </summary>
		[Description("중복체크정보")]
		public string DuplicatedCheckInfo { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Description("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 10)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 최대중복가능개수
		/// </summary>
		[Description("최대중복가능개수")]
		public int MaximumDuplicatedPossibleNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 시작일
		/// </summary>
		[Column("시작일")]
		public DateTime StartDate { get; set; }
		/// <summary>
		/// 종료일
		/// </summary>
		[Column("종료일")]
		public DateTime EndDate { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 경품품목번호
		/// </summary>
		[Column("경품품목번호")]
		public int GiveawayItemNumber { get; set; }
		/// <summary>
		/// 경품품목명
		/// </summary>
		[Column("경품품목명")]
		public string GiveawayItemName { get; set; }
		/// <summary>
		/// 총수량
		/// </summary>
		[Column("총수량")]
		public int TotalQuantity { get; set; }
		/// <summary>
		/// 지급수량
		/// </summary>
		[Column("지급수량")]
		public int PaymentQuantity { get; set; }
		/// <summary>
		/// 남은수량
		/// </summary>
		[Column("남은수량")]
		public int LeftQuantity { get; set; }
		/// <summary>
		/// 금일지급가능수량
		/// </summary>
		[Column("금일지급가능수량")]
		public int TodayPaymentPossibleQuantity { get; set; }
		/// <summary>
		/// 금일지급수량
		/// </summary>
		[Column("금일지급수량")]
		public int TodayPaymentQuantity { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Column("이벤트번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Column("상태1")]
		public string State1 { get; set; }
		/// <summary>
		/// 상태2
		/// </summary>
		[Column("상태2")]
		public string State2 { get; set; }
		/// <summary>
		/// 상태3
		/// </summary>
		[Column("상태3")]
		public string State3 { get; set; }
		/// <summary>
		/// 번호1
		/// </summary>
		[Column("번호1")]
		public int Number1 { get; set; }
		/// <summary>
		/// 번호2
		/// </summary>
		[Column("번호2")]
		public int Number2 { get; set; }
		/// <summary>
		/// 번호3
		/// </summary>
		[Column("번호3")]
		public int Number3 { get; set; }
		/// <summary>
		/// 평점
		/// </summary>
		[Column("평점")]
		public short Rating { get; set; }
		/// <summary>
		/// 아이피
		/// </summary>
		[Column("아이피")]
		public string IP { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Column("이벤트번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Column("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Column("상태1")]
		public string State1 { get; set; }
		/// <summary>
		/// 상태2
		/// </summary>
		[Column("상태2")]
		public string State2 { get; set; }
		/// <summary>
		/// 상태3
		/// </summary>
		[Column("상태3")]
		public string State3 { get; set; }
		/// <summary>
		/// 번호1
		/// </summary>
		[Column("번호1")]
		public int Number1 { get; set; }
		/// <summary>
		/// 번호2
		/// </summary>
		[Column("번호2")]
		public int Number2 { get; set; }
		/// <summary>
		/// 번호3
		/// </summary>
		[Column("번호3")]
		public int Number3 { get; set; }
		/// <summary>
		/// 평점
		/// </summary>
		[Column("평점")]
		public short Rating { get; set; }
		/// <summary>
		/// 아이피
		/// </summary>
		[Column("아이피")]
		public string IP { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 당첨여부
		/// </summary>
		[Column("당첨여부")]
		public string WinnerOrNot { get; set; }
	}
}