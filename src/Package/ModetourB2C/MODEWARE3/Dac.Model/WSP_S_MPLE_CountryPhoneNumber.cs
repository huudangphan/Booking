namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_MPLE_국가전화번호
/// </summary>
public class WSP_S_MPLE_CountryPhoneNumber
{
	public const string SP_NAME = "WSP_S_MPLE_국가전화번호";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 검색어
		/// </summary>
		[Description("검색어")]
		public string SearchingKeyword { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 국가명
		/// </summary>
		[Column("국가명")]
		public string CountryName { get; set; }
		/// <summary>
		/// 국가코드
		/// </summary>
		[Column("국가코드")]
		public int CountryCode { get; set; }
	}
}