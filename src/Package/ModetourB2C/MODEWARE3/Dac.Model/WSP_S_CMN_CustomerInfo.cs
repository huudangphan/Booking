namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_거래처정보
/// </summary>
public class WSP_S_CMN_CustomerInfo
{
	public const string SP_NAME = "WSP_S_CMN_거래처정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 관계종류
		/// </summary>
		[Column("관계종류")]
		public string RelationshipType { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// PTKNAME
		/// </summary>
		[Column("PTKNAME")]
		public string PTKNAME { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 집전화
		/// </summary>
		[Column("집전화")]
		public string HomePhone { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// PTKNAME
		/// </summary>
		[Column("PTKNAME")]
		public string PTKNAME { get; set; }
		/// <summary>
		/// 웹사이트주소
		/// </summary>
		[Column("웹사이트주소")]
		public string WebSiteAddress { get; set; }
		/// <summary>
		/// 법인명
		/// </summary>
		[Column("법인명")]
		public string CorporationName { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 관계종류
		/// </summary>
		[Column("관계종류")]
		public string RelationshipType { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// PTKNAME
		/// </summary>
		[Column("PTKNAME")]
		public string PTKNAME { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 집전화
		/// </summary>
		[Column("집전화")]
		public string HomePhone { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 회사전화
		/// </summary>
		[Column("회사전화")]
		public string CompanyPhone { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 영업지원
		/// </summary>
		[Column("영업지원")]
		public int BusinessSupport { get; set; }
	}

	public class Result5 : IDbResult
	{
		/// <summary>
		/// 영업지원부서
		/// </summary>
		[Column("영업지원부서")]
		public int BusinessSupportDepartment { get; set; }
	}

	public class Result6 : IDbResult
	{
		/// <summary>
		/// 스킨명
		/// </summary>
		[Column("스킨명")]
		public string SkinName { get; set; }
		/// <summary>
		/// 스킨이미지주소
		/// </summary>
		[Column("스킨이미지주소")]
		public string SkinImageAddress { get; set; }
		/// <summary>
		/// 패키지아이콘
		/// </summary>
		[Column("패키지아이콘")]
		public string PackageIcon { get; set; }
		/// <summary>
		/// 항공아이콘
		/// </summary>
		[Column("항공아이콘")]
		public string FlightIcon { get; set; }
		/// <summary>
		/// 호텔아이콘
		/// </summary>
		[Column("호텔아이콘")]
		public string HotelIcon { get; set; }
		/// <summary>
		/// 철도아이콘
		/// </summary>
		[Column("철도아이콘")]
		public string RailwayIcon { get; set; }
		/// <summary>
		/// 오시는길아이콘
		/// </summary>
		[Column("오시는길아이콘")]
		public string CommingWayIcon { get; set; }
		/// <summary>
		/// 거래처명
		/// </summary>
		[Column("거래처명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 패키지여부
		/// </summary>
		[Column("패키지여부")]
		public string PackageOrNot { get; set; }
		/// <summary>
		/// 항공여부
		/// </summary>
		[Column("항공여부")]
		public string FlightOrNot { get; set; }
		/// <summary>
		/// 호텔여부
		/// </summary>
		[Column("호텔여부")]
		public string HotelOrNot { get; set; }
		/// <summary>
		/// 철도여부
		/// </summary>
		[Column("철도여부")]
		public string RailwayOrNot { get; set; }
		/// <summary>
		/// 오시는길여부
		/// </summary>
		[Column("오시는길여부")]
		public string CommingWayOrNot { get; set; }
	}

	public class Result7 : IDbResult
	{
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 여행사
		/// </summary>
		[Column("여행사")]
		public string TravelCompany { get; set; }
		/// <summary>
		/// 우편번호
		/// </summary>
		[Column("우편번호")]
		public string ZipCode { get; set; }
		/// <summary>
		/// 주소1
		/// </summary>
		[Column("주소1")]
		public string Address1 { get; set; }
		/// <summary>
		/// 주소2
		/// </summary>
		[Column("주소2")]
		public string Address2 { get; set; }
		/// <summary>
		/// 전화번호
		/// </summary>
		[Column("전화번호")]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// 팩스
		/// </summary>
		[Column("팩스")]
		public string Fax { get; set; }
		/// <summary>
		/// 약도
		/// </summary>
		[Column("약도")]
		public string SketchMap { get; set; }
		/// <summary>
		/// 대표자명
		/// </summary>
		[Column("대표자명")]
		public string RepresentativeName { get; set; }
		/// <summary>
		/// 위도
		/// </summary>
		[Column("위도")]
		public string Latitude { get; set; }
		/// <summary>
		/// 경도
		/// </summary>
		[Column("경도")]
		public string Longtitude { get; set; }
	}
}