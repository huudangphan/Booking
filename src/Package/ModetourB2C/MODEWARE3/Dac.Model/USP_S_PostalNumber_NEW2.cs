namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_우편번호_NEW2
/// </summary>
public class USP_S_PostalNumber_NEW2
{
	public const string SP_NAME = "USP_S_우편번호_NEW2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 읍면동
		/// </summary>
		[Description("읍면동")]
		public string TownVillageArea { get; set; }
	}

	public class Result : IDbResult
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
		/// <summary>
		/// 우편번호_기존
		/// </summary>
		[Column("우편번호_기존")]
		public string ZipCode_Existing { get; set; }
	}
}