namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_MPLE_가이드정보
/// </summary>
public class WSP_S_MPLE_GuideInfo
{
	public const string SP_NAME = "WSP_S_MPLE_가이드정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PTID
		/// </summary>
		[Description("PTID")]
		public int PTID { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 한글이름
		/// </summary>
		[Column("한글이름")]
		public string KoreanName { get; set; }
		/// <summary>
		/// 아이디
		/// </summary>
		[Column("아이디")]
		public string ID { get; set; }
		/// <summary>
		/// 영문성
		/// </summary>
		[Column("영문성")]
		public string EnglishLastName { get; set; }
		/// <summary>
		/// 영문이름
		/// </summary>
		[Column("영문이름")]
		public string EnglishName { get; set; }
		/// <summary>
		/// 현지연락처
		/// </summary>
		[Column("현지연락처")]
		public string LocalContact { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Column("생년월일")]
		public string BirthYearMonthDay { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 가이드시작년도
		/// </summary>
		[Column("가이드시작년도")]
		public int GuideStartYear { get; set; }
		/// <summary>
		/// 이미지파일명
		/// </summary>
		[Column("이미지파일명")]
		public string ImageFileName { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 랜드사명
		/// </summary>
		[Column("랜드사명")]
		public string LandCompanyName { get; set; }
		/// <summary>
		/// 승인여부
		/// </summary>
		[Column("승인여부")]
		public string ApprovalOrNot { get; set; }
		/// <summary>
		/// 직위
		/// </summary>
		[Column("직위")]
		public string Position { get; set; }
		/// <summary>
		/// 직위코드
		/// </summary>
		[Column("직위코드")]
		public string PositionCode { get; set; }
		/// <summary>
		/// 소속랜드사근무시작년도
		/// </summary>
		[Column("소속랜드사근무시작년도")]
		public string AffiliationLandCompanyWorkStartYear { get; set; }
		/// <summary>
		/// 랜드사번호
		/// </summary>
		[Column("랜드사번호")]
		public int LandCompanyNumber { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 사용언어
		/// </summary>
		[Column("사용언어")]
		public string UseLanguage { get; set; }
	}

	public class Result4 : IDbResult
	{
		/// <summary>
		/// 자격증
		/// </summary>
		[Column("자격증")]
		public string Certificate { get; set; }
	}
}