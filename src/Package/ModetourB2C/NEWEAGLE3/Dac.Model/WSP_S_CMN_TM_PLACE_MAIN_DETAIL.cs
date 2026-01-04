namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_TM_PLACE_MAIN_DETAIL
/// </summary>
public class WSP_S_CMN_TM_PLACE_MAIN_DETAIL
{
	public const string SP_NAME = "WSP_S_CMN_TM_PLACE_MAIN_DETAIL";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// GubunCode
		/// </summary>
		[Description("GubunCode")]
		public string GubunCode { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// GubunCode
		/// </summary>
		[Column("GubunCode")]
		public string GubunCode { get; set; }
		/// <summary>
		/// SubTitle
		/// </summary>
		[Column("SubTitle")]
		public string SubTitle { get; set; }
		/// <summary>
		/// BgImg
		/// </summary>
		[Column("BgImg")]
		public string BgImg { get; set; }
		/// <summary>
		/// KorName
		/// </summary>
		[Column("KorName")]
		public string KorName { get; set; }
		/// <summary>
		/// Value1
		/// </summary>
		[Column("Value1")]
		public string Value1 { get; set; }
	}
}