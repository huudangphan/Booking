namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_마일리지카드신청리스트
/// </summary>
public class WSP_S_MileageCardRequestList
{
	public const string SP_NAME = "WSP_S_마일리지카드신청리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Description("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 검색필드
		/// </summary>
		[Description("검색필드")]
		public string SearchingField { get; set; }
		/// <summary>
		/// 검색어
		/// </summary>
		[Description("검색어")]
		public string SearchingKeyword { get; set; }
	}

}