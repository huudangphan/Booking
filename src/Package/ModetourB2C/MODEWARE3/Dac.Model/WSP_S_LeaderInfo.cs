namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_인솔자정보
/// </summary>
public class WSP_S_LeaderInfo
{
	public const string SP_NAME = "WSP_S_인솔자정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PNUM
		/// </summary>
		[Description("PNUM")]
		public int PNUM { get; set; }
		/// <summary>
		/// INUM
		/// </summary>
		[Description("INUM")]
		public int INUM { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// IP
		/// </summary>
		[Description("IP")]
		public string IP { get; set; }
		/// <summary>
		/// APP
		/// </summary>
		[Description("APP")]
		public string APP { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 연락처
		/// </summary>
		[Column("연락처")]
		public string Contact { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 전화
		/// </summary>
		[Column("전화")]
		public string Phone { get; set; }
	}
}