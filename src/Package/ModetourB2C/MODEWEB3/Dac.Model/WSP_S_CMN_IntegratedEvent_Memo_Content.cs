namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_통합이벤트_메모_내용
/// </summary>
public class WSP_S_CMN_IntegratedEvent_Memo_Content
{
	public const string SP_NAME = "WSP_S_CMN_통합이벤트_메모_내용";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Description("이벤트번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Description("상태1")]
		public string State1 { get; set; }
		/// <summary>
		/// 상태2
		/// </summary>
		[Description("상태2")]
		public string State2 { get; set; }
		/// <summary>
		/// 상태3
		/// </summary>
		[Description("상태3")]
		public string State3 { get; set; }
		/// <summary>
		/// 번호1
		/// </summary>
		[Description("번호1")]
		public int Number1 { get; set; }
		/// <summary>
		/// 번호2
		/// </summary>
		[Description("번호2")]
		public int Number2 { get; set; }
		/// <summary>
		/// 번호3
		/// </summary>
		[Description("번호3")]
		public int Number3 { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 초대장발송횟수
		/// </summary>
		[Column("초대장발송횟수")]
		public int InvitationCardSendingTimes { get; set; }
		/// <summary>
		/// 응모횟수
		/// </summary>
		[Column("응모횟수")]
		public int ApplicationTimes { get; set; }
	}

	public class Result2 : IDbResult
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
		/// 삭제
		/// </summary>
		[Column("삭제")]
		public string Delete { get; set; }
		/// <summary>
		/// 당첨여부
		/// </summary>
		[Column("당첨여부")]
		public string WinnerOrNot { get; set; }
		/// <summary>
		/// 당첨연락처
		/// </summary>
		[Column("당첨연락처")]
		public string WinnerContact { get; set; }
		/// <summary>
		/// 당첨우편번호
		/// </summary>
		[Column("당첨우편번호")]
		public string WinnerZipCode { get; set; }
		/// <summary>
		/// 당첨주소1
		/// </summary>
		[Column("당첨주소1")]
		public string WinnerAddress1 { get; set; }
		/// <summary>
		/// 당첨주소2
		/// </summary>
		[Column("당첨주소2")]
		public string WinnerAddress2 { get; set; }
		/// <summary>
		/// 기타요청사항
		/// </summary>
		[Column("기타요청사항")]
		public string OtherRequest { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 출력
		/// </summary>
		[Column("출력")]
		public string PrintOut { get; set; }
		/// <summary>
		/// SMS전송
		/// </summary>
		[Column("SMS전송")]
		public string SMS_Sending { get; set; }
		/// <summary>
		/// 이미지저장
		/// </summary>
		[Column("이미지저장")]
		public string ImageSaving { get; set; }
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
		/// <summary>
		/// 삭제
		/// </summary>
		[Column("삭제")]
		public string Delete { get; set; }
		/// <summary>
		/// 당첨여부
		/// </summary>
		[Column("당첨여부")]
		public string WinnerOrNot { get; set; }
		/// <summary>
		/// 당첨연락처
		/// </summary>
		[Column("당첨연락처")]
		public string WinnerContact { get; set; }
		/// <summary>
		/// 당첨우편번호
		/// </summary>
		[Column("당첨우편번호")]
		public string WinnerZipCode { get; set; }
		/// <summary>
		/// 당첨주소1
		/// </summary>
		[Column("당첨주소1")]
		public string WinnerAddress1 { get; set; }
		/// <summary>
		/// 당첨주소2
		/// </summary>
		[Column("당첨주소2")]
		public string WinnerAddress2 { get; set; }
		/// <summary>
		/// 기타요청사항
		/// </summary>
		[Column("기타요청사항")]
		public string OtherRequest { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 조회수
		/// </summary>
		[Column("조회수")]
		public int SearchNumber { get; set; }
		/// <summary>
		/// 출력
		/// </summary>
		[Column("출력")]
		public string PrintOut { get; set; }
		/// <summary>
		/// SMS전송
		/// </summary>
		[Column("SMS전송")]
		public string SMS_Sending { get; set; }
		/// <summary>
		/// 이미지저장
		/// </summary>
		[Column("이미지저장")]
		public string ImageSaving { get; set; }
		/// <summary>
		/// 추천수
		/// </summary>
		[Column("추천수")]
		public int RecommendNumber { get; set; }
	}
}