namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_일정표_인솔자정보
/// </summary>
public class WSP_S_ScheduleTable_LeaderInfo
{
	public const string SP_NAME = "WSP_S_일정표_인솔자정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 주문번호
		/// </summary>
		[Description("주문번호")]
		public int OrderNumber { get; set; }
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
		/// 행사번호
		/// </summary>
		[Column("행사번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Column("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 안내원동행인원
		/// </summary>
		[Column("안내원동행인원")]
		public int GuideAccompanyNumberOfPeople { get; set; }
		/// <summary>
		/// 인솔자확정
		/// </summary>
		[Column("인솔자확정")]
		public string LeaderConfirm { get; set; }
		/// <summary>
		/// 메인여부
		/// </summary>
		[Column("메인여부")]
		public string MainOrNot { get; set; }
		/// <summary>
		/// 인솔자성명
		/// </summary>
		[Column("인솔자성명")]
		public string LeaderName { get; set; }
		/// <summary>
		/// 인솔자성별
		/// </summary>
		[Column("인솔자성별")]
		public string LeaderGender { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
	}
}