namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_환율_저장
/// </summary>
public class WSP_T_ExchangeRate_Saving
{
	public const string SP_NAME = "WSP_T_환율_저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 고시일
		/// </summary>
		[Description("고시일")]
		public DateTime ExamDate { get; set; }
		/// <summary>
		/// 국가코드
		/// </summary>
		[Description("국가코드")]
		public string CountryCode { get; set; }
		/// <summary>
		/// 환율
		/// </summary>
		[Description("환율")]
		public string ExchangeRate { get; set; }
	}

}