namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_KOOST_VIEW
/// </summary>
public class WSP_T_KOOST_VIEW
{
	public const string SP_NAME = "WSP_T_KOOST_VIEW";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 개인접속ID
		/// </summary>
		[Description("개인접속ID")]
		public string PersonalAccessID { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 상품타입명
		/// </summary>
		[Description("상품타입명")]
		public string ProductTypeName { get; set; }
		/// <summary>
		/// 카테고리
		/// </summary>
		[Description("카테고리")]
		public string Category { get; set; }
	}

}