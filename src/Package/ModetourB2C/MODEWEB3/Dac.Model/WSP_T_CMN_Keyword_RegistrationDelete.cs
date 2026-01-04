namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_키워드_등록삭제
/// </summary>
public class WSP_T_CMN_Keyword_RegistrationDelete
{
	public const string SP_NAME = "WSP_T_CMN_키워드_등록삭제";

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
		/// 구분번호
		/// </summary>
		[Description("구분번호")]
		public int ClassificationNumber { get; set; }
		/// <summary>
		/// 종류
		/// </summary>
		[Description("종류")]
		public string Type { get; set; }
		/// <summary>
		/// 키워드
		/// </summary>
		[Description("키워드")]
		public string Keyword { get; set; }
		/// <summary>
		/// 링크경로
		/// </summary>
		[Description("링크경로")]
		public string LinkRoute { get; set; }
		/// <summary>
		/// 태그
		/// </summary>
		[Description("태그")]
		public string Tag { get; set; }
		/// <summary>
		/// 정렬
		/// </summary>
		[Description("정렬")]
		public int Sorting { get; set; }
	}

}