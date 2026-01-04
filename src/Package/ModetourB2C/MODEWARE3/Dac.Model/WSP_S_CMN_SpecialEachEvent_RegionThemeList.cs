namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_기획전별_지역테마리스트
/// </summary>
public class WSP_S_CMN_SpecialEachEvent_RegionThemeList
{
	public const string SP_NAME = "WSP_S_CMN_기획전별_지역테마리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 기획전번호LIST
		/// </summary>
		[Description("기획전번호LIST")]
		public string SpecialEventNumber_LIST { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 기획전번호
		/// </summary>
		[Column("기획전번호")]
		public int SpecialEventNumber { get; set; }
		/// <summary>
		/// 지역명
		/// </summary>
		[Column("지역명")]
		public string RegionName { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 기획전번호
		/// </summary>
		[Column("기획전번호")]
		public int SpecialEventNumber { get; set; }
		/// <summary>
		/// 테마명
		/// </summary>
		[Column("테마명")]
		public string ThemeName { get; set; }
	}
}