namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_검색리조트_상세보기
/// </summary>
public class WSP_S_CMN_SearchResort_DetailSeeing
{
	public const string SP_NAME = "WSP_S_CMN_검색리조트_상세보기";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Description("PLID")]
		public int PLID { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 지역1
		/// </summary>
		[Column("지역1")]
		public string Region1 { get; set; }
		/// <summary>
		/// 지역2
		/// </summary>
		[Column("지역2")]
		public string Region2 { get; set; }
		/// <summary>
		/// 지역3
		/// </summary>
		[Column("지역3")]
		public string Region3 { get; set; }
		/// <summary>
		/// 항목번호
		/// </summary>
		[Column("항목번호")]
		public int ItemNumber { get; set; }
		/// <summary>
		/// 명칭
		/// </summary>
		[Column("명칭")]
		public string Name { get; set; }
		/// <summary>
		/// 명칭1
		/// </summary>
		[Column("명칭1")]
		public string Name1 { get; set; }
		/// <summary>
		/// 속성1
		/// </summary>
		[Column("속성1")]
		public string Attribute1 { get; set; }
		/// <summary>
		/// 속성2
		/// </summary>
		[Column("속성2")]
		public string Attribute2 { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Column("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Column("SORT")]
		public int SORT { get; set; }
		/// <summary>
		/// 속성번호
		/// </summary>
		[Column("속성번호")]
		public int AttributeNumber { get; set; }
		/// <summary>
		/// 영문지역3
		/// </summary>
		[Column("영문지역3")]
		public string EnglishRegion3 { get; set; }
		/// <summary>
		/// PLACEINFO번호
		/// </summary>
		[Column("PLACEINFO번호")]
		public int PLACEINFO_Number { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 파일주소
		/// </summary>
		[Column("파일주소")]
		public string FileAddress { get; set; }
		/// <summary>
		/// 사진명
		/// </summary>
		[Column("사진명")]
		public string PictureName { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 리조트명
		/// </summary>
		[Column("리조트명")]
		public string ResortName { get; set; }
		/// <summary>
		/// 리조트영문명
		/// </summary>
		[Column("리조트영문명")]
		public string ResortEnglishName { get; set; }
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
		/// <summary>
		/// INFOTYPE번호
		/// </summary>
		[Column("INFOTYPE번호")]
		public int INFOTYPE_Number { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Column("SORT")]
		public string SORT { get; set; }
	}
}