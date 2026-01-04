namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_모두POP_투어마일리지_특별적립
/// </summary>
public class WSP_T_CMN_MODEPOP_TourMileage_SpecialAccumulation
{
	public const string SP_NAME = "WSP_T_CMN_모두POP_투어마일리지_특별적립";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// MODE
		/// </summary>
		[Description("MODE")]
		public string MODE { get; set; }
		/// <summary>
		/// app_key
		/// </summary>
		[Description("app_key")]
		public long app_key { get; set; }
		/// <summary>
		/// unit_id
		/// </summary>
		[Description("unit_id")]
		public string unit_id { get; set; }
		/// <summary>
		/// transaction_id
		/// </summary>
		[Description("transaction_id")]
		public string transaction_id { get; set; }
		/// <summary>
		/// user_id
		/// </summary>
		[Description("user_id")]
		public string user_id { get; set; }
		/// <summary>
		/// campaign_id
		/// </summary>
		[Description("campaign_id")]
		public string campaign_id { get; set; }
		/// <summary>
		/// campaign_name
		/// </summary>
		[Description("campaign_name")]
		public string campaign_name { get; set; }
		/// <summary>
		/// title
		/// </summary>
		[Description("title")]
		public string title { get; set; }
		/// <summary>
		/// point
		/// </summary>
		[Description("point")]
		public int point { get; set; }
		/// <summary>
		/// base_point
		/// </summary>
		[Description("base_point")]
		public int base_point { get; set; }
		/// <summary>
		/// is_media
		/// </summary>
		[Description("is_media")]
		public int is_media { get; set; }
		/// <summary>
		/// revenue_type
		/// </summary>
		[Description("revenue_type")]
		public string revenue_type { get; set; }
		/// <summary>
		/// action_type
		/// </summary>
		[Description("action_type")]
		public string action_type { get; set; }
		/// <summary>
		/// event_at
		/// </summary>
		[Description("event_at")]
		public long event_at { get; set; }
		/// <summary>
		/// extra
		/// </summary>
		[Description("extra")]
		public string extra { get; set; }
		/// <summary>
		/// unit_price
		/// </summary>
		[Description("unit_price")]
		public long unit_price { get; set; }
		/// <summary>
		/// custom
		/// </summary>
		[Description("custom")]
		public string custom { get; set; }
		/// <summary>
		/// ifa
		/// </summary>
		[Description("ifa")]
		public string ifa { get; set; }
		/// <summary>
		/// reward
		/// </summary>
		[Description("reward")]
		public int reward { get; set; }
		/// <summary>
		/// allow_multiple_conversions
		/// </summary>
		[Description("allow_multiple_conversions")]
		public int allow_multiple_conversions { get; set; }
		/// <summary>
		/// data
		/// </summary>
		[Description("data")]
		public string data { get; set; }
		/// <summary>
		/// click_type
		/// </summary>
		[Description("click_type")]
		public string click_type { get; set; }
		/// <summary>
		/// 결과
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("결과")]
		public int Result { get; set; }
		/// <summary>
		/// 에러메시지
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 1000)]
		[Description("에러메시지")]
		public string ErrorMessage { get; set; }
	}

}