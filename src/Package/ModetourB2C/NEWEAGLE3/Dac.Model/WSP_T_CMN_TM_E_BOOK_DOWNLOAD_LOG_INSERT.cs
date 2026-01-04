namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_TM_E_BOOK_DOWNLOAD_LOG_INSERT
/// </summary>
public class WSP_T_CMN_TM_E_BOOK_DOWNLOAD_LOG_INSERT
{
	public const string SP_NAME = "WSP_T_CMN_TM_E_BOOK_DOWNLOAD_LOG_INSERT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// AreaCode
		/// </summary>
		[Description("AreaCode")]
		public string AreaCode { get; set; }
		/// <summary>
		/// FilePath
		/// </summary>
		[Description("FilePath")]
		public string FilePath { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

}