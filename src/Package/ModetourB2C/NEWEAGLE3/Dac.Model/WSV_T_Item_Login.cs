namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSV_T_아이템_로그인
/// </summary>
public class WSV_T_Item_Login
{
	public const string SP_NAME = "WSV_T_아이템_로그인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 품목코드
		/// </summary>
		[Description("품목코드")]
		public string ProductListCode { get; set; }
		/// <summary>
		/// URL
		/// </summary>
		[Description("URL")]
		public string URL { get; set; }
		/// <summary>
		/// DATA
		/// </summary>
		[Description("DATA")]
		public string DATA { get; set; }
		/// <summary>
		/// KEY
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 1000)]
		[Description("KEY")]
		public string KEY { get; set; }
	}

}