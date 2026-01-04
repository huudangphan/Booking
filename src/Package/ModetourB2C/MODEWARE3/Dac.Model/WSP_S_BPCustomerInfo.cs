namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_BP거래처정보
/// </summary>
public class WSP_S_BPCustomerInfo
{
	public const string SP_NAME = "WSP_S_BP거래처정보";

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
		/// 회사명
		/// </summary>
		[Column("회사명")]
		public string CompanyName { get; set; }
		/// <summary>
		/// 대표자
		/// </summary>
		[Column("대표자")]
		public string Representative { get; set; }
		/// <summary>
		/// 회사우편번호
		/// </summary>
		[Column("회사우편번호")]
		public string CompanyZipCode { get; set; }
		/// <summary>
		/// 회사주소1
		/// </summary>
		[Column("회사주소1")]
		public string CompanyAddress1 { get; set; }
		/// <summary>
		/// 회사주소2
		/// </summary>
		[Column("회사주소2")]
		public string CompanyAddress2 { get; set; }
		/// <summary>
		/// 회사전화
		/// </summary>
		[Column("회사전화")]
		public string CompanyPhone { get; set; }
		/// <summary>
		/// 팩스
		/// </summary>
		[Column("팩스")]
		public string Fax { get; set; }
		/// <summary>
		/// 담당자이메일
		/// </summary>
		[Column("담당자이메일")]
		public string ManagerEmail { get; set; }
		/// <summary>
		/// 사업자번호
		/// </summary>
		[Column("사업자번호")]
		public string LicenseeNumber { get; set; }
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
		/// <summary>
		/// BP
		/// </summary>
		[Column("BP")]
		public string BP { get; set; }
	}

	public class Result2 : IDbResult
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
}