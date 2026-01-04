namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_여행사진공모전
/// </summary>
public class WSP_T_TravelImageExhibition
{
	public const string SP_NAME = "WSP_T_여행사진공모전";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 공모전횟수
		/// </summary>
		[Description("공모전횟수")]
		public short ExhibitionTimes { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 주제
		/// </summary>
		[Description("주제")]
		public string Topic { get; set; }
		/// <summary>
		/// 대륙pid
		/// </summary>
		[Description("대륙pid")]
		public int Continent_PID { get; set; }
		/// <summary>
		/// 국가pid
		/// </summary>
		[Description("국가pid")]
		public int Country_PID { get; set; }
		/// <summary>
		/// 주pid
		/// </summary>
		[Description("주pid")]
		public int State_PID { get; set; }
		/// <summary>
		/// 도시pid
		/// </summary>
		[Description("도시pid")]
		public int City_PID { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Description("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 축소사진
		/// </summary>
		[Description("축소사진")]
		public string DownsizePicture { get; set; }
		/// <summary>
		/// 원본사진
		/// </summary>
		[Description("원본사진")]
		public string OriginalPicture { get; set; }
		/// <summary>
		/// 삭제
		/// </summary>
		[Description("삭제")]
		public string Delete { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
	}

}