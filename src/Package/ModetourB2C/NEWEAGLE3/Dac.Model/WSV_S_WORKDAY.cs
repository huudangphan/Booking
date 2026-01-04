namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSV_S_WORKDAY
/// </summary>
public class WSV_S_WORKDAY
{
	public const string SP_NAME = "WSV_S_WORKDAY";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 기준일
		/// </summary>
		[Description("기준일")]
		public string StandardDate { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public string Column1 { get; set; }
	}
}