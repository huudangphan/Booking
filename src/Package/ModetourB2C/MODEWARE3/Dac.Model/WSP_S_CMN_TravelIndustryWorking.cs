namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_여행업계종사
/// </summary>
public class WSP_S_CMN_TravelIndustryWorking
{
	public const string SP_NAME = "WSP_S_CMN_여행업계종사";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 업체번호
		/// </summary>
		[Description("업체번호")]
		public int CompanyNumber { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public int Column1 { get; set; }
	}
}