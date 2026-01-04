namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_EXCEPTION_LIST
/// </summary>
public class WSP_S_EXCEPTION_LIST
{
	public const string SP_NAME = "WSP_S_EXCEPTION_LIST";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// DateStart
		/// </summary>
		[Description("DateStart")]
		public DateTime DateStart { get; set; }
		/// <summary>
		/// DateEnd
		/// </summary>
		[Description("DateEnd")]
		public DateTime DateEnd { get; set; }
		/// <summary>
		/// Path
		/// </summary>
		[Description("Path")]
		public string Path { get; set; }
		/// <summary>
		/// Project
		/// </summary>
		[Description("Project")]
		public string Project { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Idx
		/// </summary>
		[Column("Idx")]
		public long Idx { get; set; }
		/// <summary>
		/// Project
		/// </summary>
		[Column("Project")]
		public string Project { get; set; }
		/// <summary>
		/// Domain
		/// </summary>
		[Column("Domain")]
		public string Domain { get; set; }
		/// <summary>
		/// Path
		/// </summary>
		[Column("Path")]
		public string Path { get; set; }
		/// <summary>
		/// Message
		/// </summary>
		[Column("Message")]
		public string Message { get; set; }
		/// <summary>
		/// StackTrace
		/// </summary>
		[Column("StackTrace")]
		public string StackTrace { get; set; }
		/// <summary>
		/// Oid
		/// </summary>
		[Column("Oid")]
		public string Oid { get; set; }
		/// <summary>
		/// RegDate
		/// </summary>
		[Column("RegDate")]
		public DateTime RegDate { get; set; }
	}
}