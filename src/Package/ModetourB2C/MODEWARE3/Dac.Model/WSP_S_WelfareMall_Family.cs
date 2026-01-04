namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_복지몰_가족
/// </summary>
public class WSP_S_WelfareMall_Family
{
	public const string SP_NAME = "WSP_S_복지몰_가족";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 회원번호
		/// </summary>
		[Column("회원번호")]
		public int MemberNumber { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 회원관계
		/// </summary>
		[Column("회원관계")]
		public string MemberRelationship { get; set; }
		/// <summary>
		/// 회원관계명
		/// </summary>
		[Column("회원관계명")]
		public string MemberRelationshipName { get; set; }
	}
}