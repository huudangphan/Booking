namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_외부단체등록_11번가
/// </summary>
public class WSP_T_CMN_ExternalGroupRegistration_11st
{
	public const string SP_NAME = "WSP_T_CMN_외부단체등록_11번가";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// 최소단체번호
		/// </summary>
		[Description("최소단체번호")]
		public int MinimumGroupNumber { get; set; }
		/// <summary>
		/// 업체단체번호
		/// </summary>
		[Description("업체단체번호")]
		public int CompanyGroupNumber { get; set; }
		/// <summary>
		/// 출발일1
		/// </summary>
		[Description("출발일1")]
		public DateTime DepartureDate1 { get; set; }
		/// <summary>
		/// 출발일2
		/// </summary>
		[Description("출발일2")]
		public DateTime DepartureDate2 { get; set; }
	}

}