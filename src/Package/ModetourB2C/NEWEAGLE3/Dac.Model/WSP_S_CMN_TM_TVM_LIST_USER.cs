namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_S_CMN_TM_TVM_LIST_USER
/// </summary>
public class WSP_S_CMN_TM_TVM_LIST_USER
{
	public const string SP_NAME = "WSP_S_CMN_TM_TVM_LIST_USER";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// IDX
		/// </summary>
		[Description("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// USEFLAG
		/// </summary>
		[Description("USEFLAG")]
		public string USEFLAG { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// IDX
		/// </summary>
		[Column("IDX")]
		public int IDX { get; set; }
		/// <summary>
		/// AREACODE
		/// </summary>
		[Column("AREACODE")]
		public string AREACODE { get; set; }
		/// <summary>
		/// THEMECODE
		/// </summary>
		[Column("THEMECODE")]
		public string THEMECODE { get; set; }
		/// <summary>
		/// SUBJECT
		/// </summary>
		[Column("SUBJECT")]
		public string SUBJECT { get; set; }
		/// <summary>
		/// HOTFLAG
		/// </summary>
		[Column("HOTFLAG")]
		public string HOTFLAG { get; set; }
		/// <summary>
		/// USEFLAG
		/// </summary>
		[Column("USEFLAG")]
		public string USEFLAG { get; set; }
		/// <summary>
		/// IMG
		/// </summary>
		[Column("IMG")]
		public string IMG { get; set; }
		/// <summary>
		/// VIDEOURL
		/// </summary>
		[Column("VIDEOURL")]
		public string VIDEOURL { get; set; }
		/// <summary>
		/// CONTENTS
		/// </summary>
		[Column("CONTENTS")]
		public string CONTENTS { get; set; }
	}
}