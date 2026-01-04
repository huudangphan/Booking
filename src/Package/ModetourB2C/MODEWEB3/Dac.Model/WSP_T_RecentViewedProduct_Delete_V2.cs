namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_최근본상품_삭제_V2
/// </summary>
public class WSP_T_RecentViewedProduct_Delete_V2
{
	public const string SP_NAME = "WSP_T_최근본상품_삭제_V2";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 테이블구분
		/// </summary>
		[Description("테이블구분")]
		public string TableClassification { get; set; }
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
		/// 일련번호리스트
		/// </summary>
		[Description("일련번호리스트")]
		public string SerialNumberList { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Description("종류")]
		public string Type { get; set; }
	}

}