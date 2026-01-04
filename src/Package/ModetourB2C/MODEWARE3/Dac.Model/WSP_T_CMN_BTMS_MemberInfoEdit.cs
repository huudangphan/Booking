namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_CMN_BTMS_회원정보수정
/// </summary>
public class WSP_T_CMN_BTMS_MemberInfoEdit
{
	public const string SP_NAME = "WSP_T_CMN_BTMS_회원정보수정";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 일련번호
		/// </summary>
		[Description("일련번호")]
		public int SerialNumber { get; set; }
		/// <summary>
		/// 저장구분
		/// </summary>
		[Description("저장구분")]
		public string SavingClassification { get; set; }
		/// <summary>
		/// UserPwd
		/// </summary>
		[Description("UserPwd")]
		public string UserPwd { get; set; }
		/// <summary>
		/// UserId
		/// </summary>
		[Description("UserId")]
		public string UserId { get; set; }
		/// <summary>
		/// 이름
		/// </summary>
		[Description("이름")]
		public string Name { get; set; }
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
		/// 생년월일
		/// </summary>
		[Description("생년월일")]
		public string BirthYearMonthDay { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Description("휴대폰")]
		public string CellPhone { get; set; }
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
		/// 비자유무
		/// </summary>
		[Description("비자유무")]
		public string VisaOrNot { get; set; }
		/// <summary>
		/// 발급국가
		/// </summary>
		[Description("발급국가")]
		public string IssuanceCountry { get; set; }
		/// <summary>
		/// 유효기간
		/// </summary>
		[Description("유효기간")]
		public string ValidPeriod { get; set; }
	}

}