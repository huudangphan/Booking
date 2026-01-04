namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_여권비자_등록
/// </summary>
public class WSP_T_PassportVisa_Registration
{
	public const string SP_NAME = "WSP_T_여권비자_등록";

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
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 카테고리
		/// </summary>
		[Description("카테고리")]
		public string Category { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Description("지역")]
		public int Region { get; set; }
		/// <summary>
		/// 국가
		/// </summary>
		[Description("국가")]
		public int Country { get; set; }
		/// <summary>
		/// 대사관주소
		/// </summary>
		[Description("대사관주소")]
		public string EmbassyAddress { get; set; }
		/// <summary>
		/// 대사관전화번호
		/// </summary>
		[Description("대사관전화번호")]
		public string EmbassyPhoneNumber { get; set; }
		/// <summary>
		/// 대사관업무시간
		/// </summary>
		[Description("대사관업무시간")]
		public string EmbassyTaskTime { get; set; }
		/// <summary>
		/// 순번
		/// </summary>
		[Description("순번")]
		public byte Order { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Description("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
	}

}