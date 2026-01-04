namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_호텔_배너_리스트
/// </summary>
public class WSP_S_Hotel_Banner_List
{
	public const string SP_NAME = "WSP_S_호텔_배너_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public short Classification { get; set; }
		/// <summary>
		/// 개시여부
		/// </summary>
		[Description("개시여부")]
		public string ReleaseOrNot { get; set; }
		/// <summary>
		/// 페이지번호
		/// </summary>
		[Description("페이지번호")]
		public int PageNumber { get; set; }
		/// <summary>
		/// 페이지크기
		/// </summary>
		[Description("페이지크기")]
		public short PageSize { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// TotalCnt
		/// </summary>
		[Column("TotalCnt")]
		public int TotalCnt { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// ROWNUM
		/// </summary>
		[Column("ROWNUM")]
		public long ROWNUM { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 태그
		/// </summary>
		[Column("태그")]
		public string Tag { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// 이미지
		/// </summary>
		[Column("이미지")]
		public string Image { get; set; }
		/// <summary>
		/// 링크
		/// </summary>
		[Column("링크")]
		public string Link { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 새창여부
		/// </summary>
		[Column("새창여부")]
		public string NewWindowOrNot { get; set; }
		/// <summary>
		/// 개시여부
		/// </summary>
		[Column("개시여부")]
		public string ReleaseOrNot { get; set; }
		/// <summary>
		/// 개시순서
		/// </summary>
		[Column("개시순서")]
		public short ReleaseOrder { get; set; }
	}
}