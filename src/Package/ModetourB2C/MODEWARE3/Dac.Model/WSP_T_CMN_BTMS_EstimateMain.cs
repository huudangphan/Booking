namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_BTMS_견적메인
/// </summary>
public class WSP_T_CMN_BTMS_EstimateMain
{
	public const string SP_NAME = "WSP_T_CMN_BTMS_견적메인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 견적번호
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("견적번호")]
		public int EstimateNumber { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 요청자
		/// </summary>
		[Description("요청자")]
		public string Requester { get; set; }
		/// <summary>
		/// 출장명
		/// </summary>
		[Description("출장명")]
		public string BusinessTripName { get; set; }
		/// <summary>
		/// 출발일
		/// </summary>
		[Description("출발일")]
		public DateTime DepartureDate { get; set; }
		/// <summary>
		/// 도착일
		/// </summary>
		[Description("도착일")]
		public DateTime ArrivalDate { get; set; }
		/// <summary>
		/// 첨부파일번호
		/// </summary>
		[Description("첨부파일번호")]
		public int AttachFileNumber { get; set; }
	}

}