namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// ASP_TOURLIST_INSERT_NEW
/// </summary>
public class ASP_TOURLIST_INSERT_NEW
{
	public const string SP_NAME = "ASP_TOURLIST_INSERT_NEW";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// TOURLIST
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("TOURLIST")]
		public List<TYPE_ASP_TOURLIST> TOURLIST { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// RCODE
		/// </summary>
		[Column("RCODE")]
		public string RCODE { get; set; }
		/// <summary>
		/// RMSG
		/// </summary>
		[Column("RMSG")]
		public string RMSG { get; set; }
	}
}