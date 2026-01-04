namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_BTMS_거래처
/// </summary>
public class WSP_S_CMN_BTMS_Customer
{
	public const string SP_NAME = "WSP_S_CMN_BTMS_거래처";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Column("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 회사명
		/// </summary>
		[Column("회사명")]
		public string CompanyName { get; set; }
		/// <summary>
		/// 항공담당자
		/// </summary>
		[Column("항공담당자")]
		public string FlightManager { get; set; }
		/// <summary>
		/// 호텔담당자
		/// </summary>
		[Column("호텔담당자")]
		public string HotelManager { get; set; }
		/// <summary>
		/// 비자담당자
		/// </summary>
		[Column("비자담당자")]
		public string VisaManager { get; set; }
		/// <summary>
		/// 승인기능사용여부
		/// </summary>
		[Column("승인기능사용여부")]
		public string ApprovalFunctionUseOrNot { get; set; }
		/// <summary>
		/// BTMS웹사이트
		/// </summary>
		[Column("BTMS웹사이트")]
		public string BTMS_WebSite { get; set; }
		/// <summary>
		/// BTMS_출장규정파일
		/// </summary>
		[Column("BTMS_출장규정파일")]
		public string BTMS_BusinessTripRegulationsFile { get; set; }
	}
}