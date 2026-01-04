namespace ModetourB2C.Dac.Model.MODEWARE3;

/// <summary>
/// WSP_T_거래처
/// </summary>
public class WSP_T_Customer
{
	public const string SP_NAME = "WSP_T_거래처";

	public class Parameters : BaseDbParameters
	{
		/// <summary>
		/// PARTYID
		/// </summary>
		[Description("PARTYID")]
		public int PARTYID { get; set; }
		/// <summary>
		/// 거래처코드
		/// </summary>
		[Description("거래처코드")]
		public int CustomerCode { get; set; }
		/// <summary>
		/// 회사명
		/// </summary>
		[Description("회사명")]
		public string CompanyName { get; set; }
		/// <summary>
		/// 대표자
		/// </summary>
		[Description("대표자")]
		public string Representative { get; set; }
		/// <summary>
		/// 사업자번호
		/// </summary>
		[Description("사업자번호")]
		public string LicenseeNumber { get; set; }
		/// <summary>
		/// 직업대분류코드
		/// </summary>
		[Description("직업대분류코드")]
		public string JobMajorClassificationCode { get; set; }
		/// <summary>
		/// 회사우편번호
		/// </summary>
		[Description("회사우편번호")]
		public string CompanyZipCode { get; set; }
		/// <summary>
		/// 회사주소1
		/// </summary>
		[Description("회사주소1")]
		public string CompanyAddress1 { get; set; }
		/// <summary>
		/// 회사주소2
		/// </summary>
		[Description("회사주소2")]
		public string CompanyAddress2 { get; set; }
		/// <summary>
		/// 회사전화
		/// </summary>
		[Description("회사전화")]
		public string CompanyPhone { get; set; }
		/// <summary>
		/// 회사팩스
		/// </summary>
		[Description("회사팩스")]
		public string CompanyFax { get; set; }
		/// <summary>
		/// 회사대표메일
		/// </summary>
		[Description("회사대표메일")]
		public string CompanyRepresentativeMail { get; set; }
		/// <summary>
		/// 부서번호
		/// </summary>
		[Description("부서번호")]
		public string DepartmentNumber { get; set; }
		/// <summary>
		/// 지점명
		/// </summary>
		[Description("지점명")]
		public string BranchName { get; set; }
		/// <summary>
		/// 별칭
		/// </summary>
		[Description("별칭")]
		public string Nickname { get; set; }
		/// <summary>
		/// RETURN
		/// </summary>
		[DapperParameter(DbType.AnsiString, ParameterDirection.InputOutput, 200)]
		[Description("RETURN")]
		public string RETURN { get; set; }
	}

}