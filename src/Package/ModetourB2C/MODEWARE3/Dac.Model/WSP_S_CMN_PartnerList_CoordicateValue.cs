namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_파트너리스트_좌표값
/// </summary>
public class WSP_S_CMN_PartnerList_CoordicateValue
{
	public const string SP_NAME = "WSP_S_CMN_파트너리스트_좌표값";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 위도1
		/// </summary>
		[Description("위도1")]
		public string Latitude1 { get; set; }
		/// <summary>
		/// 위도2
		/// </summary>
		[Description("위도2")]
		public string Latitude2 { get; set; }
		/// <summary>
		/// 경도1
		/// </summary>
		[Description("경도1")]
		public string Longtitude1 { get; set; }
		/// <summary>
		/// 경도2
		/// </summary>
		[Description("경도2")]
		public string Longtitude2 { get; set; }
		/// <summary>
		/// 닷컴예약권한
		/// </summary>
		[Description("닷컴예약권한")]
		public string DotComBookingAuthority { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// PTID1
		/// </summary>
		[Column("PTID1")]
		public int PTID1 { get; set; }
		/// <summary>
		/// PTID2
		/// </summary>
		[Column("PTID2")]
		public int PTID2 { get; set; }
		/// <summary>
		/// 시도
		/// </summary>
		[Column("시도")]
		public string CityProvince { get; set; }
		/// <summary>
		/// 시군구
		/// </summary>
		[Column("시군구")]
		public string CityDistrictWard { get; set; }
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
		/// 팩스번호
		/// </summary>
		[Column("팩스번호")]
		public string FaxNumber { get; set; }
		/// <summary>
		/// 담당직원
		/// </summary>
		[Column("담당직원")]
		public string ResponsibilityEmployee { get; set; }
		/// <summary>
		/// 담당직원2
		/// </summary>
		[Column("담당직원2")]
		public string ResponsibilityEmployee2 { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 약도
		/// </summary>
		[Column("약도")]
		public string SketchMap { get; set; }
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