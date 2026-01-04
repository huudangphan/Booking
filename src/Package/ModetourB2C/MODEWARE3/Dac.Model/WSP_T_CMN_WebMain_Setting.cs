namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_웹메인_설정
/// </summary>
public class WSP_T_CMN_WebMain_Setting
{
	public const string SP_NAME = "WSP_T_CMN_웹메인_설정";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 웹지역_테마번호
		/// </summary>
		[Description("웹지역_테마번호")]
		public int WebRegion_ThemeNumber { get; set; }
		/// <summary>
		/// 항목종류
		/// </summary>
		[Description("항목종류")]
		public string ItemType { get; set; }
		/// <summary>
		/// 항목코드
		/// </summary>
		[Description("항목코드")]
		public string ItemCode { get; set; }
		/// <summary>
		/// 항목번호
		/// </summary>
		[Description("항목번호")]
		public int ItemNumber { get; set; }
		/// <summary>
		/// 항목경로
		/// </summary>
		[Description("항목경로")]
		public string ItemRoute { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Description("정렬")]
		public int Sorting { get; set; }
		/// <summary>
		/// 오픈상태
		/// </summary>
		[Description("오픈상태")]
		public string OpenState { get; set; }
	}

}