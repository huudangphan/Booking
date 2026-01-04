namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_추천_등록
/// </summary>
public class WSP_T_CMN_Recommendation_Registration
{
	public const string SP_NAME = "WSP_T_CMN_추천_등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 구분번호
		/// </summary>
		[Description("구분번호")]
		public int ClassificationNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 추천
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("추천")]
		public int Recommend { get; set; }
	}

}