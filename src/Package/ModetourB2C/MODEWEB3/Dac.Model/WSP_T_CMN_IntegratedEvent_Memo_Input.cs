namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_통합이벤트_메모_입력
/// </summary>
public class WSP_T_CMN_IntegratedEvent_Memo_Input
{
	public const string SP_NAME = "WSP_T_CMN_통합이벤트_메모_입력";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
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
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Description("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Description("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 아이피
		/// </summary>
		[Description("아이피")]
		public string IP { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
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
		/// <summary>
		/// 평점
		/// </summary>
		[Description("평점")]
		public int Rating { get; set; }
		/// <summary>
		/// 삭제
		/// </summary>
		[Description("삭제")]
		public string Delete { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 당첨여부
		/// </summary>
		[Description("당첨여부")]
		public string WinnerOrNot { get; set; }
		/// <summary>
		/// 당첨연락처
		/// </summary>
		[Description("당첨연락처")]
		public string WinnerContact { get; set; }
		/// <summary>
		/// 당첨우편번호
		/// </summary>
		[Description("당첨우편번호")]
		public string WinnerZipCode { get; set; }
		/// <summary>
		/// 당첨주소1
		/// </summary>
		[Description("당첨주소1")]
		public string WinnerAddress1 { get; set; }
		/// <summary>
		/// 당첨주소2
		/// </summary>
		[Description("당첨주소2")]
		public string WinnerAddress2 { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Description("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 출력
		/// </summary>
		[Description("출력")]
		public string PrintOut { get; set; }
		/// <summary>
		/// SMS전송
		/// </summary>
		[Description("SMS전송")]
		public string SMS_Sending { get; set; }
		/// <summary>
		/// 이미지저장
		/// </summary>
		[Description("이미지저장")]
		public string ImageSaving { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 결과2
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 20)]
		[Description("결과2")]
		public string Result2 { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 난수
		/// </summary>
		[Column("난수")]
		public string RandomNumber { get; set; }
		/// <summary>
		/// 사용유무
		/// </summary>
		[Column("사용유무")]
		public string UseOrNot { get; set; }
	}
}