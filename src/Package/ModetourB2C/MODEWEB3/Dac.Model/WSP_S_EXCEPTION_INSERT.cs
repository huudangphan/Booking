namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_S_EXCEPTION_INSERT
/// </summary>
public class WSP_S_EXCEPTION_INSERT
{
	public const string SP_NAME = "WSP_S_EXCEPTION_INSERT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// Type
		/// </summary>
		[Description("Type")]
		public string Type { get; set; }
		/// <summary>
		/// Message
		/// </summary>
		[Description("Message")]
		public string Message { get; set; }
		/// <summary>
		/// StackTrace
		/// </summary>
		[Description("StackTrace")]
		public string StackTrace { get; set; }
		/// <summary>
		/// Oid
		/// </summary>
		[Description("Oid")]
		public string Oid { get; set; }
		/// <summary>
		/// Data
		/// </summary>
		[Description("Data")]
		public string Data { get; set; }
		/// <summary>
		/// ProjectName
		/// </summary>
		[Description("ProjectName")]
		public string ProjectName { get; set; }
		/// <summary>
		/// ProjectClass
		/// </summary>
		[Description("ProjectClass")]
		public string ProjectClass { get; set; }
		/// <summary>
		/// ProjectMethod
		/// </summary>
		[Description("ProjectMethod")]
		public string ProjectMethod { get; set; }
		/// <summary>
		/// PageBrowser
		/// </summary>
		[Description("PageBrowser")]
		public string PageBrowser { get; set; }
		/// <summary>
		/// PageDomain
		/// </summary>
		[Description("PageDomain")]
		public string PageDomain { get; set; }
		/// <summary>
		/// PagePath
		/// </summary>
		[Description("PagePath")]
		public string PagePath { get; set; }
		/// <summary>
		/// PageServerIP
		/// </summary>
		[Description("PageServerIP")]
		public string PageServerIP { get; set; }
		/// <summary>
		/// PageClientIP
		/// </summary>
		[Description("PageClientIP")]
		public string PageClientIP { get; set; }
		/// <summary>
		/// PageParam
		/// </summary>
		[Description("PageParam")]
		public string PageParam { get; set; }
	}

}