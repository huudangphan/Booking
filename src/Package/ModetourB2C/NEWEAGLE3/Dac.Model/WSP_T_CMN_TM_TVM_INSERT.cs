namespace ModetourB2C.Dac.Model.NEWEAGLE3;

/// <summary>
/// WSP_T_CMN_TM_TVM_INSERT
/// </summary>
public class WSP_T_CMN_TM_TVM_INSERT
{
	public const string SP_NAME = "WSP_T_CMN_TM_TVM_INSERT";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// AreaCode
		/// </summary>
		[Description("AreaCode")]
		public string AreaCode { get; set; }
		/// <summary>
		/// ThemeCode
		/// </summary>
		[Description("ThemeCode")]
		public string ThemeCode { get; set; }
		/// <summary>
		/// Subject
		/// </summary>
		[Description("Subject")]
		public string Subject { get; set; }
		/// <summary>
		/// HotFlag
		/// </summary>
		[Description("HotFlag")]
		public string HotFlag { get; set; }
		/// <summary>
		/// UseFlag
		/// </summary>
		[Description("UseFlag")]
		public string UseFlag { get; set; }
		/// <summary>
		/// Img
		/// </summary>
		[Description("Img")]
		public string Img { get; set; }
		/// <summary>
		/// VideoUrl
		/// </summary>
		[Description("VideoUrl")]
		public string VideoUrl { get; set; }
		/// <summary>
		/// Contents
		/// </summary>
		[Description("Contents")]
		public string Contents { get; set; }
		/// <summary>
		/// PlanTitle
		/// </summary>
		[Description("PlanTitle")]
		public string PlanTitle { get; set; }
		/// <summary>
		/// PlanUrl
		/// </summary>
		[Description("PlanUrl")]
		public string PlanUrl { get; set; }
	}

}