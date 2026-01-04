namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_허니문상담예약신청
/// </summary>
public class WSP_T_HoneymoonConsultantReservationRequest
{
	public const string SP_NAME = "WSP_T_허니문상담예약신청";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 고객명
		/// </summary>
		[Description("고객명")]
		public string CustomerName { get; set; }
		/// <summary>
		/// 고객연락처
		/// </summary>
		[Description("고객연락처")]
		public string CustomerContact { get; set; }
		/// <summary>
		/// 고객메일
		/// </summary>
		[Description("고객메일")]
		public string CustomerMail { get; set; }
		/// <summary>
		/// 고객예식일
		/// </summary>
		[Description("고객예식일")]
		public string CustomerWeddingDate { get; set; }
		/// <summary>
		/// 고객내용
		/// </summary>
		[Description("고객내용")]
		public string CustomerContent { get; set; }
		/// <summary>
		/// 상담원이름
		/// </summary>
		[Description("상담원이름")]
		public string ConsultantName { get; set; }
		/// <summary>
		/// 상담원핸드폰
		/// </summary>
		[Description("상담원핸드폰")]
		public string ConsultantPhone { get; set; }
		/// <summary>
		/// 상담원지역
		/// </summary>
		[Description("상담원지역")]
		public string ConsultantRegion { get; set; }
		/// <summary>
		/// 상담원메일
		/// </summary>
		[Description("상담원메일")]
		public string ConsultantMail { get; set; }
		/// <summary>
		/// 상담여행사이름
		/// </summary>
		[Description("상담여행사이름")]
		public string ConsultantTravelCompanyName { get; set; }
		/// <summary>
		/// 상담원직원번호
		/// </summary>
		[Description("상담원직원번호")]
		public string ConsultantEmployeeNumber { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 10)]
		[Description("결과")]
		public string Result { get; set; }
	}

}