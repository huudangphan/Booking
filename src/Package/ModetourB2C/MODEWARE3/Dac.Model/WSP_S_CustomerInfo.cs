namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_S_거래처정보
/// </summary>
public class WSP_S_CustomerInfo
{
	public const string SP_NAME = "WSP_S_거래처정보";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Description("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 권한
		/// </summary>
		[Description("권한")]
		public string Authority { get; set; }
	}

	public class Result : IDbResult
	{
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
		/// 회사전화
		/// </summary>
		[Column("회사전화")]
		public string CompanyPhone { get; set; }
		/// <summary>
		/// 회사팩스
		/// </summary>
		[Column("회사팩스")]
		public string CompanyFax { get; set; }
		/// <summary>
		/// 예약담당자
		/// </summary>
		[Column("예약담당자")]
		public string BookingManager { get; set; }
		/// <summary>
		/// 회사로고
		/// </summary>
		[Column("회사로고")]
		public string CompanyLogo { get; set; }
		/// <summary>
		/// 회사대표메일
		/// </summary>
		[Column("회사대표메일")]
		public string CompanyRepresentativeMail { get; set; }
		/// <summary>
		/// 거래처직원
		/// </summary>
		[Column("거래처직원")]
		public string CustomerEmployee { get; set; }
		/// <summary>
		/// 거래처직원번호
		/// </summary>
		[Column("거래처직원번호")]
		public int CustomerEmployeeNumber { get; set; }
		/// <summary>
		/// 담당직원번호
		/// </summary>
		[Column("담당직원번호")]
		public int ResponsibilityEmployeeNumber { get; set; }
		/// <summary>
		/// 담당직원명
		/// </summary>
		[Column("담당직원명")]
		public string ResponsibilityEmployeeName { get; set; }
		/// <summary>
		/// 담당자이메일
		/// </summary>
		[Column("담당자이메일")]
		public string ManagerEmail { get; set; }
		/// <summary>
		/// 담당자전화
		/// </summary>
		[Column("담당자전화")]
		public string ManagerPhone { get; set; }
		/// <summary>
		/// 사업자번호
		/// </summary>
		[Column("사업자번호")]
		public string LicenseeNumber { get; set; }
		/// <summary>
		/// 대표회사전화
		/// </summary>
		[Column("대표회사전화")]
		public string RepresentativeCompanyPhone { get; set; }
	}
}