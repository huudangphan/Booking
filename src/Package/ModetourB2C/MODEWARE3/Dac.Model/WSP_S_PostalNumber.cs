namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_우편번호
/// </summary>
public class WSP_S_PostalNumber
{
	public const string SP_NAME = "WSP_S_우편번호";

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
		/// 읍면동
		/// </summary>
		[Description("읍면동")]
		public string TownVillageArea { get; set; }
		/// <summary>
		/// 건물번호본번
		/// </summary>
		[Description("건물번호본번")]
		public string BuildingNumberMainNumber { get; set; }
		/// <summary>
		/// 건물번호부번
		/// </summary>
		[Description("건물번호부번")]
		public string BuildingNumberSerialNumber { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 우편번호
		/// </summary>
		[Column("우편번호")]
		public string ZipCode { get; set; }
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
		/// 읍면동
		/// </summary>
		[Column("읍면동")]
		public string TownVillageArea { get; set; }
		/// <summary>
		/// 도로명
		/// </summary>
		[Column("도로명")]
		public string StreetName { get; set; }
		/// <summary>
		/// 법정동명
		/// </summary>
		[Column("법정동명")]
		public string LegalSameName { get; set; }
		/// <summary>
		/// 건물번호본번
		/// </summary>
		[Column("건물번호본번")]
		public string BuildingNumberMainNumber { get; set; }
		/// <summary>
		/// 건물번호부번
		/// </summary>
		[Column("건물번호부번")]
		public string BuildingNumberSerialNumber { get; set; }
		/// <summary>
		/// 우편번호_기존
		/// </summary>
		[Column("우편번호_기존")]
		public string ZipCode_Existing { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 우편번호
		/// </summary>
		[Column("우편번호")]
		public string ZipCode { get; set; }
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
		/// 읍면동
		/// </summary>
		[Column("읍면동")]
		public string TownVillageArea { get; set; }
		/// <summary>
		/// 기타
		/// </summary>
		[Column("기타")]
		public string Other { get; set; }
	}
}