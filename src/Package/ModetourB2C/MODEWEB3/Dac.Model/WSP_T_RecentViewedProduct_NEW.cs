namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_최근본상품_NEW
/// </summary>
public class WSP_T_RecentViewedProduct_NEW
{
	public const string SP_NAME = "WSP_T_최근본상품_NEW";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 유저ID
		/// </summary>
		[Description("유저ID")]
		public string User_ID { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 단체구분
		/// </summary>
		[Description("단체구분")]
		public string GroupClassification { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 카테고리
		/// </summary>
		[Description("카테고리")]
		public string Category { get; set; }
		/// <summary>
		/// 카테고리링크
		/// </summary>
		[Description("카테고리링크")]
		public string CategoryLink { get; set; }
		/// <summary>
		/// 기획전번호
		/// </summary>
		[Description("기획전번호")]
		public int SpecialEventNumber { get; set; }
		/// <summary>
		/// 키워드
		/// </summary>
		[Description("키워드")]
		public string Keyword { get; set; }
		/// <summary>
		/// 현지투어번호
		/// </summary>
		[Description("현지투어번호")]
		public string LocalTourNumber { get; set; }
		/// <summary>
		/// 호텔번호
		/// </summary>
		[Description("호텔번호")]
		public string HotelNumber { get; set; }
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }
	}

}