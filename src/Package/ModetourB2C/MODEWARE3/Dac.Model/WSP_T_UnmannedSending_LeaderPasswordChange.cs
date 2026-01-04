namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_무인센딩_인솔자비밀번호변경
/// </summary>
public class WSP_T_UnmannedSending_LeaderPasswordChange
{
	public const string SP_NAME = "WSP_T_무인센딩_인솔자비밀번호변경";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public string PTID { get; set; }
		/// <summary>
		/// PWD
		/// </summary>
		[Description("PWD")]
		public string PWD { get; set; }
		/// <summary>
		/// THREE
		/// </summary>
		[Description("THREE")]
		public string THREE { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// Column1
		/// </summary>
		[Column("Column1")]
		public string Column1 { get; set; }
	}
}