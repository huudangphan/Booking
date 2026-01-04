namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_채용_팝업_NEW
/// </summary>
public class WSP_S_Recruitment_Popup_NEW
{
	public const string SP_NAME = "WSP_S_채용_팝업_NEW";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 팝업이름
		/// </summary>
		[Description("팝업이름")]
		public string PopupName { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 검색내용
		/// </summary>
		[Description("검색내용")]
		public string SearchingContent { get; set; }
		/// <summary>
		/// 학교구분
		/// </summary>
		[Description("학교구분")]
		public string SchoolClassification { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// 오류
		/// </summary>
		[Column("오류")]
		public string Error { get; set; }
	}
}