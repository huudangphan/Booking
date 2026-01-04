namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// GSP_S_인솔자_출장보고현황02
/// </summary>
public class GSP_S_Leader_BusinessTripReportCurrentState02
{
	public const string SP_NAME = "GSP_S_인솔자_출장보고현황02";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 항목분류
		/// </summary>
		[Description("항목분류")]
		public string ItemClassification { get; set; }
		/// <summary>
		/// 도시번호
		/// </summary>
		[Description("도시번호")]
		public int CityNumber { get; set; }
		/// <summary>
		/// PLID
		/// </summary>
		[Description("PLID")]
		public int PLID { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 출장보고세부번호
		/// </summary>
		[Column("출장보고세부번호")]
		public int BusinessTripReportDetailNumber { get; set; }
		/// <summary>
		/// 항목분류명
		/// </summary>
		[Column("항목분류명")]
		public string ItemClassificationName { get; set; }
		/// <summary>
		/// 도시명
		/// </summary>
		[Column("도시명")]
		public string CityName { get; set; }
		/// <summary>
		/// 아이템명
		/// </summary>
		[Column("아이템명")]
		public string ItemName { get; set; }
		/// <summary>
		/// 조중석
		/// </summary>
		[Column("조중석")]
		public string Cockpit { get; set; }
		/// <summary>
		/// 메뉴
		/// </summary>
		[Column("메뉴")]
		public string Menu { get; set; }
		/// <summary>
		/// 만족도
		/// </summary>
		[Column("만족도")]
		public int SatisfactionRate { get; set; }
		/// <summary>
		/// 코멘트
		/// </summary>
		[Column("코멘트")]
		public string Comment { get; set; }
	}
}