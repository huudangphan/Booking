namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_키오스크_상담시간
/// </summary>
public class WSP_S_CMN_Kiosk_ConsultantTime
{
	public const string SP_NAME = "WSP_S_CMN_키오스크_상담시간";

	public class Result : IDbResult
	{
		/// <summary>
		/// 년월일
		/// </summary>
		[Column("년월일")]
		public DateTime YearMonthDate { get; set; }
		/// <summary>
		/// 요일
		/// </summary>
		[Column("요일")]
		public string Day { get; set; }
		/// <summary>
		/// 시간
		/// </summary>
		[Column("시간")]
		public int Time { get; set; }
	}
}