namespace ModetourB2C.Dac.Model.INTRANET3;

/// <summary>
/// WSP_T_게시판_임시저장
/// </summary>
public class WSP_T_Noticeboard_TemporarySaving
{
	public const string SP_NAME = "WSP_T_게시판_임시저장";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 사원번호
		/// </summary>
		[Description("사원번호")]
		public int StaffNumber { get; set; }
		/// <summary>
		/// 대분류
		/// </summary>
		[Description("대분류")]
		public string MajorClassification { get; set; }
		/// <summary>
		/// 게시판타입
		/// </summary>
		[Description("게시판타입")]
		public string NoticeboardType { get; set; }
		/// <summary>
		/// 게시판번호
		/// </summary>
		[Description("게시판번호")]
		public int NoticeboardNumber { get; set; }
		/// <summary>
		/// 게시판명
		/// </summary>
		[Description("게시판명")]
		public string NoticeboardName { get; set; }
		/// <summary>
		/// 내용1
		/// </summary>
		[Description("내용1")]
		public string Content1 { get; set; }
		/// <summary>
		/// 내용2
		/// </summary>
		[Description("내용2")]
		public string Content2 { get; set; }
		/// <summary>
		/// 내용3
		/// </summary>
		[Description("내용3")]
		public string Content3 { get; set; }
		/// <summary>
		/// 내용4
		/// </summary>
		[Description("내용4")]
		public string Content4 { get; set; }
		/// <summary>
		/// 내용5
		/// </summary>
		[Description("내용5")]
		public string Content5 { get; set; }
		/// <summary>
		/// 내용6
		/// </summary>
		[Description("내용6")]
		public string Content6 { get; set; }
		/// <summary>
		/// 상태1
		/// </summary>
		[Description("상태1")]
		public string State1 { get; set; }
		/// <summary>
		/// 상태2
		/// </summary>
		[Description("상태2")]
		public string State2 { get; set; }
		/// <summary>
		/// 상태3
		/// </summary>
		[Description("상태3")]
		public string State3 { get; set; }
		/// <summary>
		/// 상태4
		/// </summary>
		[Description("상태4")]
		public string State4 { get; set; }
		/// <summary>
		/// 상태5
		/// </summary>
		[Description("상태5")]
		public string State5 { get; set; }
		/// <summary>
		/// 상태6
		/// </summary>
		[Description("상태6")]
		public string State6 { get; set; }
		/// <summary>
		/// 상태7
		/// </summary>
		[Description("상태7")]
		public string State7 { get; set; }
		/// <summary>
		/// 상태8
		/// </summary>
		[Description("상태8")]
		public string State8 { get; set; }
		/// <summary>
		/// 상태9
		/// </summary>
		[Description("상태9")]
		public string State9 { get; set; }
		/// <summary>
		/// 상태10
		/// </summary>
		[Description("상태10")]
		public string State10 { get; set; }
		/// <summary>
		/// 상태11
		/// </summary>
		[Description("상태11")]
		public string State11 { get; set; }
		/// <summary>
		/// 상태12
		/// </summary>
		[Description("상태12")]
		public string State12 { get; set; }
		/// <summary>
		/// 상태13
		/// </summary>
		[Description("상태13")]
		public string State13 { get; set; }
		/// <summary>
		/// 상태14
		/// </summary>
		[Description("상태14")]
		public string State14 { get; set; }
		/// <summary>
		/// 상태15
		/// </summary>
		[Description("상태15")]
		public string State15 { get; set; }
		/// <summary>
		/// 상태16
		/// </summary>
		[Description("상태16")]
		public string State16 { get; set; }
		/// <summary>
		/// 상태17
		/// </summary>
		[Description("상태17")]
		public string State17 { get; set; }
		/// <summary>
		/// 상태18
		/// </summary>
		[Description("상태18")]
		public string State18 { get; set; }
		/// <summary>
		/// 상태19
		/// </summary>
		[Description("상태19")]
		public string State19 { get; set; }
		/// <summary>
		/// 상태20
		/// </summary>
		[Description("상태20")]
		public string State20 { get; set; }
		/// <summary>
		/// 상태21
		/// </summary>
		[Description("상태21")]
		public string State21 { get; set; }
		/// <summary>
		/// 상태22
		/// </summary>
		[Description("상태22")]
		public string State22 { get; set; }
		/// <summary>
		/// 상태23
		/// </summary>
		[Description("상태23")]
		public string State23 { get; set; }
		/// <summary>
		/// 상태24
		/// </summary>
		[Description("상태24")]
		public string State24 { get; set; }
		/// <summary>
		/// 상태25
		/// </summary>
		[Description("상태25")]
		public string State25 { get; set; }
		/// <summary>
		/// 상태26
		/// </summary>
		[Description("상태26")]
		public string State26 { get; set; }
		/// <summary>
		/// 상태27
		/// </summary>
		[Description("상태27")]
		public string State27 { get; set; }
		/// <summary>
		/// 상태28
		/// </summary>
		[Description("상태28")]
		public string State28 { get; set; }
		/// <summary>
		/// 상태29
		/// </summary>
		[Description("상태29")]
		public string State29 { get; set; }
		/// <summary>
		/// 상태30
		/// </summary>
		[Description("상태30")]
		public string State30 { get; set; }
		/// <summary>
		/// 상태31
		/// </summary>
		[Description("상태31")]
		public string State31 { get; set; }
		/// <summary>
		/// 상태32
		/// </summary>
		[Description("상태32")]
		public string State32 { get; set; }
		/// <summary>
		/// 상태33
		/// </summary>
		[Description("상태33")]
		public string State33 { get; set; }
		/// <summary>
		/// 상태34
		/// </summary>
		[Description("상태34")]
		public string State34 { get; set; }
		/// <summary>
		/// 상태35
		/// </summary>
		[Description("상태35")]
		public string State35 { get; set; }
		/// <summary>
		/// 상태36
		/// </summary>
		[Description("상태36")]
		public string State36 { get; set; }
		/// <summary>
		/// 상태37
		/// </summary>
		[Description("상태37")]
		public string State37 { get; set; }
		/// <summary>
		/// 상태38
		/// </summary>
		[Description("상태38")]
		public string State38 { get; set; }
		/// <summary>
		/// 상태39
		/// </summary>
		[Description("상태39")]
		public string State39 { get; set; }
	}

}