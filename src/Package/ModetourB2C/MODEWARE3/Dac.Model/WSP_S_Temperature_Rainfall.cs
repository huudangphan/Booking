namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_기온_강수량
/// </summary>
public class WSP_S_Temperature_Rainfall
{
	public const string SP_NAME = "WSP_S_기온_강수량";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PLID
		/// </summary>
		[Description("PLID")]
		public int PLID { get; set; }
		/// <summary>
		/// Gubun
		/// </summary>
		[Description("Gubun")]
		public string Gubun { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// PLKNAME
		/// </summary>
		[Column("PLKNAME")]
		public string PLKNAME { get; set; }
		/// <summary>
		/// PLENAME
		/// </summary>
		[Column("PLENAME")]
		public string PLENAME { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Column("내용")]
		public string Content { get; set; }
		/// <summary>
		/// INFOTYPE번호
		/// </summary>
		[Column("INFOTYPE번호")]
		public int INFOTYPE_Number { get; set; }
	}
}