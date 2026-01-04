namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_아이템_문의
/// </summary>
public class WSP_T_Item_Inquiry
{
	public const string SP_NAME = "WSP_T_아이템_문의";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 문의일련번호
		/// </summary>
		[Description("문의일련번호")]
		public int InquirySerialNumber { get; set; }
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }
		/// <summary>
		/// 상품코드
		/// </summary>
		[Description("상품코드")]
		public string ProductCode { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 내용
		/// </summary>
		[Description("내용")]
		public string Content { get; set; }
		/// <summary>
		/// 공개여부
		/// </summary>
		[Description("공개여부")]
		public string ReleaseOrNot { get; set; }
	}

}