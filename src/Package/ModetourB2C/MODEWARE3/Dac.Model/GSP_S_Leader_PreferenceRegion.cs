namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_S_인솔자_선호지역
/// </summary>
public class GSP_S_Leader_PreferenceRegion
{
	public const string SP_NAME = "GSP_S_인솔자_선호지역";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 인솔자번호
		/// </summary>
		[Description("인솔자번호")]
		public int LeaderNumber { get; set; }
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

	public class Result : IDbResult
	{
		/// <summary>
		/// 지역코드
		/// </summary>
		[Column("지역코드")]
		public string RegionCode { get; set; }
		/// <summary>
		/// 지역명
		/// </summary>
		[Column("지역명")]
		public string RegionName { get; set; }
		/// <summary>
		/// 선호도
		/// </summary>
		[Column("선호도")]
		public int Preference { get; set; }
	}
}