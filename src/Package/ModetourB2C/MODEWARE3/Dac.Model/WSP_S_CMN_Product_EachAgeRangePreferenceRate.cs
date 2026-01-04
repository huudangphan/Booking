namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_상품_연령별선호도
/// </summary>
public class WSP_S_CMN_Product_EachAgeRangePreferenceRate
{
	public const string SP_NAME = "WSP_S_CMN_상품_연령별선호도";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 연령대
		/// </summary>
		[Column("연령대")]
		public int AgeGroup { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 수
		/// </summary>
		[Column("수")]
		public int Number { get; set; }
	}
}