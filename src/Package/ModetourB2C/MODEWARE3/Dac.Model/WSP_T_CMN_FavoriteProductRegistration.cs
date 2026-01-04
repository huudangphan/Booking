namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_찜상품등록
/// </summary>
public class WSP_T_CMN_FavoriteProductRegistration
{
	public const string SP_NAME = "WSP_T_CMN_찜상품등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 단체번호
		/// </summary>
		[Description("단체번호")]
		public int GroupNumber { get; set; }
		/// <summary>
		/// 기획전번호
		/// </summary>
		[Description("기획전번호")]
		public int SpecialEventNumber { get; set; }
		/// <summary>
		/// 호텔콘도번호
		/// </summary>
		[Description("호텔콘도번호")]
		public int HotelCondominiumNumber { get; set; }
		/// <summary>
		/// 현지투어번호
		/// </summary>
		[Description("현지투어번호")]
		public string LocalTourNumber { get; set; }
		/// <summary>
		/// 웹사이트번호
		/// </summary>
		[Description("웹사이트번호")]
		public int WebSiteNumber { get; set; }
		/// <summary>
		/// 테이블구분
		/// </summary>
		[Description("테이블구분")]
		public string TableClassification { get; set; }
	}

}