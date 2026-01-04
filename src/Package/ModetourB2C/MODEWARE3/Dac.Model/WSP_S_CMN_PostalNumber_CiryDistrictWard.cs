namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_우편번호_시군구
/// </summary>
public class WSP_S_CMN_PostalNumber_CiryDistrictWard
{
	public const string SP_NAME = "WSP_S_CMN_우편번호_시군구";

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
	}

	public class Result : IDbResult
	{
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
	}
}