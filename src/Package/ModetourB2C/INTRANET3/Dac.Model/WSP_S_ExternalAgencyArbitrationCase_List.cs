namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_S_외부기관중재사례_리스트
/// </summary>
public class WSP_S_ExternalAgencyArbitrationCase_List
{
	public const string SP_NAME = "WSP_S_외부기관중재사례_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 현재페이지
		/// </summary>
		[Description("현재페이지")]
		public int CurrentPage { get; set; }
		/// <summary>
		/// 페이지당글개수
		/// </summary>
		[Description("페이지당글개수")]
		public int EachPageCharactersNumber { get; set; }
		/// <summary>
		/// 전체게시글수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체게시글수")]
		public int EntirePostCharactersNumber { get; set; }
		/// <summary>
		/// 전체페이지수
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("전체페이지수")]
		public int EntirePageNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 작성자명
		/// </summary>
		[Column("작성자명")]
		public string WritterName { get; set; }
		/// <summary>
		/// 중재기관
		/// </summary>
		[Column("중재기관")]
		public string ArbitrationOffice { get; set; }
		/// <summary>
		/// 고객명
		/// </summary>
		[Column("고객명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Column("출발일")]
		public string DepartureDate { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 신고항목
		/// </summary>
		[Column("신고항목")]
		public string ReportItem { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 처리결과
		/// </summary>
		[Column("처리결과")]
		public bool HandleResult { get; set; }
		/// <summary>
		/// 세부처리결과
		/// </summary>
		[Column("세부처리결과")]
		public string DetailHandleResult { get; set; }
		/// <summary>
		/// 작성일
		/// </summary>
		[Column("작성일")]
		public DateTime WrittingDate { get; set; }
	}
}