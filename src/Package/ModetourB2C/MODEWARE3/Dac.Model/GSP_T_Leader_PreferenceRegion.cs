namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_T_인솔자_선호지역
/// </summary>
public class GSP_T_Leader_PreferenceRegion
{
	public const string SP_NAME = "GSP_T_인솔자_선호지역";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 인솔자번호
		/// </summary>
		[Description("인솔자번호")]
		public int LeaderNumber { get; set; }
		/// <summary>
		/// 선호지역코드
		/// </summary>
		[Description("선호지역코드")]
		public string PreferenceRegionCode { get; set; }
		/// <summary>
		/// 선호도
		/// </summary>
		[Description("선호도")]
		public int Preference { get; set; }
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