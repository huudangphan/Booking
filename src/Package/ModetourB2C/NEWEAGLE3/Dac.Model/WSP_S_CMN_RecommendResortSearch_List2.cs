namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_추천리조트검색_리스트2
/// </summary>
public class WSP_S_CMN_RecommendResortSearch_List2
{
	public const string SP_NAME = "WSP_S_CMN_추천리조트검색_리스트2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 대륙번호
		/// </summary>
		[Description("대륙번호")]
		public string ContinentNumber { get; set; }
		/// <summary>
		/// 국가번호
		/// </summary>
		[Description("국가번호")]
		public string CountryNumber { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Description("도시번호")]
		public string CityNumber { get; set; }
		/// <summary>
		/// 리조트명
		/// </summary>
		[Description("리조트명")]
		public string ResortName { get; set; }
		/// <summary>
		/// ONO
		/// </summary>
		[Description("ONO")]
		public int ONO { get; set; }
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
		/// PLID
		/// </summary>
		[Column("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// 지역
		/// </summary>
		[Column("지역")]
		public string Region { get; set; }
		/// <summary>
		/// 국가
		/// </summary>
		[Column("국가")]
		public string Country { get; set; }
		/// <summary>
		/// 도시
		/// </summary>
		[Column("도시")]
		public string City { get; set; }
		/// <summary>
		/// 리조트번호
		/// </summary>
		[Column("리조트번호")]
		public int ResortNumber { get; set; }
		/// <summary>
		/// 리조트명
		/// </summary>
		[Column("리조트명")]
		public string ResortName { get; set; }
		/// <summary>
		/// 대륙번호
		/// </summary>
		[Column("대륙번호")]
		public int ContinentNumber { get; set; }
		/// <summary>
		/// 국가번호
		/// </summary>
		[Column("국가번호")]
		public int CountryNumber { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Column("도시번호")]
		public int CityNumber { get; set; }
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
		/// <summary>
		/// 객실정보
		/// </summary>
		[Column("객실정보")]
		public string GuestRoomInfo { get; set; }
		/// <summary>
		/// 레저부대시설
		/// </summary>
		[Column("레저부대시설")]
		public string LeisureFacilities { get; set; }
		/// <summary>
		/// 레스토랑
		/// </summary>
		[Column("레스토랑")]
		public string Restaurant { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
	}
}