namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_우편번호고시형주소
/// </summary>
public class WSP_S_CMN_PostalNumberExamTypeAddress
{
	public const string SP_NAME = "WSP_S_CMN_우편번호고시형주소";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 우편번호
		/// </summary>
		[Description("우편번호")]
		public string ZipCode { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 우편번호
		/// </summary>
		[Column("우편번호")]
		public string ZipCode { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Column("일련번호")]
		public string SerialNumber { get; set; }
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
		/// 리
		/// </summary>
		[Column("리")]
		public string 리 { get; set; }
		/// <summary>
		/// 번지
		/// </summary>
		[Column("번지")]
		public string HouseNumber { get; set; }
		/// <summary>
		/// 동
		/// </summary>
		[Column("동")]
		public string 동 { get; set; }
		/// <summary>
		/// 주소
		/// </summary>
		[Column("주소")]
		public string Address { get; set; }
	}
}