namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_MPLE_회원정보수정
/// </summary>
public class WSP_T_MPLE_MemberInfoEdit
{
	public const string SP_NAME = "WSP_T_MPLE_회원정보수정";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
		/// <summary>
		/// 한글명
		/// </summary>
		[Description("한글명")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 영문성
		/// </summary>
		[Description("영문성")]
		public string EnglishLastName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Description("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 국가번호
		/// </summary>
		[Description("국가번호")]
		public string CountryNumber { get; set; }
		/// <summary>
		/// 연락처
		/// </summary>
		[Description("연락처")]
		public string Contact { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Description("생년월일")]
		public string BirthYearMonthDay { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Description("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 가이드시작년도
		/// </summary>
		[Description("가이드시작년도")]
		public int GuideStartYear { get; set; }
	}

	public class Result : IDbResult
	{
		/// <summary>
		/// RETURN_CODE
		/// </summary>
		[Column("RETURN_CODE")]
		public int RETURN_CODE { get; set; }
		/// <summary>
		/// RETURN_MSG
		/// </summary>
		[Column("RETURN_MSG")]
		public string RETURN_MSG { get; set; }
	}
}