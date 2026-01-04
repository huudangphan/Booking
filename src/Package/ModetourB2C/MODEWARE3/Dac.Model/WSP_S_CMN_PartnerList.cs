namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_파트너리스트
/// </summary>
public class WSP_S_CMN_PartnerList
{
	public const string SP_NAME = "WSP_S_CMN_파트너리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 시도
		/// </summary>
		[Description("시도")]
		public string CityProvince { get; set; }
		/// <summary>
		/// 시군구
		/// </summary>
		[Description("시군구")]
		public string CityDistrictWard { get; set; }
		/// <summary>
		/// 여행사명
		/// </summary>
		[Description("여행사명")]
		public string TravelCompanyName { get; set; }
		/// <summary>
		/// 직원명
		/// </summary>
		[Description("직원명")]
		public string EmployeeName { get; set; }
		/// <summary>
		/// 닷컴예약권한
		/// </summary>
		[Description("닷컴예약권한")]
		public string DotComBookingAuthority { get; set; }
	}

	public class Result1 : IDbResult
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
		/// <summary>
		/// 홈페이지주소
		/// </summary>
		[Column("홈페이지주소")]
		public string HomePageAddress { get; set; }
		/// <summary>
		/// 으뜸BP
		/// </summary>
		[Column("으뜸BP")]
		public string Best_BP { get; set; }
		/// <summary>
		/// 분류
		/// </summary>
		[Column("분류")]
		public string Classification { get; set; }
		/// <summary>
		/// 인센티브전용BP
		/// </summary>
		[Column("인센티브전용BP")]
		public string IncentiveUseOnlyBP { get; set; }
		/// <summary>
		/// 비즈전용BP
		/// </summary>
		[Column("비즈전용BP")]
		public string BusinessUseOnlyBP { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Column("SORT")]
		public Guid SORT { get; set; }
	}

	public class Result2 : IDbResult
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

	public class Result3 : IDbResult
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
		/// <summary>
		/// 홈페이지주소
		/// </summary>
		[Column("홈페이지주소")]
		public string HomePageAddress { get; set; }
		/// <summary>
		/// 으뜸BP
		/// </summary>
		[Column("으뜸BP")]
		public string Best_BP { get; set; }
		/// <summary>
		/// 분류
		/// </summary>
		[Column("분류")]
		public string Classification { get; set; }
		/// <summary>
		/// 인센티브전용BP
		/// </summary>
		[Column("인센티브전용BP")]
		public string IncentiveUseOnlyBP { get; set; }
		/// <summary>
		/// 비즈전용BP여부
		/// </summary>
		[Column("비즈전용BP여부")]
		public string BusinessUseOnlyBPOrNot { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Column("SORT")]
		public Guid SORT { get; set; }
	}
}