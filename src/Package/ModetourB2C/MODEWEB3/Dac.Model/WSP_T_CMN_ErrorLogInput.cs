namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_에러로그입력
/// </summary>
public class WSP_T_CMN_ErrorLogInput
{
	public const string SP_NAME = "WSP_T_CMN_에러로그입력";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 도메인
		/// </summary>
		[Description("도메인")]
		public string Domain { get; set; }
		/// <summary>
		/// 페이지경로
		/// </summary>
		[Description("페이지경로")]
		public string PageRoute { get; set; }
		/// <summary>
		/// 파라미터
		/// </summary>
		[Description("파라미터")]
		public string Parameter { get; set; }
		/// <summary>
		/// 클라이언트IP
		/// </summary>
		[Description("클라이언트IP")]
		public string Client_IP { get; set; }
		/// <summary>
		/// 서버
		/// </summary>
		[Description("서버")]
		public string Server { get; set; }
		/// <summary>
		/// 브라우저
		/// </summary>
		[Description("브라우저")]
		public string Browser { get; set; }
		/// <summary>
		/// 정보1
		/// </summary>
		[Description("정보1")]
		public string Info1 { get; set; }
		/// <summary>
		/// 정보2
		/// </summary>
		[Description("정보2")]
		public string Info2 { get; set; }
		/// <summary>
		/// 정보3
		/// </summary>
		[Description("정보3")]
		public string Info3 { get; set; }
		/// <summary>
		/// 정보4
		/// </summary>
		[Description("정보4")]
		public string Info4 { get; set; }
		/// <summary>
		/// 정보5
		/// </summary>
		[Description("정보5")]
		public string Info5 { get; set; }
		/// <summary>
		/// 메시지1
		/// </summary>
		[Description("메시지1")]
		public string Message1 { get; set; }
		/// <summary>
		/// 대분류
		/// </summary>
		[Description("대분류")]
		public string MajorClassification { get; set; }
	}

}