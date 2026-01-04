namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_제휴사이트_회원여부조회
/// </summary>
public class WSP_T_CMN_AffiliateSite_MemberOrNotFind
{
	public const string SP_NAME = "WSP_T_CMN_제휴사이트_회원여부조회";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 아이디
		/// </summary>
		[Description("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Description("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 사이트번호
		/// </summary>
		[Description("사이트번호")]
		public string SiteNumber { get; set; }
		/// <summary>
		/// IDX
		/// </summary>
		[Description("IDX")]
		public int IDX { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 회원정보no
		/// </summary>
		[Column("회원정보no")]
		public int MemberInfo_NO { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 비밀번호
		/// </summary>
		[Column("비밀번호")]
		public string Password { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 회원등급
		/// </summary>
		[Column("회원등급")]
		public string MemberClass { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 사이트NO
		/// </summary>
		[Column("사이트NO")]
		public string Site_NO { get; set; }
		/// <summary>
		/// 현금보상
		/// </summary>
		[Column("현금보상")]
		public string CashCompensation { get; set; }
		/// <summary>
		/// 비고1
		/// </summary>
		[Column("비고1")]
		public string Note1 { get; set; }
		/// <summary>
		/// 비고2
		/// </summary>
		[Column("비고2")]
		public string Note2 { get; set; }
		/// <summary>
		/// 비고3
		/// </summary>
		[Column("비고3")]
		public string Note3 { get; set; }
		/// <summary>
		/// 사용여부
		/// </summary>
		[Column("사용여부")]
		public string UseOrNot { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// ERROR
		/// </summary>
		[Column("ERROR")]
		public int ERROR { get; set; }
	}
}