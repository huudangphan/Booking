namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_파트너상세정보
/// </summary>
public class WSP_S_CMN_PartnerDetailInfo
{
	public const string SP_NAME = "WSP_S_CMN_파트너상세정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID1
		/// </summary>
		[Description("PTID1")]
		public int PTID1 { get; set; }
		/// <summary>
		/// PTID2
		/// </summary>
		[Description("PTID2")]
		public int PTID2 { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Column("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 거래처직원명
		/// </summary>
		[Column("거래처직원명")]
		public string CustomerEmployeeName { get; set; }
		/// <summary>
		/// 거래처직원명2
		/// </summary>
		[Column("거래처직원명2")]
		public string CustomerEmployeeName2 { get; set; }
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
		/// 홈페이지
		/// </summary>
		[Column("홈페이지")]
		public string HomePage { get; set; }
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