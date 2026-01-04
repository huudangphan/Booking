namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_EXCEPTION_SELECT
/// </summary>
public class WSP_S_EXCEPTION_SELECT
{
	public const string SP_NAME = "WSP_S_EXCEPTION_SELECT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Idx
		/// </summary>
		[Description("Idx")]
		public long Idx { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// Idx
		/// </summary>
		[Column("Idx")]
		public long Idx { get; set; }
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
		/// Browser
		/// </summary>
		[Column("Browser")]
		public string Browser { get; set; }
		/// <summary>
		/// ClientIP
		/// </summary>
		[Column("ClientIP")]
		public string ClientIP { get; set; }
		/// <summary>
		/// ServerIP
		/// </summary>
		[Column("ServerIP")]
		public string ServerIP { get; set; }
		/// <summary>
		/// Project
		/// </summary>
		[Column("Project")]
		public string Project { get; set; }
		/// <summary>
		/// Class
		/// </summary>
		[Column("Class")]
		public string Class { get; set; }
		/// <summary>
		/// Method
		/// </summary>
		[Column("Method")]
		public string Method { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// Idx
		/// </summary>
		[Column("Idx")]
		public long Idx { get; set; }
		/// <summary>
		/// Key
		/// </summary>
		[Column("Key")]
		public string Key { get; set; }
		/// <summary>
		/// Value
		/// </summary>
		[Column("Value")]
		public string Value { get; set; }
	}
}