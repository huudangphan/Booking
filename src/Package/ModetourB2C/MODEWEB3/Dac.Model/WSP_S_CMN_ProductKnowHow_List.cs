namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_상품노하우_리스트
/// </summary>
public class WSP_S_CMN_ProductKnowHow_List
{
	public const string SP_NAME = "WSP_S_CMN_상품노하우_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// ONO
		/// </summary>
		[Description("ONO")]
		public int ONO { get; set; }
		/// <summary>
		/// KIND
		/// </summary>
		[Description("KIND")]
		public string KIND { get; set; }
		/// <summary>
		/// ST
		/// </summary>
		[Description("ST")]
		public string ST { get; set; }
		/// <summary>
		/// TOTALCOUNT
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("TOTALCOUNT")]
		public int TOTALCOUNT { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 컬럼리스트
		/// </summary>
		[Column("컬럼리스트")]
		public long ColumnList { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 카테고리
		/// </summary>
		[Column("카테고리")]
		public string Category { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 분류
		/// </summary>
		[Column("분류")]
		public int Classification { get; set; }
		/// <summary>
		/// 카테고리명
		/// </summary>
		[Column("카테고리명")]
		public string CategoryName { get; set; }
		/// <summary>
		/// 지역명
		/// </summary>
		[Column("지역명")]
		public string RegionName { get; set; }
		/// <summary>
		/// 분류명
		/// </summary>
		[Column("분류명")]
		public string ClassificationName { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 조회
		/// </summary>
		[Column("조회")]
		public int Search { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
	}
}