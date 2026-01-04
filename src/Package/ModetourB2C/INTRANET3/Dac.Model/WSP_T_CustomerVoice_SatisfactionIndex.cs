namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_T_고객의소리_만족지수
/// </summary>
public class WSP_T_CustomerVoice_SatisfactionIndex
{
	public const string SP_NAME = "WSP_T_고객의소리_만족지수";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 고객의소리일련번호
		/// </summary>
		[Description("고객의소리일련번호")]
		public int CustomerVoiceSerialNumber { get; set; }
		/// <summary>
		/// 작성자명
		/// </summary>
		[Description("작성자명")]
		public string WritterName { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Description("종류")]
		public string Type { get; set; }
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
		/// 만족지수
		/// </summary>
		[Description("만족지수")]
		public int SatisfationIndex { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Description("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
	}

}