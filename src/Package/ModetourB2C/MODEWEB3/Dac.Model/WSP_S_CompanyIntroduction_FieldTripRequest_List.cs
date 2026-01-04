namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_회사소개_견학신청_리스트
/// </summary>
public class WSP_S_CompanyIntroduction_FieldTripRequest_List
{
	public const string SP_NAME = "WSP_S_회사소개_견학신청_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 사용자구분
		/// </summary>
		[Description("사용자구분")]
		public string UserClassification { get; set; }
		/// <summary>
		/// 신청자성명
		/// </summary>
		[Description("신청자성명")]
		public string RequesterName { get; set; }
		/// <summary>
		/// 신청자전화번호
		/// </summary>
		[Description("신청자전화번호")]
		public string RequesterPhoneNumber { get; set; }
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
		/// 검색필드
		/// </summary>
		[Description("검색필드")]
		public string SearchingField { get; set; }
		/// <summary>
		/// 검색어
		/// </summary>
		[Description("검색어")]
		public string SearchingKeyword { get; set; }
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
		/// 견학일
		/// </summary>
		[Column("견학일")]
		public DateTime FieldtripDate { get; set; }
		/// <summary>
		/// 신청자성명
		/// </summary>
		[Column("신청자성명")]
		public string RequesterName { get; set; }
		/// <summary>
		/// 단체이름
		/// </summary>
		[Column("단체이름")]
		public string GroupName { get; set; }
		/// <summary>
		/// 상태
		/// </summary>
		[Column("상태")]
		public string State { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}
}