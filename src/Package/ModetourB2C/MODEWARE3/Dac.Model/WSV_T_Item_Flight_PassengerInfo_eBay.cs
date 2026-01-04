namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSV_T_아이템_항공_탑승자정보_이베이
/// </summary>
public class WSV_T_Item_Flight_PassengerInfo_eBay
{
	public const string SP_NAME = "WSV_T_아이템_항공_탑승자정보_이베이";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 탑승자정보
		/// </summary>
		[Description("탑승자정보")]
		public string PassengerInfo { get; set; }
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