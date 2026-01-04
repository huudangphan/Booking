namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// ACP_LOGIN_CHECK
/// </summary>
public class ACP_LOGIN_CHECK
{
	public const string SP_NAME = "ACP_LOGIN_CHECK";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// AUS_PTID
		/// </summary>
		[Description("AUS_PTID")]
		public int AUS_PTID { get; set; }
		/// <summary>
		/// LALO_IP
		/// </summary>
		[Description("LALO_IP")]
		public string LALO_IP { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// ID
		/// </summary>
		[Column("ID")]
		public string ID { get; set; }
		/// <summary>
		/// NAME
		/// </summary>
		[Column("NAME")]
		public string NAME { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// COMP_CODE
		/// </summary>
		[Column("COMP_CODE")]
		public string COMP_CODE { get; set; }
		/// <summary>
		/// EXEC_YN
		/// </summary>
		[Column("EXEC_YN")]
		public string EXEC_YN { get; set; }
	}
}