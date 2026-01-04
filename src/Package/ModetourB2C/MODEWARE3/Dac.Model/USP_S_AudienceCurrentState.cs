namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_S_모객현황
/// </summary>
public class USP_S_AudienceCurrentState
{
	public const string SP_NAME = "USP_S_모객현황";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 시작일
		/// </summary>
		[Description("시작일")]
		public DateTime StartDate { get; set; }
		/// <summary>
		/// 종료일
		/// </summary>
		[Description("종료일")]
		public DateTime EndDate { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 조회구분
		/// </summary>
		[Description("조회구분")]
		public string SearchClassification { get; set; }
		/// <summary>
		/// 상품구분
		/// </summary>
		[Description("상품구분")]
		public string ProductClassification { get; set; }
		/// <summary>
		/// 담당구분
		/// </summary>
		[Description("담당구분")]
		public string ResponsibilityClassification { get; set; }
		/// <summary>
		/// AGT재분류
		/// </summary>
		[Description("AGT재분류")]
		public string AGT_Reclassification { get; set; }
		/// <summary>
		/// USERIP
		/// </summary>
		[Description("USERIP")]
		public string USERIP { get; set; }
		/// <summary>
		/// USEID
		/// </summary>
		[Description("USEID")]
		public int USEID { get; set; }
		/// <summary>
		/// APPNAME
		/// </summary>
		[Description("APPNAME")]
		public string APPNAME { get; set; }
		/// <summary>
		/// HP
		/// </summary>
		[Description("HP")]
		public string HP { get; set; }
	}

}