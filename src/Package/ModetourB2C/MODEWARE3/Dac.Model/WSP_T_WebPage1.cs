namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_웹페이지1
/// </summary>
public class WSP_T_WebPage1
{
	public const string SP_NAME = "WSP_T_웹페이지1";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// DEL
		/// </summary>
		[Description("DEL")]
		public string DEL { get; set; }
		/// <summary>
		/// SORT
		/// </summary>
		[Description("SORT")]
		public int SORT { get; set; }
		/// <summary>
		/// SORTVALUE
		/// </summary>
		[Description("SORTVALUE")]
		public byte SORTVALUE { get; set; }
		/// <summary>
		/// ERRNO
		/// </summary>
		[DapperParameter(DbType.Int32, ParameterDirection.InputOutput, 4)]
		[Description("ERRNO")]
		public int ERRNO { get; set; }
		/// <summary>
		/// ERRMSG
		/// </summary>
		[DapperParameter(DbType.String, ParameterDirection.InputOutput, 1000)]
		[Description("ERRMSG")]
		public string ERRMSG { get; set; }
	}

}