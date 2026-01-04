namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_T_아이템_항공_아피스입력여부
/// </summary>
public class WSV_T_Item_Flight_APISInputOrNot
{
	public const string SP_NAME = "WSV_T_아이템_항공_아피스입력여부";

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
		/// 아피스입력여부
		/// </summary>
		[Description("아피스입력여부")]
		public string ApisInputOrNot { get; set; }
		/// <summary>
		/// 수정경로
		/// </summary>
		[Description("수정경로")]
		public string EditionRoute { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.AnsiStringFixedLength, ParameterDirection.InputOutput, 1)]
		[Description("결과")]
		public string Result { get; set; }
		/// <summary>
		/// 에러메시지
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 1000)]
		[Description("에러메시지")]
		public string ErrorMessage { get; set; }
	}

}