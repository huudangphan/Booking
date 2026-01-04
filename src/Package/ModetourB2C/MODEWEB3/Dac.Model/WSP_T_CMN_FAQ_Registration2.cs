namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_자주묻는질문_등록
/// </summary>
public class WSP_T_CMN_FAQ_Registration2
{
	public const string SP_NAME = "WSP_T_CMN_자주묻는질문_등록";

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
		/// 상태
		/// </summary>
		[Description("상태")]
		public byte State { get; set; }
		/// <summary>
		/// 상세구분
		/// </summary>
		[Description("상세구분")]
		public string DetailClassification { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
	}

}