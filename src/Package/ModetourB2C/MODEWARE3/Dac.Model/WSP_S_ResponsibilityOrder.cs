namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_담당순번
/// </summary>
public class WSP_S_ResponsibilityOrder
{
	public const string SP_NAME = "WSP_S_담당순번";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public int Classification { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Column("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
	}
}