namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_CMN_키워드_리스트
/// </summary>
public class WSP_S_CMN_Keyword_List
{
	public const string SP_NAME = "WSP_S_CMN_키워드_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분번호
		/// </summary>
		[Description("구분번호")]
		public int ClassificationNumber { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Description("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 리스트갯수
		/// </summary>
		[Description("리스트갯수")]
		public int ListNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 키워드
		/// </summary>
		[Column("키워드")]
		public string Keyword { get; set; }
		/// <summary>
		/// 링크경로
		/// </summary>
		[Column("링크경로")]
		public string LinkRoute { get; set; }
		/// <summary>
		/// 태그
		/// </summary>
		[Column("태그")]
		public string Tag { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public int Sorting { get; set; }
	}
}