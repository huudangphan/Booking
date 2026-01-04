namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_회원백신정보
/// </summary>
public class WSP_S_CMN_MemberVaccineInfo
{
	public const string SP_NAME = "WSP_S_CMN_회원백신정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// MT번호
		/// </summary>
		[Description("MT번호")]
		public string MT_Number { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 백신접종예정일자
		/// </summary>
		[Column("백신접종예정일자")]
		public DateTime VaccinationExpectationDate { get; set; }
		/// <summary>
		/// 등록일시
		/// </summary>
		[Column("등록일시")]
		public DateTime RegisterDateAndTime { get; set; }
		/// <summary>
		/// 보험가입여부
		/// </summary>
		[Column("보험가입여부")]
		public string InsuranceSignUpOrNot { get; set; }
		/// <summary>
		/// 백신인증파일
		/// </summary>
		[Column("백신인증파일")]
		public string VaccineVerificationFile { get; set; }
		/// <summary>
		/// 파일인증상태
		/// </summary>
		[Column("파일인증상태")]
		public string FileVerificationState { get; set; }
		/// <summary>
		/// 파일등록일시
		/// </summary>
		[Column("파일등록일시")]
		public DateTime FileRegisterDateAndTime { get; set; }
		/// <summary>
		/// 굿즈신청여부
		/// </summary>
		[Column("굿즈신청여부")]
		public string GoodsRequestOrNot { get; set; }
		/// <summary>
		/// 굿즈신청일자
		/// </summary>
		[Column("굿즈신청일자")]
		public DateTime GoodsRequestDate { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 테마분류
		/// </summary>
		[Column("테마분류")]
		public string ThemeClassification { get; set; }
		/// <summary>
		/// 등록일자
		/// </summary>
		[Column("등록일자")]
		public DateTime RegisterDate { get; set; }
	}

	public class Result3 : IDbResult
	{
		/// <summary>
		/// 희망년월
		/// </summary>
		[Column("희망년월")]
		public string DesiredYearMonth { get; set; }
		/// <summary>
		/// 등록일자
		/// </summary>
		[Column("등록일자")]
		public DateTime RegisterDate { get; set; }
	}
}