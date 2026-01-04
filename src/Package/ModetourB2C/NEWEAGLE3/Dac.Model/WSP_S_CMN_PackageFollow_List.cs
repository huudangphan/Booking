namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_패키지따라가기_리스트
/// </summary>
public class WSP_S_CMN_PackageFollow_List
{
	public const string SP_NAME = "WSP_S_CMN_패키지따라가기_리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// oNo
		/// </summary>
		[Description("oNo")]
		public int oNo { get; set; }
		/// <summary>
		/// KIND
		/// </summary>
		[Description("KIND")]
		public string KIND { get; set; }
		/// <summary>
		/// AREA
		/// </summary>
		[Description("AREA")]
		public int AREA { get; set; }
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
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public int Region { get; set; }
		/// <summary>
		/// 국가
		/// </summary>
		[Column("국가")]
		public int Country { get; set; }
		/// <summary>
		/// 주
		/// </summary>
		[Column("주")]
		public int Week { get; set; }
		/// <summary>
		/// 도시
		/// </summary>
		[Column("도시")]
		public int City { get; set; }
		/// <summary>
		/// 지역명
		/// </summary>
		[Column("지역명")]
		public string RegionName { get; set; }
		/// <summary>
		/// 국가명
		/// </summary>
		[Column("국가명")]
		public string CountryName { get; set; }
		/// <summary>
		/// 주명
		/// </summary>
		[Column("주명")]
		public string StateName { get; set; }
		/// <summary>
		/// 도시명
		/// </summary>
		[Column("도시명")]
		public string CityName { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Column("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 리스트사진
		/// </summary>
		[Column("리스트사진")]
		public string ListPicture { get; set; }
		/// <summary>
		/// 소개
		/// </summary>
		[Column("소개")]
		public string Introduction { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}
}