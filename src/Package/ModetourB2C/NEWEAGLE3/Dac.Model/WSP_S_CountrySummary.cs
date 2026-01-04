namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_국가개요
/// </summary>
public class WSP_S_CountrySummary
{
	public const string SP_NAME = "WSP_S_국가개요";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Description("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// INFOTYPE번호
		/// </summary>
		[Description("INFOTYPE번호")]
		public int INFOTYPE_Number { get; set; }
		/// <summary>
		/// AREA1
		/// </summary>
		[Description("AREA1")]
		public string AREA1 { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// NATION
		/// </summary>
		[Column("NATION")]
		public string NATION { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 하위제목
		/// </summary>
		[Column("하위제목")]
		public string LowRankTitle { get; set; }
		/// <summary>
		/// 내용2
		/// </summary>
		[Column("내용2")]
		public string Content2 { get; set; }
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// PLENAME
		/// </summary>
		[Column("PLENAME")]
		public string PLENAME { get; set; }
		/// <summary>
		/// 좌표
		/// </summary>
		[Column("좌표")]
		public string Coordinate { get; set; }
		/// <summary>
		/// P_PLID
		/// </summary>
		[Column("P_PLID")]
		public int P_PLID { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// PLACEIMAGE번호
		/// </summary>
		[Column("PLACEIMAGE번호")]
		public int PLACEIMAGE_Number { get; set; }
		/// <summary>
		/// 파일명
		/// </summary>
		[Column("파일명")]
		public string FileName { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// PLKNAME
		/// </summary>
		[Column("PLKNAME")]
		public string PLKNAME { get; set; }
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public string Column1 { get; set; }
		/// <summary>
		/// PLID1
		/// </summary>
		[Column("PLID1")]
		public int PLID1 { get; set; }
		/// <summary>
		/// PLCODE
		/// </summary>
		[Column("PLCODE")]
		public string PLCODE { get; set; }
		/// <summary>
		/// PLKNAME1
		/// </summary>
		[Column("PLKNAME1")]
		public string PLKNAME1 { get; set; }
		/// <summary>
		/// PLENAME
		/// </summary>
		[Column("PLENAME")]
		public string PLENAME { get; set; }
		/// <summary>
		/// 레벨
		/// </summary>
		[Column("레벨")]
		public byte Level { get; set; }
		/// <summary>
		/// P_PLID
		/// </summary>
		[Column("P_PLID")]
		public int P_PLID { get; set; }
		/// <summary>
		/// PATH
		/// </summary>
		[Column("PATH")]
		public string PATH { get; set; }
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 수정일
		/// </summary>
		[Column("수정일")]
		public DateTime EditionDate { get; set; }
		/// <summary>
		/// 수정자
		/// </summary>
		[Column("수정자")]
		public int Editor { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Column("비고")]
		public string Note { get; set; }
		/// <summary>
		/// 좌표
		/// </summary>
		[Column("좌표")]
		public string Coordinate { get; set; }
		/// <summary>
		/// 날씨영문명
		/// </summary>
		[Column("날씨영문명")]
		public string WeatherEnglishName { get; set; }
		/// <summary>
		/// PLEVEL
		/// </summary>
		[Column("PLEVEL")]
		public int PLEVEL { get; set; }
		/// <summary>
		/// FULLNAME
		/// </summary>
		[Column("FULLNAME")]
		public string FULLNAME { get; set; }
		/// <summary>
		/// PLACE_경로
		/// </summary>
		[Column("PLACE_경로")]
		public string PLACE_Route { get; set; }
		/// <summary>
		/// 컨텐츠갯수
		/// </summary>
		[Column("컨텐츠갯수")]
		public int ContentNumber { get; set; }
		/// <summary>
		/// 컨텐츠갯수_하위포함
		/// </summary>
		[Column("컨텐츠갯수_하위포함")]
		public int ContentNumber_LowRankIncluded { get; set; }
		/// <summary>
		/// 미등록컨텐츠갯수
		/// </summary>
		[Column("미등록컨텐츠갯수")]
		public int UnregisterContentNumber { get; set; }
		/// <summary>
		/// 미등록컨텐츠갯수_하위포함
		/// </summary>
		[Column("미등록컨텐츠갯수_하위포함")]
		public int UnregisterContentNumber_LowRankIncluded { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Column("사용여부")]
		public string UseOrNot { get; set; }
		/// <summary>
		/// PLACEINFO번호
		/// </summary>
		[Column("PLACEINFO번호")]
		public int PLACEINFO_Number { get; set; }
		/// <summary>
		/// PLID2
		/// </summary>
		[Column("PLID2")]
		public int PLID2 { get; set; }
		/// <summary>
		/// INFOTYPE번호
		/// </summary>
		[Column("INFOTYPE번호")]
		public int INFOTYPE_Number { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 수정일1
		/// </summary>
		[Column("수정일1")]
		public DateTime EditionDate1 { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// INFOTYPE번호
		/// </summary>
		[Column("INFOTYPE번호")]
		public int INFOTYPE_Number { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
	}
}