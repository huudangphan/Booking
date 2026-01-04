namespace ModetourB2C.Dac.Model.GROUPWARE3;

/// <summary>
/// UP_결재완료_수신문서_리스트
/// </summary>
public class UP_ApprovalFinish_ReceiptDocument_List
{
	public const string SP_NAME = "UP_결재완료_수신문서_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 직원번호
		/// </summary>
		[Description("직원번호")]
		public int EmployeeNumber { get; set; }
		/// <summary>
		/// 결재진행
		/// </summary>
		[Description("결재진행")]
		public string ApprovalProgress { get; set; }
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
		/// 문서코드
		/// </summary>
		[Column("문서코드")]
		public int DocumentCode { get; set; }
		/// <summary>
		/// 문서번호
		/// </summary>
		[Column("문서번호")]
		public string DocumentNumber { get; set; }
		/// <summary>
		/// 문서구분
		/// </summary>
		[Column("문서구분")]
		public string DocumentClassification { get; set; }
		/// <summary>
		/// 기안일
		/// </summary>
		[Column("기안일")]
		public DateTime DraftDate { get; set; }
		/// <summary>
		/// 기안자정보
		/// </summary>
		[Column("기안자정보")]
		public string DrafterInfo { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 첨부파일
		/// </summary>
		[Column("첨부파일")]
		public byte AttachFile { get; set; }
		/// <summary>
		/// 의견
		/// </summary>
		[Column("의견")]
		public byte Opinion { get; set; }
		/// <summary>
		/// 결재진행일
		/// </summary>
		[Column("결재진행일")]
		public DateTime ApprovalProgressDate { get; set; }
		/// <summary>
		/// 수신
		/// </summary>
		[Column("수신")]
		public string Reception { get; set; }
		/// <summary>
		/// 양식명
		/// </summary>
		[Column("양식명")]
		public string FormName { get; set; }
		/// <summary>
		/// 문서구분명
		/// </summary>
		[Column("문서구분명")]
		public string DocumentClassificationName { get; set; }
	}
}