namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_거래처별회원체크
/// </summary>
public class WSP_S_CMN_EachCustomerMemberCheck
{
	public const string SP_NAME = "WSP_S_CMN_거래처별회원체크";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// PTID1
		/// </summary>
		[Column("PTID1")]
		public int PTID1 { get; set; }
		/// <summary>
		/// PTID2
		/// </summary>
		[Column("PTID2")]
		public int PTID2 { get; set; }
		/// <summary>
		/// 관계종류
		/// </summary>
		[Column("관계종류")]
		public string RelationshipType { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Column("상태1")]
		public string State1 { get; set; }
		/// <summary>
		/// 상태2
		/// </summary>
		[Column("상태2")]
		public string State2 { get; set; }
		/// <summary>
		/// 상태3
		/// </summary>
		[Column("상태3")]
		public string State3 { get; set; }
		/// <summary>
		/// 상태4
		/// </summary>
		[Column("상태4")]
		public string State4 { get; set; }
		/// <summary>
		/// 상태5
		/// </summary>
		[Column("상태5")]
		public string State5 { get; set; }
		/// <summary>
		/// 상태6
		/// </summary>
		[Column("상태6")]
		public string State6 { get; set; }
		/// <summary>
		/// 상태7
		/// </summary>
		[Column("상태7")]
		public string State7 { get; set; }
		/// <summary>
		/// 상태8
		/// </summary>
		[Column("상태8")]
		public string State8 { get; set; }
		/// <summary>
		/// 상태9
		/// </summary>
		[Column("상태9")]
		public string State9 { get; set; }
		/// <summary>
		/// 상태10
		/// </summary>
		[Column("상태10")]
		public string State10 { get; set; }
		/// <summary>
		/// 상태11
		/// </summary>
		[Column("상태11")]
		public string State11 { get; set; }
		/// <summary>
		/// 상태12
		/// </summary>
		[Column("상태12")]
		public string State12 { get; set; }
		/// <summary>
		/// 상태13
		/// </summary>
		[Column("상태13")]
		public string State13 { get; set; }
		/// <summary>
		/// 상태14
		/// </summary>
		[Column("상태14")]
		public string State14 { get; set; }
		/// <summary>
		/// 상태15
		/// </summary>
		[Column("상태15")]
		public string State15 { get; set; }
		/// <summary>
		/// 상태16
		/// </summary>
		[Column("상태16")]
		public string State16 { get; set; }
		/// <summary>
		/// 상태17
		/// </summary>
		[Column("상태17")]
		public string State17 { get; set; }
		/// <summary>
		/// 상태18
		/// </summary>
		[Column("상태18")]
		public string State18 { get; set; }
		/// <summary>
		/// 상태19
		/// </summary>
		[Column("상태19")]
		public string State19 { get; set; }
		/// <summary>
		/// 상태20
		/// </summary>
		[Column("상태20")]
		public string State20 { get; set; }
		/// <summary>
		/// 등록일
		/// </summary>
		[Column("등록일")]
		public DateTime RegisterDate { get; set; }
		/// <summary>
		/// 상태21
		/// </summary>
		[Column("상태21")]
		public string State21 { get; set; }
		/// <summary>
		/// 상태22
		/// </summary>
		[Column("상태22")]
		public string State22 { get; set; }
		/// <summary>
		/// 상태23
		/// </summary>
		[Column("상태23")]
		public string State23 { get; set; }
		/// <summary>
		/// 상태24
		/// </summary>
		[Column("상태24")]
		public string State24 { get; set; }
		/// <summary>
		/// 상태25
		/// </summary>
		[Column("상태25")]
		public string State25 { get; set; }
		/// <summary>
		/// 상태26
		/// </summary>
		[Column("상태26")]
		public string State26 { get; set; }
		/// <summary>
		/// 상태27
		/// </summary>
		[Column("상태27")]
		public string State27 { get; set; }
		/// <summary>
		/// 상태28
		/// </summary>
		[Column("상태28")]
		public string State28 { get; set; }
		/// <summary>
		/// 상태29
		/// </summary>
		[Column("상태29")]
		public string State29 { get; set; }
		/// <summary>
		/// 상태30
		/// </summary>
		[Column("상태30")]
		public string State30 { get; set; }
		/// <summary>
		/// 상태31
		/// </summary>
		[Column("상태31")]
		public string State31 { get; set; }
		/// <summary>
		/// 상태32
		/// </summary>
		[Column("상태32")]
		public string State32 { get; set; }
	}
}