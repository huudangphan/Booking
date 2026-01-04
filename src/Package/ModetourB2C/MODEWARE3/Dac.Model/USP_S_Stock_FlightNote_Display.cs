namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_재고_항공비고_노출
/// </summary>
public class USP_S_Stock_FlightNote_Display
{
	public const string SP_NAME = "USP_S_재고_항공비고_노출";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 재고번호
		/// </summary>
		[Description("재고번호")]
		public int StockNumber { get; set; }
		/// <summary>
		/// 공항센딩
		/// </summary>
		[Description("공항센딩")]
		public string AirportSending { get; set; }
		/// <summary>
		/// E센딩
		/// </summary>
		[Description("E센딩")]
		public string E_Sending { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 항공정보명
		/// </summary>
		[Column("항공정보명")]
		public string FlightInfoName { get; set; }
		/// <summary>
		/// 항공비고사항
		/// </summary>
		[Column("항공비고사항")]
		public string FlightNoteItem { get; set; }
		/// <summary>
		/// 항공비고_마스터일련번호
		/// </summary>
		[Column("항공비고_마스터일련번호")]
		public int FlightNote_MasterSerialNumber { get; set; }
	}
}