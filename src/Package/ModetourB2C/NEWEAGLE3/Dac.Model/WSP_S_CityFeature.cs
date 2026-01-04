namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_도시속성
/// </summary>
public class WSP_S_CityFeature
{
	public const string SP_NAME = "WSP_S_도시속성";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Description("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// INFOTYPE번호
		/// </summary>
		[Description("INFOTYPE번호")]
		public int INFOTYPE_Number { get; set; }
		/// <summary>
		/// WEATHER_SW
		/// </summary>
		[Description("WEATHER_SW")]
		public string WEATHER_SW { get; set; }
		/// <summary>
		/// AREA1
		/// </summary>
		[Description("AREA1")]
		public string AREA1 { get; set; }
		/// <summary>
		/// AREA2
		/// </summary>
		[Description("AREA2")]
		public string AREA2 { get; set; }
		/// <summary>
		/// AREA3
		/// </summary>
		[Description("AREA3")]
		public string AREA3 { get; set; }
	}

}