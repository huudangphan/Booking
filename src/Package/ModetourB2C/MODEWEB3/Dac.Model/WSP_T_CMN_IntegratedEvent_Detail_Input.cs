namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_통합이벤트_상세_입력
/// </summary>
public class WSP_T_CMN_IntegratedEvent_Detail_Input
{
	public const string SP_NAME = "WSP_T_CMN_통합이벤트_상세_입력";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 이벤트번호
		/// </summary>
		[Description("이벤트번호")]
		public int EventNumber { get; set; }
		/// <summary>
		/// 템플릿코드
		/// </summary>
		[Description("템플릿코드")]
		public string TemplateCode { get; set; }
		/// <summary>
		/// 안내문구
		/// </summary>
		[Description("안내문구")]
		public string InfoWords { get; set; }
		/// <summary>
		/// 세부이벤트내용
		/// </summary>
		[Description("세부이벤트내용")]
		public string DetailEventContent { get; set; }
		/// <summary>
		/// 에러문구
		/// </summary>
		[Description("에러문구")]
		public string ErrorWords { get; set; }
		/// <summary>
		/// 체크데이터
		/// </summary>
		[Description("체크데이터")]
		public string CheckData { get; set; }
		/// <summary>
		/// 세부사항등록일
		/// </summary>
		[Description("세부사항등록일")]
		public DateTime DetailItemRegisterDate { get; set; }
	}

}