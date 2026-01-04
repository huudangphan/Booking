namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_비즈모두_뉴스레터_코드
/// </summary>
public class WSP_S_CMN_BizMODE_Newsletter_Code
{
	public const string SP_NAME = "WSP_S_CMN_비즈모두_뉴스레터_코드";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 상위코드
		/// </summary>
		[Description("상위코드")]
		public int HighRankCode { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 종류
		/// </summary>
		[Column("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 코드
		/// </summary>
		[Column("코드")]
		public string Code { get; set; }
		/// <summary>
		/// 코드명
		/// </summary>
		[Column("코드명")]
		public string CodeName { get; set; }
		/// <summary>
		/// 비고
		/// </summary>
		[Column("비고")]
		public string Note { get; set; }
		/// <summary>
		/// 사용
		/// </summary>
		[Column("사용")]
		public string Use { get; set; }
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
		/// 정렬
		/// </summary>
		[Column("정렬")]
		public byte Sorting { get; set; }
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
		/// <summary>
		/// 메인TABLE
		/// </summary>
		[Column("메인TABLE")]
		public string Main_TABLE { get; set; }
		/// <summary>
		/// 메인컬럼
		/// </summary>
		[Column("메인컬럼")]
		public string MainColumn { get; set; }
		/// <summary>
		/// 메인메뉴
		/// </summary>
		[Column("메인메뉴")]
		public string MainMenu { get; set; }
		/// <summary>
		/// 사용2
		/// </summary>
		[Column("사용2")]
		public string Use2 { get; set; }
		/// <summary>
		/// 추가사항
		/// </summary>
		[Column("추가사항")]
		public string AddItem { get; set; }
		/// <summary>
		/// 코드번호
		/// </summary>
		[Column("코드번호")]
		public int CodeNumber { get; set; }
		/// <summary>
		/// CODE
		/// </summary>
		[Column("CODE")]
		public string CODE2 { get; set; }
	}
}