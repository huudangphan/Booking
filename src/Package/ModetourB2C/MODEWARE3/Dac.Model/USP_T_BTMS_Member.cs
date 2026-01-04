namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// USP_T_BTMS_회원
/// </summary>
public class USP_T_BTMS_Member
{
	public const string SP_NAME = "USP_T_BTMS_회원";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 저장구분
		/// </summary>
		[Description("저장구분")]
		public string SavingClassification { get; set; }
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 거래처번호
		/// </summary>
		[Description("거래처번호")]
		public int CustomerNumber { get; set; }
		/// <summary>
		/// 직원명
		/// </summary>
		[Description("직원명")]
		public string EmployeeName { get; set; }
		/// <summary>
		/// 부서명
		/// </summary>
		[Description("부서명")]
		public string DepartmentName { get; set; }
		/// <summary>
		/// 직급
		/// </summary>
		[Description("직급")]
		public string JobPosition { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Description("휴대폰")]
		public string CellPhone { get; set; }
		/// <summary>
		/// 관리자여부
		/// </summary>
		[Description("관리자여부")]
		public string AdminOrNot { get; set; }
		/// <summary>
		/// 승인상태
		/// </summary>
		[Description("승인상태")]
		public string ApprovalState { get; set; }
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
		/// 여권번호
		/// </summary>
		[Description("여권번호")]
		public string PassportNumber { get; set; }
		/// <summary>
		/// 여권발급일
		/// </summary>
		[Description("여권발급일")]
		public DateTime PassportIssuanceDate { get; set; }
		/// <summary>
		/// 여권만료일
		/// </summary>
		[Description("여권만료일")]
		public DateTime PassportExpirationDate { get; set; }
		/// <summary>
		/// 여권파일번호
		/// </summary>
		[Description("여권파일번호")]
		public int PassportFileNumber { get; set; }
		/// <summary>
		/// 비자유무
		/// </summary>
		[Description("비자유무")]
		public string VisaOrNot { get; set; }
		/// <summary>
		/// 개인정보동의여부
		/// </summary>
		[Description("개인정보동의여부")]
		public string PersonalInfoAgreeOrNot { get; set; }
		/// <summary>
		/// USERID
		/// </summary>
		[Description("USERID")]
		public string USERID { get; set; }
		/// <summary>
		/// USERPWD
		/// </summary>
		[Description("USERPWD")]
		public string USERPWD { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Description("생년월일")]
		public string BirthYearMonthDay { get; set; }
		/// <summary>
		/// 저장자
		/// </summary>
		[Description("저장자")]
		public int Saver { get; set; }
		/// <summary>
		/// T_직원일반_비자
		/// </summary>
		[DapperParameter(DbType.Object)]
		[Description("T_직원일반_비자")]
		public List<TYPE_VisaInfo> T_EmployeeNormal_Visa { get; set; }
		/// <summary>
		/// 일반비자번호
		/// </summary>
		[Description("일반비자번호")]
		public int NormalVisaNumber { get; set; }
		/// <summary>
		/// 비자파일번호
		/// </summary>
		[Description("비자파일번호")]
		public int VisaFileNumber { get; set; }
	}

}