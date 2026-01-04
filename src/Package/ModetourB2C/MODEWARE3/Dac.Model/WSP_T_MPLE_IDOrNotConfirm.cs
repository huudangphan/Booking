namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_MPLE아이디유무확인
/// </summary>
public class WSP_T_MPLE_IDOrNotConfirm
{
	public const string SP_NAME = "WSP_T_MPLE아이디유무확인";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// RETURN_CODE
		/// </summary>
		[Column("RETURN_CODE")]
		public int RETURN_CODE { get; set; }
		/// <summary>
		/// RETURN_MSG
		/// </summary>
		[Column("RETURN_MSG")]
		public string RETURN_MSG { get; set; }
		/// <summary>
		/// RETURN_EMAIL
		/// </summary>
		[Column("RETURN_EMAIL")]
		public string RETURN_EMAIL { get; set; }
	}
}