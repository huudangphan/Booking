namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_T_아이템예약_단체항공_제휴_탑승자_여권정보
/// </summary>
public class WSV_T_ItemReservation_GroupFlight_Affiliate_Passenger_PassportInfo
{
	public const string SP_NAME = "WSV_T_아이템예약_단체항공_제휴_탑승자_여권정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
		/// <summary>
		/// 예약자번호
		/// </summary>
		[Description("예약자번호")]
		public int BookerNumber { get; set; }
		/// <summary>
		/// 판매명세번호
		/// </summary>
		[Description("판매명세번호")]
		public int SalesSpecificationNumber { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Description("생년월일")]
		public string BirthYearMonthDay { get; set; }
		/// <summary>
		/// 여권번호
		/// </summary>
		[Description("여권번호")]
		public string PassportNumber { get; set; }
		/// <summary>
		/// 여권만료일
		/// </summary>
		[Description("여권만료일")]
		public string PassportExpirationDate { get; set; }
		/// <summary>
		/// 국적코드
		/// </summary>
		[Description("국적코드")]
		public string NationalityCode { get; set; }
		/// <summary>
		/// 발행국코드
		/// </summary>
		[Description("발행국코드")]
		public string PublishCountryCode { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 에러메시지
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 1000)]
		[Description("에러메시지")]
		public string ErrorMessage { get; set; }
	}

}