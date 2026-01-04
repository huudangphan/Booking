namespace ModetourB2C.Dac.Model.MODEWEB3;

/// <summary>
/// WSP_T_CMN_나의여행스크랩등록
/// </summary>
public class WSP_T_CMN_MyTravelScrapRegistration
{
	public const string SP_NAME = "WSP_T_CMN_나의여행스크랩등록";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 구분
		/// </summary>
		[Description("구분")]
		public string Classification { get; set; }
		/// <summary>
		/// 제목
		/// </summary>
		[Description("제목")]
		public string Title { get; set; }
		/// <summary>
		/// 설명
		/// </summary>
		[Description("설명")]
		public string Explaination { get; set; }
		/// <summary>
		/// 관련번호
		/// </summary>
		[Description("관련번호")]
		public int RelatedNumber { get; set; }
		/// <summary>
		/// 관련경로
		/// </summary>
		[Description("관련경로")]
		public string RelatedRoute { get; set; }
	}

}