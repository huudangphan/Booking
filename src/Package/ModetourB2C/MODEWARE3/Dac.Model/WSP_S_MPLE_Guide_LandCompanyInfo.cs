namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_MPLE_가이드_랜드사정보
/// </summary>
public class WSP_S_MPLE_Guide_LandCompanyInfo
{
	public const string SP_NAME = "WSP_S_MPLE_가이드_랜드사정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 랜드사번호
		/// </summary>
		[Description("랜드사번호")]
		public int LandCompanyNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 랜드사명
		/// </summary>
		[Column("랜드사명")]
		public string LandCompanyName { get; set; }
		/// <summary>
		/// 직위
		/// </summary>
		[Column("직위")]
		public string Position { get; set; }
		/// <summary>
		/// 직위코드
		/// </summary>
		[Column("직위코드")]
		public string PositionCode { get; set; }
		/// <summary>
		/// 소속랜드사근무시작년도
		/// </summary>
		[Column("소속랜드사근무시작년도")]
		public string AffiliationLandCompanyWorkStartYear { get; set; }
		/// <summary>
		/// 랜드사번호
		/// </summary>
		[Column("랜드사번호")]
		public int LandCompanyNumber { get; set; }
	}
}