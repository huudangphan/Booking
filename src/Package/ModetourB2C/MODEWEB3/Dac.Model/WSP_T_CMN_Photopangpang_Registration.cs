namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_포토팡팡_등록
/// </summary>
public class WSP_T_CMN_Photopangpang_Registration
{
	public const string SP_NAME = "WSP_T_CMN_포토팡팡_등록";

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
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 작성자
		/// </summary>
		[Description("작성자")]
		public string Writter { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Description("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 여행지
		/// </summary>
		[Description("여행지")]
		public string TravelSpot { get; set; }
		/// <summary>
		/// 사진
		/// </summary>
		[Description("사진")]
		public string Picture { get; set; }
		/// <summary>
		/// 형식
		/// </summary>
		[Description("형식")]
		public bool Format { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Description("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// IP
		/// </summary>
		[Description("IP")]
		public string IP { get; set; }
		/// <summary>
		/// 정보반영
		/// </summary>
		[Description("정보반영")]
		public bool InfoReflect { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Description("지역")]
		public int Region { get; set; }
		/// <summary>
		/// 사이트
		/// </summary>
		[Description("사이트")]
		public string Site { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 핸드폰
		/// </summary>
		[Description("핸드폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Description("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 여행구분
		/// </summary>
		[Description("여행구분")]
		public string TravelClassification { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 테마
		/// </summary>
		[Description("테마")]
		public string Theme { get; set; }
		/// <summary>
		/// 사진크기
		/// </summary>
		[Description("사진크기")]
		public string PictureSize { get; set; }
		/// <summary>
		/// 이벤트참가여부
		/// </summary>
		[Description("이벤트참가여부")]
		public string EventParticipateOrNot { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 결과2
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 10)]
		[Description("결과2")]
		public string Result2 { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public string Column1 { get; set; }
	}
}