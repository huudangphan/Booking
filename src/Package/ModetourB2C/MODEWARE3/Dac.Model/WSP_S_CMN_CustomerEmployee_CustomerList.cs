namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_CMN_거래처직원_거래처리스트
/// </summary>
public class WSP_S_CMN_CustomerEmployee_CustomerList
{
	public const string SP_NAME = "WSP_S_CMN_거래처직원_거래처리스트";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처직원코드
		/// </summary>
		[Description("거래처직원코드")]
		public int CustomerEmployeeCode { get; set; }
		/// <summary>
		/// 권한
		/// </summary>
		[Description("권한")]
		public string Authority { get; set; }
	}

	public class Result1 : IDbResult
	{
		/// <summary>
		/// 이름
		/// </summary>
		[Column("이름")]
		public string Name { get; set; }
		/// <summary>
		/// 전화
		/// </summary>
		[Column("전화")]
		public string Phone { get; set; }
		/// <summary>
		/// 이메일
		/// </summary>
		[Column("이메일")]
		public string Email { get; set; }
		/// <summary>
		/// 생년월일
		/// </summary>
		[Column("생년월일")]
		public string BirthYearMonthDay { get; set; }
		/// <summary>
		/// 생년월일2
		/// </summary>
		[Column("생년월일2")]
		public string BirthYearMonthDay2 { get; set; }
		/// <summary>
		/// 생년월일3
		/// </summary>
		[Column("생년월일3")]
		public string BirthYearMonthDay3 { get; set; }
		/// <summary>
		/// 성별
		/// </summary>
		[Column("성별")]
		public string Gender { get; set; }
		/// <summary>
		/// 휴대폰
		/// </summary>
		[Column("휴대폰")]
		public string CellPhone { get; set; }
	}

	public class Result2 : IDbResult
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Column("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 회사명
		/// </summary>
		[Column("회사명")]
		public string CompanyName { get; set; }
		/// <summary>
		/// 대표자
		/// </summary>
		[Column("대표자")]
		public string Representative { get; set; }
		/// <summary>
		/// 회사전화
		/// </summary>
		[Column("회사전화")]
		public string CompanyPhone { get; set; }
		/// <summary>
		/// 회사이메일
		/// </summary>
		[Column("회사이메일")]
		public string CompanyEmail { get; set; }
		/// <summary>
		/// 회사우편번호
		/// </summary>
		[Column("회사우편번호")]
		public string CompanyZipCode { get; set; }
		/// <summary>
		/// 회사주소1
		/// </summary>
		[Column("회사주소1")]
		public string CompanyAddress1 { get; set; }
		/// <summary>
		/// 회사주소2
		/// </summary>
		[Column("회사주소2")]
		public string CompanyAddress2 { get; set; }
		/// <summary>
		/// 사업자번호
		/// </summary>
		[Column("사업자번호")]
		public string LicenseeNumber { get; set; }
		/// <summary>
		/// 모두투어담당사원명
		/// </summary>
		[Column("모두투어담당사원명")]
		public string MODETOURResponsibilityStaffName { get; set; }
		/// <summary>
		/// 회사명_1
		/// </summary>
		[Column("회사명_1")]
		public string CompanyName_1 { get; set; }
		/// <summary>
		/// 대표자_1
		/// </summary>
		[Column("대표자_1")]
		public string Representative_1 { get; set; }
		/// <summary>
		/// 회사전화_1
		/// </summary>
		[Column("회사전화_1")]
		public string CompanyPhone_1 { get; set; }
		/// <summary>
		/// 회사이메일_1
		/// </summary>
		[Column("회사이메일_1")]
		public string CompanyEmail_1 { get; set; }
		/// <summary>
		/// 회사우편번호_1
		/// </summary>
		[Column("회사우편번호_1")]
		public string CompanyZipCode_1 { get; set; }
		/// <summary>
		/// 회사주소1_1
		/// </summary>
		[Column("회사주소1_1")]
		public string CompanyAddress1_1 { get; set; }
		/// <summary>
		/// 회사주소2_1
		/// </summary>
		[Column("회사주소2_1")]
		public string CompanyAddress2_1 { get; set; }
		/// <summary>
		/// 사업자번호_1
		/// </summary>
		[Column("사업자번호_1")]
		public string LicenseeNumber_1 { get; set; }
	}
}